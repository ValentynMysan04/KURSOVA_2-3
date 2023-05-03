using AuditVaccinationPatientsApp.Data.DataSet1TableAdapters;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AuditVaccinationPatientsApp.Forms
{
    public partial class PtientVaccinationEditForm : XtraForm
    {
        public PtientVaccinationEditForm()
        {
            InitializeComponent();

            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();

            this.Size = new Size(600, 300);
            this.StartPosition = FormStartPosition.CenterParent;


            this.FormBorderEffect = FormBorderEffect.Shadow;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public PtientVaccinationEditForm(int patientId, int patientVactinationsId, bool editMode) : this()
        {
            this.Text = "Картка вакинації пацієнта";
            this.layoutControlGroup1.Text = "Вакинація пацієнта";
            EditMode = editMode;
            PatientID = patientId;
            PatientVactinationsID = patientVactinationsId;
        }

        private PatientsTableAdapter patient = new PatientsTableAdapter();
        private PatientVactinationsTableAdapter patientVacctinations = new PatientVactinationsTableAdapter();
        private VaccinesTableAdapter vaccines = new VaccinesTableAdapter();
        private DoctorsTableAdapter doctors = new DoctorsTableAdapter();

        public bool EditMode { get; set; }
        private int PatientID { get; set; }
        private string PatientName { get; set; }
        private int VaccineID { get; set; } = -1;
        private DateTime DateOfVaccination { get; set; } = DateTime.MinValue;
        private int DoctorID { get; set; } = -1;
        private int PatientVactinationsID { get; set; } = -1;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormShadow.Opacity = 120;
            FormShadow.AllowResizeViaShadows = true;
        }

        private void PtientVaccinationEditForm_Load(object sender, EventArgs e)
        {
            sbSaveUpdate.Enabled = false;

            var patientData = patient.GetData();
            var patientsRow = patientData.FirstOrDefault(row => row.PatientID == PatientID);
            PatientName = $"{patientsRow.LastName} {patientsRow.FirstName} {patientsRow.MiddleName}";
            PatientNameTextEdit.Text = PatientName;
            PatientNameTextEdit.Enabled = false;

            DateOfVaccinationDateEdit.EditValue = DateTime.Now;

            var vaccinesData = vaccines.GetData();
            var vaccinesDatasource = vaccinesData.Select(row => new { row.VaccineID, row.VaccineName }).OrderBy(x => x.VaccineID).ToList();
            VaccinesLookUpEdit.Properties.DataSource = vaccinesDatasource;
            VaccinesLookUpEdit.Properties.ValueMember = "VaccineID";
            VaccinesLookUpEdit.Properties.DisplayMember = "VaccineName";
            VaccinesLookUpEdit.Properties.NullText = "Виберіть вакцину...";

            var doctorsData = doctors.GetData();
            var doctorsDatasource = doctorsData.Select(row => new { row.DoctorID, DoctorName = $"{row.LastName} {row.FirstName} {row.MiddleName}" }).ToList();
            DoctorsLookUpEdit.Properties.DataSource = doctorsDatasource;
            DoctorsLookUpEdit.Properties.ValueMember = "DoctorID";
            DoctorsLookUpEdit.Properties.DisplayMember = "DoctorName";
            DoctorsLookUpEdit.Properties.NullText = "Виберіть лікаря...";

            if (EditMode)
            {
                var patientVactinationData = patientVacctinations.GetDataByPatientVaccinationID(PatientVactinationsID);
                var patientVactinationRow = patientVactinationData.FirstOrDefault(row => row.PatientVactinationsID == PatientVactinationsID);
                if (patientVactinationRow != null)
                {
                    DateOfVaccinationDateEdit.EditValue = patientVactinationRow.DateOfVaccination;
                    VaccinesLookUpEdit.EditValue = patientVactinationRow.VaccineID;
                    DoctorsLookUpEdit.EditValue = patientVactinationRow.DoctorID;
                }
            }

            ValidateSaveButton();
        }

        private void DateOfVaccinationDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            DateOfVaccination = (DateTime)(!string.IsNullOrEmpty(DateOfVaccinationDateEdit.EditValue.ToString()) ? DateOfVaccinationDateEdit.EditValue : DateTime.Now);

            ValidateSaveButton();
        }

        private void VaccineLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            VaccineID = !string.IsNullOrEmpty(VaccinesLookUpEdit.EditValue.ToString()) ? (int)VaccinesLookUpEdit.EditValue : -1;

            ValidateSaveButton();
        }

        private void DoctorsLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            DoctorID = !string.IsNullOrEmpty(DoctorsLookUpEdit.EditValue.ToString()) ? (int)DoctorsLookUpEdit.EditValue : -1;

            ValidateSaveButton();
        }

        private void ValidateSaveButton()
        {
            sbSaveUpdate.Enabled = DateOfVaccination != DateTime.MinValue && VaccineID > 0 && DoctorID > 0;
        }

        private void sbSaveUpdate_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                if (XtraMessageBox.Show(this, "Ви хочете поновити запис про вакцинацію?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = patientVacctinations.UpdatePatientVaccination(PatientID, VaccineID, DateOfVaccination.ToString(), DoctorID, DoctorID, PatientVactinationsID);

                    this.Close();
                }
            }
            else
            {
                if (XtraMessageBox.Show(this, "Ви хочете зберегти запис про вакцинацію?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = patientVacctinations.InsertPatientVaccination(PatientID, VaccineID, DateOfVaccination.ToString(), DoctorID, DoctorID);

                    this.Close();
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}