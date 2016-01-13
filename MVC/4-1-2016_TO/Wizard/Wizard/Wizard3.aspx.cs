using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wizard
{
    public partial class Wizard3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Page.PreviousPage != null) && (PreviousPage.IsValid))
            {
                txtId.Text = PreviousPage.StudentId;
                txtName.Text = PreviousPage.StudentName;
                cbLovesGirls.Checked = PreviousPage.LovesGirls;
                cbHebrew.Checked = PreviousPage.Hebrew;
                txtComments.Text = PreviousPage.Comments;
            }
        }

        public string StudentId { get { return txtId.Text; } }
        public string StudentName { get { return txtName.Text; } }
        public bool LovesGirls { get { return cbLovesGirls.Checked; } }
        public string Course { get { return ddlCourse.SelectedItem.Text; } }
        public bool Hebrew { get { return cbHebrew.Checked; } }
        public string Comments { get { return txtComments.Text; } }

    }
}