
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
    public partial class BrunchDto
    {
       

        public int Id { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<int> StaffId { get; set; }
        public List<int> OrdersId { get; set; }
           
       // public List<StaffDto> Staff { get; set; }
       
    }
}
