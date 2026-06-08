namespace GUI
{
    partial class FormInventory
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_header = new System.Windows.Forms.Panel();
            btn_refresh = new System.Windows.Forms.Button();
            btn_export = new System.Windows.Forms.Button();
            btn_filter = new System.Windows.Forms.Button();
            pnl_filters = new System.Windows.Forms.Panel();
            cbb_statusFilter = new System.Windows.Forms.ComboBox();
            cbb_categories = new System.Windows.Forms.ComboBox();
            pnl_dashboard = new System.Windows.Forms.Panel();
            lbl_outOfStockCount = new System.Windows.Forms.Label();
            lbl_warningCount = new System.Windows.Forms.Label();
            lbl_availableCount = new System.Windows.Forms.Label();
            lbl_totalCount = new System.Windows.Forms.Label();
            dgv_inventory = new System.Windows.Forms.DataGridView();
            pnl_footer = new System.Windows.Forms.Panel();
            lbl_needOrder = new System.Windows.Forms.Label();
            lbl_timeUpdate = new System.Windows.Forms.Label();
            pnl_header.SuspendLayout();
            pnl_filters.SuspendLayout();
            pnl_dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_inventory).BeginInit();
            pnl_footer.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_header
            // 
            pnl_header.Controls.Add(btn_refresh);
            pnl_header.Controls.Add(btn_export);
            pnl_header.Controls.Add(btn_filter);
            pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_header.Location = new System.Drawing.Point(0, 0);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new System.Drawing.Size(1674, 86);
            pnl_header.TabIndex = 3;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new System.Drawing.Point(1066, 10);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new System.Drawing.Size(596, 60);
            btn_refresh.TabIndex = 0;
            btn_refresh.Text = "🔄 Làm mới";
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btn_export
            // 
            btn_export.Location = new System.Drawing.Point(487, 12);
            btn_export.Name = "btn_export";
            btn_export.Size = new System.Drawing.Size(573, 58);
            btn_export.TabIndex = 1;
            btn_export.Text = "📤 Xuất Excel";
            btn_export.Click += btn_export_Click;
            // 
            // btn_filter
            // 
            btn_filter.Location = new System.Drawing.Point(12, 12);
            btn_filter.Name = "btn_filter";
            btn_filter.Size = new System.Drawing.Size(469, 58);
            btn_filter.TabIndex = 2;
            btn_filter.Text = "🔍 Kiểm kê";
            btn_filter.Click += btn_filter_Click;
            // 
            // pnl_filters
            // 
            pnl_filters.Controls.Add(cbb_statusFilter);
            pnl_filters.Controls.Add(cbb_categories);
            pnl_filters.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_filters.Location = new System.Drawing.Point(0, 86);
            pnl_filters.Name = "pnl_filters";
            pnl_filters.Size = new System.Drawing.Size(1674, 116);
            pnl_filters.TabIndex = 2;
            // 
            // cbb_statusFilter
            // 
            cbb_statusFilter.Location = new System.Drawing.Point(12, 61);
            cbb_statusFilter.Name = "cbb_statusFilter";
            cbb_statusFilter.Size = new System.Drawing.Size(1650, 49);
            cbb_statusFilter.TabIndex = 0;
            // 
            // cbb_categories
            // 
            cbb_categories.Location = new System.Drawing.Point(12, 6);
            cbb_categories.Name = "cbb_categories";
            cbb_categories.Size = new System.Drawing.Size(1650, 49);
            cbb_categories.TabIndex = 1;
            // 
            // pnl_dashboard
            // 
            pnl_dashboard.Controls.Add(lbl_outOfStockCount);
            pnl_dashboard.Controls.Add(lbl_warningCount);
            pnl_dashboard.Controls.Add(lbl_availableCount);
            pnl_dashboard.Controls.Add(lbl_totalCount);
            pnl_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_dashboard.Location = new System.Drawing.Point(0, 202);
            pnl_dashboard.Name = "pnl_dashboard";
            pnl_dashboard.Size = new System.Drawing.Size(1674, 114);
            pnl_dashboard.TabIndex = 1;
            // 
            // lbl_outOfStockCount
            // 
            lbl_outOfStockCount.BackColor = System.Drawing.SystemColors.ControlLight;
            lbl_outOfStockCount.Location = new System.Drawing.Point(1248, 3);
            lbl_outOfStockCount.Name = "lbl_outOfStockCount";
            lbl_outOfStockCount.Size = new System.Drawing.Size(414, 96);
            lbl_outOfStockCount.TabIndex = 0;
            lbl_outOfStockCount.Text = "2\r\nHết hàng";
            // 
            // lbl_warningCount
            // 
            lbl_warningCount.BackColor = System.Drawing.SystemColors.ControlLight;
            lbl_warningCount.Location = new System.Drawing.Point(852, 3);
            lbl_warningCount.Name = "lbl_warningCount";
            lbl_warningCount.Size = new System.Drawing.Size(390, 96);
            lbl_warningCount.TabIndex = 1;
            lbl_warningCount.Text = "4\r\nSắp hết (≤ MinStock)";
            // 
            // lbl_availableCount
            // 
            lbl_availableCount.BackColor = System.Drawing.SystemColors.ControlLight;
            lbl_availableCount.Location = new System.Drawing.Point(430, 3);
            lbl_availableCount.Name = "lbl_availableCount";
            lbl_availableCount.Size = new System.Drawing.Size(416, 96);
            lbl_availableCount.TabIndex = 2;
            lbl_availableCount.Text = "18\r\nCòn hàng";
            // 
            // lbl_totalCount
            // 
            lbl_totalCount.BackColor = System.Drawing.SystemColors.ControlLight;
            lbl_totalCount.Location = new System.Drawing.Point(12, 3);
            lbl_totalCount.Name = "lbl_totalCount";
            lbl_totalCount.Size = new System.Drawing.Size(412, 96);
            lbl_totalCount.TabIndex = 3;
            lbl_totalCount.Text = "24\r\nTổng sản phẩm";
            // 
            // dgv_inventory
            // 
            dgv_inventory.ColumnHeadersHeight = 29;
            dgv_inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_inventory.Location = new System.Drawing.Point(0, 316);
            dgv_inventory.Name = "dgv_inventory";
            dgv_inventory.RowHeadersWidth = 51;
            dgv_inventory.Size = new System.Drawing.Size(1674, 634);
            dgv_inventory.TabIndex = 0;
            // 
            // pnl_footer
            // 
            pnl_footer.Controls.Add(lbl_needOrder);
            pnl_footer.Controls.Add(lbl_timeUpdate);
            pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_footer.Location = new System.Drawing.Point(0, 950);
            pnl_footer.Name = "pnl_footer";
            pnl_footer.Size = new System.Drawing.Size(1674, 54);
            pnl_footer.TabIndex = 4;
            // 
            // lbl_needOrder
            // 
            lbl_needOrder.Location = new System.Drawing.Point(805, 3);
            lbl_needOrder.Name = "lbl_needOrder";
            lbl_needOrder.Size = new System.Drawing.Size(857, 42);
            lbl_needOrder.TabIndex = 0;
            lbl_needOrder.Text = "Cần nhập thêm: 6 sản phẩm";
            // 
            // lbl_timeUpdate
            // 
            lbl_timeUpdate.Location = new System.Drawing.Point(12, 3);
            lbl_timeUpdate.Name = "lbl_timeUpdate";
            lbl_timeUpdate.Size = new System.Drawing.Size(787, 46);
            lbl_timeUpdate.TabIndex = 1;
            lbl_timeUpdate.Text = "Cập nhật lúc: 09:30 01/06/2026";
            lbl_timeUpdate.Click += lbl_timeUpdate_Click;
            // 
            // FormInventory
            // 
            ClientSize = new System.Drawing.Size(1674, 1004);
            Controls.Add(dgv_inventory);
            Controls.Add(pnl_dashboard);
            Controls.Add(pnl_filters);
            Controls.Add(pnl_header);
            Controls.Add(pnl_footer);
            Text = "Kiểm kê tồn kho";
            Load += FormInventory_Load;
            pnl_header.ResumeLayout(false);
            pnl_filters.ResumeLayout(false);
            pnl_dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_inventory).EndInit();
            pnl_footer.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Panel pnl_filters;
        private System.Windows.Forms.ComboBox cbb_statusFilter;
        private System.Windows.Forms.ComboBox cbb_categories;
        private System.Windows.Forms.Panel pnl_dashboard;
        private System.Windows.Forms.Label lbl_totalCount;
        private System.Windows.Forms.Label lbl_outOfStockCount;
        private System.Windows.Forms.Label lbl_warningCount;
        private System.Windows.Forms.Label lbl_availableCount;
        private System.Windows.Forms.DataGridView dgv_inventory;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Label lbl_needOrder;
        private System.Windows.Forms.Label lbl_timeUpdate;
    }
}