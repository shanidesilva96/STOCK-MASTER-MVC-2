using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class SM_PATIENTS
    {
        [Key]
        public int Patient_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Patient_Name { get; set; }

        public DateTime DOB { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }

        [StringLength(30)]
        public string NIC { get; set; }

        [StringLength(30)]
        public string Custodians_NIC { get; set; }

        public int Mobile_Number { get; set; }

        [Required]
        public int Requested_By { get; set; }

        [Required]
        public DateTime Requested_Date { get; set; }



        public ICollection<SM_INVENTORY_DETAILS> SM_INVENTORY_DETAILS { get; set; }

        [ForeignKey("Requested_By")]
        public SM_USER? User { get; set; }
    }
}
