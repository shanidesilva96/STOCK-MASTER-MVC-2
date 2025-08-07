using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class SM_INVENTORY_DETAILS
    {
        [Key]
        public int Inv_Details_ID { get; set; }

        public int Inv_ID { get; set; }

        [StringLength(50)]
        public DateTime Expiration_Date { get; set; }

        [StringLength(50)]
        public bool Is_Expired { get; set; }

        public string Serial_No { get; set; }

        public bool Is_Used { get; set; }

        public int Patient_ID { get; set; }

        public DateTime Used_Date { get; set; }

        // Foreign Key to SM_USER
        public int Used_By { get; set; }

        public bool Is_Lock { get; set; }


        [ForeignKey("Inv_ID")]
        public SM_INVENTORY SM_INVENTORY { get; set; }

        [ForeignKey("Patient_ID")]
        public SM_PATIENTS SM_PATIENTS { get; set; }

        [ForeignKey("Used_By")]
        public SM_USER User { get; set; }
    }
}
