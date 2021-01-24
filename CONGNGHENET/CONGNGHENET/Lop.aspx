<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Lop.aspx.cs" Inherits="CONGNGHENET.Lop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
            width: 146px;
        }
        .auto-style6 {
            width: 146px;
        }
        .auto-style7 
        {
         text-align:center;
            width: 60%;
        }
        .auto-style9 {
            width: 83px;
        }
        .auto-style10 {
            margin-left: 0px;
        }
        h1{
            text-align: center;
        }
    .auto-style11 {
        height: 26px;
        width: 227px;
    }
    .auto-style12 {
        width: 227px;
    }
    .content{
        margin-bottom: 100px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <h1 >DANH SACH LOP</h1>
    <table class="auto-style7">
        <tr>
            <td class="auto-style5">Ten Lop:</td>
            <td class="auto-style2" colspan="2">
                <asp:TextBox ID="txtlop" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">
                Nhap&nbsp; MaLop:</td>
            <td class="auto-style11">
                <asp:TextBox ID="txtmalop" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Nganh:</td>
            <td colspan="2">
                <asp:DropDownList ID="ddlnganh2" runat="server" DataSourceID="SqlDataSourceDDL" DataTextField="TenNganh" DataValueField="MaNganh">
                </asp:DropDownList>
            </td>
            <td colspan="2">
                <asp:SqlDataSource ID="SqlDataSourceDDL" runat="server" ConnectionString="<%$ ConnectionStrings:KTGK222ConnectionString %>" SelectCommand="SELECT [MaNganh], [TenNganh] FROM [NGANH]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style9">
                <asp:Button ID="btnadd" runat="server" Text="ADD" Width="72px" OnClick="btnadd_Click" />
            </td>
            <td class="auto-style6">
                <asp:Button ID="btnempty" runat="server" Text="EMPTY" OnClick="btnempty_Click" />
            </td>
            <td>
                <asp:Button ID="btndelete" runat="server" Text="DELETE" OnClick="btndelete_Click" />
            </td>
            <td class="auto-style12">
                <asp:Button ID="Button2" runat="server" Text="EDIT" Width="70px" OnClick="Button2_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:GridView ID="grvlop" runat="server" CssClass="auto-style10" Width="804px">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
    </div>
</asp:Content>
