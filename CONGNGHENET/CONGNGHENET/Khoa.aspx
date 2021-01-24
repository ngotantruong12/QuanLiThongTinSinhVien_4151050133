<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Khoa.aspx.cs" Inherits="CONGNGHENET.Khoa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 133px;
        }
        .auto-style3 {
            width: 194px;
        }
        .auto-style4 {
            width: 133px;
            height: 24px;
        }
        .auto-style5 {
            width: 194px;
            height: 24px;
        }
        .auto-style6 {
            height: 24px;
            width: 226px;
        }
        .auto-style7 {
            width: 60%;
            text-align: center;
        }
        .auto-style8 {
            width: 226px;
        }
        .auto-style11 {
            width: 133px;
            height: 28px;
        }
        .auto-style12 {
            width: 194px;
            height: 28px;
        }
        .auto-style13 {
            width: 226px;
            height: 28px;
        }
        .auto-style14 {
            width: 133px;
            height: 43px;
        }
        .auto-style15 {
            width: 194px;
            height: 43px;
        }
        .auto-style16 {
            width: 226px;
            height: 43px;
        }
        .auto-style17 {
            width: 133px;
            height: 22px;
        }
        .auto-style18 {
            width: 194px;
            height: 22px;
        }
        .auto-style19 {
            height: 22px;
            width: 226px;
        }
        h1{
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>DANH SÁCH CÁC KHOA</h1>
    <table class="auto-style7">
        <tr>
            <td class="auto-style17"></td>
            <td class="auto-style18"></td>
            <td class="auto-style19" colspan="2"></td>
        </tr>
        <tr>
            <td class="auto-style14">Tên khoa:</td>
            <td class="auto-style15">
                <asp:TextBox ID="txtTK" runat="server" Width="157px"></asp:TextBox>
            </td>
            <td class="auto-style16" colspan="2">Mã khoa:
                <asp:TextBox ID="txtMK" runat="server" Width="157px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Số điện thoại:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtSDT" runat="server" Width="157px"></asp:TextBox>
            </td>
            <td class="auto-style6" colspan="2"></td>
        </tr>
        <tr>
            <td class="auto-style4">Email:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txteml" runat="server" Width="157px"></asp:TextBox>
            </td>
            <td class="auto-style6" colspan="2"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style8" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style8" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Button ID="btnAddKhoa" runat="server" Text="ADD" OnClick="Button1_Click" />
            </td>
            <td class="auto-style12">
                <asp:Button ID="btnEty" runat="server" OnClick="btnEty_Click" Text="EMPTY" />
            </td>
            <td class="auto-style13">
                <asp:Button ID="Button3" runat="server" Text="DELETE" OnClick="Button3_Click" />
            </td>
            <td class="auto-style13">
                <asp:Button ID="Button2" runat="server" Text="EDIT" OnClick="Button2_Click" />
            </td>
         
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style8" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="gvKhoa" runat="server" Width="548px">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="lblTB" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
