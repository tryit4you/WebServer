using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Data.Models
{
    public class Account
    {
        [Key]
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Score { get; set; }
        public int TimeSpent { get; set; }
    }
}
