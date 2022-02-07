using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasTarefas.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public bool Done { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime LastUpdateDate { get; set; } = DateTime.Now;

        public string User { get; set; }
    }
}
