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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridCheque = new DevExpress.XtraGrid.GridControl();
            this.grid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BankId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CityId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BranchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccountOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReceivedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textDate = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.CostValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodeNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AssignmentedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReceiptedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeliveredOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReturnedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SettlementedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SettlementDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AssignorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrackingNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textString = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.SpentTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookupBank = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.lookupBankView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lookupCity = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.lookupCityView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lookupStatus = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.lookupStatusView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lookTheme = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textString)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupBankView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCityView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupStatusView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCheque
            // 
            this.gridCheque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCheque.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridCheque.Location = new System.Drawing.Point(0, 0);
            this.gridCheque.MainView = this.grid;
            this.gridCheque.Name = "gridCheque";
            this.gridCheque.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookupBank,
            this.lookupCity,
            this.lookupStatus,
            this.textString,
            this.textDate});
            this.gridCheque.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridCheque.Size = new System.Drawing.Size(1065, 563);
            this.gridCheque.TabIndex = 0;
            this.gridCheque.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid});
            this.gridCheque.Load += new System.EventHandler(this.gridCheque_Load);
            // 
            // grid
            // 
            this.grid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BankId,
            this.CityId,
            this.BranchCode,
            this.AccountNumber,
            this.AccountOwner,
            this.ReceivedOn,
            this.CostValue,
            this.CodeNumber,
            this.SerialNumber,
            this.StatusId,
            this.AssignmentedOn,
            this.ReceiptedOn,
            this.DeliveredOn,
            this.ReturnedOn,
            this.SettlementedOn,
            this.SettlementDay,
            this.AssignorName,
            this.TrackingNumber,
            this.CreatedOn,
            this.CustomerName,
            this.SpentTo});
            this.grid.GridControl = this.gridCheque;
            this.grid.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BranchCode", null, "(کد شعبه: SUM={0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CostValue", null, "(مبلغ چک: مجموع={0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "CostValue", null, "(مبلغ چک: میانگین={0:0.##})")});
            this.grid.Name = "grid";
            this.grid.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grid.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.grid.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.grid.OptionsView.EnableAppearanceEvenRow = true;
            this.grid.OptionsView.EnableAppearanceOddRow = true;
            this.grid.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.grid.OptionsView.ShowFooter = true;
            this.grid.RowHeight = 30;
            this.grid.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridCheque_InitNewRow);
            this.grid.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.grid_InvalidRowException);
            this.grid.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grid_ValidateRow);
            this.grid.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridCheque_RowUpdated);
            // 
            // BankId
            // 
            this.BankId.Caption = "بانک";
            this.BankId.FieldName = "BankId";
            this.BankId.Name = "BankId";
            this.BankId.Visible = true;
            this.BankId.VisibleIndex = 0;
            this.BankId.Width = 58;
            // 
            // CityId
            // 
            this.CityId.Caption = "شهر";
            this.CityId.FieldName = "CityId";
            this.CityId.Name = "CityId";
            this.CityId.Visible = true;
            this.CityId.VisibleIndex = 14;
            this.CityId.Width = 20;
            // 
            // BranchCode
            // 
            this.BranchCode.Caption = "کد شعبه";
            this.BranchCode.FieldName = "BranchCode";
            this.BranchCode.Name = "BranchCode";
            this.BranchCode.Visible = true;
            this.BranchCode.VisibleIndex = 1;
            this.BranchCode.Width = 58;
            // 
            // AccountNumber
            // 
            this.AccountNumber.Caption = "شماره حساب چک";
            this.AccountNumber.FieldName = "AccountNumber";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Visible = true;
            this.AccountNumber.VisibleIndex = 2;
            this.AccountNumber.Width = 58;
            // 
            // AccountOwner
            // 
            this.AccountOwner.Caption = "نام صاحب حساب";
            this.AccountOwner.FieldName = "AccountOwner";
            this.AccountOwner.Name = "AccountOwner";
            this.AccountOwner.Visible = true;
            this.AccountOwner.VisibleIndex = 3;
            this.AccountOwner.Width = 58;
            // 
            // ReceivedOn
            // 
            this.ReceivedOn.Caption = "تاریخ چک";
            this.ReceivedOn.ColumnEdit = this.textDate;
            this.ReceivedOn.FieldName = "ReceivedOn";
            this.ReceivedOn.Name = "ReceivedOn";
            this.ReceivedOn.Visible = true;
            this.ReceivedOn.VisibleIndex = 4;
            this.ReceivedOn.Width = 67;
            // 
            // textDate
            // 
            this.textDate.AutoHeight = false;
            this.textDate.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.textDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textDate.EditFormat.FormatString = "yyyy/MM/dd";
            this.textDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textDate.Mask.EditMask = "(1[34]\\d\\d)\\/(1[012]|0[1-9])\\/(0[1-9]|[12]\\d|3[01])";
            this.textDate.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textDate.Name = "textDate";
            this.textDate.NullText = "____/__/__";
            // 
            // CostValue
            // 
            this.CostValue.Caption = "مبلغ چک";
            this.CostValue.FieldName = "CostValue";
            this.CostValue.Name = "CostValue";
            this.CostValue.Visible = true;
            this.CostValue.VisibleIndex = 5;
            this.CostValue.Width = 57;
            // 
            // CodeNumber
            // 
            this.CodeNumber.Caption = "شماره چک";
            this.CodeNumber.FieldName = "CodeNumber";
            this.CodeNumber.Name = "CodeNumber";
            this.CodeNumber.Visible = true;
            this.CodeNumber.VisibleIndex = 6;
            this.CodeNumber.Width = 57;
            // 
            // SerialNumber
            // 
            this.SerialNumber.Caption = "سری چک";
            this.SerialNumber.FieldName = "SerialNumber";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Visible = true;
            this.SerialNumber.VisibleIndex = 7;
            this.SerialNumber.Width = 57;
            // 
            // StatusId
            // 
            this.StatusId.Caption = "وضعیت";
            this.StatusId.FieldName = "StatusId";
            this.StatusId.Name = "StatusId";
            this.StatusId.Visible = true;
            this.StatusId.VisibleIndex = 15;
            this.StatusId.Width = 20;
            // 
            // AssignmentedOn
            // 
            this.AssignmentedOn.Caption = "تاریخ واگذاری";
            this.AssignmentedOn.ColumnEdit = this.textDate;
            this.AssignmentedOn.FieldName = "AssignmentedOn";
            this.AssignmentedOn.Name = "AssignmentedOn";
            this.AssignmentedOn.Visible = true;
            this.AssignmentedOn.VisibleIndex = 8;
            this.AssignmentedOn.Width = 57;
            // 
            // ReceiptedOn
            // 
            this.ReceiptedOn.Caption = "تاریخ وصول";
            this.ReceiptedOn.ColumnEdit = this.textDate;
            this.ReceiptedOn.FieldName = "ReceiptedOn";
            this.ReceiptedOn.Name = "ReceiptedOn";
            this.ReceiptedOn.Visible = true;
            this.ReceiptedOn.VisibleIndex = 10;
            this.ReceiptedOn.Width = 52;
            // 
            // DeliveredOn
            // 
            this.DeliveredOn.Caption = "تاریخ عودت";
            this.DeliveredOn.ColumnEdit = this.textDate;
            this.DeliveredOn.FieldName = "DeliveredOn";
            this.DeliveredOn.Name = "DeliveredOn";
            this.DeliveredOn.Visible = true;
            this.DeliveredOn.VisibleIndex = 18;
            this.DeliveredOn.Width = 20;
            // 
            // ReturnedOn
            // 
            this.ReturnedOn.Caption = "تاریخ برگشت";
            this.ReturnedOn.ColumnEdit = this.textDate;
            this.ReturnedOn.FieldName = "ReturnedOn";
            this.ReturnedOn.Name = "ReturnedOn";
            this.ReturnedOn.Visible = true;
            this.ReturnedOn.VisibleIndex = 11;
            this.ReturnedOn.Width = 55;
            // 
            // SettlementedOn
            // 
            this.SettlementedOn.Caption = "تاریخ تسویه برگشتی";
            this.SettlementedOn.ColumnEdit = this.textDate;
            this.SettlementedOn.FieldName = "SettlementedOn";
            this.SettlementedOn.Name = "SettlementedOn";
            this.SettlementedOn.Visible = true;
            this.SettlementedOn.VisibleIndex = 12;
            this.SettlementedOn.Width = 55;
            // 
            // SettlementDay
            // 
            this.SettlementDay.Caption = "مدت تسویه برگشتی";
            this.SettlementDay.FieldName = "SettlementDay";
            this.SettlementDay.Name = "SettlementDay";
            this.SettlementDay.OptionsColumn.ReadOnly = true;
            this.SettlementDay.Visible = true;
            this.SettlementDay.VisibleIndex = 13;
            this.SettlementDay.Width = 55;
            // 
            // AssignorName
            // 
            this.AssignorName.Caption = "نام واگذار کننده";
            this.AssignorName.FieldName = "AssignorName";
            this.AssignorName.Name = "AssignorName";
            this.AssignorName.Visible = true;
            this.AssignorName.VisibleIndex = 9;
            this.AssignorName.Width = 60;
            // 
            // TrackingNumber
            // 
            this.TrackingNumber.Caption = "شماره پیگیری";
            this.TrackingNumber.FieldName = "TrackingNumber";
            this.TrackingNumber.Name = "TrackingNumber";
            this.TrackingNumber.Visible = true;
            this.TrackingNumber.VisibleIndex = 17;
            this.TrackingNumber.Width = 44;
            // 
            // CreatedOn
            // 
            this.CreatedOn.Caption = "تاریخ دریافت چک";
            this.CreatedOn.ColumnEdit = this.textDate;
            this.CreatedOn.FieldName = "CreatedOn";
            this.CreatedOn.Name = "CreatedOn";
            this.CreatedOn.Visible = true;
            this.CreatedOn.VisibleIndex = 20;
            this.CreatedOn.Width = 20;
            // 
            // CustomerName
            // 
            this.CustomerName.Caption = "نام مشتری";
            this.CustomerName.ColumnEdit = this.textString;
            this.CustomerName.FieldName = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Visible = true;
            this.CustomerName.VisibleIndex = 16;
            this.CustomerName.Width = 67;
            // 
            // textString
            // 
            this.textString.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.textString.AutoHeight = false;
            this.textString.Name = "textString";
            this.textString.NullValuePrompt = "فیلد را پر کنید";
            this.textString.NullValuePromptShowForEmptyValue = true;
            this.textString.ShowNullValuePromptWhenFocused = true;
            // 
            // SpentTo
            // 
            this.SpentTo.Caption = "خرج شده به";
            this.SpentTo.FieldName = "SpentTo";
            this.SpentTo.Name = "SpentTo";
            this.SpentTo.Visible = true;
            this.SpentTo.VisibleIndex = 19;
            this.SpentTo.Width = 67;
            // 
            // lookupBank
            // 
            this.lookupBank.AutoHeight = false;
            this.lookupBank.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "لیست بانک ها", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.lookupBank.DisplayMember = "Title";
            this.lookupBank.Name = "lookupBank";
            this.lookupBank.NullText = "";
            this.lookupBank.ValueMember = "Id";
            this.lookupBank.View = this.lookupBankView;
            // 
            // lookupBankView
            // 
            this.lookupBankView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.lookupBankView.Name = "lookupBankView";
            this.lookupBankView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.lookupBankView.OptionsView.ShowGroupPanel = false;
            // 
            // lookupCity
            // 
            this.lookupCity.AutoHeight = false;
            this.lookupCity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupCity.DisplayMember = "Title";
            this.lookupCity.Name = "lookupCity";
            this.lookupCity.NullText = "";
            this.lookupCity.ValueMember = "Id";
            this.lookupCity.View = this.lookupCityView;
            // 
            // lookupCityView
            // 
            this.lookupCityView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.lookupCityView.Name = "lookupCityView";
            this.lookupCityView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.lookupCityView.OptionsView.ShowGroupPanel = false;
            // 
            // lookupStatus
            // 
            this.lookupStatus.AutoHeight = false;
            this.lookupStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupStatus.DisplayMember = "Title";
            this.lookupStatus.Name = "lookupStatus";
            this.lookupStatus.NullText = "";
            this.lookupStatus.ValueMember = "Id";
            this.lookupStatus.View = this.lookupStatusView;
            // 
            // lookupStatusView
            // 
            this.lookupStatusView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.lookupStatusView.Name = "lookupStatusView";
            this.lookupStatusView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.lookupStatusView.OptionsView.ShowGroupPanel = false;
            // 
            // ChequeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridCheque);
            this.Name = "ChequeView";
            this.Size = new System.Drawing.Size(1065, 563);
            ((System.ComponentModel.ISupportInitialize)(this.gridCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textString)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupBankView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCityView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupStatusView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCheque;
        private DevExpress.XtraGrid.Views.Grid.GridView grid;
        private DevExpress.XtraGrid.Columns.GridColumn BranchCode;
        private DevExpress.XtraGrid.Columns.GridColumn BankId;
        private DevExpress.XtraGrid.Columns.GridColumn AccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn AccountOwner;
        private DevExpress.XtraGrid.Columns.GridColumn ReceivedOn;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit lookupBank;
        private DevExpress.XtraGrid.Views.Grid.GridView lookupBankView;
        private DevExpress.LookAndFeel.DefaultLookAndFeel lookTheme;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit lookupCity;
        private DevExpress.XtraGrid.Views.Grid.GridView lookupCityView;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit lookupStatus;
        private DevExpress.XtraGrid.Views.Grid.GridView lookupStatusView;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textString;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textDate;
    }
}
