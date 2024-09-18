using System.ComponentModel.DataAnnotations;

namespace ABCMoneyTransfer.ViewModel;

public class RegisterViewModel
{
    [Required(ErrorMessage = "First Name is required")]
    [MaxLength(50, ErrorMessage = "50 character limit")]
    public string FirstName { get; set; }

    [MaxLength(50, ErrorMessage = "50 character limit")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Email address is required")]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be between {2} and {1} character length")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    [Compare("Password")]
    [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be between {2} and {1} character length")]
    public string ConfirmPassword { get; set; }
}
