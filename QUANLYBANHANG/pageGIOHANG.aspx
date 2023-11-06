<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageUser.Master" AutoEventWireup="true" CodeBehind="pageGIOHANG.aspx.cs" Inherits="QUANLYBANHANG.pageGIOHANG" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center_content">
    <asp:GridView ID="grvCARD" runat="server" AutoGenerateColumns="False" CellSpacing="4" ForeColor="#333333" GridLines="None" ShowFooter="True">
        <AlternatingRowStyle BackColor="white" />
        <Columns>
            <asp:BoundField DataField="MASANPHAM" HeaderText="Mã s&#7843;n ph&#7849;m" />
            <asp:BoundField DataField="TENSANPHAM" HeaderText="Tên s&#7843;n ph&#7849;m" />
            <asp:BoundField DataField="SOLUONG" HeaderText="S&#7889; l&#432;&#7907;ng" />
            <asp:BoundField DataField="DONGIA" HeaderText="&#272;&#417;n " />
            <asp:BoundField DataField="THANHTIEN" HeaderText="Thành ti&#7873;n" />
            <asp:ImageField DataAlternateTextField="HINHANH" DataImageUrlField="HINHANH" DataImageUrlFormatString="/images/{0}" HeaderText="&#7842;nh">
            </asp:ImageField>
            <asp:TemplateField HeaderText="Tr&#7843; hàng">
                <ItemTemplate>
                    <asp:CheckBox ID="ckbREMOVEITEM" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button runat="server" Text="Tr&#7843; hàng" ID="btnDELETE" OnClick="btnDELETE_Click" />
        </div>
</asp:Content>
