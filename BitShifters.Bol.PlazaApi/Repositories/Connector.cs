using BitShifters.Bol.PlazaApi.Config;
using BitShifters.Bol.PlazaApi.Exceptions;
using BitShifters.Bol.PlazaApi.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BitShifters.Bol.PlazaApi.Repositories
{
    public class Connector
    {
        private const string BolDateHeader = "X-BOL-Date";
        private const string BolAuthorizationHeader = "X-BOL-Authorization";
        private const string AcceptHeader = "Accept";
        private const string ContentTypeHeader = "Content-Type";
        private const string ContentType = "application/xml; charset=UTF-8";

        private PlazaApiConfig _config;

        public Connector(PlazaApiConfig config)
        {
            _config = config;
        }

        public async Task<TEntity> GetDataAsync<TEntity>(HttpMethod method, string path, XmlRootAttribute xmlRootAttribute, string content = null )
        {
            using (var client = new HttpClient())
            {
                SetHeaders(client, method, path);

                var request = GetRequestMessage(method, path, content??String.Empty);

                var response = await client.SendAsync(request);

                var data = await response.Content.ReadAsStringAsync();

                try
                {
                    return BolXmlSerializer.Deserialize<TEntity>(data, xmlRootAttribute);
                }
                catch(InvalidOperationException)
                {
                    var exceptionData = BolXmlSerializer.Deserialize<ServiceExceptionData>(data, BolXmlSerializer.GetXmlRootAttribute(data));
                    throw new ServiceException(exceptionData);
                }
            }
        }

        private HttpRequestMessage GetRequestMessage(HttpMethod method, string path, string content)
        {
            var request = new HttpRequestMessage(method, _config.RootEndPoint + path)
            {
                Content = new StringContent(content, Encoding.UTF8)
            };

            request.Content.Headers.Remove(ContentTypeHeader);
            request.Content.Headers.Add(ContentTypeHeader, ContentType);

            return request;
        }

        private void SetHeaders(HttpClient client, HttpMethod method, string path)
        {
            var dateString = DateTime.UtcNow.ToString("R");
            client.DefaultRequestHeaders.Add(BolAuthorizationHeader, _config.PublicKey + ":" + GetAuthenticationSignature(method.Method, TrimParameters(path), ContentType, dateString));
            client.DefaultRequestHeaders.Add(BolDateHeader, dateString);
            client.DefaultRequestHeaders.Add(AcceptHeader, ContentType);
        }

        private string GetAuthenticationSignature(string method, string path, string contentType, string dateString)
        {
            var signature = method + "\n\n"
                    + contentType + "\n"
                    + dateString + "\n"
                    + BolDateHeader.ToLower() + ":" + dateString + "\n"
                    + path;

            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(_config.PrivateKey)))
            {
                hmac.Initialize();
                var result = hmac.ComputeHash(Encoding.UTF8.GetBytes(signature));
                return Convert.ToBase64String(result);
            }
        }

        private string TrimParameters(string path)
        {
            var result = path;
            var index = result.IndexOf("?");
            if (index > -1)
            {
                result = result.Substring(0, index);
            }
            return result;
        }
    }
}
