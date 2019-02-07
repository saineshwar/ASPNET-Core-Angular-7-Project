using System.Linq;
using AngularCoreGym.Models;
using AngularCoreGym.ViewModels;

namespace AngularCoreGym.Interface
{
    public interface IPaymentDetails
    {
        IQueryable<PaymentDetailsViewModel> GetAll(QueryParameters queryParameters, int userId);
        int Count(int userId);
        bool RenewalPayment(RenewalViewModel renewalViewModel);
    }
}