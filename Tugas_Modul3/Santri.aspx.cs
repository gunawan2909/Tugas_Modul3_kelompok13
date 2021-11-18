using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace Tugas_Modul3
{
    public partial class ListItems : System.Web.UI.Page
    {
        
        protected void Page_Loadsantri(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=gunawanp\\SQLEXPRESS ;Initial Catalog = TUGAS_MODUL3; Integrated Security = True";
            con.Open();
            if (!Page.IsPostBack)
            {
                DataShowsantri();
            }
        }
        public void DataShowsantri()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * from Santri where is_delet=0";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewJoin.DataSource = ds;
            GridViewJoin.DataBind();
            con.Close();
        }



        protected void btnAddSantri_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert Into Santri(ID_Santri, ID_Kelas, ID_Jurusan, Nama)values('" + txtIdBuku.Text + "', '" + txtJudul.Text + "', '" + txtGenre.Text + "','" + txtRilis.Text.ToString() + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();

        }

        protected void btnUpdateSantri_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Santri set ID_Kelas='" + txtJudul.Text + "', ID_Jurusan = '" + txtGenre.Text + "', Nama_santri = '" + txtRilis.Text.ToString() + "' WHERE ID_Santri = '" + txtIdBuku.Text + "'";
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShow();

        }

        protected void btnDeleteSantri_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Delete from Buku where ID_Buku='" + txtIdBuku.Text + "'";
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShow();

        }

        protected void btnClearSantri_Click(object sender, EventArgs e)
        {
            txtGenre.Text = null;
            txtIdBuku.Text = null;
            txtJudul.Text = null;
            txtRilis.Text = null;
        }
    }
}
}