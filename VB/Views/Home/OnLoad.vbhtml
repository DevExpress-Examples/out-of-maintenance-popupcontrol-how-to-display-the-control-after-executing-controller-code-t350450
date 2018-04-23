@Html.DevExpress().PopupControl( _
    Sub(settings)
            settings.Name = "PopupControl"
            settings.ShowOnPageLoad = True
            'settings.ClientSideEvents.Init = "function(s, e) { s.Show(); }"; ' Alternative approach
            settings.SetContent( _
                Sub()
                ViewContext.Writer.Write("On Load")
        End Sub)
    End Sub).GetHtml()