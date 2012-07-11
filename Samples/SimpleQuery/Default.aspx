<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleQuery._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<asp:DataList ID="listFriends" runat="server" RepeatDirection="Horizontal" >
			<ItemTemplate>
				<asp:Label ID="Label1" runat="server" Text='<%# Eval("Name") %>'></asp:Label><br />
				<asp:Image runat="server" ImageUrl='<%# Eval("Picture") %>'></asp:Image>
			</ItemTemplate>
			<SeparatorTemplate>
			</SeparatorTemplate>
		</asp:DataList>
	</div>
	</form>
</body>
</html>
