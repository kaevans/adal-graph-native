using Microsoft.Graph;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
var graphClient = new GraphServiceClient(
    "https://graph.microsoft.com/v1.0",
    new DelegateAuthenticationProvider(
        async (requestMessage) =>
        {
                                   
            var ctx = new AuthenticationContext("https://login.microsoftonline.com/microsoft.onmicrosoft.com");
            var authResult = await ctx.AcquireTokenAsync(
                "https://graph.microsoft.com/", 
                "342ccd8e-387c-4369-81b1-813e3a24b5f1", 
                new Uri("https://localhost"), 
                new PlatformParameters(PromptBehavior.Auto));

            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", authResult.AccessToken);
        }));
var me = graphClient.Me.Request().GetAsync().GetAwaiter().GetResult();

Console.WriteLine(me.Surname);
        }
    }
}
