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
    public static class PositionLoader
    {
        public static List<PositionViewModel> GetAll()
        {

            PositionViewModel mappedPosition = new PositionViewModel();
            List<PositionViewModel> list = new List<PositionViewModel>();


            List<PositionDto> positions;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Position").Result;
            positions = response.Content.ReadAsAsync<List<PositionDto>>().Result;

            foreach (var position in positions)
            {
                mappedPosition = Mapper.MapPosition(position);
                foreach (var staff in mappedPosition.Staff)
                {
                    var staffinjected = StaffLoader.GetInsertedById(staff.Id);
                    mappedPosition.Staff.Add(staffinjected);

                }
                list.Add(mappedPosition);
            }



            return list;



        }





        public static PositionViewModel GetById(int id)
        {
            PositionDto position;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Position/" + id.ToString()).Result;
            position = response.Content.ReadAsAsync<PositionDto>().Result;
            var result = Mapper.MapPosition(position);
            result.Staff = StaffLoader.GetAll().Where(x => x.Position_id == result.Id).ToList();




            return result;
        }

        static public PositionViewModel GetInsertedById(int id)
        {

            PositionDto position;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Position/" + id.ToString()).Result;
            position = response.Content.ReadAsAsync<PositionDto>().Result;
            var result = Mapper.MapPosition(position);



            return result;
        }

        public static void Save(PositionDto position)
        {

            if (position.Id == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Position", position).Result;
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Position/" + position.Id, position).Result;
            }
        }

        public static void Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Position/" + id).Result;
        }
    }
}
