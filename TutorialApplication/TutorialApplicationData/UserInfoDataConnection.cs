using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TutorialApplicationData;
using TutorialApplicationEntity;

namespace TutorialApplicationData
{
    public class UserInfoDataConnection
    {
        #region Disconnected approach
        string sqlConnectionStr = "Data Source=LAPTOP-DL0P9UEA;Initial Catalog=TutorialDb;Integrated Security=True";
        public string InsertUser(UserInfoModel userinfomodel)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into UserInfo values('" + userinfomodel.FirstName + "','" + userinfomodel.LastName + "','" + userinfomodel.Email + "','" + userinfomodel.Mobile + "','" + userinfomodel.Pwd + "')", sqlConnectionObj);
            adp.Fill(dt);
            return "Registered Successfully";
        }

        public DataTable GetUserInfo()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select*from UserInfo", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
        #endregion Disconnected approach
        public DataTable LoginCheck(string email, string password)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select firstname,lastname,email,mobile from userinfo where email='" + email + "' and pwd='" + password + "'", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
    }
}
