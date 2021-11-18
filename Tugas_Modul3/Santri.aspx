<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Santri.aspx.cs" Inherits="Tugas_Modul3.Santri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                   <tr>
                    <td>ID Santri:</td>
                    <td>
                        <asp:TextBox ID="txtIDSantri" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>ID Kelas :</td>
                    <td>
                        <asp:TextBox ID="txtIDKelas" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>ID Jurusan :</td>
                    <td>
                        <asp:TextBox ID="txtIDJurusan" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Nama Santri :</td>
                    <td>
                        <asp:TextBox ID="txtNamaSantri" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnAddSantri" runat="server" Text="ADD" OnClick="btnAddSantri_Click" 
                             /> 
                        <asp:Button ID="btnDeleteSantri" runat="server" 
                            Text="DELETE" OnClick="btnDeleteSantri_Click" />

                        <asp:Button ID="btnUpdateSantri" runat="server"
                            Text="UPDATE" OnClick="btnUpdateSantri_Click" />

                         <asp:Button ID="btnClearSantri" runat="server"
                            Text="CLEAR" OnClick="btnClear_Click" />
                    </td>
                </tr>
            </table>
        </div>
            <asp:GridView ID="GridViewJoin" runat="server">
            </asp:GridView>
    </form>
</body>
</html>
