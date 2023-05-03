
namespace AuditVaccinationPatientsApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSkins = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinDropDownButtonItem = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinPaletteRibbonGalleryBarItem = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barBtnPatients = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barBtnVaccinations = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barBtnVaccine = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barBtnDoctors = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barBtnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 158);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(905, 333);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSkins});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "Вигляд";
            // 
            // rpgSkins
            // 
            this.rpgSkins.ItemLinks.Add(this.skinDropDownButtonItem);
            this.rpgSkins.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem);
            this.rpgSkins.Name = "rpgSkins";
            this.rpgSkins.Text = "Skins";
            // 
            // skinDropDownButtonItem
            // 
            this.skinDropDownButtonItem.Id = 2;
            this.skinDropDownButtonItem.Name = "skinDropDownButtonItem";
            // 
            // skinPaletteRibbonGalleryBarItem
            // 
            this.skinPaletteRibbonGalleryBarItem.Caption = "skinPaletteRibbonGalleryBarItem";
            this.skinPaletteRibbonGalleryBarItem.Id = 3;
            this.skinPaletteRibbonGalleryBarItem.Name = "skinPaletteRibbonGalleryBarItem";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Головна";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnPatients);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // barBtnPatients
            // 
            this.barBtnPatients.Caption = "Пацієнти МедЦентру";
            this.barBtnPatients.Id = 2;
            this.barBtnPatients.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnPatients.ImageOptions.Image")));
            this.barBtnPatients.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnPatients.ImageOptions.LargeImage")));
            this.barBtnPatients.Name = "barBtnPatients";
            this.barBtnPatients.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPatients_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnVaccinations);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // barBtnVaccinations
            // 
            this.barBtnVaccinations.Caption = "Історія Вакцинацій";
            this.barBtnVaccinations.Id = 3;
            this.barBtnVaccinations.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnVaccinations.ImageOptions.Image")));
            this.barBtnVaccinations.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnVaccinations.ImageOptions.LargeImage")));
            this.barBtnVaccinations.Name = "barBtnVaccinations";
            this.barBtnVaccinations.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnVaccinations_ItemClick);
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnVaccine);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // barBtnVaccine
            // 
            this.barBtnVaccine.Caption = "Каталог Вакцин";
            this.barBtnVaccine.Id = 4;
            this.barBtnVaccine.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnVaccine.ImageOptions.SvgImage")));
            this.barBtnVaccine.Name = "barBtnVaccine";
            this.barBtnVaccine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnVaccine_ItemClick);
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnDoctors);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // barBtnDoctors
            // 
            this.barBtnDoctors.Caption = "Лікарі МедЦентру";
            this.barBtnDoctors.Id = 5;
            this.barBtnDoctors.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnDoctors.ImageOptions.SvgImage")));
            this.barBtnDoctors.Name = "barBtnDoctors";
            this.barBtnDoctors.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDoctors_ItemClick);
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barBtnAbout);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // barBtnAbout
            // 
            this.barBtnAbout.Caption = "Про програму";
            this.barBtnAbout.Id = 6;
            this.barBtnAbout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnAbout.ImageOptions.SvgImage")));
            this.barBtnAbout.Name = "barBtnAbout";
            this.barBtnAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAbout_ItemClick);
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Caption = "skinRibbonGalleryBarItem";
            this.skinRibbonGalleryBarItem.Id = 1;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.skinRibbonGalleryBarItem,
            this.skinDropDownButtonItem,
            this.skinPaletteRibbonGalleryBarItem,
            this.barBtnPatients,
            this.barBtnVaccinations,
            this.barBtnVaccine,
            this.barBtnDoctors,
            this.barBtnAbout});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 7;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage});
            this.ribbonControl.Size = new System.Drawing.Size(905, 158);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("actions_refresh", "actions_refresh", typeof(AuditVaccinationPatientsApp.Properties.Resources));
            this.svgImageCollection1.Add("actions_addcircled", "actions_addcircled", typeof(AuditVaccinationPatientsApp.Properties.Resources));
            this.svgImageCollection1.Add("actions_deletecircled", "actions_deletecircled", typeof(AuditVaccinationPatientsApp.Properties.Resources));
            this.svgImageCollection1.Add("editnames", "editnames", typeof(AuditVaccinationPatientsApp.Properties.Resources));
            this.svgImageCollection1.Add("actions_question", "actions_question", typeof(AuditVaccinationPatientsApp.Properties.Resources));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 491);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.Image = global::AuditVaccinationPatientsApp.Properties.Resources.injection_syringe;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.Text = "ОБЛІК ВАКЦИНАЦІЇ ПАЦІЄНТІВ МЕДИЧНОГО ЦЕНТРУ ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSkins;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barBtnPatients;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barBtnVaccinations;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem barBtnVaccine;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barBtnDoctors;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barBtnAbout;
    }
}
