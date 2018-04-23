<script type="text/javascript">
    function btnAjax_Click(s, e) {
        $.ajax({
            url: '@Url.Action("AjaxAction", "Home")',
            type: "POST",
            success: function (data) {
                PopupControl.SetContentHtml(data);
                PopupControl.Show();
            },
            error: function (xhr, textStatus, errorThrown) {
                alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
            }
        });
    }
</script>

@Html.DevExpress().Button( _
    Sub(settings)
            settings.Name = "btnAjax"
            settings.Text = "Initiate AJAX request"
            settings.ClientSideEvents.Click = "btnAjax_Click"
    End Sub).GetHtml()

@Html.DevExpress().PopupControl( _
    Sub(settings)
            settings.Name = "PopupControl"
    End Sub).GetHtml()