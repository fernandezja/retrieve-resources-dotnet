using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Starwars.Apps.WebAppMvcNet48.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var starwarsQuotes = new List<string>();

            starwarsQuotes.Add($" Yoda Quote 1 : {Starwars.Core.Resources.JediResources.Quote1}");
            starwarsQuotes.Add($" Yoda Quote 2 : {Starwars.Core.Resources.JediResources.Quote2}");

            var coreResourcesMain = new Core.Resources.CoreResourcesMain();

            string binFolderPath = System.Web.Hosting.HostingEnvironment.MapPath("~/bin");
             
            starwarsQuotes.Add($"Leia's Quotes : {coreResourcesMain.GetResources2ContentLeiaQuotes(directoryPath:binFolderPath)}");

            starwarsQuotes.Add($"Darth Vader's  Quotes : {coreResourcesMain.GetResources3EmbeddedResourceDarthVaderQuotes()}");


            return View(starwarsQuotes);
        }

    }
}