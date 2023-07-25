using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LoginFlowInMauiBlazorApp1.Models
{
    public class UserBasicDetail
    {
        public string Name { get; set; }
        public string UserId { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
    }
}
