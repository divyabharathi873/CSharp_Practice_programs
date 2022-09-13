<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reg_page.aspx.cs" Inherits="User_Registration.Reg_page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-lg-8">
       <div class="row">
         <h1 class ="align-center" >Registration Form</h1>
       </div>
    <div class="row">
        <div class="col-sm-4">
         <div class="form-group">
        <asp:Label ID="lbl_username" runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="txt_username" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            </div>
        <div class="col-sm-4">
         <div class="form-group">
        <asp:Label ID="lbl_emial" runat="server" Text="Email Id"></asp:Label>
        <asp:TextBox ID="txt_email" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            </div>
        </div>

         <div class="row">
        <div class="col-sm-4">
         <div class="form-group">
        <asp:Label ID="lbl_password" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txt_password" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            </div>
        <div class="col-sm-4">
         <div class="form-group">
        <asp:Label ID="lbl_repassword" runat="server" Text="Re-enter Password"></asp:Label>
        <asp:TextBox ID="txt_repassword" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            </div>
        </div>

         <div class="row">
        <div class="col-sm-4">
         <div class="form-group">
        <asp:Label ID="lbl_country" runat="server" Text="Country"></asp:Label>
             <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                 <asp:ListItem Text="USA" Value="USA"></asp:ListItem>
                  <asp:ListItem Text="India" Value="India"></asp:ListItem>
                  <asp:ListItem Text="Canada" Value="Canada"></asp:ListItem>
                  <asp:ListItem Text="Brazil" Value="Brazil"></asp:ListItem>
                  <asp:ListItem Text="Mexico" Value="Mexico"></asp:ListItem>
             </asp:DropDownList>
       
            </div>
            </div>
        <div class="col-sm-4">
         <div class="form-group">            
        <asp:Label ID="lbl_gender" runat="server" Text="Gender"></asp:Label>
             <asp:RadioButtonList ID="RadioButtonList1" RepeatDirection="Horizontal" TextAlign="Left" runat="server">
                 <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                  <asp:ListItem Text="Female" Value="Female"></asp:ListItem>                 
             </asp:RadioButtonList>
            </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-8">
                <asp:Button Text="Submit" ID="btn_submit" runat="server" CssClass="btn btn-primary" OnClick="btn_submit_Click" />
            </div>

        </div>
    </div>
</asp:Content>
