using DTOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static MVCDataLoader.Globalvariables;

namespace MVCDataLoader
{
  public  class StaffLoader
    {
        public static List<StaffViewModel> GetAll()
        {

            StaffViewModel mappedStaff = new StaffViewModel();
            List<StaffViewModel> list = new List<StaffViewModel>();


            List<StaffDto> staffs;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Staff").Result;
            staffs = response.Content.ReadAsAsync<List<StaffDto>>().Result;

            foreach (var staff in staffs)
            {
                mappedStaff = Mapper.MapStaff(staff);
                mappedStaff.Brunch = BrunchLoader.GetInsertedById(staff.Brunch_id);
                mappedStaff.Position = PositionLoader.GetInsertedById(staff.Position_id);
                foreach (var orders in staff.Orsers_id)
                {
                    var order = MVCDataLoader.OrderLoader.GetInsertedById(orders);
                    mappedStaff.Orders.Add(order);

                   
                }


                list.Add(mappedStaff);
               



            }
            return list;
        }

     
        


        public static  StaffViewModel GetInsertedById(int id)
        {
            StaffDto staff;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Staff/" + id.ToString()).Result;
            staff = response.Content.ReadAsAsync<StaffDto>().Result;
            var  result = Mapper.MapStaff(staff);
            



            return result;
        }

        static   public StaffViewModel  GetById(int id)
        {

            StaffDto staff;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Staff/" + id.ToString()).Result;
            staff = response.Content.ReadAsAsync<StaffDto>().Result;
            var result = Mapper.MapStaff(staff);
            result.Position = PositionLoader.GetInsertedById(result.Position_id);
            result.Brunch = BrunchLoader.GetInsertedById(result.Brunch_id);
            foreach (var order in staff.Orsers_id)
            {
               var getorder = OrderLoader.GetOrder(order);

                result.Orders.Add(getorder);
            }           
            return result;
        }

        public static void Save(StaffDto staff)
        {
           
            if (staff.Id == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Staff", staff).Result;
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Staff/" + staff.Id, staff).Result;
            }


        }
        public static void Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Staff/" + id).Result;
        }



    }
}
