using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutorialApplicationBusiness;
using TutorialApplicationEntity;
using System.Data;

namespace TutorialApplication
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            UserInfoBusiness userInfoBusiness = new UserInfoBusiness();
            UserInfoModel userInfoModelObj = new UserInfoModel();
            userInfoModelObj.FirstName = txtfname.Text;
            userInfoModelObj.LastName = txtlname.Text;
            userInfoModelObj.Email = txtemail.Text;
            userInfoModelObj.Mobile =txtmobile.Text;
            userInfoModelObj.Pwd= txtpwd.Text;
          
            string msg = userInfoBusiness.InsertUser(userInfoModelObj);
            DataTable dt = userInfoBusiness.GetUserInfo();
            gvUserInfo.DataSource = dt;
            gvUserInfo.DataBind();
        }

        
    }
}