<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageUser.Master" AutoEventWireup="true" CodeBehind="CHITIETSANPHAM.aspx.cs" Inherits="QUANLYBANHANG.CHITIETSANPHAM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
        <ItemTemplate>

        <div class="prod_box">
                    <div class="top_prod_box"></div>
                    <div class="center_prod_box">
                        <div class="product_title"><a href="details.html"><%# Eval("TENSANPHAM") %></a></div>
                        <div class="product_img"><a href="details.html"><img src="/images/<%# Eval("HINHANH") %>" alt="" border="0" /></a></div>
                        <div class="prod_price"><span class="reduce">350$</span> <span class="price"><%# Eval("DONGIA") %></span></div>
                    </div>
                    <div class="bottom_prod_box"></div>
                    <div class="prod_details_tab">
                        <asp:ImageButton title="header=[Add to cart] body=[&nbsp;] fade=[on]" ID="Imagecart" ImageUrl="/images/cart.gif" class="left bt" OnClick="Imagecart_Click" runat="server" />    
                        <a href="#" title="header=[Specials] body=[&nbsp;] fade=[on]">
                            <img src="/images/favs.gif" alt="" border="0" class="left_bt" />
                        </a> 
                        <a href="#" title="header=[Gifts] body=[&nbsp;] fade=[on]">
                            <img src="/images/favorites.gif" alt="" border="0" class="left_bt" />

                        </a> 
                        <a href="details.html" class="prod_details">details</a> 
                    </div>
                </div>
            </ItemTemplate>
    </asp:Repeater>
</asp:Content>
