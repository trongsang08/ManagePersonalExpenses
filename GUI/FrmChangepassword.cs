using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmChangepassword : Form
    {
        public FrmChangepassword()
        {
            InitializeComponent();
        }
        SqlConnection conn;

        MD5 md5 = MD5.Create();
        public static string CreateMD5(string password)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return Convert.ToHexString(hashBytes); // .NET 5 +
                // Convert the byte array to hexadecimal string prior to .NET 5
                // StringBuilder sb = new System.Text.StringBuilder();
                // for (int i = 0; i < hashBytes.Length; i++)
                // {
                //     sb.Append(hashBytes[i].ToString("X2"));
                // }
                // return sb.ToString();
            }
        }
        public bool thongbao()
        {
            //if(txtUsername.Text.Equals("") || txtOldPass.Text.Equals("") || txtNewpass.Text.Equals("") || txtConfirmNewpass.Text.Equals(""))
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            //    return false;
            //}else
            if (txtUsername.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập Username!!");
                //txtUsername.Focus();
                return false;
            }
            else if (txtOldPass.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ");
                //txtOldPass.Focus();
                return false;
            }
            else if (txtNewpass.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!!");
                //txtNewpass.Focus();
                return false;
            }
            else if (txtConfirmNewpass.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng xác nhập mật khẩu mới!!");
                //txtNewpass.Focus();
                return false;
            }
            else if(txtNewpass.Text != txtConfirmNewpass.Text)
            {
                MessageBox.Show("Mật khẩu mới không chính xác !!");
                //txtConfirmNewpass.Focus();
                //txtConfirmNewpass.SelectAll();
                return false;
            }
            return true;
        }

        private void btnChangepass_Click(object sender, EventArgs e)
        {
            if (thongbao())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    string strCnn = "server=DESKTOP-671LN6B;database=ManagePersonalExpenses;uid=sa;pwd=123456";
                    conn = new SqlConnection(strCnn);
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_Update";
                    cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = txtUsername.Text;
                    cmd.Parameters.Add("@OldPass", SqlDbType.NVarChar).Value = CreateMD5(txtOldPass.Text);
                    cmd.Parameters.Add("@NewPass", SqlDbType.NVarChar).Value = CreateMD5(txtNewpass.Text);
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.GetInt32(0) == 1)
                    {
                        //lbOldpassword.ForeColor = System.Drawing.Color.Blue;
                        //lbOldpassword.Text = dr.GetString(1);
                        txtConfirmNewpass.Text = "";
                        txtOldPass.Text = "";
                        txtNewpass.Text = "";
                        txtOldPass.Focus();
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");

                    }
                    else
                    {
                        //lbOldpassword.ForeColor = System.Drawing.Color.Red;
                        //lbOldpassword.Text = dr.GetString(1);
                        //txtOldPass.Focus();
                        //txtOldPass.SelectAll();
                        MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng!", "Thông báo");
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                
            
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dg == DialogResult.Yes)
            //{
            //    this.Close();
            //}
            this.Close();
        }

        private void checkShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowpass.Checked)
            {
                txtOldPass.PasswordChar = (char)0;
                txtNewpass.PasswordChar = (char)0;
                txtConfirmNewpass.PasswordChar = (char)0;
            }
            else
            {
                txtOldPass.PasswordChar = '*';
                txtNewpass.PasswordChar = '*';
                txtConfirmNewpass.PasswordChar = '*';
            }
        }
    }
}
