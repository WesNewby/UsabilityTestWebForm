using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BasicWebForm.Models;

namespace BasicWebForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }
        public void magic(object sender, EventArgs e)
        {
            OnModel.on = !(OnModel.on);
            if (!OnModel.on) { button1.Text = "nottub yretsym"; }
            else { button1.Text = "mystery button"; }
                
        }

        
    }

}