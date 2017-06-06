using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.WebUI.Abstract
{
    public interface IAuthProvider
    {
        bool Authenticate(string username, string password);
    }
}
