<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListItems.aspx.cs" 
    Inherits="Tugas_Modul3.ListItems" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 546px;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <center><h1>Pondok Pesantren Nurul Himah</h1>
                <a href="recycle.aspx">Recycle Data</a>
              </center>
           <br />
        </div>
        <center>           <asp:GridView ID="GridViewJoin" runat="server" Width="557px">
            </asp:GridView>
       </center>
        <br />
        <table>
            <tr>
                <td>
                  <div class="auto-style1">
        <h2>UPDATE SANTRI </h2>
        
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
      
            <asp:GridView ID="GridViewSantri" runat="server">
            </asp:GridView>
         </div>
          </td><td>
                  <div>
                    <h2>UPDATE Jurusan </h2>
        
                        <table>
                               <tr>
                                <td>ID Jurusan:</td>
                                <td>
                                    <asp:TextBox ID="txtJ_IDJurusan" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Nama Jurusan :</td>
                                <td>
                                    <asp:TextBox ID="txtJ_NamaJuruasn" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Nama Universitas :</td>
                                <td>
                                    <asp:TextBox ID="txtJ_NamaUniversitas" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Angkatan :</td>
                                <td>
                                    <asp:TextBox ID="txtJ_Angkatan" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>
                                    <asp:Button ID="btnAddJurusan" runat="server" Text="ADD" OnClick="btnAddJurusan_Click" 
                                         /> 
                                    <asp:Button ID="btnDeleteJurusan" runat="server" 
                                        Text="DELETE" OnClick="btnDeleteJurusan_Click" />

                                    <asp:Button ID="btnUpdateJurusan" runat="server"
                                        Text="UPDATE" OnClick="btnUpdateJurusan_Click" />

                                     <asp:Button ID="btnClearJurusan" runat="server"
                                        Text="CLEAR" OnClick="btnClearJurusan_Click" />
                                </td>
                            </tr>
                        </table>
      
                        <asp:GridView ID="GridViewJurusan" runat="server">
                        </asp:GridView>
                    </div>
               </td>

            </tr>
            <td>
            <div>
                    <h2>UPDATE Kelas </h2>
        
                        <table>
                               <tr>
                                <td>ID Kelas:</td>
                                <td>
                                    <asp:TextBox ID="txtK_IDKelas" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Nama Kitab :</td>
                                <td>
                                    <asp:TextBox ID="txtK_NamaKitab" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Nama Ustad :</td>
                                <td>
                                    <asp:TextBox ID="txtK_NamaUstadz" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Hari :</td>
                                <td>
                                    <asp:TextBox ID="txtK_Hari" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>
                                    <asp:Button ID="btnAddKelas" runat="server" Text="ADD" OnClick="btnAddKelas_Click" 
                                         /> 
                                    <asp:Button ID="btnDeleteKelas" runat="server" 
                                        Text="DELETE" OnClick="btnDeleteKelas_Click" />

                                    <asp:Button ID="btnUpdateKelas" runat="server"
                                        Text="UPDATE" OnClick="btnUpdateKelas_Click" />

                                     <asp:Button ID="btnClearKelas" runat="server"
                                        Text="CLEAR" OnClick="btnClearKelas_Click" />
                                </td>
                            </tr>
                        </table>
      
                        <asp:GridView ID="GridViewKelas" runat="server">
                        </asp:GridView>
                    </div>
            </td>

        </table>

    </form>
</body>
</html>
