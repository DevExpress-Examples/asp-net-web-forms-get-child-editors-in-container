using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public static class HelperClass
{
    public static List<ASPxEdit> GetChildControls(object container, Func<Control, bool> predicate)
    {
        return GetChildControls(container, new List<ASPxEdit>(), predicate);
    }
    public static List<ASPxEdit> GetChildControls(object container)
    {
        return GetChildControls(container, new List<ASPxEdit>(), null);
    }
    private static List<ASPxEdit> GetChildControls(object Container, List<ASPxEdit> controlsList, Func<Control, bool> predicate)
    {
        Control c = Container as Control;
        if (c == null || c.Controls.Count == 0)
            return controlsList;
        foreach (Control item in c.Controls)
        {
            if (item is ASPxEdit && (predicate == null || predicate(item) == true))
            {
                controlsList.Add((ASPxEdit)item);
            }
            if (item.Controls.Count > 0)
                controlsList = GetChildControls(item, controlsList, predicate);
        }
        return controlsList;
    }
}