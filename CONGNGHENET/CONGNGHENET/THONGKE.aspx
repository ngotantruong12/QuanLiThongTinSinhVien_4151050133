<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="THONGKE.aspx.cs" Inherits="CONGNGHENET.THONGKE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .content{
            margin-left: 30px;
            height: 350px;
        }
        table tr td{
            width: 400px;
           
        }
        table{
             border: 5px solid black;
        }
        h1{
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
       <h1>THONG KE SINH VIEN</h1>
        <table style="width:100%; height:20px;">
    <tr>
        <td>
            <asp:GridView ID="grvthongke" runat="server">
            </asp:GridView>
        </td>
    </tr>
</table>
   </div>
</asp:Content>
