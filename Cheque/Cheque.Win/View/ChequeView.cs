using System;
using System.Windows.Forms;
using Cheque.DataLayer.Context;
using Cheque.ServiceLayer.Contracts;
using Cheque.Win.Start;
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

            repositoryItemGridLookUpEdit1.DataSource = _bankService.FillBankLookup();
            repositoryItemGridLookUpEdit1.PopulateViewColumns();
            repositoryItemGridLookUpEdit1.View.Columns["Id"].Visible = false;
            repositoryItemGridLookUpEdit1.View.Columns["CustomeCode"].Caption = "کد";
            repositoryItemGridLookUpEdit1.View.Columns["Title"].Caption = "عنوان";
            BankId.ColumnEdit = repositoryItemGridLookUpEdit1;

            repositoryItemGridLookUpEdit2.DataSource = _cityService.FillCityLookup();
            repositoryItemGridLookUpEdit2.PopulateViewColumns();
            repositoryItemGridLookUpEdit2.View.Columns["Id"].Visible = false;
            repositoryItemGridLookUpEdit2.View.Columns["CustomeCode"].Caption = "کد";
            repositoryItemGridLookUpEdit2.View.Columns["Title"].Caption = "عنوان";
            CityId.ColumnEdit = repositoryItemGridLookUpEdit2;

            repositoryItemGridLookUpEdit3.DataSource = _statusService.FillStatusLookup();
            repositoryItemGridLookUpEdit3.PopulateViewColumns();
            repositoryItemGridLookUpEdit3.View.Columns["Id"].Visible = false;
            repositoryItemGridLookUpEdit3.View.Columns["Title"].Caption = "عنوان";
            StatusId.ColumnEdit = repositoryItemGridLookUpEdit3;
        }

        #endregion

        #region GridChequeRowUpdated

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridCheque_RowUpdated(object sender, RowObjectEventArgs e)
        {
            var cheque = _chequeService.GetForEdit(((DomainClasses.Entities.Cheque) e.Row).Id);

            if (cheque == null)
            {
                _chequeService.Create((DomainClasses.Entities.Cheque) e.Row);
                _unitOfWork.SaveAllChanges();
                MessageBox.Show("با موفقیت ذخیره شد");
                return;
            }

            cheque.BranchCode = ((DomainClasses.Entities.Cheque) e.Row).BranchCode;
            cheque.AccountOwner = ((DomainClasses.Entities.Cheque) e.Row).AccountOwner;
            cheque.BankId = ((DomainClasses.Entities.Cheque) e.Row).BankId;
            _unitOfWork.SaveAllChanges();
            MessageBox.Show("با موفقیت ایجاد شد");
        }

        #endregion

        #region GridChequeInitNewRow

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridCheque_InitNewRow(object sender, InitNewRowEventArgs e)
        {
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