using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Student
    {
       public int ID { get; set; }
       public string Name { get; set; }

       [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
    }
}