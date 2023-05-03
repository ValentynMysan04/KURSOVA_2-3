using AuditVaccinationPatientsApp.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Text;
using System.Windows.Forms;

namespace AuditVaccinationPatientsApp.Data
{
    public static class Helper
    {

        public static string GetConfirmCaption => "Підтвердіть операцію";
        public static string GetNotificationCaption => "Попередження";

        public static string GetMenuCaption(ViewData currentView, RowState action)
        {
            switch (currentView)
            {
                case ViewData.None:
                    return $"{currentView}";
                case ViewData.Patients:
                    switch (action)
                    {
                        case RowState.Add:
                            return "Добавити картку пацієнта";
                        case RowState.Update:
                            return "Редагувати картку пацієнта";
                        case RowState.Delete:
                            return "Видалити картку пацієнта";
                        default:
                            return $"Оновити картки пацієнтів";
                            //return $"{currentView} {action}";
                    }
                case ViewData.Vacctinations:
                    switch (action)
                    {
                        case RowState.Add:
                            return "Добавити вакцинацію";
                        case RowState.Update:
                            return "Редагувати вакцинацію";
                        case RowState.Delete:
                            return "Видалити вакцинацію";
                        default:
                            return $"Оновити вакцинації пацієнта";
                            //return $"{currentView} {action}";
                    }
                case ViewData.Vaccines:
                    switch (action)
                    {
                        case RowState.Add:
                            return "Добавити нову вакцину";
                        case RowState.Update:
                            return "Редагувати вакцину";
                        case RowState.Delete:
                            return "Видалити вакцину";
                        default:
                            return $"Оновити вакцини";
                            //return $"{currentView} {action}";
                    }
                case ViewData.Doctors:
                    switch (action)
                    {
                        case RowState.Add:
                            return "Добавити картку лікаря";
                        case RowState.Update:
                            return "Редагувати картку лікаря";
                        case RowState.Delete:
                            return "Видалити картку лікаря";
                        default:
                            return $"Оновити картки лікарів";
                            //return $"{currentView} {action}";
                    }
                default:
                    return $"{currentView}";
            }
        }

        public static void ShowingPopupEditForm(object sender, ShowingPopupEditFormEventArgs e, ViewData CurrentView)
        {
            switch (CurrentView)
            {
                case ViewData.None:
                    break;
                case ViewData.Patients:
                    e.EditForm.Text = "Картка пацієнта";
                    break;
                case ViewData.Vacctinations:
                    e.EditForm.Text = "Картка вакинації пацієнта";
                    break;
                case ViewData.Vaccines:
                    e.EditForm.Text = "Картка вакцини";
                    break;
                case ViewData.Doctors:
                    e.EditForm.Text = "Картка лікаря";
                    break;
                default:
                    break;
            }
        }

        public static void ShowAbout(MainForm owner)
        {
            string caption = "Про програму";
            var message = new StringBuilder();
            message.Append("Name:  Audit Vaccination Patients App");
            message.Append(Environment.NewLine);
            message.Append("Version: 0.0.0.1");
            message.Append(Environment.NewLine);
            message.Append("Date:    01.05.2023");
            message.Append(Environment.NewLine);
            message.Append("Author:  Valentyn Mysan");
            message.Append(Environment.NewLine);

            if (XtraMessageBox.Show(owner, message.ToString(), caption, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) { }
        }
    }
}
