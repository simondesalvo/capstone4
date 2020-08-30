using System;
using System.Collections.Generic;

namespace capstone4.Models
{
    public partial class ToDoList
    {
        public int ToDoId { get; set; }
        public string ToDoDesc { get; set; }
        public bool? ToDoComplete { get; set; }
        public string UserId { get; set; }
        public DateTime? ToDoDue { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
