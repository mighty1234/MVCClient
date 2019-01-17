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
    public class BrunchLoader
    {

        public static BrunchViewModel GetBrunch(int id)
        {

            BrunchDto brunch;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Brunch/" + id.ToString()).Result;
            brunch = response.Content.ReadAsAsync<BrunchDto>().Result;
            var result = Mapper.MapBrunch(brunch);
            foreach (var item in brunch.OrdersId)
            {
                result.Orders.Add(OrderLoader.GetOrder(item));
            }

            foreach (var item in brunch.StaffId)
            {
                result.Staff.Add(StaffLoader.GetInsertedById(item));
            }




            return result;
        }
        public static BrunchViewModel GetInsertedById(int id)
        {
            
            BrunchDto brunch;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Brunch/" + id.ToString()).Result;
            brunch = response.Content.ReadAsAsync<BrunchDto>().Result;
            var result = Mapper.MapBrunch(brunch);



            return result;
        }


        public static List<BrunchViewModel> GetBrunches()
        {
            BrunchViewModel mappedBrunch = new BrunchViewModel();
            List<BrunchViewModel> list = new List<BrunchViewModel>();


            IEnumerable<BrunchDto> brunchList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Brunch").Result;
            brunchList = response.Content.ReadAsAsync<IEnumerable<BrunchDto>>().Result;

            foreach (var brunch in brunchList)
            {
                mappedBrunch = Mapper.MapBrunch(brunch);
               
                foreach (var item in brunch.OrdersId)
                {
                    OrderViewModel order = OrderLoader.GetOrder(item);
                    mappedBrunch.Orders.Add(order);
                }
                foreach (var item in brunch.StaffId)
                {
                    StaffViewModel staff = new StaffViewModel();
                    staff = StaffLoader.GetInsertedById(item);
                    mappedBrunch.Staff.Add(staff);
                }

                list.Add(mappedBrunch);
            }

            return list;


        }

        public static void Save(BrunchDto brunch)
        {
            if (brunch.Id == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Brunch", brunch).Result;
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Brunch/" + brunch.Id, brunch).Result;
            }

        }
    }
}
