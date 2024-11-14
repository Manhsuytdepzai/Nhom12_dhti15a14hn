﻿using Nhom12_dhti5a14hn.Connect;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Nhom12_dhti5a14hn
{
    internal class Login
    {
        public class User
        {
            private connect ketnoi;

            public User()
            {
                ketnoi = new connect();
            }

            public bool Login(string username, string password)
            {
                string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@TenDangNhap", username),
                    new SqlParameter("MatKhau", password)
                };
                DataTable dt = new DataTable();
                dt = ketnoi.readData(sql, parameters);
                if (dt != null)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    return true;
                }
                MessageBox.Show(" Sai mật khẩu hoặc tên đăng nhập");

                return false;
            }
        }
    }
}