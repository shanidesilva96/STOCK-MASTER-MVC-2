using System.ComponentModel.DataAnnotations;

namespace STOCK_MASTER_MVC.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Name")]
        public string? StudentName { get; set; }
        public int Age { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string? Password { get; set; }

        public string? BankId { get; set; }

        public List<Bank> BankList { get; set; }
    }

    public class Bank
    {
        public int BankId { get; set; }
        public string? BankName { get; set; }
    }
}
