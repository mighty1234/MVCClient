using DTOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDataLoader
{
    public static class Mapper
    {
        public static BrunchViewModel MapBrunch(BrunchDto brunch)
        {
            BrunchViewModel brunchViewModel = new BrunchViewModel();
            brunchViewModel.Id = brunch.Id;
            brunchViewModel.Name = brunch.Name;
            brunchViewModel.Email = brunch.Email;
            brunchViewModel.Address = brunch.Address;
            brunchViewModel.Orders = new List<OrderViewModel>();

            return brunchViewModel;
        }
        public static OrderViewModel MapOrder(OrdersDto order)
        {

            OrderViewModel orderViewModel = new OrderViewModel();
            orderViewModel.Id = order.Id;
            orderViewModel.Brunch_id = order.Brunch_id;
            orderViewModel.Client_id = order.Client_id;
            orderViewModel.Gift_id = order.Gift_id;
            orderViewModel.Staff_id = order.Staff_id;
            orderViewModel.Staff = new StaffViewModel();

            return orderViewModel;
        }

        public static StaffViewModel MapStaff(StaffDto staff)
        {
            StaffViewModel staffViewModel = new StaffViewModel();
            staffViewModel.Id = staff.Id;
            staffViewModel.Surname = staff.Surname;
            staffViewModel.Name = staff.Name;
            staffViewModel.Brunch =new BrunchViewModel();
            staffViewModel.Orders = new List<OrderViewModel>();
            staffViewModel.Position = new PositionViewModel();

            return staffViewModel;

        }




    }
}
