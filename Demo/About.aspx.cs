using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Title = "From code behind";
                Trace.Write("No postevent");
            }
             else
            {
                if(string.IsNullOrEmpty(txtData.Text))
                {
                    throw new ApplicationException("Something unexcepted happened");
                }
                Title = "Postback Data: " + txtData.Text;
                Trace.Write("postevent message "+ txtData.Text );
            }
               
        }

        protected void btnSendInfo_Click(object sender, EventArgs e)
        {
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            //log the information
            var ex = Server.GetLastError();
            Server.ClearError();
            Response.Write(ex.Message);
        }
    }
}