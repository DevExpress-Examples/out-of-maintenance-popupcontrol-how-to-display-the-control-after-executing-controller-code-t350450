Imports System.Web.Mvc
Imports System.Web.Routing

Namespace PopupControlAfterRequestMvc
	Public Class MvcApplication
		Inherits System.Web.HttpApplication

		Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}")
			routes.IgnoreRoute("{resource}.ashx/{*pathInfo}")

			routes.MapRoute("Default", "{controller}/{action}/{id}", New With {Key .controller = "Home", Key .action = "Index", Key .id = UrlParameter.Optional}) ' Parameter defaults -  URL with parameters -  Route name
		End Sub

		Protected Sub Application_Start()
			AreaRegistration.RegisterAllAreas()

			RegisterRoutes(RouteTable.Routes)

			ModelBinders.Binders.DefaultBinder = New DevExpress.Web.Mvc.DevExpressEditorsBinder()
		End Sub
	End Class
End Namespace