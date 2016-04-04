using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassMates.Models
{
    public class classmates
    {
        public classmates(int id, string name, string hair, double tall)
        {
            Id = id;
            Name = name;
            HairColor = hair;
            Height = tall;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string HairColor { get; set; }
        public double Height { get; set; }
    }
}