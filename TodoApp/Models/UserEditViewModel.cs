using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class UserEditViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        [DisplayName("ユーザー名")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("新しいパスワード")]
        public string Password { get; set; }

        [DisplayName("ロール")]
        public List<int> RoleIds { get; set; }
    }
}