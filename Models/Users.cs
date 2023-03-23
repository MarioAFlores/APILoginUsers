using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APILoginUsers.Models
{
    [Table("users")]
    public class Users
    {
        [Key]
        public int Id_User { get; set; }
        public string Name { get; set; }
        public string Last_Name { get; set; }
        public string Mail { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set;}
        public int Fk_User_Role { get; set; }
    }
}
