
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
    public partial class PositionDto
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public List<int> StaffIds { get; set; }

      

    }
}
