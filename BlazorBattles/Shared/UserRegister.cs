using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBattles.Shared
{
    public class UserRegister
    {
        [Required]
        public string Email { get; set; }
        [Required, StringLength(16, ErrorMessage = "Your username is too long")]
        public string Username { get; set; }
        public string Bio { get; set; }
        [Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "The passwords do not match")]
        public string ConfirmedPassword { get; set; }
        public int StartUnitId { get; set; }
        [Range(0, 1000, ErrorMessage = "Please choose a number btween 0 and 1000.")]
        public int Bananas { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        [Required, Range(typeof(bool), "true","true", ErrorMessage = "Only confirmed users can play!")]
        public bool IsConfirmed { get; set; } = true;
    }
}
