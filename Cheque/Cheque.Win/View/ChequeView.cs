using System;
using System.Windows.Forms;
using Cheque.DataLayer.Context;
using Cheque.ServiceLayer.Contracts;
using Cheque.Win.Start;

namespace Cheque.Win.View
{
    public partial class ChequeView : UserControl
    {
        public ChequeView()
        {
            _unitOfWork = StructureMapConfig.Resolve<IUnitOfWork>();
            _chequeService = StructureMapConfig.Resolve<IChequeService>();

            InitializeComponent();
        }

        private void ChequeView_Load(object sender, EventArgs e)
        {
            gridCheque.DataSource = _chequeService.GetList();
        }

        #region Fields

        private readonly IChequeService _chequeService;
        private readonly IUnitOfWork _unitOfWork;

        #endregion
    }
}