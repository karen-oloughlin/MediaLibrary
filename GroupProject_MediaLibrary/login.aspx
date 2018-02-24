<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="GroupProject_MediaLibrary.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="css/main.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" /> 
    <link href="Content/site.css" rel="stylesheet" /> 
    <script src="Scripts/jquery-1.9.1.min.js"></script> 
    <script src="Scripts/bootstrap.min.js"></script>

    <style>
        .form-group         {
                            width: 50%;
                            margin: 0 auto;
                            margin-top: 2%;
                            }
        .bottomtext         {
                            margin-top: 5%;
                            box-sizing: border-box;
                            padding-left: 15%;
                            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<nav class="navbar navbar-default">
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand" href="index.aspx">Media Library</a>
    </div>
    <ul class="nav navbar-nav">
      <li class="active"><a href="login.aspx">Login</a></li>
      <li><a href="catalog.aspx">Catalog</a></li>
    </ul>
  </div>
</nav>
        <div class="form-group">
            <label for="txtID" class="control-label col-md-2">Book ID: </label>
            <asp:TextBox ID="txtID" runat="server" CssClass="form-control" OnTextChanged="txtID_TextChanged"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtTitle" class="control-label col-md-2">Title: </label>
            <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtISBN10" class="control-label col-md-2">ISBN-10: </label>
            <asp:TextBox ID="txtISBN10" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtISBN13" class="control-label col-md-2">ISBN-13: </label>
            <asp:TextBox ID="txtISBN13" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtAuthor" class="control-label col-md-2">Author: </label>
            <asp:TextBox ID="txtAuthor" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtPublisher" class="control-label col-md-2">Publisher: </label>
            <asp:TextBox ID="txtPublisher" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtCopyright" class="control-label col-md-2">Copyright Year: </label>
            <asp:TextBox ID="txtCopyright" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtLength" class="control-label col-md-2">Pages: </label>
            <asp:TextBox ID="txtLength" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group bottomtext">
            <asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" CssClass="btn btn-primary" text="Select"/>
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" CssClass="btn btn-success" Text="Update" />
        </div>
</form>
</body>
</html>
