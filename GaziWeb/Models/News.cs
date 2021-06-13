using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GaziWeb.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageLink { get; set; }
        public string Explanation { get; set; }
    }
}
