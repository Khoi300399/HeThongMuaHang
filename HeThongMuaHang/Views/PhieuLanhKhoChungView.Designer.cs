namespace HeThongMuaHang.Views
{
    partial class PhieuLanhKhoChungView
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Facility = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RequestDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RequestNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepartmentRequest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductionLineRequest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepartmentUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductionLineUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Completed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sites = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusSign = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(HeThongMuaHang.Models.PhieuLanhKhoChungModel);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(945, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Facility,
            this.RequestDate,
            this.RequestNo,
            this.DepartmentRequest,
            this.ProductionLineRequest,
            this.DepartmentUsed,
            this.ProductionLineUsed,
            this.CreateDate,
            this.CreateUser,
            this.Completed,
            this.Sites,
            this.StatusSign});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Facility
            // 
            this.Facility.Caption = "RequestDate";
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
            // DepartmentRequest
            // 
            this.DepartmentRequest.Caption = "DepartmentRequest";
            this.DepartmentRequest.FieldName = "DepartmentRequest";
            this.DepartmentRequest.MinWidth = 25;
            this.DepartmentRequest.Name = "DepartmentRequest";
            this.DepartmentRequest.Visible = true;
            this.DepartmentRequest.VisibleIndex = 3;
            this.DepartmentRequest.Width = 94;
            // 
            // ProductionLineRequest
            // 
            this.ProductionLineRequest.Caption = "ProductionLineRequest";
            this.ProductionLineRequest.FieldName = "ProductionLineRequest";
            this.ProductionLineRequest.MinWidth = 25;
            this.ProductionLineRequest.Name = "ProductionLineRequest";
            this.ProductionLineRequest.Visible = true;
            this.ProductionLineRequest.VisibleIndex = 4;
            this.ProductionLineRequest.Width = 94;
            // 
            // DepartmentUsed
            // 
            this.DepartmentUsed.Caption = "DepartmentUsed";
            this.DepartmentUsed.FieldName = "DepartmentUsed";
            this.DepartmentUsed.MinWidth = 25;
            this.DepartmentUsed.Name = "DepartmentUsed";
            this.DepartmentUsed.Visible = true;
            this.DepartmentUsed.VisibleIndex = 5;
            this.DepartmentUsed.Width = 94;
            // 
            // ProductionLineUsed
            // 
            this.ProductionLineUsed.Caption = "ProductionLineUsed";
            this.ProductionLineUsed.FieldName = "ProductionLineUsed";
            this.ProductionLineUsed.MinWidth = 25;
            this.ProductionLineUsed.Name = "ProductionLineUsed";
            this.ProductionLineUsed.Visible = true;
            this.ProductionLineUsed.VisibleIndex = 6;
            this.ProductionLineUsed.Width = 94;
            // 
            // CreateDate
            // 
            this.CreateDate.Caption = "CreateDate";
            this.CreateDate.FieldName = "CreateDate";
            this.CreateDate.MinWidth = 25;
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Visible = true;
            this.CreateDate.VisibleIndex = 7;
            this.CreateDate.Width = 94;
            // 
            // CreateUser
            // 
            this.CreateUser.Caption = "CreateUser";
            this.CreateUser.FieldName = "CreateUser";
            this.CreateUser.MinWidth = 25;
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Visible = true;
            this.CreateUser.VisibleIndex = 8;
            this.CreateUser.Width = 94;
            // 
            // Completed
            // 
            this.Completed.Caption = "Completed";
            this.Completed.FieldName = "Completed";
            this.Completed.MinWidth = 25;
            this.Completed.Name = "Completed";
            this.Completed.Visible = true;
            this.Completed.VisibleIndex = 9;
            this.Completed.Width = 94;
            // 
            // Sites
            // 
            this.Sites.Caption = "Sites";
            this.Sites.FieldName = "Sites";
            this.Sites.MinWidth = 25;
            this.Sites.Name = "Sites";
            this.Sites.Visible = true;
            this.Sites.VisibleIndex = 10;
            this.Sites.Width = 94;
            // 
            // StatusSign
            // 
            this.StatusSign.FieldName = "StatusSign";
            this.StatusSign.MinWidth = 25;
            this.StatusSign.Name = "StatusSign";
            this.StatusSign.Visible = true;
            this.StatusSign.VisibleIndex = 11;
            this.StatusSign.Width = 94;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 419);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(945, 31);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Approve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhieuLanhKhoChungView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.gridControl1);
            this.Name = "PhieuLanhKhoChungView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn Facility;
        private DevExpress.XtraGrid.Columns.GridColumn RequestDate;
        private DevExpress.XtraGrid.Columns.GridColumn RequestNo;
        private DevExpress.XtraGrid.Columns.GridColumn DepartmentRequest;
        private DevExpress.XtraGrid.Columns.GridColumn ProductionLineRequest;
        private DevExpress.XtraGrid.Columns.GridColumn DepartmentUsed;
        private DevExpress.XtraGrid.Columns.GridColumn ProductionLineUsed;
        private DevExpress.XtraGrid.Columns.GridColumn CreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn CreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn Completed;
        private DevExpress.XtraGrid.Columns.GridColumn Sites;
        private DevExpress.XtraGrid.Columns.GridColumn StatusSign;
    }
}