using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class SM_SUPPLIERS
    {
        [Key]
        public int Supplier_ID { get; set; }

        [Required]
        [StringLength(300)]
        public string Supplier_Name { get; set; }

        [StringLength(50)]
        public string Registration_No { get; set; }

        public int Contact_Number { get; set; }



        public ICollection<SM_GRN> SM_GRN { get; set; }
    }
}
