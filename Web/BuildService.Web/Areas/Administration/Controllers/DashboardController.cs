﻿namespace BuildService.Web.Areas.Administration.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class DashboardController : AdministrationController
    {
        public DashboardController()
        {
        }

        public IActionResult Index()
        {
           // var viewModel = new IndexViewModel { SettingsCount = this.settingsService.GetCount(), };
            return this.View();
        }
    }
}
