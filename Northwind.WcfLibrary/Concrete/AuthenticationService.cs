using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Bll.Concrete;
using Northwind.Dal.Concrete.EntityFramework;
using Northwind.Entities;
using Northwind.Interfaces;

namespace Northwind.WcfLibrary.Concrete
{
    public class AuthenticationService:IAuthenticationService
    {
        AuthenticationManager _authenticationManager = new AuthenticationManager(new EfAuthenticationDal());
        public User Authenticate(User user)
        {
            return _authenticationManager.Authenticate(user);
        }
    }
}
