using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DTOLibrary
{
    public class GiftsViewModel
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public int Cost { get; set; }
       
        public virtual List<OrderViewModel> Orders { get; set; }
    }
}