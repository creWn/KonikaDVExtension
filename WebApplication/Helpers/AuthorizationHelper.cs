using System;
using System.Net.Http.Headers;
using System.Text;

using WebApplication.Models;

namespace WebApplication.Helpers
{
    public static class AuthorizationHelper
    {
        // address username password
        public static AuthorizationModel GetCredentials(AuthenticationHeaderValue authHeader)
        {
            var credentials = Encoding.ASCII.GetString(Convert.FromBase64String(authHeader.Parameter));
            var credentialsArray = credentials.Split(' ');

            if (credentialsArray.Length == 3)
            {
                return new AuthorizationModel
                {
                    Address = credentialsArray[0],
                    UserName = credentialsArray[1],
                    Password = credentialsArray[2]
                };
            }
            return null;
        }
    }
}