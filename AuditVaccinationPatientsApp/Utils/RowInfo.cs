using DevExpress.XtraGrid.Views.Grid;

namespace AuditVaccinationPatientsApp.Utils
{
    class RowInfo
    {
        public RowInfo(GridView view, int rowHandle, ViewData currentView, RowState action)
        {
            this.RowHandle = rowHandle;
            this.View = view;
            this.CurrentView = currentView;
            this.Action = action;
        }
        public GridView View;
        public int RowHandle;
        public ViewData CurrentView;
        public RowState Action;
    }
}
