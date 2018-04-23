Imports System.Web.Mvc

Namespace PopupControlAfterRequestMvc
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function OnLoad() As ActionResult
			Return View()
		End Function

		Public Function AfterJQueryAjax() As ActionResult
			Return View()
		End Function

		Public Function AfterSyncFormSubmit() As ActionResult
			Return View()
		End Function

		Public Function AfterAsyncAjaxFormSubmit() As ActionResult
			Return View()
		End Function

		<HttpPost>
		Public Function AjaxAction() As ActionResult
			Return Content("After jQuery Ajax")
		End Function

		<HttpPost, ValidateInput(False)>
		Public Function ActionMethodForSyncForm(ByVal Description As String) As ActionResult
			ViewData("showPopup") = True
			ViewData("content") = Description
			Return View("AfterSyncFormSubmit")
		End Function

		<HttpPost, ValidateInput(False)>
		Public Function ActionMethodForAsyncAjaxForm(ByVal Description As String) As ActionResult
			Return Content(Description)
		End Function
	End Class
End Namespace