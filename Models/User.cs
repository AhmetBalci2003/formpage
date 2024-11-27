﻿using System.ComponentModel.DataAnnotations.Schema;

namespace formpage.Models
{

    [Table("Users")]
    public class User
        {
            public String ID { get; set; }
            public string Name { get; set; }
            public string S_Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public DateTime Reg_Date { get; set; }
            public bool Account_Status { get; set; }
            public string Phone_Num { get; set; }
            public DateTime? Last_Log_Date { get; set; }
        public User()
        {
            
        }
    }
}
