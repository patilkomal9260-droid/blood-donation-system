<%@ Page Title="" Language="C#" MasterPageFile="~/Blood Donar.Master" AutoEventWireup="true" CodeBehind="Donar Request.aspx.cs" Inherits="Final_Project.Donar_Request" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <div class="container" style="margin-top:70px">
   <div class="row">
   <div class="col-md-12">
       <h2 style="text-align:center">Donation Request</h2>
   </div>
    </div>

      <div class="row">
    <div class="col-md-3"></div>
  
     <div class="mb-3 mt-3">
         <label for="pwd">Name:  <span style="color: red">*</span></label>
          <asp:TextBox ID = "TextName" runat="server" placeholder="Enter Name" CssClass="form-control"></asp:TextBox>
     </div>

       
     <div class="mb-3 mt-3">
        <label for="pwd">Request Date:  <span style="color: red">*</span></label>
        <asp:TextBox ID = "TextRequestDate" runat="server" placeholder="Select Date" TextMode="Date" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="mb-3 mt-3">
         <label for="pwd">Status:  <span style="color: red">*</span></label>
        <asp:TextBox ID = "Textstatus" runat="server" placeholder="Enter Status" CssClass="form-control"></asp:TextBox>
    </div>

          
   <asp:Button ID = "btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn btn-success"/>

 
</div>
</div>
</asp:Content>
