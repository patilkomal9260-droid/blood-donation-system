<%@ Page Title="" Language="C#" MasterPageFile="~/Blood Donar.Master" AutoEventWireup="true" CodeBehind="Donar Login.aspx.cs" Inherits="Final_Project.Donar_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container" style="margin-top:70px">
<div class="row">
<div class="col-md-12">
    <h2 style="text-align:center">Donar Login</h2>
</div>
 </div>

   <div class="row">
 <div class="col-md-3"></div>
     
   <div class="mb-3 mt-3">
      <label for="pwd">Email:  <span style="color: red">*</span></label>
      <asp:Textbox runat="server" TextMode="Email" CssClass="form-control" ID="TextEmail"></asp:Textbox>
  </div>

  <div class="mb-3 mt-3">
      <label for="pwd">Password:  <span style="color: red">*</span></label>
      <asp:Textbox runat="server" TextMode="Password" CssClass="form-control" ID="TextPassword"></asp:Textbox>
  </div>
  <asp:Button OnClick="btnLogin_Click" runat="server" ID="btnLogin" Text="Login" CssClass="btn btn-danger" />

</div>
</div>
</asp:Content>
