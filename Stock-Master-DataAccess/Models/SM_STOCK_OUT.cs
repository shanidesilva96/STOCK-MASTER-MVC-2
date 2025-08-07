using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class SM_STOCK_OUT
    {
        [Key]
        public int STOCK_OUT_ID { get; set; }

        [Required]
        public int ItemID { get; set; }

        [Required]
        public int Inv_Details_ID { get; set; }

        [Required]
        public int QTY { get; set; }

        [StringLength(20)]
        public string Requested_Reason { get; set; }

        [Required]
        public int Patient_ID { get; set; }

        [Required]
        public int Requested_By { get; set; }

        [Required]
        public DateTime Requested_Date { get; set; }



        [ForeignKey("Requested_By")]
        public SM_USER? User { get; set; }
    }
}
