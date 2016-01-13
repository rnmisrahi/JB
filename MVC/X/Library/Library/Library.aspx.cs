using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library.Models;

namespace Library
{
    public partial class Library : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                Audience = ddlAudience.SelectedValue,
                BookId = txtCode.Text,
                Category = ddlCategory.SelectedValue,
                Copies = int.Parse(txtCopies.Text),
                Editor = txtEditor.Text,
                IsActive = (rdbIsActive.SelectedIndex == 0),
                Title = txtTitle.Text
            };
            BookRepository.Books.Add(book);
        }
    }
}