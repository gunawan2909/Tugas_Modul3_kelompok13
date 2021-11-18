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
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        SqlDataAdapter sda = new SqlDataAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=gunawanp\\SQLEXPRESS ;Initial Catalog = TUGAS_MODUL3; Integrated Security = True";
            con.Open();
            if (!Page.IsPostBack)
            {
                DataShow();
         
            }
        }

        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * FROM DATA_SANTRI ";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewJoin.DataSource = ds;
            GridViewJoin.DataBind();
            ds = new DataSet();
            cmd.CommandText = "Select  ID_Santri,Nama_Santri, ID_kelas, ID_Jurusan  From Santri where isDelete = 0 ";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewSantri.DataSource = ds;
            GridViewSantri.DataBind();
            ds = new DataSet();
            cmd.CommandText = "Select Id_jurusan, Nama_universitas, Nama_Jurusan, Angkatan From Jurusan where isDelete = 0 ";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewJurusan.DataSource = ds;
            GridViewJurusan.DataBind();
            ds = new DataSet();
            cmd.CommandText = "Select Id_kelas, Nama_Kitab, Nama_Ustadz, Hari From Kelas where isDelete = 0 ";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewKelas.DataSource = ds;
            GridViewKelas.DataBind();
            con.Close();
        }
        
        
        protected void btnAddSantri_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert Into Santri(ID_Santri, ID_Kelas, ID_Jurusan, Nama_santri, IsDelete)values('" + txtIDSantri.Text + "', '" + txtIDKelas.Text + "', '" + txtIDJurusan.Text + "','" + txtNamaSantri.Text + "',0)";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnUpdateSantri_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Santri set Nama_santri ='" + txtNamaSantri.Text + "', ID_Kelas = '" + txtIDKelas.Text + "', ID_Jurusan = '" + txtIDJurusan.Text + "' WHERE ID_Santri = '" + txtIDSantri.Text + "'";
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShow();
        }

        protected void btnDeleteSantri_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Santri Set IsDelete = 1 where ID_Santri='" + txtIDSantri.Text + "'";
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShow();

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtIDSantri.Text = null;
            txtIDKelas.Text = null;
            txtIDJurusan.Text = null;
            txtNamaSantri.Text = null;
        }

        protected void btnAddJurusan_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert Into Jurusan(ID_Jurusan, Nama_Jurusan, Nama_Universitas, Angkatan, IsDelete)values('" + txtJ_IDJurusan.Text + "', '" + txtJ_NamaJuruasn.Text.ToString() + "', '" + txtJ_NamaUniversitas.Text.ToString() + "','" + txtJ_Angkatan.Text + "',0)";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnDeleteJurusan_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Jurusan Set IsDelete = 1 where ID_Jurusan='" + txtJ_IDJurusan.Text + "'";
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShow();
        }

        protected void btnUpdateJurusan_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Jurusan set Nama_Jurusan ='" + txtJ_NamaJuruasn.Text.ToString() + "', Nama_Universitas = '" + txtJ_NamaUniversitas.Text.ToString() + "', Angkatan = '" + txtJ_Angkatan.Text.ToString() + "' WHERE ID_Jurusan = '" + txtJ_IDJurusan.Text + "'";
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShow();
        }

        protected void btnClearJurusan_Click(object sender, EventArgs e)
        {
            txtJ_IDJurusan.Text = null;
            txtJ_NamaJuruasn.Text = null;
            txtJ_NamaUniversitas.Text = null;
            txtJ_Angkatan.Text = null;
        }

        protected void btnAddKelas_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert Into Kelas(ID_Kelas, Nama_Kitab, Nama_Ustadz, Hari, IsDelete)values('" + txtK_IDKelas.Text + "', '" + txtK_NamaKitab.Text.ToString() + "', '" + txtK_NamaUstadz.Text.ToString() + "','" + txtK_Hari.Text + "',0)";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnDeleteKelas_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Kelas Set IsDelete = 1 where ID_Kelas='" + txtK_IDKelas.Text + "'";
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShow();
        }

        protected void btnUpdateKelas_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Kelas set Nama_Kitab ='" + txtK_NamaKitab.Text.ToString() + "', Nama_Ustadz = '" + txtK_NamaUstadz.Text.ToString() + "', Hari = '" + txtK_Hari.Text.ToString() + "' WHERE ID_Kelas = '" + txtK_IDKelas.Text + "'";
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShow();
        }

        protected void btnClearKelas_Click(object sender, EventArgs e)
        {
            txtK_IDKelas.Text = null;
            txtK_NamaKitab.Text = null;
            txtK_NamaUstadz.Text = null;
            txtK_Hari.Text = null;
        }
    }
}


