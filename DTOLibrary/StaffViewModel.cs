using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTOLibrary
{
    public class StaffViewModel
    {
        public int Id { get; set; }
        public int Brunch_id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Position_id { get; set; }


        public virtual BrunchViewModel Brunch { get; set; }      
        public virtual List<OrderViewModel> Orders { get; set; }
        public virtual PositionViewModel Position { get; set; }
    }
}
