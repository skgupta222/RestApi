using RestService.Models;
using System.Threading.Tasks;

namespace RestService.Services
{
    public interface IBusinessLogic
    {
        /// <summary>
        /// Will return second heighest number
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int GetSecondHighestInteger(RequestModel model);
    }
}
