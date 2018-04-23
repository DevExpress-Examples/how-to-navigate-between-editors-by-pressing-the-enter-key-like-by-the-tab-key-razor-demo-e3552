@Code
	ViewBag.Title = "How to navigate between editors by pressing the Enter key like by the Tab key"
End Code
<h2>@ViewBag.Message</h2>
<p>
	To learn more about DevExpress Extensions for ASP.NET MVC visit <a href="http://devexpress.com/Products/NET/Controls/ASP-NET-MVC/"
		title="ASP.NET MVC Website">http://devexpress.com/Products/NET/Controls/ASP-NET-MVC/</a>.
</p>
<script type="text/javascript">
	function DoProcessEnterKey(htmlEvent, editName) {
		console.log(htmlEvent.keyCode);
		
		if (htmlEvent.keyCode == 13) {
			htmlEvent.cancelBubble = true;
			if (editName) {
				ASPxClientControl.GetControlCollection().GetByName(editName).SetFocus();
			} else {
				bt1.DoClick();
			}
		}
	}
</script>
@Code
Html.DevExpress().TextBox( _
        Sub(s)
	s.Name = "TextBox1"
	s.Properties.ClientInstanceName = "tb1"
	s.Properties.ClientSideEvents.KeyDown = "function(s, e) { DoProcessEnterKey(e.htmlEvent, 'tb2'); }"
    End Sub).GetHtml()
Html.DevExpress().TextBox( _
        Sub(s)
	s.Name = "TextBox2"
	s.Properties.ClientInstanceName = "tb2"
	s.Properties.ClientSideEvents.KeyDown = "function(s, e) { DoProcessEnterKey(e.htmlEvent, 'tb3'); }"
    End Sub).GetHtml()
Html.DevExpress().TextBox( _
        Sub(s)
	s.Name = "TextBox3"
	s.Properties.ClientInstanceName = "tb3"
	s.Properties.ClientSideEvents.KeyDown = "function(s, e) { DoProcessEnterKey(e.htmlEvent, ''); }"
    End Sub).GetHtml()
End Code