namespace HeThongMuaHang.Views
{
    partial class PhieuLanhKhoChiTietView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.Columns.GridColumn DisDate;
            this.gridPhieuLanhKhoChiTiet = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Facility = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RequestDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RequestNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RequestLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WorkerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WorkerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RequestQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RequestRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DisQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DisUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DisRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            DisDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuLanhKhoChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DisDate
            // 
            DisDate.Caption = "DisDate";
            DisDate.FieldName = "DisDate";
            DisDate.MinWidth = 25;
            DisDate.Name = "DisDate";
            DisDate.Visible = true;
            DisDate.VisibleIndex = 12;
            DisDate.Width = 94;
            // 
            // gridPhieuLanhKhoChiTiet
            // 
            this.gridPhieuLanhKhoChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPhieuLanhKhoChiTiet.Location = new System.Drawing.Point(0, 0);
            this.gridPhieuLanhKhoChiTiet.MainView = this.gridView1;
            this.gridPhieuLanhKhoChiTiet.Name = "gridPhieuLanhKhoChiTiet";
            this.gridPhieuLanhKhoChiTiet.Size = new System.Drawing.Size(956, 450);
            this.gridPhieuLanhKhoChiTiet.TabIndex = 0;
            this.gridPhieuLanhKhoChiTiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Facility,
            this.RequestDate,
            this.RequestNo,
            this.RequestLine,
            this.ItemNo,
            this.ItemName,
            this.WorkerID,
            this.WorkerName,
            this.RequestQty,
            this.UnitCode,
            this.RequestRemark,
            this.DisQty,
            DisDate,
            this.DisUser,
            this.DisRemark});
            this.gridView1.GridControl = this.gridPhieuLanhKhoChiTiet;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // Facility
            // 
            this.Facility.Caption = "Facility";
            this.Facility.FieldName = "Facility";
            this.Facility.MinWidth = 25;
            this.Facility.Name = "Facility";
            this.Facility.Visible = true;
            this.Facility.VisibleIndex = 0;
            this.Facility.Width = 94;
            // 
            // RequestDate
            // 
            this.RequestDate.Caption = "RequestDate";
            this.RequestDate.FieldName = "RequestDate";
            this.RequestDate.MinWidth = 25;
            this.RequestDate.Name = "RequestDate";
            this.RequestDate.Visible = true;
            this.RequestDate.VisibleIndex = 1;
            this.RequestDate.Width = 94;
            // 
            // RequestNo
            // 
            this.RequestNo.Caption = "RequestNo";
            this.RequestNo.FieldName = "RequestNo";
            this.RequestNo.MinWidth = 25;
            this.RequestNo.Name = "RequestNo";
            this.RequestNo.Visible = true;
            this.RequestNo.VisibleIndex = 2;
            this.RequestNo.Width = 94;
            // 
            // RequestLine
            // 
            this.RequestLine.Caption = "RequestLine";
            this.RequestLine.FieldName = "RequestLine";
            this.RequestLine.MinWidth = 25;
            this.RequestLine.Name = "RequestLine";
            this.RequestLine.Visible = true;
            this.RequestLine.VisibleIndex = 3;
            this.RequestLine.Width = 94;
            // 
            // ItemNo
            // 
            this.ItemNo.Caption = "ItemNo";
            this.ItemNo.FieldName = "ItemNo";
            this.ItemNo.MinWidth = 25;
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.Visible = true;
            this.ItemNo.VisibleIndex = 4;
            this.ItemNo.Width = 94;
            // 
            // ItemName
            // 
            this.ItemName.Caption = "ItemName";
            this.ItemName.FieldName = "ItemName";
            this.ItemName.MinWidth = 25;
            this.ItemName.Name = "ItemName";
            this.ItemName.Visible = true;
            this.ItemName.VisibleIndex = 5;
            this.ItemName.Width = 94;
            // 
            // WorkerID
            // 
            this.WorkerID.Caption = "WorkerID";
            this.WorkerID.FieldName = "WorkerID";
            this.WorkerID.MinWidth = 25;
            this.WorkerID.Name = "WorkerID";
            this.WorkerID.Visible = true;
            this.WorkerID.VisibleIndex = 6;
            this.WorkerID.Width = 94;
            // 
            // WorkerName
            // 
            this.WorkerName.Caption = "WorkerName";
            this.WorkerName.FieldName = "WorkerName";
            this.WorkerName.MinWidth = 25;
            this.WorkerName.Name = "WorkerName";
            this.WorkerName.Visible = true;
            this.WorkerName.VisibleIndex = 7;
            this.WorkerName.Width = 94;
            // 
            // RequestQty
            // 
            this.RequestQty.Caption = "RequestQty";
            this.RequestQty.FieldName = "RequestQty";
            this.RequestQty.MinWidth = 25;
            this.RequestQty.Name = "RequestQty";
            this.RequestQty.Visible = true;
            this.RequestQty.VisibleIndex = 8;
            this.RequestQty.Width = 94;
            // 
            // UnitCode
            // 
            this.UnitCode.Caption = "UnitCode";
            this.UnitCode.FieldName = "UnitCode";
            this.UnitCode.MinWidth = 25;
            this.UnitCode.Name = "UnitCode";
            this.UnitCode.Visible = true;
            this.UnitCode.VisibleIndex = 9;
            this.UnitCode.Width = 94;
            // 
            // RequestRemark
            // 
            this.RequestRemark.Caption = "RequestRemark";
            this.RequestRemark.FieldName = "RequestRemark";
            this.RequestRemark.MinWidth = 25;
            this.RequestRemark.Name = "RequestRemark";
            this.RequestRemark.Visible = true;
            this.RequestRemark.VisibleIndex = 10;
            this.RequestRemark.Width = 94;
            // 
            // DisQty
            // 
            this.DisQty.Caption = "DisQty";
            this.DisQty.FieldName = "DisQty";
            this.DisQty.MinWidth = 25;
            this.DisQty.Name = "DisQty";
            this.DisQty.Visible = true;
            this.DisQty.VisibleIndex = 11;
            this.DisQty.Width = 94;
            // 
            // DisUser
            // 
            this.DisUser.Caption = "DisUser";
            this.DisUser.FieldName = "DisUser";
            this.DisUser.MinWidth = 25;
            this.DisUser.Name = "DisUser";
            this.DisUser.Visible = true;
            this.DisUser.VisibleIndex = 13;
            this.DisUser.Width = 94;
            // 
            // DisRemark
            // 
            this.DisRemark.Caption = "DisRemark";
            this.DisRemark.FieldName = "DisRemark";
            this.DisRemark.MinWidth = 25;
            this.DisRemark.Name = "DisRemark";
            this.DisRemark.Visible = true;
            this.DisRemark.VisibleIndex = 14;
            this.DisRemark.Width = 94;
            // 
            // PhieuLanhKhoChiTietView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.gridPhieuLanhKhoChiTiet);
            this.Name = "PhieuLanhKhoChiTietView";
            this.Text = "Phiếu lãnh kho chi tiết";
            this.Load += new System.EventHandler(this.PhieuLanhKhoChiTietView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuLanhKhoChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridPhieuLanhKhoChiTiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Facility;
        private DevExpress.XtraGrid.Columns.GridColumn RequestDate;
        private DevExpress.XtraGrid.Columns.GridColumn RequestNo;
        private DevExpress.XtraGrid.Columns.GridColumn RequestLine;
        private DevExpress.XtraGrid.Columns.GridColumn ItemNo;
        private DevExpress.XtraGrid.Columns.GridColumn ItemName;
        private DevExpress.XtraGrid.Columns.GridColumn WorkerID;
        private DevExpress.XtraGrid.Columns.GridColumn WorkerName;
        private DevExpress.XtraGrid.Columns.GridColumn RequestQty;
        private DevExpress.XtraGrid.Columns.GridColumn UnitCode;
        private DevExpress.XtraGrid.Columns.GridColumn RequestRemark;
        private DevExpress.XtraGrid.Columns.GridColumn DisQty;
        private DevExpress.XtraGrid.Columns.GridColumn DisUser;
        private DevExpress.XtraGrid.Columns.GridColumn DisRemark;
    }
}