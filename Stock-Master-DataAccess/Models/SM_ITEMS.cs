using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class SM_ITEMS
    {
        [Key]
        public int Item_ID { get; set; }

        [Required]
        [StringLength(300)]
        public string Item_Name { get; set; }

        [Required]
        public int Item_Category_ID { get; set; }

        [StringLength(1000)]
        public string Decription { get; set; }

        [StringLength(10)]
        public string BulkId_Name { get; set; }

        [Required]
        public int Preorder_Level { get; set; }

        public SM_CATEGORY SM_CATEGORY { get; set; }



        public ICollection<SM_GRN_DETAILS> SM_GRN_DETAILS { get; set; }
        public ICollection<SM_INVENTORY> SM_INVENTORY { get; set; }
    }
}
