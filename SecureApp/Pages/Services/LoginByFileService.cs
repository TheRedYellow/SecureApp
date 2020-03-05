using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SecureApp.Pages.Services
{
    public class LoginByFileService
    {
        private readonly IConfiguration configuration;

        public LoginByFileService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public (string, string) GetLoginInfo()
        {
            var username = File.ReadAllText(configuration["LoginFile:UserNameFilePath"]);
            var password = File.ReadAllText(configuration["LoginFile:PasswordFilePath"]);

            return (username, password);
        }

    }
}
