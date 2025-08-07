using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class SM_PREFIX
    {
        [Key]
        public int Prefix_ID { get; set; }

        [Required]
        [StringLength(7)]
        public string Prefix { get; set; }



        public ICollection<SM_USER> SM_USER { get; set; }
    }
}
