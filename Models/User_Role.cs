using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APILoginUsers.Models
{
    [Table("User_Role")]
    public class User_Role
    {
        [Key]
        public int Id_User_Role { get; set; }
        public string Role { get; set; }
    }
}
