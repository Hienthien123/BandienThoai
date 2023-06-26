﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SellPhoneUntilities.Constants;
using System.Linq;
using System.Threading.Tasks;
using WebsellphoneAdmin.Models;
using WebSellPhoneApiCaller.ApiCaller.ApiLanguageClient;

namespace WebsellphoneAdmin.Controllers.Components
{
    public class NavigationViewComponent : ViewComponent
    {
        private readonly ILanguageApiClient _languageApiClient;

        public NavigationViewComponent(ILanguageApiClient languageApiClient)
        {
            _languageApiClient = languageApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var languages = await _languageApiClient.GetAll();
            var currentLanguageId = HttpContext
                .Session
                .GetString(SystemConstants.AppSettings.DefaultLanguageId);
            var items = languages.ResultObj.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
                Selected = currentLanguageId == null ? x.IsDefault : currentLanguageId == x.Id.ToString()
            });
            var navigationVm = new NavigationViewModel()
            {
                CurrentLanguageId = currentLanguageId,
                Languages = items.ToList()
            };

            return View("Default", navigationVm);
            //return await Task.FromResult((IViewComponentResult)View("Default"));
        }
    }
}
