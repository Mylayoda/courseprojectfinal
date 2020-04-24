﻿using courses.Extensions;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace courses.Controllers
{
    [Authorize]
    public class ProductContentController : Controller
    {
        public async Task<ActionResult> Index(int id)
        {
            var userId = Request.IsAuthenticated ? HttpContext.GetUserId() : null;
            var sections = await SectionExtensions.GetProductSectionsAsync(id, userId);

            return View(sections);
        }

        

    }
}