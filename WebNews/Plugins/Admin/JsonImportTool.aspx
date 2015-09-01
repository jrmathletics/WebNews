<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JsonImportTool.aspx.cs" Inherits="WebNews.Plugins.Admin.JsonImportTool" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Skriv inn ID på den siden du vil opprette alle de nye sidene fra json under:
    <div>
        Page ID: 
        <input type="text" id="PageID" />
        <input type="submit" value="Trykk her" />
    </div>
    </form>
</body>
</html>
