using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore_2.Models
{
    public class Clients
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public MaleFemale Sex { get; set; }

        public enum MaleFemale
        {
            None = 0,
            Male = 1,
            Female = 2
        }

    }
}