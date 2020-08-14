﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("ユーザー名")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("パスワード")]
        public string Password { get; set; }
    }
}