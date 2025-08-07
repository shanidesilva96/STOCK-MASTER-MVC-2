using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class SM_USER_TYPES
    {
        [Key]
        public int User_Type_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string User_Type { get; set; }

        [Required]
        public string Description { get; set; }


        public ICollection<SM_USER> SM_USER { get; set; }
    }
}
