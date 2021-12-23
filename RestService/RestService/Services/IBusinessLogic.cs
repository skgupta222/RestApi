using RestService.Models;
using System.Threading.Tasks;

namespace RestService.Services
{
    public interface IBusinessLogic
    {
        int GetSecondHighestInteger(RequestModel model);
    }
}
