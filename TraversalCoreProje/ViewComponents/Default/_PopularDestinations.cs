﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
