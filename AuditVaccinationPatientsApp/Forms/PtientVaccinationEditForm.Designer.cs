
namespace AuditVaccinationPatientsApp.Forms
{
    partial class PtientVaccinationEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PtientVaccinationEditForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.sbSaveUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.DoctorsLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.VaccinesLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.DateOfVaccinationDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.PatientNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VaccinesLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfVaccinationDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfVaccinationDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.sbSaveUpdate);
            this.layoutControl1.Controls.Add(this.DoctorsLookUpEdit);
            this.layoutControl1.Controls.Add(this.VaccinesLookUpEdit);
            this.layoutControl1.Controls.Add(this.DateOfVaccinationDateEdit);
            this.layoutControl1.Controls.Add(this.PatientNameTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(705, 197, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(522, 268);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = global::AuditVaccinationPatientsApp.Properties.Resources.close;
            this.simpleButton2.Location = new System.Drawing.Point(355, 208);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(143, 36);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // sbSaveUpdate
            // 
            this.sbSaveUpdate.ImageOptions.SvgImage = global::AuditVaccinationPatientsApp.Properties.Resources.save;
            this.sbSaveUpdate.Location = new System.Drawing.Point(208, 208);
            this.sbSaveUpdate.Name = "sbSaveUpdate";
            this.sbSaveUpdate.Size = new System.Drawing.Size(143, 36);
            this.sbSaveUpdate.StyleController = this.layoutControl1;
            this.sbSaveUpdate.TabIndex = 8;
            this.sbSaveUpdate.Text = "Save/Update";
            this.sbSaveUpdate.Click += new System.EventHandler(this.sbSaveUpdate_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(522, 268);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem5,
            this.emptySpaceItem3,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(502, 248);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(184, 107);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(184, 96);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(147, 67);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbSaveUpdate;
            this.layoutControlItem5.Location = new System.Drawing.Point(184, 163);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(147, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(331, 96);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(147, 67);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton2;
            this.layoutControlItem6.Location = new System.Drawing.Point(331, 163);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(147, 40);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // DoctorsLookUpEdit
            // 
            this.DoctorsLookUpEdit.Location = new System.Drawing.Point(131, 117);
            this.DoctorsLookUpEdit.Name = "DoctorsLookUpEdit";
            this.DoctorsLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DoctorsLookUpEdit.Properties.NullText = "Виберіть лікаря";
            this.DoctorsLookUpEdit.Size = new System.Drawing.Size(367, 20);
            this.DoctorsLookUpEdit.StyleController = this.layoutControl1;
            this.DoctorsLookUpEdit.TabIndex = 7;
            this.DoctorsLookUpEdit.EditValueChanged += new System.EventHandler(this.DoctorsLookUpEdit_EditValueChanged);
            // 
            // VaccinesLookUpEdit
            // 
            this.VaccinesLookUpEdit.Location = new System.Drawing.Point(131, 93);
            this.VaccinesLookUpEdit.Name = "VaccinesLookUpEdit";
            this.VaccinesLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VaccinesLookUpEdit.Properties.NullText = "Вибкріть вакцину";
            this.VaccinesLookUpEdit.Size = new System.Drawing.Size(367, 20);
            this.VaccinesLookUpEdit.StyleController = this.layoutControl1;
            this.VaccinesLookUpEdit.TabIndex = 6;
            this.VaccinesLookUpEdit.EditValueChanged += new System.EventHandler(this.VaccineLookUpEdit_EditValueChanged);
            // 
            // DateOfVaccinationDateEdit
            // 
            this.DateOfVaccinationDateEdit.EditValue = null;
            this.DateOfVaccinationDateEdit.Location = new System.Drawing.Point(131, 69);
            this.DateOfVaccinationDateEdit.Name = "DateOfVaccinationDateEdit";
            this.DateOfVaccinationDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateOfVaccinationDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateOfVaccinationDateEdit.Size = new System.Drawing.Size(367, 20);
            this.DateOfVaccinationDateEdit.StyleController = this.layoutControl1;
            this.DateOfVaccinationDateEdit.TabIndex = 5;
            this.DateOfVaccinationDateEdit.EditValueChanged += new System.EventHandler(this.DateOfVaccinationDateEdit_EditValueChanged);
            // 
            // PatientNameTextEdit
            // 
            this.PatientNameTextEdit.Location = new System.Drawing.Point(131, 45);
            this.PatientNameTextEdit.Name = "PatientNameTextEdit";
            this.PatientNameTextEdit.Size = new System.Drawing.Size(367, 20);
            this.PatientNameTextEdit.StyleController = this.layoutControl1;
            this.PatientNameTextEdit.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.PatientNameTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(478, 24);
            this.layoutControlItem1.Text = "Patient Name";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.DoctorsLookUpEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(478, 24);
            this.layoutControlItem4.Text = "Doctor Name";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.VaccinesLookUpEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(478, 24);
            this.layoutControlItem3.Text = "Vaccine";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.DateOfVaccinationDateEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(478, 24);
            this.layoutControlItem2.Text = "Date Of Vaccination";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 13);
            // 
            // PtientVaccinationEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 268);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("PtientVaccinationEditForm.IconOptions.Image")));
            this.Name = "PtientVaccinationEditForm";
            this.Text = "PtientVaccinationEditForm";
            this.Load += new System.EventHandler(this.PtientVaccinationEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VaccinesLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfVaccinationDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfVaccinationDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.DateEdit DateOfVaccinationDateEdit;
        private DevExpress.XtraEditors.TextEdit PatientNameTextEdit;
        private DevExpress.XtraEditors.LookUpEdit VaccinesLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit DoctorsLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SimpleButton sbSaveUpdate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}