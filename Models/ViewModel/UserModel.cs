﻿using System.ComponentModel.DataAnnotations;

namespace MyWebApplication.Models.ViewModel
{
    public class UserModel
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Enter Username")]
        public string LoginName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Created By")]
        public int CreatedBy { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string AccountImage { get; set; }

    }
    public class UsersModel
    {
        public List<UserModel> Users { get; set; }
    }
}
