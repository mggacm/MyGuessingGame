using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyGuessingGame.Models
{
    public class GuessingGameModel 
    {
        [Display(Name = "Enter your name.")]
        [Required(ErrorMessage = "Please enter your name.")]        
        [MinLength(1, ErrorMessage = "Your name is too short.")]
        [MaxLength(30, ErrorMessage = "Your name is too long.")]
        public string PlayerName { get; set; }

        [Display(Name = "Enter a number.")]
        [Required(ErrorMessage = "Please enter a number.")]
        [Range(1, 10, ErrorMessage = "Guess a number between 1 and 10.")]
        public int Guess { get; set; }

    }
}