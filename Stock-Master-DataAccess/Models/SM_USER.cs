using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class SM_USER
    {
        [Key]
        public int User_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string First_Name { get; set; }

        [StringLength(30)]
        public string? Middle_Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Last_Name { get; set; }

        public int Prefix_ID { get; set; }

        public int User_Type_ID { get; set; }

        [StringLength(50)]
        public string? Email { get; set; }

        [Required]
        [StringLength(25)]
        public string Username { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string? NIC { get; set; }

        public int Mobile_Number { get; set; }

        [StringLength(50)]
        public string? User_Display_Number { get; set; }

        [StringLength(50)]
        public string? User_Display_Name { get; set; }



        [ForeignKey("Prefix_ID")]
        public SM_PREFIX SM_PREFIX { get; set; }

        [ForeignKey("User_Type_ID")] 
        public SM_USER_TYPES SM_USER_TYPES { get; set; }


        public SM_DOCTOR_DETAILS SM_DOCTOR_DETAILS { get; set; }
    }
}
