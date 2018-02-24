using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace GroupProject_MediaLibrary
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnSelect_Click(object sender, EventArgs e)
        {
            string bookID = txtID.Text;
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\meji2\\Documents\\School\\4 Spring 2018 Semester\\Advanced C#\\GroupProject_MediaLibrary\\GroupProject_MediaLibrary\\GroupProject_MediaLibrary\\App_Data\\LibraryCatalogue.mdf; Integrated Security = True");
            SqlCommand cmdTitle = new SqlCommand("select  RTRIM(title) from fullCatalogue where BookID=" + bookID, conn);
            SqlCommand cmdISBN10 = new SqlCommand("select  RTRIM(ISBN10) from fullCatalogue where BookID=" + bookID, conn);
            SqlCommand cmdISBN13 = new SqlCommand("select  RTRIM(ISBN13) from fullCatalogue where BookID=" + bookID, conn);
            SqlCommand cmdAuthor = new SqlCommand("select  RTRIM(author) from fullCatalogue where BookID=" + bookID, conn);
            SqlCommand cmdPublisher = new SqlCommand("select  RTRIM(publisher) from fullCatalogue where BookID=" + bookID, conn);
            SqlCommand cmdCopyright = new SqlCommand("select  RTRIM(copyright) from fullCatalogue where BookID=" + bookID, conn);
            SqlCommand cmdLength = new SqlCommand("select  RTRIM(length) from fullCatalogue where BookID=" + bookID, conn);

            conn.Open();

            string isbn13 = cmdISBN13.ExecuteScalar().ToString();

            isbn13 = (isbn13.Substring(0, 3)) + "-" + (isbn13.Substring(3));
            txtTitle.Text = cmdTitle.ExecuteScalar().ToString();
            txtAuthor.Text = cmdAuthor.ExecuteScalar().ToString();
            txtCopyright.Text = cmdCopyright.ExecuteScalar().ToString();
            txtISBN10.Text = cmdISBN10.ExecuteScalar().ToString();
            txtISBN13.Text = isbn13;
            txtLength.Text = cmdLength.ExecuteScalar().ToString();
            txtPublisher.Text = cmdPublisher.ExecuteScalar().ToString();
            
            conn.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string bookID = txtID.Text;
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\meji2\\Documents\\School\\4 Spring 2018 Semester\\Advanced C#\\GroupProject_MediaLibrary\\GroupProject_MediaLibrary\\GroupProject_MediaLibrary\\App_Data\\LibraryCatalogue.mdf; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("UPDATE fullCatalogue SET ISBN10 = @isbn10, ISBN13 = @isbn13,"
                                          + "title = @title, author = @author, publisher = @pub, copyright = @copy, length = @length " +
                                            "WHERE BookID=" + bookID, conn);

            string isbn13 = txtISBN13.Text;
            if (isbn13.Length > 13)
                isbn13 = (isbn13.Substring(0, 3)) + (isbn13.Substring(4));
            cmd.Parameters.AddWithValue("@title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@pub", txtPublisher.Text);
            cmd.Parameters.AddWithValue("@length", txtLength.Text);
            cmd.Parameters.AddWithValue("@isbn13", isbn13);
            cmd.Parameters.AddWithValue("@isbn10", txtISBN10.Text);
            cmd.Parameters.AddWithValue("@copy", txtCopyright.Text);
            cmd.Parameters.AddWithValue("@author", txtAuthor.Text);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        protected void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtID_TextChanged(object sender, EventArgs e)
        {
            btnSelect_Click(sender, e);
        }
    }
}