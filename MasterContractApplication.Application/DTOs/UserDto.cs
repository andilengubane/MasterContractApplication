using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Application.DTOs
{
    public record UserDto(int Id, string FisrtName, string LastName, string EmailAddress , string Password, string RegNumber, bool IsActived, int UserRole);
    public record CeateUserDto(int Id, string FisrtName, string LastName, string EmailAddress, string Password, string RegNumber, bool IsActived, int UserRole);

    public record UpdateUserDto(int Id, string FisrtName, string LastName, string EmailAddress, string Password, string RegNumber, bool IsActived, int UserRole);
}
