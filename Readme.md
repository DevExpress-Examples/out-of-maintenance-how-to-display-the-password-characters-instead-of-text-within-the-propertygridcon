<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128638603/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1095)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomObject.cs](./CS/Q140616/CustomObject.cs) (VB: [CustomObject.vb](./VB/Q140616/CustomObject.vb))
* [Form1.cs](./CS/Q140616/Form1.cs) (VB: [Form1.vb](./VB/Q140616/Form1.vb))
* [Program.cs](./CS/Q140616/Program.cs) (VB: [Program.vb](./VB/Q140616/Program.vb))
<!-- default file list end -->
# How to display the password characters instead of text within the PropertyGridControl


<p>To accomplish this task, create a RepositoryItemTextEdit, and set its PasswordChar property to any value. Then, within the OnCustomRecordCellEdit event handler assign a created RepositoryItemTextEdit to this cell, if the current property of the selected object has a PasswordPropertyText attribute.</p>

<br/>


