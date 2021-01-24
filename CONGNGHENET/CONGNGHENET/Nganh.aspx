<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Nganh.aspx.cs" Inherits="CONGNGHENET.Nganh" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
            width: 95px;
        }
        .auto-style5 {
            width: 95px;
            height: 30px;
        }
        .auto-style7 {
            height: 30px;
            width: 197px;
        }
        .auto-style8 {
            width: 197px;
        }
        .auto-style9 {
            width: 60%;
            text-align:center;
        }
        .auto-style12 {
            width: 75px;
            height: 30px;
        }
        .auto-style13 {
            width: 75px;
        }
        .auto-style14 {
            height: 30px;
        }
        .auto-style15 {
            margin-right: 40px;
            width:180px;
        }
        h1{
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>DANH SACH CAC NGANH</h1>
    <table class="auto-style9">
    <tr>
        <td class="auto-style5">&nbsp;Tên ngành :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
        <td class="auto-style14" colspan="2">
            <asp:TextBox ID="txtnganh" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style12" colspan="2">
            Mã Ngành:</td>
        <td class="auto-style7">
            <asp:TextBox ID="txtmanganh" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">Mã Khoa :</td>
        <td colspan="2">
            <asp:DropDownList ID="DDLMaKhoa" runat="server" CssClass="auto-style15">
            </asp:DropDownList>
        </td>
        <td class="auto-style13" colspan="2">
            &nbsp;</td>
        <td class="auto-style8">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td colspan="2">&nbsp;</td>
        <td class="auto-style13" colspan="2">
            &nbsp;</td>
        <td class="auto-style8">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">
            <asp:Button ID="BtnADD" runat="server" Text="ADD" Width="60px" OnClick="BtnADD_Click" style="height: 26px" />
        </td>
        <td colspan="2">
            <asp:Button ID="btnempty" runat="server" OnClick="btnempty_Click" Text="EMPTY" />
        </td>
        <td class="auto-style13" colspan="2">
            <asp:Button ID="BtnDl" runat="server" Text="DELETE" Width="62px" CssClass="auto-style15" OnClick="BtnDl_Click" />
        </td>
        <td class="auto-style8">
            <asp:Button ID="btnedit" runat="server" Text="EDIT" Width="61px" OnClick="btnedit_Click" />
        </td>
    </tr>
    <tr>
        <td colspan="6">
            <asp:GridView ID="grvNganh" runat="server" Width="610px">
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            &nbsp;</td>
        <td colspan="2">
            <asp:Label ID="lbthongbao" runat="server" ForeColor="Red"></asp:Label>
        </td>
        <td colspan="2">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td colspan="2">
            &nbsp;</td>
        <td class="auto-style13" colspan="2">&nbsp;</td>
        <td class="auto-style8">&nbsp;</td>
    </tr>
</table>
</asp:Content>
