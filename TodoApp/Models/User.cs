using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(256)]
        [DisplayName("ユーザー名")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("パスワード")]
        public string Password { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        [Required]
        [NotMapped]
        [DisplayName("ロール")]
        public List<int> RoleIds { get; set; }

        public virtual ICollection<Todo> Todoes { get; set; }
    }
}