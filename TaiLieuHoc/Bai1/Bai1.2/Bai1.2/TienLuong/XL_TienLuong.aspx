<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XL_TienLuong.aspx.cs" Inherits="Bai1._2.TienLuong.XL_TienLuong" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 500px; margin: 0 auto">
            <table style="width: 100%" border="1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Mã NV"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMaNV2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Ngày công"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNgayCong2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Tiền lĩnh"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTienLinh2" runat="server"></asp:TextBox>
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
