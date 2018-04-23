namespace Q140616 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.passwordEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridControl1.Location = new System.Drawing.Point(0, 0);
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.passwordEdit});
            this.propertyGridControl1.ServiceProvider = null;
            this.propertyGridControl1.Size = new System.Drawing.Size(547, 296);
            this.propertyGridControl1.TabIndex = 0;
            this.propertyGridControl1.CustomRecordCellEdit += new DevExpress.XtraVerticalGrid.Events.GetCustomRowCellEditEventHandler(this.OnCustomRecordCellEdit);
            // 
            // passwordEdit
            // 
            this.passwordEdit.AutoHeight = false;
            this.passwordEdit.Name = "passwordEdit";
            this.passwordEdit.PasswordChar = '*';
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 296);
            this.Controls.Add(this.propertyGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit passwordEdit;
    }
}

