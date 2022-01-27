using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TutorialApplicationEntity;

namespace TutorialApplicationData
{
    public class TutorialDataConnection
    {
        string sqlConnectionStr = "Data Source=LAPTOP-DL0P9UEA;Initial Catalog=TutorialDb;Integrated Security=True";
        public string InsertTutorial(TutorialModel tutorialModelObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            #region connectecd approach
            //SqlCommand sqlCommandObj = new SqlCommand("insert into Tutorial values("+tutorialModelObj.ID+",'"+tutorialModelObj.Name+"','"+tutorialModelObj.Course+"',"+tutorialModelObj.Fee+")", sqlConnectionObj);
            //sqlConnectionObj.Open();
            //sqlCommandObj.ExecuteNonQuery();
            //sqlConnectionObj.Close();
            #endregion

            #region disconnected approach
            SqlDataAdapter adp = new SqlDataAdapter("insert into Tutorial values(" + tutorialModelObj.ID + ",'" + tutorialModelObj.Name + "','" + tutorialModelObj.Course + "'," + tutorialModelObj.Fee + ")", sqlConnectionObj);
            adp.Fill(dt);
            #endregion
            return "Tutorial details saved successfully";
        }
        public string UpdateTutorial(TutorialModel tutorialModelObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            //SqlCommand sqlCommandObj = new SqlCommand("update Tutorial set tutorialname='" + tutorialModelObj.Name + "' , tutorialcourse='" + tutorialModelObj.Course + "' , Fee=" + tutorialModelObj.Fee+ " where tutorialid=" + tutorialModelObj.ID + "", sqlConnectionObj);
            //sqlConnectionObj.Open();
            //sqlCommandObj.ExecuteNonQuery();
            //sqlConnectionObj.Close();
            #region disconnected approach
            SqlDataAdapter adp = new SqlDataAdapter("update Tutorial set tutorialname='" + tutorialModelObj.Name + "' , tutorialdesc='" + tutorialModelObj.Course + "' , published=" + tutorialModelObj.Fee + " where tutorialid=" + tutorialModelObj.ID + "", sqlConnectionObj);
            adp.Fill(dt);
            #endregion
            return "Tutorial id " + tutorialModelObj.ID + " details updated successfully";
        }
        public string DeleteTutorialById(int ID)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("delete from Tutorial where tutorialid=" + ID + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Tutorial id " + ID + " details deleted successfully";
        }
        public DataTable SelectTutorial()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            #region connected approach
            //SqlCommand sqlCommandObj = new SqlCommand("select * from Tutorial", sqlConnectionObj);
            //sqlConnectionObj.Open();
            //SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(sqlDataReader);
            //sqlConnectionObj.Close();
            #endregion
            #region disconnected approach
            SqlDataAdapter adp = new SqlDataAdapter("select * from Tutorial", sqlConnectionObj);
            adp.Fill(dt);
            #endregion
            return dt;
        }
        public DataTable EditTutorialById(int tutorialId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from Tutorial where tutorialid=" + tutorialId + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
    }
}
