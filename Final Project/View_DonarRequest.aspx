<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="View_DonarRequest.aspx.cs" Inherits="Final_Project.View_DonarRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container" style="margin-top:100px">
            <h1 class="my-3" style="text-align: center">Donar Request</h1>
      <div class="row" >
      <div class="col-md-2">
     </div>
<div class="col-md-8">
    <div class="table-responsive">
    <asp:GridView ID="gvdata" CssClass="table table-striped" runat="server" AutoGenerateColumns="false" EmptyDataText="No data found">
        <Columns>

      <asp:TemplateField HeaderText="Donar ID">
           <ItemTemplate>
           <asp:Label ID="lbldonarid" runat="server" Text='<%# Eval("Donar ID") %>'></asp:Label>
          </ItemTemplate>
      </asp:TemplateField>


     <asp:TemplateField HeaderText="Name">
         <ItemTemplate>
            <asp:Label ID="lblname" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
         </ItemTemplate>
    </asp:TemplateField>

     <asp:TemplateField HeaderText="RequestDate" ItemStyle-Width="150">
          <ItemTemplate>
             <asp:Label ID="lblrequestdate" runat="server" Text='<%# Eval("RequestDate") %>'></asp:Label>
         </ItemTemplate>
      </asp:TemplateField>


       <asp:BoundField DataField="Status" HeaderText="Status" />

    <asp:TemplateField HeaderText="Update Status">
        <ItemTemplate>
           <asp:DropDownList ID="ddlstatus" runat="server">
               <asp:ListItem>Pending</asp:ListItem>
               <asp:ListItem>Approved</asp:ListItem>
               <asp:ListItem>Completed</asp:ListItem>
               <asp:ListItem>Rejected</asp:ListItem>
           </asp:DropDownList>

        <asp:Button ID="btnUpdate" Class="btn btn-primary" runat="server" Text="Update" CommandArgument='<%# Eval("Donar ID") %>' OnClick="btnUpdate_Click" />

       </ItemTemplate>
   </asp:TemplateField>

 

       </Columns>
       </asp:GridView>

    </div>
   </div>
  </div>
  </div>
</asp:Content>
