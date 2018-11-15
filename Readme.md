<!-- default file list -->
*Files to look at*:

* [CustomObject.cs](./CS/Q140616/CustomObject.cs) (VB: [CustomObject.vb](./VB/Q140616/CustomObject.vb))
* [Form1.cs](./CS/Q140616/Form1.cs) (VB: [Form1.vb](./VB/Q140616/Form1.vb))
* [Program.cs](./CS/Q140616/Program.cs) (VB: [Program.vb](./VB/Q140616/Program.vb))
<!-- default file list end -->
# How to display the password characters instead of text within the PropertyGridControl


<p>To accomplish this task, create a RepositoryItemTextEdit, and set its PasswordChar property to any value. Then, within the OnCustomRecordCellEdit event handler assign a created RepositoryItemTextEdit to this cell, if the current property of the selected object has a PasswordPropertyText attribute.</p>

<br/>


