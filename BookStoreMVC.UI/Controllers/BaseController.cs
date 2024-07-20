﻿namespace BookStoreMVC.UI.Controllers
{
    public class BaseController : Controller
    {
        protected INotyfService NotyfService => HttpContext.RequestServices.GetService(typeof(INotyfService)) as INotyfService;
        protected void NotifiySuccess(string message)
        {
            NotyfService.Success(message);
        }

        protected void NotifiyError(string message)
        {
            NotyfService.Error(message);
        }
        protected void NotifiyWarning(string message)
        {
            NotyfService.Warning(message);
        }

    }
}
