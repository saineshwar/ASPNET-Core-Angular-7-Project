using System;
using AngularCoreGym.ViewModels;

namespace AngularCoreGym.Interface
{
    public interface IRenewal
    {
        RenewalViewModel GetMemberNo(string memberNo, int userid);
        bool CheckRenewalPaymentExists(DateTime newdate, long memberId);
    }
}