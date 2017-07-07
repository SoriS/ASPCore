using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoASPCore.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
