using LoginFlowInMauiBlazorApp1.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;

namespace LoginFlowInMauiBlazorApp1.Services
{
    public class AppService : IAppService
    {
        //private string _baseUrl = "https://localhost:7107";
        private string _baseUrl = "https://g6hr0mv2-7107.brs.devtunnels.ms";
        public async Task<AuthenticateResult> AuthenticateUser(LoginModel loginModel)
        {
            var returnStr = new AuthenticateResult();
            using (var client = new HttpClient())
            {
                var url = $"{_baseUrl}{APIs.AuthenticateUser}";

                var serializedStr = JsonConvert.SerializeObject(loginModel);

                var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    returnStr = JsonConvert.DeserializeObject<AuthenticateResult>(json);
                }
            }

            return returnStr;
        }

        public async Task<(bool IsSuccess, string ErrorMessage)> RegistrationUser(RegistrationModel registerModel)
        {
            string errorMessage = string.Empty;
            bool isSuccess = false;
            using (var client = new HttpClient())
            {

                var url = $"{_baseUrl}{APIs.RegistrationUser}";

                var serializedStr = JsonConvert.SerializeObject(registerModel);

                var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    isSuccess = true;
                }
                else
                {
                    errorMessage = await response.Content.ReadAsStringAsync();
                }
            }

            return (isSuccess, errorMessage);
        }
    }
}
