using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class SM_CATEGORY
    {
        [Key]
        public int Item_Category_ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Item_Category_Name { get; set; }

        public ICollection<SM_ITEMS> SM_ITEMS { get; set; }
    }
}
