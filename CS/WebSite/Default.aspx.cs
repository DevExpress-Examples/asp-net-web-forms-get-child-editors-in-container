using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        List<ASPxEdit> l = new List<ASPxEdit>();
        ASPxGridView1.DataBind();
        //l = HelperClass.GetChildControls(ASPxGridView1,k=>k.NamingContainer is GridViewDataItemTemplateContainer);             
    }

    protected void ASPxButton_Click(object sender, EventArgs e) {
        ASPxButton b = sender as ASPxButton;
        string s = b.ID[b.ID.Length - 1].ToString();
         List<ASPxEdit> l = new List<ASPxEdit>();         
        switch (s) {
            case "1":
               l = HelperClass.GetChildControls(ASPxPageControl1);
                break;
            case "2":
                l = HelperClass.GetChildControls(ASPxGridView1, k => k.NamingContainer is GridViewDataItemTemplateContainer);
                break;
            case "3":
                l = HelperClass.GetChildControls(ASPxPanel1);
                break;
        }
        ((ASPxLabel)this.FindControl("ASPxLabel" + s)).Text = l.Count.ToString();
    }
}
