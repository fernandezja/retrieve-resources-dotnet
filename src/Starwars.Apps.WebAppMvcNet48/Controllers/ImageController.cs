using Starwars.Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Starwars.Apps.WebAppMvcNet48.Controllers
{
    public class ImageController : Controller
    {

        private const string CONTENT_TYPE_JPG = "image/jpeg";

        private CoreResourcesMain _coreResourcesMain;
        private string _binFolderPath;

        public ImageController()
        {
            _coreResourcesMain = new Core.Resources.CoreResourcesMain();
            _binFolderPath = System.Web.Hosting.HostingEnvironment.MapPath("~/bin");
        }

        public ActionResult Yoda()
        {
            //byte[] yodaImage = Starwars.Core.Resources.JediResources.Yoda001;

            return File(Starwars.Core.Resources.JediResources.Yoda001, CONTENT_TYPE_JPG);
        }

        public ActionResult Leia()
        {

            byte[] leiaImage = _coreResourcesMain.GetResources2ContentLeiaImage(directoryPath: _binFolderPath);

            return File(leiaImage, CONTENT_TYPE_JPG);
        }

        public ActionResult DarthVader()
        {

            byte[] darthVadermage = _coreResourcesMain.GetResources3EmbeddedResourceDarthVaderImage();

            return File(darthVadermage, CONTENT_TYPE_JPG);
        }

    }
}