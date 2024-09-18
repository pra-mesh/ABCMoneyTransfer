using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ABCMoneyTransfer.Models;

public class Users : IdentityUser
{
    [MaxLength(50)]
    public string FirstName { get; set; }
    [MaxLength(50)]
    public string LastName { get; set; }
}
