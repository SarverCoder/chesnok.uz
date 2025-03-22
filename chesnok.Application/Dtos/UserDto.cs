using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chesnok.Application.Dtos;


public class UpdateUserDto
{
}

public class CreateUserDto
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }

}

public class UserDto
{
}
