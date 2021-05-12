using System.Text.RegularExpressions;
using System.Web;
using System.Web.Routing;

namespace WebApp
{
    public class ReactRouteHandler : RouteBase
	{
		private readonly string[] reactPages = new[] {
			"hello",
			"counter"
		};

		public override RouteData GetRouteData(HttpContextBase httpContext)
		{
			foreach (var reactPage in reactPages)
			{
				if (Regex.Match(httpContext.Request.Path, $"^/{reactPage}", RegexOptions.IgnoreCase).Success)
				{
					httpContext.Response.ContentType = "text/html";
					httpContext.Response.TransmitFile("~/build/index.html");
					httpContext.Response.End();
				}
			}

			return null;
		}

		public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
		{
			return null;
		}
	}
}