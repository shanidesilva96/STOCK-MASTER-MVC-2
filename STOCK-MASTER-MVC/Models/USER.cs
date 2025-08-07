using Stock_Master_DataAccess.Models;
using System.ComponentModel.DataAnnotations;

namespace STOCK_MASTER_MVC.Models
{
    public class USER
    {

        public List<UserList>? UserList { get; set; }
    }

    public class UserList
    {
        public int User_ID { get; set; }
        public string First_Name { get; set; }
        public string? Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public int Prefix_ID { get; set; }
        public int User_Type_ID { get; set; }
        public string? Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? NIC { get; set; }
        public int Mobile_Number { get; set; }
        public string? User_Display_Number { get; set; }
        public string? User_Display_Name { get; set; }
    }
}
