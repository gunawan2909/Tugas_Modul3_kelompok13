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
    public partial class recycle : System.Web.UI.Page
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
            cmd.CommandText = "Select  ID_Santri,Nama_Santri, ID_kelas, ID_Jurusan  From Santri where isDelete = 1 ";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewSantri.DataSource = ds;
            GridViewSantri.DataBind();
            ds = new DataSet();
            cmd.CommandText = "Select Id_jurusan, Nama_universitas, Nama_Jurusan, Angkatan From Jurusan where isDelete = 1 ";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewJurusan.DataSource = ds;
            GridViewJurusan.DataBind();
            ds = new DataSet();
            cmd.CommandText = "Select Id_kelas, Nama_Kitab, Nama_Ustadz, Hari From Kelas where isDelete = 1 ";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewKelas.DataSource = ds;
            GridViewKelas.DataBind();
            con.Close();
        }

            

        protected void Restore_clik(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update "+ Nama_Tabel.Text.ToString() + " Set IsDelete = 0 where ID_"+ Nama_Tabel.Text.ToString() + "=" + ID_Tabel.Text ;
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShow();
        }

        protected void Delete_clik(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "delete from " + Nama_Tabel.Text + " where ID_" + Nama_Tabel.Text.ToString() + "=" + ID_Tabel.Text + ";";
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShow();
        }
    }
}