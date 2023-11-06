<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QUANLYSANPHAM_GUI.aspx.cs" Inherits="QUANLYBANHANG.ADMIN.GUI.QUANLYSANPHAM_GUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
            width: 108px;
        }
        .auto-style4 {
            width: 53%;
        }
        .auto-style5 {
            width: 9%;
        }
        .auto-style6 {
            width: 108px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                   <th colspan="5">QUẢN LÝ DANH SÁCH SẢN PHẨM</th> 
                </tr>
                <tr>
                    <td class="auto-style6">Mã danh mục</td>
                    <td colspan="4">
                        <asp:DropDownList ID="drpDANHMUC" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Mã sản phẩm</td>
                    <td colspan="4">
                        <asp:TextBox ID="txtMASANPHAM" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Tên sản phẩm</td>
                    <td colspan="4">
                        <asp:TextBox ID="txtTENSANPHAM" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Đơn giá</td>
                    <td colspan="4">
                        <asp:TextBox ID="txtDONGIA" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Số lượng</td>
                    <td colspan="4">
                        <asp:TextBox ID="txtSOLUONG" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Upload ảnh</td>
                    <td colspan="4" class="auto-style1">
                        <asp:FileUpload ID="FileANHSANPHAM" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="5">Mô tả</td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="5">
                        <asp:TextBox ID="txtMOTA" runat="server" Rows="5" TextMode="MultiLine" Width="1019px" Wrap="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Button ID="btnInsert" OnClick="btnInsert_Click" runat="server" Text="Thêm mới" />
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnDelete"  OnClick="btnDelete_Click" runat="server" Text="Xóa" />
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="btnUpdate"  OnClick="btnUpdate_Click" runat="server" Text="Sửa" />
                    </td>
                    <td colspan="2" class="auto-style5"> </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="grvSANPHAM" runat="server" AutoGenerateColumns="False" Width="1026px">
            <Columns>
                <asp:BoundField DataField="MASANPHAM" HeaderText="Mã sản phẩm" />
                <asp:BoundField DataField="TENSANPHAM" HeaderText="Tên sản phẩm" />
                <asp:BoundField DataField="DONGIA" HeaderText="Đơn giá" />
                <asp:BoundField DataField="SOLUONG" HeaderText="Số lượng" />
                <asp:ImageField DataAlternateTextField="HINHANH"  DataImageUrlField="HINHANH" DataImageUrlFormatString="/images/{0}" HeaderText="Ảnh sản phẩm">
                    <ControlStyle Width="200px" />
                </asp:ImageField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
