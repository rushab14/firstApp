// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");
RestClient client = new RestClient();
RestRequest request = new RestRequest("https://localhost:7195/api/Name/authenticate", Method.Post);
request.AddJsonBody(new
{
    username = "test1",
    password = "password1"
});
var response1 = client.Execute(request);
var token = JsonConvert.DeserializeObject<string>(response1.Content);
Console.WriteLine(token);



//call authorise api by calling the token 

RestRequest request2 = new RestRequest("https://localhost:7195/api/Name", Method.Get);
client.AddDefaultHeader("Authorization", $"Bearer {token}");
var response2 = client.Execute(request2).Content;
Console.WriteLine(response2);
Console.ReadLine();