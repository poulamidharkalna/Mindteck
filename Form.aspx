<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="Reg_From.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td>Full Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" placeholder="Enter your full name" Enabled="True"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="txtAdd" runat="server" placeholder="Enter your address"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:RadioButton GroupName="user" ID="RadioButton1" runat="server" Text="Male" OnCheckedChanged="RadioButton1_CheckedChanged" />
                    <asp:RadioButton GroupName="user" ID="RadioButton2" runat="server" Text="Female" OnCheckedChanged="RadioButton2_CheckedChanged" /></td>
                </tr>
                <tr>
                    <td>Phone</td>
                    <td>
                        <asp:TextBox ID="txtPhone" runat="server" placeholder="+977-012-345-6789"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Placeholder ="P123@gmail.com"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Username</td>
                    <td>
                        <asp:TextBox ID="txtUser" runat="server" Placeholder="Enter Username" OnTextChanged="txtUser_TextChanged"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server" Placeholder="*****" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnReg" runat="server" Text="Register" OnClick="btnReg_Click1" /></td>
                </tr>
            </table>

            

        </div>
        
    </form>
</body>
</html>
