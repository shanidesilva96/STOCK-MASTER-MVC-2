using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class SM_PATIENT_DETAILS
    {
        [Key]
        public int Patient_Details_ID { get; set; }

        public int Patient_ID { get; set; }

        [StringLength(30)]
        public string Disease { get; set; }

        [StringLength(300)]
        public string Description { get; set; }
    }
}
