<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SinhVien.aspx.cs" Inherits="CONGNGHENET.SinhVien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 92px;
    }
    .auto-style4 {
        width: 100px;
    }
        .auto-style5 {
            width: 126px;
        }
        .auto-style6 {
            width: 118px;
        }
        h1{
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>DANH SACH SINH VIEN</h1>
    <table style="width:60%;">
    <tr>
        <td class="auto-style2">TenSV:</td>
        <td class="auto-style5">
            <asp:TextBox ID="txttensv" runat="server" Width="116px"></asp:TextBox>
        </td>
        <td class="auto-style4">Nhap MaSV:</td>
        <td class="auto-style6">
            <asp:TextBox ID="txtmasv" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">GioiTinh</td>
        <td class="auto-style5">
            <asp:DropDownList ID="ddlgioitinh" runat="server">
                <asp:ListItem Value="1">Men</asp:ListItem>
                <asp:ListItem Value="0">Woman</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">NgaySinh</td>
        <td class="auto-style5">
            <asp:TextBox ID="txtngaysinh" runat="server" TextMode="Date"></asp:TextBox>
        </td>
        <td class="auto-style4">
            &nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">SoCMND:</td>
        <td class="auto-style5">
            <asp:TextBox ID="txtcmnd" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">TonGiao:</td>
        <td class="auto-style5">
            <asp:TextBox ID="txttongiao" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">SDT:</td>
        <td class="auto-style5">
            <asp:TextBox ID="txtsdt" runat="server"></asp:TextBox>
            <br />
        </td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">QueQuan:</td>
        <td class="auto-style5">
            <asp:TextBox ID="txtquequan" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">KhoaHoc:</td>
        <td class="auto-style5">
            <asp:TextBox ID="txtkhoahoc" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">MaTinhTrang:</td>
        <td class="auto-style5">
            <asp:DropDownList ID="ddlmatinhtrang" runat="server" Height="16px" DataSourceID="SqlDataSource1" DataTextField="TinhTrang" DataValueField="MaTT">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KTGK222ConnectionString %>" SelectCommand="SELECT * FROM [TINHTRANG]"></asp:SqlDataSource>
        </td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">MaLop:</td>
        <td class="auto-style5">
            <asp:DropDownList ID="ddlmalop" runat="server" DataSourceID="SqlDataSource2" DataTextField="TenLop" DataValueField="MaLop">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:KTGK222ConnectionString %>" SelectCommand="SELECT * FROM [LOP]"></asp:SqlDataSource>
        </td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style6">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">MaGV:</td>
        <td class="auto-style5">
            <asp:DropDownList ID="ddlmagv" runat="server" DataSourceID="SqlDataSource3" DataTextField="TenGV" DataValueField="MaGV">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:KTGK222ConnectionString %>" SelectCommand="SELECT * FROM [GIANGVIEN]"></asp:SqlDataSource>
        </td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Button ID="btnadd" runat="server" Text="ADD" OnClick="btnadd_Click" />
        </td>
        <td class="auto-style5">
            <asp:Button ID="Button2" runat="server" Text="EMPTY" style="height: 26px" OnClick="Button2_Click" />
        </td>
        <td class="auto-style4">
            <asp:Button ID="btndelete" runat="server" Text="DELETE" OnClick="btndelete_Click" />
        </td>
        <td class="auto-style6">
            <asp:Button ID="btnedit" runat="server" Text="EDIT" OnClick="btnedit_Click" />
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <asp:GridView ID="grvsinhvien" runat="server">
            </asp:GridView>
            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
        </td>
    <tr>
        <td colspan="4">
            &nbsp;</td>
 </table>      
</asp:Content>
