using AuditVaccinationPatientsApp.Data.DataSet1TableAdapters;
using AuditVaccinationPatientsApp.Utils;
using DevExpress.Utils.Menu;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AuditVaccinationPatientsApp
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();

            InitializeClientSettings();

            InitializeGridSettings();
        }

        private void InitializeClientSettings()
        {
            this.Text = "ОБЛІК ВАКЦИНАЦІЇ ПАЦІЄНТІВ МЕДИЧНОГО ЦЕНТРУ ";
            barBtnPatients.Caption = "Пацієнти Мед Центру";
            barBtnVaccinations.Caption = "Історія Вакцинацій";
            barBtnVaccine.Caption = "Каталог Вакцин";
            barBtnDoctors.Caption = "Лікарі Мед Центру";
            barBtnAbout.Caption = "Про Програму";
            this.Size = new Size(1600, 900);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += MainForm_FormClosing;
        }

        private void InitializeGridSettings()
        {
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            gridView.Appearance.HeaderPanel.Font = new Font(gridView.Appearance.HeaderPanel.Font, FontStyle.Bold);
            gridView.OptionsView.ShowFooter = true;
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            gridView.NewItemRowText = "Клацніть тут щоб добавити новий запис...";

            gridView.OptionsBehavior.Editable = true;
            gridView.OptionsBehavior.EditingMode = GridEditingMode.EditForm;

            gridView.CustomDrawFooter += gridView_CustomDrawFooter;
            gridView.FocusedRowChanged += gridView_FocusedRowChanged;
            gridView.ShowingPopupEditForm += gridView_ShowingPopupEditForm;
            gridView.RowUpdated += gridView_RowUpdated;
            gridView.PopupMenuShowing += gridView_PopupMenuShowing;
        }

        // Local variables

        private int _patientID = 0;
        private int _patientFocusedRowHandle = 0;
        private int _patientVacinationFocusedRowHandle = 0;
        private int _vaccineFocusedRowHandle = 0;
        private int _doctorFocusedRowHandle = 0;
        private ViewData CurrentView = ViewData.Patients;


        private PatientsTableAdapter patient = new PatientsTableAdapter();
        private PatientVactinationsTableAdapter patientVacctinations = new PatientVactinationsTableAdapter();
        private VaccinesTableAdapter vaccines = new VaccinesTableAdapter();
        private DoctorsTableAdapter doctors = new DoctorsTableAdapter();


        // Private methods

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPatients();

            if (gridView.RowCount >= 1)
            {
                gridView.SelectRow(1);
                gridView_FocusedRowChanged(sender, null);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show(this, "Ви хочете вийти з програми?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void gridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.MenuType == GridMenuType.Row)
            {
                int rowHandle = e.HitInfo.RowHandle;
                e.Menu.Items.Clear();
                var palette = SvgPaletteHelper.GetSvgPalette(this.LookAndFeel, DevExpress.Utils.Drawing.ObjectState.Normal);
                var iconSize = new Size(24, 24);

                DXMenuCheckItem addItem = new DXMenuCheckItem(Data.Helper.GetMenuCaption(CurrentView, RowState.Add), view.OptionsView.AllowCellMerge, null, new EventHandler(OnAddRowClick));
                addItem.Tag = new RowInfo(view, rowHandle, CurrentView, RowState.Add);
                addItem.ImageOptions.Image = svgImageCollection1.GetImage("actions_addcircled", palette, iconSize);
                e.Menu.Items.Add(addItem);

                DXMenuCheckItem editItem = new DXMenuCheckItem(Data.Helper.GetMenuCaption(CurrentView, RowState.Update), view.OptionsView.AllowCellMerge, null, new EventHandler(OnEditRowClick));
                editItem.Tag = new RowInfo(view, rowHandle, CurrentView, RowState.Update);
                editItem.ImageOptions.Image = svgImageCollection1.GetImage("editnames", palette, iconSize);
                e.Menu.Items.Add(editItem);

                DXMenuCheckItem delItem = new DXMenuCheckItem(Data.Helper.GetMenuCaption(CurrentView, RowState.Delete), view.OptionsView.AllowCellMerge, null, new EventHandler(OnDeleteRowClick));
                delItem.Tag = new RowInfo(view, rowHandle, CurrentView, RowState.Delete);
                delItem.ImageOptions.Image = svgImageCollection1.GetImage("actions_deletecircled", palette, iconSize);
                e.Menu.Items.Add(delItem);
            }
        }

        void OnAddRowClick(object sender, EventArgs e)
        {
            gridView.FocusedRowHandle = GridControl.NewItemRowHandle;
            gridView.SelectRow(GridControl.NewItemRowHandle);
            gridView.ShowPopupEditForm();
        }

        void OnEditRowClick(object sender, EventArgs e)
        {
            gridView.ShowPopupEditForm();
        }

        void OnDeleteRowClick(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            RowInfo ri = menuItem.Tag as RowInfo;
            if (ri != null)
            {
                string message = menuItem.Caption.Replace("&", "");
                if (XtraMessageBox.Show(message + " ?", Data.Helper.GetConfirmCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                patient.DeletePatient(_patientID);
                ri.View.DeleteRow(ri.RowHandle);
            }
        }

        private void gridView_ShowingPopupEditForm(object sender, ShowingPopupEditFormEventArgs e)
        {
            Data.Helper.ShowingPopupEditForm(sender, e, CurrentView);

            e.EditForm.Width = this.Width - 100;
        }

        private void gridView_RowUpdated(object sender, RowObjectEventArgs e)
        {
            switch (CurrentView)
            {
                case ViewData.Patients:
                    {
                        var row = (Data.DataSet1.PatientsRow)((System.Data.DataRowView)e.Row).Row;

                        string LastName = row.LastName;
                        string FirstName = row.FirstName;
                        string MiddleName = row.MiddleName;
                        string Gender = row.Gender;
                        string DateOfBirth = row.DateOfBirth.ToString();
                        string SSN = row.SSN;
                        string PhoneNumber = row.PhoneNumber;
                        string Address = row.Address;
                        int PatientID = row.PatientID;

                        if (PatientID < 0)
                        {
                            patient.InsertPatient(LastName, FirstName, MiddleName, Gender, DateOfBirth, SSN, PhoneNumber, Address);

                            PatientID = patient.GetPatientID(LastName, FirstName, MiddleName, Gender, DateOfBirth, SSN, PhoneNumber, Address) ?? PatientID;

                            _patientID = PatientID;

                            LoadPatients();

                            int rowHandle = gridView.LocateByValue("PatientID", PatientID);

                            if (rowHandle != GridControl.InvalidRowHandle)
                            {
                                gridView.FocusedRowHandle = rowHandle;
                                gridView.SelectRow(rowHandle);
                                gridView.Focus();
                            }
                        }
                        else
                        {
                            patient.UpdatePatient(LastName, FirstName, MiddleName, Gender, DateOfBirth, SSN, PhoneNumber, Address, PatientID);
                        }
                    }
                    break;
                case ViewData.Vacctinations:
                    {
                        var row = (Data.DataSet1.PatientsRow)((System.Data.DataRowView)e.Row).Row;

                        string LastName = row.LastName;
                        string FirstName = row.FirstName;
                        string MiddleName = row.MiddleName;
                        string Gender = row.Gender;
                        string DateOfBirth = row.DateOfBirth.ToString();
                        string SSN = row.SSN;
                        string PhoneNumber = row.PhoneNumber;
                        string Address = row.Address;
                        int PatientID = row.PatientID;

                        if (PatientID < 0)
                        {
                            patient.InsertPatient(LastName, FirstName, MiddleName, Gender, DateOfBirth, SSN, PhoneNumber, Address);

                            PatientID = patient.GetPatientID(LastName, FirstName, MiddleName, Gender, DateOfBirth, SSN, PhoneNumber, Address) ?? PatientID;

                            _patientID = PatientID;

                            LoadPatients();

                            int rowHandle = gridView.LocateByValue("PatientID", PatientID);

                            if (rowHandle != GridControl.InvalidRowHandle)
                            {
                                gridView.FocusedRowHandle = rowHandle;
                                gridView.SelectRow(rowHandle);
                                gridView.Focus();
                            }
                        }
                        else
                        {
                            patient.UpdatePatient(LastName, FirstName, MiddleName, Gender, DateOfBirth, SSN, PhoneNumber, Address, PatientID);
                        }
                    }
                    break;
                case ViewData.Vaccines:
                    {
                        // not implemented yet
                    }
                    break;
                case ViewData.Doctors:
                    {
                        // not implemented yet
                    }
                    break;
                case ViewData.None:
                default:
                    {
                        // should not be here
                    }
                    break;
            }
        }

        private void gridView_CustomDrawFooter(object sender, RowObjectCustomDrawEventArgs e)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Center;
            var rect = e.Bounds;
            rect.X += 10;
            e.DefaultDraw();
            e.Cache.DrawString($"Total: {gridView.RowCount}", e.Appearance.GetFont(), e.Appearance.GetForeBrush(e.Cache), rect, stringFormat);
            e.Handled = true;
        }

        private void gridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (CurrentView == ViewData.Patients)
            {
                if (gridView.FocusedRowHandle < 0) return;

                _patientFocusedRowHandle = gridView.FocusedRowHandle;

                var PatientID = gridView.GetFocusedDataRow()["PatientID"].ToString();

                int.TryParse(PatientID, out _patientID);
            }

            if (CurrentView == ViewData.Vacctinations)
            {
                if (gridView.FocusedRowHandle < 0) return;

                _patientVacinationFocusedRowHandle = gridView.FocusedRowHandle;
            }

            if (CurrentView == ViewData.Vaccines)
            {
                if (gridView.FocusedRowHandle < 0) return;

                _vaccineFocusedRowHandle = gridView.FocusedRowHandle;
            }

            if (CurrentView == ViewData.Doctors)
            {
                if (gridView.FocusedRowHandle < 0) return;

                _doctorFocusedRowHandle = gridView.FocusedRowHandle;
            }
        }

        private void LoadData(object data, ViewData currentView, int focusedRowHandle)
        {
            CurrentView = ViewData.None;
            gridControl.DataSource = null;
            gridView.Columns.Clear();
            gridControl.Refresh();
            gridControl.DataSource = data;
            gridView.BestFitColumns();
            gridView.FocusedRowHandle = focusedRowHandle;
            gridView.SelectRow(gridView.FocusedRowHandle);
            gridView.Focus();
            CurrentView = currentView;
        }

        private void LoadPatients()
        {
            LoadData(patient.GetData(), ViewData.Patients, _patientFocusedRowHandle);
        }

        private void LoadVactinations(int patienId)
        {
            LoadData(patientVacctinations.GetDataByPatientID(patienId), ViewData.Vacctinations, _patientVacinationFocusedRowHandle);
        }

        private void LoadVaccines()
        {
            LoadData(vaccines.GetDataAllVaccines(), ViewData.Vaccines, _vaccineFocusedRowHandle);
        }

        private void LoadDoctors()
        {
            LoadData(doctors.GetData(), ViewData.Doctors, _doctorFocusedRowHandle);
        }

        private void barBtnPatients_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadPatients();
        }

        private void barBtnVaccinations_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadVactinations(_patientID);
        }

        private void barBtnVaccine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadVaccines();
        }

        private void barBtnDoctors_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDoctors();
        }

        private void barBtnAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Data.Helper.ShowAbout(this);
        }





    }
}
