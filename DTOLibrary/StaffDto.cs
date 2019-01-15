
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
    public partial class StaffDto
    {        

        public int Id { get; set; }
        public string Name { get; set; } 
        public string Surname { get; set; }
        public int BrunchId { get; set; }
        public List<int> OrsersId { get; set; }
        public int PositionId { get; set; }

       //public PositionDto Position{ get; set; }
       // public BrunchDto Brunch { get; set; }
       // public List<Orders> Orders { get; set; }
  
    }
}

