using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aWebASPapp.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public String Person { get; set; }
        public String Issue { get; set; }
        public String Priority { get; set; }
        public String Time { get; set; }
        public String status { get; set; }
        public bool Finished { get; set; }

        public Tasks()
        {

        }

    }
}
