using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid.Events;
using DevExpress.XtraVerticalGrid;
using System.Reflection;
using DXSample;

namespace Q140616 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            propertyGridControl1.SelectedObject = new CustomObject("My Custom Object", "myGOODpassword");
        }

        private void OnCustomRecordCellEdit(object sender, GetCustomRowCellEditEventArgs e) {
            PropertyGridControl control = (PropertyGridControl)sender;
            MemberInfo[] mi = control.SelectedObject.GetType().GetMember(e.Row.Properties.FieldName);
            PasswordPropertyTextAttribute attr = (PasswordPropertyTextAttribute)Attribute.GetCustomAttribute(mi[0], typeof(PasswordPropertyTextAttribute));
            if (attr != null && attr.Password) e.RepositoryItem = passwordEdit;
        }
    }
}