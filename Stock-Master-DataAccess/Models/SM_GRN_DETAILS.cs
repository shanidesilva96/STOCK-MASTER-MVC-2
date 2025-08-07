using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class SM_GRN_DETAILS
    {
        [Key]
        public int GRN_DETAILS_ID { get; set; }

        public int GRN_ID { get; set; }

        [Required]
        public int Item_ID { get; set; }

        public int Number_Of_Bulk { get; set; }

        public int Number_Of_Item_Per_Bulk { get; set; }

        public int Number_Of_Separate_Item { get; set; }

        [Required]
        public DateTime Expiration_Date { get; set; }



        public SM_GRN SM_GRN { get; set; }
        public SM_ITEMS SM_ITEMS { get; set; }
    }
}
