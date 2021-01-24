<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dangnhap.aspx.cs" Inherits="CONGNGHENET.dangnhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 411px;
        }
        body
        {
    margin: 0;
    padding:0 0 20px;
    background:rgb(140, 139, 124);
    background-size:cover;
    background-position: center;
    font-family: sans-serif;
    text-align:center;
}

.loginbox{
    width: 420px;
    height: 380px;
    background: #000;
    color: #fff;
    top: 50%;

    left: 50%;
    right: 50%;
    position: absolute;
    transform: translate(-50%,-50%);
    box-sizing: border-box;
    padding: 50px 50px;
}



.loginbox p{
    margin: 0;
    padding: 0;
    font-weight: bold;
}

.loginbox input{
    width: 100%;
    margin-bottom: 20px;
}

.loginbox input[type="text"], input[type="password"],input[type="Confirm"]
{
    border: none;
    border-bottom: 1px solid #fff;
    background: transparent;
    outline: none;
    height: 40px;
    color: #fff;
    font-size: 16px;
}
.loginbox input[type="submit"]
{
    border: none;
    outline: none;
    height: 40px;
    background: #fb2525;
    color: #fff;
    font-size: 18px;
    border-radius: 20px;
}





    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="loginbox">
          
           
           
                        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Đăng Nhập"></asp:Label></br>
            <asp:Label ID="Label2" runat="server" Text="Tài khoản"></asp:Label><br/>
                        <asp:RequiredFieldValidator ID="rfvdangnhap" runat="server" ErrorMessage="Yêu cầu tài khoản" ControlToValidate="txttaikhoan" ForeColor="Red"></asp:RequiredFieldValidator>
                        
                
                        <asp:TextBox ID="txttaikhoan" runat="server"></asp:TextBox>
                        <asp:Label ID="Label3" runat="server" Text="Mật khẩu"></asp:Label><br />
                        <asp:RequiredFieldValidator ID="rfvmatkhau" runat="server" ErrorMessage="Yêu cầu mật khẩu" ControlToValidate="txtmatkhau" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtmatkhau" runat="server" TextMode="Password"></asp:TextBox>

                       
                         
                        <asp:Button ID="btndangnhap" runat="server" Text="Đăng Nhập" OnClick="btndangnhap_Click" />

                       
                         
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/dangki.aspx">Đăng kí</asp:HyperLink><br/>
                 
           
          
                        <asp:Label ID="lbthongbao" runat="server"></asp:Label>
                 
           
          
        </div>
    </form>
</body>
</html>
