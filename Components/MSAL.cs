using Microsoft.Identity.Client;

namespace tokenApp.Components
{
    public static class MSAL
    {
        public static string MSALToken()
        {
            string clientId = "f5f5c4a2-4086-4d54-8ab2-ff0ba768e977";
            string tenantId = "c70ad7a7-3297-49cc-aa05-725ddcb5f870";
            string clientSecret = "5Cy8Q~9_cWGxO09RPZGDFTGR~RGKP~v1MX3Voc-n";

            var pcaOptions = new PublicClientApplicationOptions
            {
                ClientId = clientId,
                TenantId = tenantId,
                RedirectUri = "http://localhost"
            };
            var pca = PublicClientApplicationBuilder.CreateWithApplicationOptions(pcaOptions).Build();

            var scopes = new[] { "User.Read" };
            var result = pca.AcquireTokenInteractive(scopes).ExecuteAsync().Result;
            Console.WriteLine($"Access Token: {result.AccessToken}");
            return result.AccessToken;

        }
    }
}
