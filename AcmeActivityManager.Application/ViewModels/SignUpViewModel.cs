using System;
using System.ComponentModel.DataAnnotations;

namespace AcmeActivityManager.Application.ViewModels
{
    public class SignUpViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [MinLength(2, ErrorMessage = "Minimum character required: {1}")]
        [MaxLength(150, ErrorMessage = "Maximum character required: {1}")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "First Name is required")]
        [MinLength(2, ErrorMessage = "Minimum character required: {1}")]
        [MaxLength(150, ErrorMessage = "Maximum character required: {1}")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        [MaxLength(100, ErrorMessage = "Maximum character required: {1}")]
        public string Email { get; set; }

        [Display(Name = "Activity Name")]
        [Required(ErrorMessage = "Activity is required")]
        [MinLength(2, ErrorMessage = "Minimum character required: {1}")]
        [MaxLength(50, ErrorMessage = "Maximum character required: {1}")]
        public string ActivityName { get; set; }

        [Display(Name = "Comments")]
        [MaxLength(200, ErrorMessage = "Maximum character required: {1}")]
        public string Comments { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Date required")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
    }
}