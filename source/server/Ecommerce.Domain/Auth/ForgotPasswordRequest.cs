﻿using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
