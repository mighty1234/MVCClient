using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTOLibrary
{
    public class GiftsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Cost { get; set; }
       
        public virtual List<OrderViewModel> Orders { get; set; }
    }
}