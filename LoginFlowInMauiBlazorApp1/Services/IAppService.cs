using LoginFlowInMauiBlazorApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginFlowInMauiBlazorApp1.Services
{
    public interface IAppService
    {
        public Task<AuthenticateResult> AuthenticateUser(LoginModel loginModel);
        public Task<(bool IsSuccess, string ErrorMessage)> RegistrationUser(RegistrationModel registerModel);
    }
}
