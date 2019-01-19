using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DTOLibrary
{
    public class StaffViewModel 
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Field is required")]
        public int Brunch_id { get; set; }
        [Required(ErrorMessage = "Field is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field is required")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Field is required")]
        public int Position_id { get; set; }
        [Required(ErrorMessage = "Field is required")]


        public virtual BrunchViewModel Brunch { get; set; }      
        public virtual List<OrderViewModel> Orders { get; set; }
        public virtual PositionViewModel Position { get; set; }
    }
}
