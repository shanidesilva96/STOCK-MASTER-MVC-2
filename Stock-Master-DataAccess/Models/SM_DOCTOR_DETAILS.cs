using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class SM_DOCTOR_DETAILS
    {
        [Key]
        public int Dr_ID { get; set; }

        public int User_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string REGISTATION_NO { get; set; }


        [ForeignKey("User_ID")]
        public SM_USER SM_USER { get; set; }
    }
}
