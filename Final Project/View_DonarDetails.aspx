<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="View_DonarDetails.aspx.cs" Inherits="Final_Project.View_DonarDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container" style="margin-top:100px">
         <h1 class="my-3" style="text-align: center">Donar Details</h1>
   <div class="row" >
   <div class="col-md-2">
  </div>

  <div class="col-md-12">
    <div class="table-responsive">
    <asp:GridView ID="gvdata" CssClass="table table-striped" runat="server" AutoGenerateColumns="false" EmptyDataText="No data found">
        <Columns>
            
      <asp:TemplateField HeaderText="Donar ID ">
           <ItemTemplate>
               <asp:Label ID="lbldonarid" runat="server" Text='<%# Eval("Donar ID") %>'></asp:Label>
           </ItemTemplate>
       </asp:TemplateField>

     <asp:TemplateField HeaderText="Name ">
        <ItemTemplate>
          <asp:Label ID="lblname" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
       </ItemTemplate>
     </asp:TemplateField>

    
     <asp:TemplateField HeaderText="Contact">
         <ItemTemplate>
           <asp:Label ID="lblcontact" runat="server" Text='<%# Eval("Contact") %>'></asp:Label>
         </ItemTemplate>
    </asp:TemplateField>

     <asp:TemplateField HeaderText="Email">
          <ItemTemplate>
            <asp:Label ID="lblemail" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
       </ItemTemplate>
    </asp:TemplateField>

       <asp:TemplateField HeaderText="BloodGroup">
           <ItemTemplate>
                <asp:Label ID="lblbloodgroup" runat="server" Text='<%# Eval("BloodGroup") %>'></asp:Label>
            </ItemTemplate>
      </asp:TemplateField>

      <asp:TemplateField HeaderText="City ">
      <ItemTemplate>
          <asp:Label ID="lblcity" runat="server" Text='<%# Eval("City") %>'></asp:Label>
     </ItemTemplate>
     </asp:TemplateField>

     <asp:TemplateField HeaderText="View Details">
        <ItemTemplate>
              <a class="btn btn-primary" href='View_profile.aspx?id=<%# Eval("Donar ID")%>'>View Details</a>
        </ItemTemplate>
     </asp:TemplateField>

     </Columns>
     </asp:GridView>

    </div>
   </div>
  </div>
  </div>

</asp:Content>
