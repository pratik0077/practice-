<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webcalculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 171px">
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Height="58px" OnTextChanged="TextBox1_TextChanged" Width="427px"></asp:TextBox>
        <br />
        <asp:Button ID="CE" runat="server" Height="58px" OnClick="CE_Click" Text="CE" Width="58px" />
        <asp:Button ID="C" runat="server" Height="58px" OnClick="C_Click" Text="C" Width="58px" />
        <asp:Button ID="back" runat="server" Height="58px" OnClick="back_Click" Text="&lt;----" Width="58px" />
        <asp:Button ID="div" runat="server" Height="58px" OnClick="div_Click" Text="/" Width="58px" />
        <asp:Button ID="sin" runat="server" Height="58px" OnClick="sin_Click" Text="Sin" Width="58px" />
        <asp:Button ID="sinh" runat="server" Height="58px" OnClick="sinh_Click" Text="Sinh" Width="58px" />
        <asp:Button ID="pi" runat="server" Height="58px" OnClick="pi_Click" Text="rr" Width="58px" />
        <br />
        <asp:Button ID="seven" runat="server" Height="58px" OnClick="Button1_Click" Text="7" Width="58px" />
        <asp:Button ID="eight" runat="server" Height="58px" OnClick="eight_Click" Text="8" Width="58px" />
        <asp:Button ID="nine" runat="server" Height="58px" OnClick="nine_Click" Text="9" Width="58px" />
        <asp:Button ID="mul" runat="server" Height="58px" OnClick="mul_Click" Text="*" Width="58px" />
        <asp:Button ID="cos" runat="server" Height="58px" OnClick="cos_Click" Text="Cos" Width="58px" />
        <asp:Button ID="cosh" runat="server" Height="58px" OnClick="cosh_Click" Text="Cosh" Width="58px" />
        <asp:Button ID="pow" runat="server" Height="58px" OnClick="pow_Click" Text="X^X" Width="58px" />
        <br />
        <asp:Button ID="four" runat="server" Height="58px" OnClick="four_Click" Text="4" Width="58px" />
        <asp:Button ID="five" runat="server" Height="58px" OnClick="five_Click" Text="5" Width="58px" />
        <asp:Button ID="six" runat="server" Height="58px" OnClick="six_Click" Text="6" Width="58px" />
        <asp:Button ID="sub" runat="server" Height="58px" OnClick="sub_Click" Text="-" Width="58px" />
        <asp:Button ID="tan" runat="server" Height="58px" OnClick="tan_Click" Text="Tan" Width="58px" />
        <asp:Button ID="tanh" runat="server" Height="58px" OnClick="tanh_Click" Text="Tanh" Width="58px" />
        <asp:Button ID="pow1" runat="server" Height="58px" OnClick="pow1_Click" Text="X^2" Width="58px" />
        <br />
        <asp:Button ID="one" runat="server" Height="58px" OnClick="one_Click" Text="1" Width="58px" />
        <asp:Button ID="twe" runat="server" Height="58px" OnClick="twe_Click" Text="2" Width="58px" />
        <asp:Button ID="three" runat="server" Height="58px" OnClick="three_Click" Text="3" Width="58px" />
        <asp:Button ID="add" runat="server" Height="58px" OnClick="add_Click" Text="+" Width="58px" />
        <asp:Button ID="log" runat="server" Height="58px" OnClick="log_Click" Text="Log" Width="58px" />
        <asp:Button ID="log10" runat="server" Height="58px" OnClick="log10_Click" Text="Log10" Width="58px" />
        <asp:Button ID="E" runat="server" Height="58px" OnClick="E_Click" Text="E" Width="58px" />
        <br />
        <asp:Button ID="zero" runat="server" Height="58px" OnClick="zero_Click" Text="0" Width="58px" />
        <asp:Button ID="point" runat="server" Height="58px" OnClick="point_Click" Text="." Width="58px" />
        <asp:Button ID="equal" runat="server" Height="58px" OnClick="equal_Click" Text="=" Width="120px" />
        <asp:Button ID="exp" runat="server" Height="58px" OnClick="exp_Click" Text="Exp" Width="58px" />
        <asp:Button ID="sqrt" runat="server" Height="58px" OnClick="sqrt_Click" Text="Sqrt" Width="58px" />
        <asp:Button ID="mod" runat="server" Height="58px" OnClick="mod_Click" Text="%" Width="58px" />
    
    </div>
    </form>
</body>
</html>
