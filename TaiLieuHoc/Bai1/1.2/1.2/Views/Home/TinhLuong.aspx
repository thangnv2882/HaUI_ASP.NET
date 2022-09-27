@{
    ViewBag.Title = "TinhLuong";
}

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TinhLuong.aspx.cs" Inherits="_1._2.Views.Home.TinhLuong" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính Lương</title>

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
                        <asp:TextBox ID="txtMaNV" runat="server" Text="hhaah">huhuhu</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Bậc lương"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtBacLuong" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Ngày công"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNgayCong" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Chức vụ"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="chucvu" runat="server">
                            <asp:ListItem Value="Trưởng phòng"  />
                            <asp:ListItem Value="Phó phòng" />
                            <asp:ListItem Value="Nhân viên" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Giới tính"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="radioGT" runat="server">
                            <asp:ListItem Value="Nam" />
                            <asp:ListItem Value="Nữ" />
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Ngoại ngữ"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="cbNgoaiNgu" runat="server">
                            <asp:ListItem Value="Anh" />
                            <asp:ListItem Value="Pháp" />
                            <asp:ListItem Value="Nga" />
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Tiền lĩnh"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTienLinh" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btTinh" runat="server" Text="TÍNH" OnClick="btTinh_Click"/>
                        <asp:Button ID="btXoa" runat="server" Text="XOÁ" />

                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>


