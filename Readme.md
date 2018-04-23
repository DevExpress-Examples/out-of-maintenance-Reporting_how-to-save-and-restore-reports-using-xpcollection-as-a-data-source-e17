# How to save and restore reports using XPcollection as a data source


<p>This example illustrates how to save and restore reports when the XPCollection is used as a data source. To accomplish this task you should to create a XtraReport class descendant with two additional properties representing XPO session that is used to load and save data and class name for the specified persistent object. Additionally you should handle the Activate event of the design panel that is used to editing report to instantiate the XPO session for report.</p><p>See also:<br />
- <a href="https://www.devexpress.com/Support/Center/p/A2944">XPO Best Practices</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1845">How to bind a report to eXpress Persistent Objects (XPO)</a>.</p>

<br/>


