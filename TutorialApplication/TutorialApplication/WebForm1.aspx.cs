using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutorialApplication.DataConnection;
using System.Data;

namespace TutorialApplication
{
    public partial class WebForm1 : System.Web.UI.Page

    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadTutorialData();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            TutorialModel tutorialModel = new TutorialModel();

            tutorialModel.ID = Convert.ToInt32(txtID.Text);
            tutorialModel.Name = txtName.Text;
            tutorialModel.Course = txtCourse.Text;
            tutorialModel.Fee = Convert.ToInt32(txtFee.Text);

            string msg = tutorialDBConnectionObj.InsertTutorial(tutorialModel);
            lblResult.Text = msg;

            LoadTutorialData();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            DataTable dtResult = tutorialDBConnectionObj.EditTutorialById(Convert.ToInt32(txtID.Text));
            txtName.Text = dtResult.Rows[0][1].ToString();
            txtCourse.Text = dtResult.Rows[0][2].ToString();
            txtFee.Text = dtResult.Rows[0][3].ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            TutorialModel tutorialModel = new TutorialModel();

            tutorialModel.ID = Convert.ToInt32(txtID.Text);
            tutorialModel.Name = txtName.Text;
            tutorialModel.Course = txtCourse.Text;
            tutorialModel.Fee = Convert.ToInt32(txtFee.Text);

            string msg = tutorialDBConnectionObj.UpdateTutorial(tutorialModel);
            lblResult.Text = msg;

            LoadTutorialData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            string msg = tutorialDBConnectionObj.DeleteTutorialById(Convert.ToInt32(txtID.Text));
            lblResult.Text = msg;

            LoadTutorialData();
        }

        public void LoadTutorialData()
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            DataTable dtResult = tutorialDBConnectionObj.SelectTutorial();
            gvTutorialDetails.DataSource = dtResult;
            gvTutorialDetails.DataBind();
        }
    }
}
    

