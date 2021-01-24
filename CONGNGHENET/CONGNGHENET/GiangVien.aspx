<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="GiangVien.aspx.cs" Inherits="CONGNGHENET.GiangVien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 282px;
        }
        .auto-style5 {
            width: 154px;
        }
        .auto-style6 {
            width: 179px;
        }
        .auto-style7 {
            width: 60%;
        }
        h1{
            text-align: center;
        }
    .auto-style9 {
        width: 179px;
        height: 24px;
    }
    .auto-style10 {
        width: 282px;
        height: 24px;
    }
    .auto-style11 {
        height: 24px;
    }
        .auto-style12 {
            width: 179px;
            height: 28px;
        }
        .auto-style13 {
            width: 282px;
            height: 28px;
        }
        .auto-style14 {
            height: 28px;
        }
        #txtemail{
            margin-left: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>DACH SACH GIANG VIEN</h1>   
    <table class="auto-style7">
            <tr>
                <td class="auto-style6">Tên Giảng Viên:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtten" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">Mã Giảng Viên:</td>
                <td>
                    <asp:TextBox ID="txtmagv" runat="server" Height="22px" Width="143px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Giới Tính:</td>
                <td class="auto-style10">
                    <asp:DropDownList ID="ddlgioitinh" runat="server">
                        <asp:ListItem Value="1">Man</asp:ListItem>
                        <asp:ListItem Value="0">Woman</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style6">SDT:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtsdt" runat="server"></asp:TextBox>
                </td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">Email:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtemail" runat="server" ></asp:TextBox>
                    <br />
                </td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Button ID="btnADD" runat="server" OnClick="btnADD_Click" Text="ADD" Width="60px" />
                </td>
                <td class="auto-style13">
                    <asp:Button ID="btnEMTY" runat="server" Text="EMTY" Width="60px" OnClick="btnEMTY_Click" />
                </td>
                <td class="auto-style14">
                    <asp:Button ID="btnDelete" runat="server" Text="DELETE" Width="60px" OnClick="btnDelete_Click" />
                </td>
                <td class="auto-style14">
                    <asp:Button ID="btnEdit" runat="server" Text="EDIT" Width="60px" OnClick="btnEdit_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:GridView ID="grvGiangVien" runat="server" Width="665px">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Label ID="lblthongbao" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
</asp:Content>
