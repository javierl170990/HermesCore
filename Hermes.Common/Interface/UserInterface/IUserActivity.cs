using Hermes.Common.Dtos;
using Hermes.Common.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Common.Interface.UserInterface
{
    public interface IUserActivity
    {
        Task<Response> UserLoggin(LogginUserDto logginUserDto);
    }
}
