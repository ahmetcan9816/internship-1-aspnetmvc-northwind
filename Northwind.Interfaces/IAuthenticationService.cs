using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Northwind.Entities;

namespace Northwind.Interfaces
{
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        User Authenticate(User user);
    }
}