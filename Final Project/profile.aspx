<%@ Page Title="" Language="C#" MasterPageFile="~/Blood Donar.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="Final_Project.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-top: 70px">
   <div class="row">
   <div class="col-md-12">
      <h1 style="text-align: center">Update Profile</h1>
  </div>
  </div>

   <div class="row">
     <div class="col-md-3"></div>
     <div class="col-md-6">
   
   <div class="mb-3 mt-3">
       <label>Name:</label>
       <asp:TextBox ID="TextName" placeholder="Enter Name" Cssclass="form-control" runat="server"></asp:TextBox>
   </div>

  <div class="mb-3 mt-3">
     <label>Contact:</label>
     <asp:TextBox ID="txtContact" placeholder="Enter Contact" Cssclass="form-control" runat="server"></asp:TextBox>
  </div>

     <div class="mb-3 mt-3">
     <label>Email:</label>
      <asp:TextBox ID="TextEmail" placeholder="Enter Email" Cssclass="form-control" runat="server"></asp:TextBox>
  </div>

 <div class="mb-3 mt-3">
    <label>Password:</label>
    <asp:TextBox ID="txtPassword" placeholder="Enter Password" runat="server" CssClass="form-control"></asp:TextBox>
 </div>

   <div class="mb-3 mt-3">
       <label>Blood Group:</label>
       <asp:DropDownList runat="server" CssClass="form-control" ID="ddlbloodgroup">
      <asp:ListItem>Select Blood Group</asp:ListItem>
       <asp:ListItem>A+</asp:ListItem>
       <asp:ListItem>B+</asp:ListItem>
       <asp:ListItem>AB+</asp:ListItem>
       <asp:ListItem>AB-</asp:ListItem>
       <asp:ListItem>O+</asp:ListItem>
       <asp:ListItem>O-</asp:ListItem>
    </asp:DropDownList>  
  </div>
 
    <div class="mb-3 mt-3">
        <label>Select City:</label>
       <asp:TextBox ID="TextCity" placeholder="Enter City" runat="server" CssClass="form-control"></asp:TextBox>  
   </div>

 <asp:Button ID="btnSave" runat="server" Text="Update Details" OnClick="btnSave_Click" CssClass="btn btn-primary" />
       
   </div>
  </div>
</div>

</asp:Content>
