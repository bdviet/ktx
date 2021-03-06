using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKTXBIA
{
    class ketnoi
    {
        public static DataSet ds;
        public static SqlDataReader dr;  
        public static SqlConnection con = null;
        SqlConnection cn;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public static DataTable dt;

        public ketnoi()
        {
            cn = new SqlConnection(@"Data Source=TIIN;Initial Catalog=Qlyktxa;Integrated Security=True");
        }
        public static void OpenCn()
        {
            try
            {
                string connect = @"Data Source=TIIN;Initial Catalog=Qlyktxa;Integrated Security=True";
                con = new SqlConnection(connect);
                con.Open();
               // MessageBox.Show("Kết nối thành công!");
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi kết nối cơ sở dự liệu");
            }
        }
        public string LayGiaTri(string str)
        {
           cn.Open();
            string kq = "";
            cmd = new SqlCommand(str, cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kq = dr[0].ToString();
            }
           cn.Close();
            return kq;
        }
        public static void CloseCn()
        {
            try
            {
                string connect = @"Data Source=TIIN;Initial Catalog=Qlyktxa;Integrated Security=True";
                con = new SqlConnection(connect);
                con.Close();
                con.Dispose();
            }
            catch (Exception)
            {               
                
            }
        }
        public static void ExitAll()
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn thực sự muốn thoát không?","Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rs==DialogResult.Yes)
            {
                Application.Exit();               
            }
        }
        public static SqlDataReader ThuchienReader(string select)
        {
            cmd = new SqlCommand(select,con);
            try
            {
                return cmd.ExecuteReader();
                
            }
            catch (SqlException)
            {

                return null;
            }
        }
        public static DataTable laydlbang(string sql)
        {
           cmd = new SqlCommand(sql,con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
       
        public static DataSet laytruong(string sql)
        {
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
       
        public static void ThucHienCmd(string select)
        {
            cmd = new SqlCommand(select,con);
            try
            {
                cmd.ExecuteNonQuery();
               
            }
            catch (SqlException)
            {

                MessageBox.Show("Lỗi cơ sở dữ liệu!");
            }
        }
        public static void Chivietso(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
            
        }
    }
}
