using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcMvc.Domain.Account;

public interface IAuthenticate
{
Task<bool> Authenticate(string? email, string? password);
Task<bool> ResisterUser(string? email, string? password);
Task Logout();
}
