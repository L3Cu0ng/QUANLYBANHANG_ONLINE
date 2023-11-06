<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageUser.Master" AutoEventWireup="true" CodeBehind="pageLOGIN.aspx.cs" Inherits="QUANLYBANHANG.pageLOGIN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center_content">
        <div class="center_title_bar">Latest Products</div>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1" colspan="2">&#272;&#258;NG NH&#7852;P&nbsp; </td>
            </tr>
            <tr>
                <td class="auto-style2">Tên ng&#432;&#7901;i dùng</td>
                <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">M&#7853;t kh&#7849;u</td>
                <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">
                <asp:Button ID="btnLogin" runat="server" Text="&#272;&#259;ng Nh&#7853;p" OnClick="btnLogin_Click"/>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
