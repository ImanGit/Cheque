using System.Windows.Forms;
using Cheque.Win.View;
using DevExpress.XtraEditors;

namespace Cheque.Win
{
    /// <summary>
    /// </summary>
    public partial class MainForm : XtraForm
    {
        /// <summary>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            var chequeView = new ChequeView {Dock = DockStyle.Fill};
            Controls.Add(chequeView);
        }
    }
}