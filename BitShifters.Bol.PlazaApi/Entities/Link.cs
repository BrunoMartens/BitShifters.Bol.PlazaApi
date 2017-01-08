using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Entities
{
    public class Link
    {
        private string _rel;

        private string _href;

        private string _method;

        

        public string Rel
        {
            get
            {
                return _rel;
            }
            set
            {
                _rel = value;
            }
        }

        
        public string Href
        {
            get
            {
                return _href;
            }
            set
            {
                _href = value;
            }
        }

        public string Method
        {
            get
            {
                return _method;
            }
            set
            {
                _method = value;
            }
        }
    }
}
