<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="CONGNGHENET.TrangChu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
         h1{
             text-align: center;
         }
         .backgr{
             height: 500px;
         }
        .nen{
            width:300px;
            height: 300px;
            border-radius: 70px;
        }
     </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="backgr">
        <h1>HỆ THỐNG QUẢN LÍ THÔNG TIN SINH VIÊN (CNTT)</h1>
        <img class="nen" src="img/logoCNTT.jpg"/>
   </div>

</asp:Content>
