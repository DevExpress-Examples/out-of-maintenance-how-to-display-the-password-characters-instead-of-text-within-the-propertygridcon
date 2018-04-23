# How to display the password characters instead of text within the PropertyGridControl


<p>To accomplish this task, create a RepositoryItemTextEdit, and set its PasswordChar property to any value. Then, within the OnCustomRecordCellEdit event handler assign a created RepositoryItemTextEdit to this cell, if the current property of the selected object has a PasswordPropertyText attribute.</p>

<br/>


