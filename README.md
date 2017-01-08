# BitShifters.Bol.PlazaApi

BOL.com Plaza Api implemented as a .NET Standard Library usable in .NET Core 
## Nuget
```
PM> Install-Package BitShifters.Bol.PlazaAPi
```
## Usage
Startup.cs
```
public void ConfigureServices(IServiceCollection services)
{
    ...
    services.AddSingleton<PlazaApiConfig>(new PlazaApiConfig
    {
        RootEndPoint = "https://test-plazaapi.bol.com",
        Namespace = "https://plazaapi.bol.com/services/xsd/v2/plazaapi.xsd",
        OrdersUrl = "/services/rest/orders/v2",
        OrderItemsUrl = "/services/rest/order-items/v2",
        ShipmentsUrl = "/services/rest/shipments/v2",
        ShippingLabelsUrl = "/services/rest/purchasable-shipping-labels/v2",
        TransportsUrl = "/services/rest/transports/v2",
        ReturnItemsUrl = "/services/rest/return-items/v2",
        ProcessStatusUrl = "/services/rest/process-status/v2",
        PublicKey = "[YOUR PUBLIC KEY]",
        PrivateKey = "[YOUR PRIVATE KEY]"
    });

    services.AddPlazaApi();

    ...
}
```

Now PlazaApiClientis available through DI

HomeController.cs

```

public class HomeController : Controller
{
    private PlazaApiClient _plazaApiClient;

    public HomeController(PlazaApiClient plazaApiClient)
    {
        _plazaApiClient = plazaApiClient;
    }

    public async Task<IActionResult> Index()
    {
        var orders = await _plazaApiClient.OrderRepository.GetOrdersAsync();
        ...
        return View();
    }

}
```

## Available Methods

### OrderRepository
```
GetOrdersAsync()
CancelOrderItemAsync(int orderItemId, Cancellation cancellation)
```
### ProcessStatusRepository
```
GetProcessStatusAsync(int processStatusId)
```
### ReturnItemRepository
```
GetReturnItemsAsync()
UpdateReturnItemStatusAsync(int returnNumber, ReturnItemStatusUpdate returnItemStatusUpdate)
```
### ShipmentRepository
```
GetShipmentsAsync(int page=1)
GetShipmentsByFulfilmentMethodAsync(FulfilmentMethod fulfilmentMethod, int page = 1)
CreateShipmentAsync(ShipmentRequest shipmentRequest)
ChangeTransportAsync(int transportId, ChangeTransportRequest changeTransportRequest)
```
### ShippingLabelRepository
```
GetShippingLabelsAsync(int orderItemId)
```
