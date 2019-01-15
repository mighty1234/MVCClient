
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
    public partial class OrdersDto
    {
       
        public int Id { get; set; }
        public int Staff_id { get; set; }
        public int Brunch_id { get; set; }
        public int Client_id { get; set; }
        public int Gift_id { get; set; }
    }
}
