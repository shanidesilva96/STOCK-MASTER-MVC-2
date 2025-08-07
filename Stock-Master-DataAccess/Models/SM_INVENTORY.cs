using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class SM_INVENTORY
    {
        [Key]
        public int Inv_ID { get; set; }

        public int Item_ID { get; set; }

        public int GRN_ID { get; set; }

        public int QTY { get; set; }

        public bool Is_Bulk_Item { get; set; }

        [StringLength(10)]
        public string Bulk_MAINT_ID { get; set; }

        [StringLength(50)]
        public string Bulk_Serial_No { get; set; }


        public SM_ITEMS SM_ITEMS { get; set; }
        public SM_GRN SM_GRN { get; set; }
        public SM_INVENTORY_DETAILS SM_INVENTORY_DETAILS { get; set; }
    }
}
