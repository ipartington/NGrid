using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NGrid.Models
{
    public class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string short_code { get; set; }
        public int Capacity { get; set; }

    }
}