using System;
using System.Windows.Forms;
using Cheque.DataLayer.Context;
using Cheque.ServiceLayer.Contracts;
using Cheque.ViewModel.Models;
using Cheque.Win.Start;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace Cheque.Win.View
{
    /// <summary>
    /// </summary>
    public partial class ChequeView : UserControl
    {
        #region Ctor

        /// <summary>
        /// </summary>
        public ChequeView()
        {
            _unitOfWork = StructureMapConfig.Resolve<IUnitOfWork>();
            _chequeService = StructureMapConfig.Resolve<IChequeService>();
            _bankService = StructureMapConfig.Resolve<IBankService>();
            _cityService = StructureMapConfig.Resolve<ICityService>();
            _statusService = StructureMapConfig.Resolve<IStatusService>();

            InitializeComponent();
        }

        #endregion

        #region GridChequeLoad

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridCheque_Load(object sender, EventArgs e)
        {
            gridCheque.DataSource = _chequeService.GetList();

            lookupBank.DataSource = _bankService.FillBankLookup();
            lookupBank.PopulateViewColumns();
            lookupBank.View.Columns["Id"].Visible = false;
            lookupBank.View.Columns["CustomeCode"].Caption = "کد";
            lookupBank.View.Columns["Title"].Caption = "عنوان";
            BankId.ColumnEdit = lookupBank;

            lookupCity.DataSource = _cityService.FillCityLookup();
            lookupCity.PopulateViewColumns();
            lookupCity.View.Columns["Id"].Visible = false;
            lookupCity.View.Columns["CustomeCode"].Caption = "کد";
            lookupCity.View.Columns["Title"].Caption = "عنوان";
            CityId.ColumnEdit = lookupCity;

            lookupStatus.DataSource = _statusService.FillStatusLookup();
            lookupStatus.PopulateViewColumns();
            lookupStatus.View.Columns["Id"].Visible = false;
            lookupStatus.View.Columns["Title"].Caption = "عنوان";
            StatusId.ColumnEdit = lookupStatus;
        }

        #endregion

        #region GridChequeRowUpdated

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridCheque_RowUpdated(object sender, RowObjectEventArgs e)
        {
            if (e.Row == null){
                _chequeService.Create((ChequeViewModel)e.Row);
                MessageBox.Show("با موفقیت ذخیره شد");
               }
            else
            {
                // var chequeViewModel = _chequeService.GetForEdit(((ChequeViewModel) e.Row).Id);
                _chequeService.Edit((ChequeViewModel)e.Row);
                MessageBox.Show("با موفقیت ویرایش شد");
            }

            
        }

        #endregion

        #region GridChequeInitNewRow

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridCheque_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var gridView = sender as GridView;
            gridView?.SetRowCellValue(e.RowHandle, gridView.Columns["CreatedOn"], "1395/10/10");
        }

        #endregion

        #region GridChequeValidateRow

        private void grid_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            var gridView = sender as GridView;
            if (gridView != null &&
                (string) gridView.GetRowCellValue(e.RowHandle, gridView.Columns["CustomerName"]) == "")
            {
                e.Valid = false;

                ((GridView) sender).SetColumnError(((GridView) sender).Columns["CustomerName"],
                    "فیلد نباید خالی باشد");
            }
        }

        #endregion

        #region GridChequeInvalidRowException

        private void grid_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        #endregion

        #region Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IChequeService _chequeService;
        private readonly IBankService _bankService;
        private readonly ICityService _cityService;
        private readonly IStatusService _statusService;

        #endregion
    }
}