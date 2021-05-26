using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmailClassLibrary;
using System.Windows.Forms;

namespace EmailWebApp
{
    
    public partial class _Default : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void SendEmailButton_Click(object sender, EventArgs e)
        {

            string to = ToTextBox.Text;
            string from = FromTextBox.Text;
            string subject = SubjectTextBox.Text;
            string message = MessageTextBox.Text;

            var email = new Email();
            
            email.SendEmail(from, to, subject, message);
            


            
            
        }
    }
}