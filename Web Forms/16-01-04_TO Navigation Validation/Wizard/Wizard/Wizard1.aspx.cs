using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Wizard.Models;

namespace Wizard
{
    public partial class Wizard1 : System.Web.UI.Page
    {
        StudentContext db = null;

        private string getParam(string[] split, string v)
        {
            foreach (string s in split)
            {
                if (s.StartsWith(v + "="))
                {
                    return s.Substring(v.Length + 1);
                }
            }
            return "";
        }

        private bool getParam(ref string res, string[] split, string v)
        {
            foreach (string s in split)
            {
                if (s.StartsWith(v + "="))
                {
                    res = s.Substring(v.Length + 1);
                    return !String.IsNullOrEmpty(res);
                }
            }
            return false;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            int stam;
            if (!IsPostBack)
            {
                if (db == null)
                {
                    System.Data.Entity.Database.SetInitializer(new StudentDbInitializer());
                    StudentContext db = new StudentContext();
                    db.Database.Initialize(true);
                }
                stam = 8;
            }
            string p = Request.Params["Parameter"];
            if (p != null)
            {
                string[] split = p.Split('|');
                string res = "";
                if (getParam(ref res, split, "StudentId"))
                    txtId.Text = res;

                if (getParam(ref res, split, "StudentName"))
                    txtName.Text = res;

                if (getParam(ref res, split, "LG"))
                    cbLovesGirls.Checked = res.ToLower().Equals("true");

                if (getParam(ref res, split, "Course"))
                    ddlCourse.SelectedItem.Value = res;

                if (getParam(ref res, split, "Hebrew"))
                    cbHebrew.Checked = res.ToLower().Equals("true");

                if (getParam(ref res, split, "Comments"))
                    txtComments.Text = res;
            }

            //int n = Request.Params.Count;
            //StringBuilder sb = new StringBuilder();
            //sb.Append(Request.Params["StudentId"]);
            //sb.Append(Request.Params["StudentName"]);
            //sb.Append(Request.Params["LG"]);
            //sb.Append(Request.Params["Course"]);
            //sb.Append(Request.Params["Hebrew"]);
            //sb.Append(Request.Params["Comments"]);
            if ((Page.PreviousPage != null) && (PreviousPage.IsValid))
            {
                //txtId.Text = PreviousPage.StudentId;
                //txtName.Text = PreviousPage.StudentName;
                //cbLovesGirls.Checked = PreviousPage.LovesGirls;
                //cbHebrew.Checked = PreviousPage.Hebrew;
                //txtComments.Text = PreviousPage.Comments;
            }
        }

        private string getParams()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("StudentId=" + txtId.Text);
            sb.Append("|StudentName=" + txtName.Text);
            sb.Append("|LG=" + cbLovesGirls.Checked);
            sb.Append("|Course=" + ddlCourse.Text);
            sb.Append("|Hebrew=" + cbHebrew.Checked);
            return sb.ToString();
        }


        protected void btnNext_Click(object sender, EventArgs e)
        {
            string s = getParams();
            Server.Transfer("Wizard2.aspx?Parameter=" + s);
            //Response.Redirect("Wizard2.aspx?Parameter=" + s);
        }

        public string StudentId { get { return txtId.Text; } }
        public string StudentName { get { return txtName.Text; } }
        public bool LovesGirls { get { return cbLovesGirls.Checked; } }
        public string Course { get { return ddlCourse.SelectedItem.Text; } }
        public bool Hebrew { get { return cbHebrew.Checked; } }
        public string Comments { get { return txtComments.Text; } }

    }
}