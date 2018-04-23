@Using (Html.BeginForm("ActionMethodForSyncForm", "Home"))
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
            settings.ShowOnPageLoad = Convert.ToBoolean(ViewData("showPopup")) ' You can use ViewData to adjust extension settings
            settings.SetContent( _
                Sub()
                        ViewContext.Writer.Write(ViewData("content"))
                End Sub)
    End Sub).GetHtml()