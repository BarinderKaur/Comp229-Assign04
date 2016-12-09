using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign04
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model md01 = new Comp229_Assign04.Model();
            md01.name = " Barinder ";
            Literal1.Text = md01.name;

            Model md02 = new Model();
        }

        private void PrepareModelCollection()
        {
        using (StreamReader streamReader = new StreamReader( System.Web.Hosting.HostingEnvironment.MapPath(Models))
    }
}