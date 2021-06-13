using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GaziWeb.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageLink { get; set; }
        public string VideoLink { get; set; }
        public string Explanation { get; set; }
        public double Rate { get; set; }
        public string Type { get; set; }
    }
}
