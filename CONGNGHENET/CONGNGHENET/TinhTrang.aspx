<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TinhTrang.aspx.cs" Inherits="CONGNGHENET.TinhTrang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
       
        .auto-style6 {
            width: 203px;
            text-align: center;
            top : 25%;
            left: 50%;
            right: 50%;
        }
        .auto-style7 {
            width:60%;
            border: 1px solid black;
           
        }
        .auto-style8 {
            width: 113px;
         
            
        }
        .auto-style9 {
            text-align: center;
            top : 25%;
            left: 50%;
            right: 50%;
        }
        .auto-style16 {
            text-align: center;
            top : 25%;
            left: 50%;
            right: 50%;
            height: 21px;
        }
        h1{
            text-align: center ;
        }
        .auto-style20 {
            text-align: center;
            top : 25%;
            left: 50%;
            right: 300%;
            height: 28px;
        }
        .auto-style22 {
            margin-top: 1px;
        }
        .auto-style23 {
            width: 103px;
        }
        .content{
        margin-bottom: 100px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="content">
        <h1 >TÌNH TRẠNG</h1>
    <table class="auto-style7">
    <tr>
        <td class="auto-style16" colspan="4">
            <asp:Label ID="Label5" runat="server" Text="Mã tình trạng"></asp:Label>
            <asp:TextBox ID="txtmaTrang" runat="server" Width="217px" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style16" colspan="4">
            <asp:Label ID="Label3" runat="server" Text="Tên tình trạng"></asp:Label>
            <asp:TextBox ID="txttenTrang" runat="server" Width="217px" ></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:Button ID="btnthem" runat="server" Text="ADD" OnClick="btnthem_Click" Width="73px" />
            </td>
        <td class="auto-style23">
            <asp:Button ID="btnET" runat="server" OnClick="btnET_Click" Text="EMPTY" />
        </td>
        <td class="auto-style8">
            <asp:Button ID="btnxoa" runat="server" Text="DELETE" OnClick="btnxoa_Click" />
        </td>
        <td class="auto-style8">
            <asp:Button ID="btnsua" runat="server" Text="EDIT" Width="72px" OnClick="btnsua_Click" Height="20px" CssClass="auto-style22" />
        </td>
    </tr>
    <tr>
        <td class="auto-style9" colspan="4">
            <asp:GridView ID="grvtinhtrang" runat="server" Width="626px">
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td class="auto-style9" colspan="4">
            <asp:Label ID="Label4" runat="server" ForeColor="Red"></asp:Label>
        </td>
    </tr>
   
</table>
   </div>
</asp:Content>
