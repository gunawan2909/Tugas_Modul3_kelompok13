<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="recycle.aspx.cs" Inherits="Tugas_Modul3.recycle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            width: 187px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>Recycle Data</h1>
                <a href ="ListItems.aspx">Kembali Ke menu Utama</a>
            
                            
                <h2>Santri</h2>
                <asp:GridView ID="GridViewSantri" runat="server">
                </asp:GridView>
               
                <h2>Kelas</h2>
                <asp:GridView ID="GridViewKelas" runat="server">
                </asp:GridView>
              
                <h2>Jurusan </h2>
                <asp:GridView ID="GridViewJurusan" runat="server">
                </asp:GridView>
              
           
 
                       
           
            <table>
                   <tr>
                    <td class="auto-style1">Tabel:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Nama_Tabel" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>ID:</td>
                    <td>
                        <asp:TextBox ID="ID_Tabel" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="RESTORE" runat="server" Text="Restore" OnClick="Restore_clik" />
                            <asp:Button ID="Delete" runat="server" 
                            Text="DELETE" OnClick="Delete_clik" />

                    </td>
                </tr>
            </table>
      
             </center>
        </div>
    </form>
</body>
</html>
