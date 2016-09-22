namespace Cheque.Win.View
{
    partial class ChequeView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridCheque = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BranchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccountOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReceivedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodeNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrackingNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AssignmentedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AssignorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReceiptedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeliveredOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReturnedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SettlementedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SettlementDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SpentTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BankId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CityId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCheque
            // 
            this.gridCheque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCheque.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridCheque.Location = new System.Drawing.Point(0, 0);
            this.gridCheque.MainView = this.gridView1;
            this.gridCheque.Margin = new System.Windows.Forms.Padding(6);
            this.gridCheque.Name = "gridCheque";
            this.gridCheque.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemGridLookUpEdit3});
            this.gridCheque.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridCheque.Size = new System.Drawing.Size(800, 600);
            this.gridCheque.TabIndex = 0;
            this.gridCheque.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridCheque.Load += new System.EventHandler(this.gridCheque_Load);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BranchCode,
            this.AccountNumber,
            this.AccountOwner,
            this.ReceivedOn,
            this.CostValue,
            this.CodeNumber,
            this.SerialNumber,
            this.CustomerName,
            this.TrackingNumber,
            this.AssignmentedOn,
            this.AssignorName,
            this.ReceiptedOn,
            this.DeliveredOn,
            this.ReturnedOn,
            this.SettlementedOn,
            this.SettlementDay,
            this.SpentTo,
            this.BankId,
            this.CityId,
            this.StatusId,
            this.CreatedOn});
            this.gridView1.GridControl = this.gridCheque;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BranchCode", this.BranchCode, "(کد شعبه: SUM={0:0.##})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridCheque_InitNewRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridCheque_RowUpdated);
            // 
            // BranchCode
            // 
            this.BranchCode.Caption = "کد شعبه";
            this.BranchCode.FieldName = "BranchCode";
            this.BranchCode.Name = "BranchCode";
            this.BranchCode.Visible = true;
            this.BranchCode.VisibleIndex = 0;
            // 
            // AccountNumber
            // 
            this.AccountNumber.Caption = "شماره حساب چک";
            this.AccountNumber.FieldName = "AccountNumber";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Visible = true;
            this.AccountNumber.VisibleIndex = 1;
            // 
            // AccountOwner
            // 
            this.AccountOwner.Caption = "نام صاحب حساب";
            this.AccountOwner.FieldName = "AccountOwner";
            this.AccountOwner.Name = "AccountOwner";
            this.AccountOwner.Visible = true;
            this.AccountOwner.VisibleIndex = 2;
            // 
            // ReceivedOn
            // 
            this.ReceivedOn.Caption = "تاریخ چک";
            this.ReceivedOn.FieldName = "ReceivedOn";
            this.ReceivedOn.Name = "ReceivedOn";
            this.ReceivedOn.Visible = true;
            this.ReceivedOn.VisibleIndex = 3;
            // 
            // CostValue
            // 
            this.CostValue.Caption = "مبلغ چک";
            this.CostValue.FieldName = "CostValue";
            this.CostValue.Name = "CostValue";
            this.CostValue.Visible = true;
            this.CostValue.VisibleIndex = 5;
            // 
            // CodeNumber
            // 
            this.CodeNumber.Caption = "شماره چک";
            this.CodeNumber.FieldName = "CodeNumber";
            this.CodeNumber.Name = "CodeNumber";
            this.CodeNumber.Visible = true;
            this.CodeNumber.VisibleIndex = 6;
            // 
            // SerialNumber
            // 
            this.SerialNumber.Caption = "سری چک";
            this.SerialNumber.FieldName = "SerialNumber";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Visible = true;
            this.SerialNumber.VisibleIndex = 7;
            // 
            // CustomerName
            // 
            this.CustomerName.Caption = "نام مشتری";
            this.CustomerName.FieldName = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Visible = true;
            this.CustomerName.VisibleIndex = 16;
            // 
            // TrackingNumber
            // 
            this.TrackingNumber.Caption = "شماره پیگیری";
            this.TrackingNumber.FieldName = "TrackingNumber";
            this.TrackingNumber.Name = "TrackingNumber";
            this.TrackingNumber.Visible = true;
            this.TrackingNumber.VisibleIndex = 17;
            // 
            // AssignmentedOn
            // 
            this.AssignmentedOn.Caption = "تاریخ واگذاری";
            this.AssignmentedOn.FieldName = "AssignmentedOn";
            this.AssignmentedOn.Name = "AssignmentedOn";
            this.AssignmentedOn.Visible = true;
            this.AssignmentedOn.VisibleIndex = 8;
            // 
            // AssignorName
            // 
            this.AssignorName.Caption = "نام واگذار کننده";
            this.AssignorName.FieldName = "AssignorName";
            this.AssignorName.Name = "AssignorName";
            this.AssignorName.Visible = true;
            this.AssignorName.VisibleIndex = 9;
            // 
            // ReceiptedOn
            // 
            this.ReceiptedOn.Caption = "تاریخ وصول";
            this.ReceiptedOn.FieldName = "ReceiptedOn";
            this.ReceiptedOn.Name = "ReceiptedOn";
            this.ReceiptedOn.Visible = true;
            this.ReceiptedOn.VisibleIndex = 10;
            // 
            // DeliveredOn
            // 
            this.DeliveredOn.Caption = "تاریخ عودت";
            this.DeliveredOn.FieldName = "DeliveredOn";
            this.DeliveredOn.Name = "DeliveredOn";
            this.DeliveredOn.Visible = true;
            this.DeliveredOn.VisibleIndex = 18;
            // 
            // ReturnedOn
            // 
            this.ReturnedOn.Caption = "تاریخ برگشت";
            this.ReturnedOn.FieldName = "ReturnedOn";
            this.ReturnedOn.Name = "ReturnedOn";
            this.ReturnedOn.Visible = true;
            this.ReturnedOn.VisibleIndex = 11;
            // 
            // SettlementedOn
            // 
            this.SettlementedOn.Caption = "تاریخ تسویه برگشتی";
            this.SettlementedOn.FieldName = "SettlementedOn";
            this.SettlementedOn.Name = "SettlementedOn";
            this.SettlementedOn.Visible = true;
            this.SettlementedOn.VisibleIndex = 12;
            // 
            // SettlementDay
            // 
            this.SettlementDay.Caption = "مدت تسویه برگشتی";
            this.SettlementDay.FieldName = "SettlementDay";
            this.SettlementDay.Name = "SettlementDay";
            this.SettlementDay.Visible = true;
            this.SettlementDay.VisibleIndex = 13;
            // 
            // SpentTo
            // 
            this.SpentTo.Caption = "خرج شده به";
            this.SpentTo.FieldName = "SpentTo";
            this.SpentTo.Name = "SpentTo";
            this.SpentTo.Visible = true;
            this.SpentTo.VisibleIndex = 19;
            // 
            // BankId
            // 
            this.BankId.Caption = "بانک";
            this.BankId.FieldName = "BankId";
            this.BankId.Name = "BankId";
            this.BankId.Visible = true;
            this.BankId.VisibleIndex = 4;
            // 
            // CityId
            // 
            this.CityId.Caption = "شهر";
            this.CityId.FieldName = "CityId";
            this.CityId.Name = "CityId";
            this.CityId.Visible = true;
            this.CityId.VisibleIndex = 14;
            // 
            // StatusId
            // 
            this.StatusId.Caption = "وضعیت";
            this.StatusId.FieldName = "StatusId";
            this.StatusId.Name = "StatusId";
            this.StatusId.Visible = true;
            this.StatusId.VisibleIndex = 15;
            // 
            // CreatedOn
            // 
            this.CreatedOn.Caption = "تاریخ دریافت چک";
            this.CreatedOn.FieldName = "CreatedOn";
            this.CreatedOn.Name = "CreatedOn";
            this.CreatedOn.Visible = true;
            this.CreatedOn.VisibleIndex = 20;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "لیست بانک ها", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.repositoryItemGridLookUpEdit1.DisplayMember = "Title";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.NullText = "";
            this.repositoryItemGridLookUpEdit1.ValueMember = "Id";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Custom;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DisplayMember = "Title";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "Id";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit3
            // 
            this.repositoryItemGridLookUpEdit3.AutoHeight = false;
            this.repositoryItemGridLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit3.DisplayMember = "Title";
            this.repositoryItemGridLookUpEdit3.Name = "repositoryItemGridLookUpEdit3";
            this.repositoryItemGridLookUpEdit3.ValueMember = "Id";
            this.repositoryItemGridLookUpEdit3.View = this.repositoryItemGridLookUpEdit3View;
            // 
            // repositoryItemGridLookUpEdit3View
            // 
            this.repositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit3View.Name = "repositoryItemGridLookUpEdit3View";
            this.repositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Caramel";
            // 
            // ChequeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridCheque);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChequeView";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.gridCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCheque;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn BranchCode;
        private DevExpress.XtraGrid.Columns.GridColumn BankId;
        private DevExpress.XtraGrid.Columns.GridColumn AccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn AccountOwner;
        private DevExpress.XtraGrid.Columns.GridColumn ReceivedOn;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraGrid.Columns.GridColumn CostValue;
        private DevExpress.XtraGrid.Columns.GridColumn CodeNumber;
        private DevExpress.XtraGrid.Columns.GridColumn SerialNumber;
        private DevExpress.XtraGrid.Columns.GridColumn AssignmentedOn;
        private DevExpress.XtraGrid.Columns.GridColumn AssignorName;
        private DevExpress.XtraGrid.Columns.GridColumn ReceiptedOn;
        private DevExpress.XtraGrid.Columns.GridColumn ReturnedOn;
        private DevExpress.XtraGrid.Columns.GridColumn SettlementedOn;
        private DevExpress.XtraGrid.Columns.GridColumn SettlementDay;
        private DevExpress.XtraGrid.Columns.GridColumn CityId;
        private DevExpress.XtraGrid.Columns.GridColumn StatusId;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn TrackingNumber;
        private DevExpress.XtraGrid.Columns.GridColumn DeliveredOn;
        private DevExpress.XtraGrid.Columns.GridColumn SpentTo;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedOn;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit3View;
    }
}
