using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasciApps_Week9.Models
{
    public class Genre
    {
        private string v;

        public Genre(string Name)
        {
            this.Name = Name;
        }

        public string Name { get; set; }
    }
}