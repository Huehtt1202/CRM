using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DomainService
{
    public interface IUserDomainService
    {
        bool SignIn(string username, string password);
        string GetMD5(string password);
        string ValudationPassword(string password);
        int EditPassword(string password);
        bool ResetPassword();

    }
}
