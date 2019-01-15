using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Umbraco.Headless.Client.Net.Services;
using Umbraco.Headless.Client.Net.Web;

namespace McCode.Controllers
{
    public class UmbracoController : DefaultUmbracoController
    {
        public UmbracoController(UmbracoContext umbracoContext, PublishedContentService headlessService) : base(umbracoContext, headlessService)
        {
        }

        public override Task<IActionResult> Index()
        {
            // get the content for the current route
            var content = UmbracoContext.GetContent();
            // return the view which will be located at /Views/Page/Index.cshtml
            return Task.FromResult((IActionResult)View(content));
        }
    }
}
