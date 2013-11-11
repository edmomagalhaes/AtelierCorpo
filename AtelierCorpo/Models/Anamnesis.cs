using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AtelierCorpo.Models
{
    public class Anamnesis
    {
        public int ID { get; set; }
        public User User { get; set; }
        public Question Quastion { get; set; }
        public bool Answer { get; set; }
        public string Complement { get; set; }
        [NotMapped]
        public int QuestionId { get; set; }

    }
}