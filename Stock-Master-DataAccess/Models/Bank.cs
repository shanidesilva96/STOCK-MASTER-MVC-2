using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class Bank
    {
        [Key]
        public int BankId { get; set; }

        [Required]
        [StringLength(50)]
        public string BankName { get; set; }
    }
}
