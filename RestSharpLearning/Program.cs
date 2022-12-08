using RestSharp;

namespace RestSharpLearning;

public class Program
{
    public static async Task Main(string[] args)
    {
        // Post info to Server
        var url = "http://192.168.0.172:8080/AdderWS/services/Adder";
        var action = "add";
        var body = @"<?xml version=""1.0"" encoding=""utf-8""?>" + "\n" +
                   @"<soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">" + "\n" +
                   @"    <soap:Body>" + "\n" +
                   @"        <add>" + "\n" +
                   @"            <facilityId>""1</facilityId>" + "\n" +
                   @"            <userId>""2</userId>" + "\n" +
                   @"            <transData>3</transData>" + "\n" +
                   @"        </add>" + "\n" +
                   @"    </soap:Body>" + "\n" +
                   @"</soap:Envelope>";
        ;
        var response = await PostToServer(url, action, body);
        Console.WriteLine(response.StatusCode);
        Console.WriteLine(response.Content);
        Console.WriteLine(response.IsSuccessStatusCode);
        Console.WriteLine(response.IsSuccessful);
        Console.WriteLine(response.ResponseStatus);
    }

    private static async Task<RestResponse> PostToServer(string url, string action, string body)
    {
        var options = new RestClientOptions(url)
        {
            MaxTimeout = 1000,
            ThrowOnAnyError = true
        };
        var client = new RestClient(options);
        var request = new RestRequest()
            .AddHeader("Content-Type", "application/xml")
            .AddHeader("soapAction", action)
            .AddXmlBody(body);

        var response = await client.PostAsync(request);
        return response;
    }
}