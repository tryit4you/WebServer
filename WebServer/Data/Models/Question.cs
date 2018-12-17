using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Data.Models
{
    public class Question
    {
        [Key]
        public string Id { get; set; }
        public string QName { get; set; }
        public string ImageName { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string AnswerId { get; set; }
        [ForeignKey("AnswerId")]
        public virtual Answer Answer { get; set; }
    }
}
