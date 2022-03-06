using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using ElementiumBrowser.Controllers;
using static ElementiumBrowser.Functions;
namespace ElementiumBrowser.Classes.Handlers
{
    public class xaleSchemaHandler : ISchemeHandlerFactory
    {
        public IResourceHandler Create(IBrowser browser, IFrame frame, string schemeName, IRequest request)
        {

            if (schemeName.ToLower() == Config.xaleSchemaName)
            {
                var schema_param = request.Url.ToLower().Contains("?") ? request.Url.ToLower().Split('?')[1] : "";
                    xaleResourceController xResourceController = new xaleResourceController(schema_param);
                   return ResourceHandler.FromString(xResourceController.loadSchemaUrl(request.Url));
                
            }

            return new ResourceHandler();
        }
    }
}
