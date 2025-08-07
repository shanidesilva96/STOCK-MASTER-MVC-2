using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class SM_GRN
    {
        [Key]
        public int GRN_ID { get; set; }

        [Required]
        public int Supplier_ID { get; set; }

        public int Submit_By { get; set; }

        [Required]
        public DateTime Submit_Date { get; set; }

        [Required]
        public DateTime Received_Date { get; set; }

        public SM_SUPPLIERS SM_SUPPLIERS { get; set; }




        public ICollection<SM_GRN_DETAILS> SM_GRN_DETAILS { get; set; }
        public ICollection<SM_INVENTORY> SM_INVENTORY { get; set; }


        [ForeignKey("Submit_By")]
        public SM_USER? User { get; set; }
    }
}
