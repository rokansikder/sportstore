using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using SportStore.WebUI.Abstract;
using System.Security.Cryptography;
using System.Text;

namespace SportStore.WebUI.Infrastructure.Concrete
{
    public class FormsAuthProvider:IAuthProvider
    {
        public bool Authenticate(string username, string password)
        {
            bool result = FormsAuthentication.Authenticate(username, password);
            //result = Membership.ValidateUser(username, password);
            
            if (result)
                FormsAuthentication.SetAuthCookie(username, false);

            return result;
        }

        public byte[] GetByteArray(string message) {
            return Encoding.UTF8.GetBytes(message);
        }

        public string CreateSalt(int size) {

            var cryptoServiceProvider = new RNGCryptoServiceProvider();
            var buffer = new byte[size];
            cryptoServiceProvider.GetBytes(buffer);

            return Convert.ToBase64String(buffer);
        }

        public string GetPasswordHashAndSalt(string password) {
            SHA256 sha = new SHA256CryptoServiceProvider();
            byte[] byteData = GetByteArray(password);
            byte[] resultBytes = sha.ComputeHash(byteData);

            return GetString(resultBytes);
        }

        public string GetString(byte[] byteData) {
            return Convert.ToBase64String(byteData);
        }
    }
}