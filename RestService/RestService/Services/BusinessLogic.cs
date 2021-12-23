using RestService.Models;
using System.Linq;

namespace RestService.Services
{
    public class BusinessLogic : IBusinessLogic
    {
        /// <summary>
        /// Will return second heighest number
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int GetSecondHighestInteger(RequestModel model)
        {
           return model.Data.ToList().Distinct().OrderByDescending(x => x).Skip(1).First();
        }
    }
}
