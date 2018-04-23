@Code
    Html.EnableUnobtrusiveJavaScript(True)
End Code

@Using (Ajax.BeginForm("ActionMethodForAsyncAjaxForm", "Home",
    New AjaxOptions With {
        .UpdateTargetId = "ajaxDiv",
        .HttpMethod = "POST",
        .OnComplete = "PopupControl.Show();",
        .InsertionMode = InsertionMode.Replace}))

    @Html.DevExpress().TextBox( _
        Sub(settings)
            settings.Name = "Description"
        End Sub).GetHtml()

    @Html.DevExpress().Button( _
        Sub(settings)
            settings.Name = "btnSubmit"
            settings.Text = "Submit"
            settings.UseSubmitBehavior = True
        End Sub).GetHtml()
End Using

@Html.DevExpress().PopupControl( _
    Sub(settings)
            settings.Name = "PopupControl"
            settings.SetContent( _
                Sub()
                        ViewContext.Writer.Write("<div id='ajaxDiv'></div>")
                End Sub)
    End Sub).GetHtml()