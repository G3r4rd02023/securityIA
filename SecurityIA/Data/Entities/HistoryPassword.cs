using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityIA.Data.Entities
{
    public class HistoryPassword
    {
        public int Id { get; set; }

        public User User { get; set; }
        
        public string Password { get; set; }

    }
}
