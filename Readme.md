<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1747)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Customer.cs](./CS/XPOReport/Customer.cs) (VB: [Customer.vb](./VB/XPOReport/Customer.vb))
* [Form1.cs](./CS/XPOReport/Form1.cs) (VB: [Form1.vb](./VB/XPOReport/Form1.vb))
* [Program.cs](./CS/XPOReport/Program.cs) (VB: [Program.vb](./VB/XPOReport/Program.vb))
* [XpoBaseReport.cs](./CS/XPOReport/XpoBaseReport.cs) (VB: [XpoBaseReport.vb](./VB/XPOReport/XpoBaseReport.vb))
<!-- default file list end -->
# How to save and restore reports using XPcollection as a data source


<p>This example illustrates how to save and restore reports when the XPCollection is used as a data source. To accomplish this task you should to create a XtraReport class descendant with two additional properties representing XPO session that is used to load and save data and class name for the specified persistent object. Additionally you should handle the Activate event of the design panel that is used to editing report to instantiate the XPO session for report.</p><p>See also:<br />
- <a href="https://www.devexpress.com/Support/Center/p/A2944">XPO Best Practices</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1845">How to bind a report to eXpress Persistent Objects (XPO)</a>.</p>

<br/>


