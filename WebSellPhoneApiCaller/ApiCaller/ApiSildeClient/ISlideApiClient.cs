using SellPhoneVIewModel.Utilities.Slides;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebSellPhoneApiCaller.ApiCaller.ApiSildeClient
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}
