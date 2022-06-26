using System.ComponentModel.DataAnnotations;

namespace EMS.BLL.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter First Name.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter Last Name.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter Email Address.")]
        [EmailAddress]
        [Display(Name = "EmailId")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Please enter Mobile Number.")]
        [EmailAddress]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        [Display(Name = "MobileNumber")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Please enter Password.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter Confirm Password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirm  password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
