<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128531633/12.2.10%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4780)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# ASP.NET Web Forms - How to get all DevExpress data editors in a container

This example demonstrates how to implement a method that returns a list of child [data editors](https://docs.devexpress.com/AspNet/7898/components/data-editors/product-information#included-components) placed in a parent container.

```aspx
private static List<ASPxEdit> GetChildControls(object Container, List<ASPxEdit> controlsList, Func<Control, bool> predicate) {
    Control c = Container as Control;
    if (c == null || c.Controls.Count == 0)
        return controlsList;
    foreach (Control item in c.Controls) {
        if (item is ASPxEdit && (predicate == null || predicate(item) == true)) {
            controlsList.Add((ASPxEdit)item);
        }
        if (item.Controls.Count > 0)
            controlsList = GetChildControls(item, controlsList, predicate);
    }
    return controlsList;
}
```

## Files to Review

* [HelperClass.cs](./CS/WebSite/App_Code/HelperClass.cs) (VB: [HelperClass.vb](./VB/WebSite/App_Code/HelperClass.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-get-child-editors-in-container&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-get-child-editors-in-container&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
