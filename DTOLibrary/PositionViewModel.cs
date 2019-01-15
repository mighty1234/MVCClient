using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTOLibrary
{
    public class PositionViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }        
        public virtual List<StaffViewModel> Staff { get; set; }
    }
}