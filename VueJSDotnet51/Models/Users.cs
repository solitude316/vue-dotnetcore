using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VueJSDotnet51.Models
{
    public class Users
    {
        [Display(Name = "Id")]
        [Key]
        public Guid user_id { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        public string first_name { get; set; }
        public string middle_name { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        public string last_name { get; set; }
        [Required(ErrorMessage = "E-mail is required.")]
        public string email { get; set; }
        [Required(ErrorMessage = "Gender is required.")]
        public ushort gender { get; set; }
        [Required(ErrorMessage = "Birthday is required.")]
        public DateTime birthday { get; set; }
        public DateTime create_time { get; set; }
        public DateTime update_time { get; set; }
    }
}
