namespace GUI
{
    partial class FormCategory
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnl_topBar = new System.Windows.Forms.Panel();
            btn_categoryRefresh = new System.Windows.Forms.Button();
            btn_categoryDelete = new System.Windows.Forms.Button();
            btn_categoryEdit = new System.Windows.Forms.Button();
            btn_categoryAdd = new System.Windows.Forms.Button();
            pnl_status = new System.Windows.Forms.Panel();
            lbl_statusSummary = new System.Windows.Forms.Label();
            pnl_left = new System.Windows.Forms.Panel();
            dgv_listCategory = new System.Windows.Forms.DataGridView();
            txt_categorySearch = new System.Windows.Forms.TextBox();
            lbl_search = new System.Windows.Forms.Label();
            pnl_details = new System.Windows.Forms.Panel();
            btn_categoryCancel = new System.Windows.Forms.Button();
            btn_categorySave = new System.Windows.Forms.Button();
            cbb_categoryStatus = new System.Windows.Forms.ComboBox();
            lbl_categoryStatus = new System.Windows.Forms.Label();
            txt_categoryDesc = new System.Windows.Forms.TextBox();
            lbl_categoryDesc = new System.Windows.Forms.Label();
            txt_categoryName = new System.Windows.Forms.TextBox();
            lbl_categoryName = new System.Windows.Forms.Label();
            lbl_detailsTitle = new System.Windows.Forms.Label();
            
            pnl_topBar.SuspendLayout();
            pnl_status.SuspendLayout();
            pnl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listCategory).BeginInit();
            pnl_details.SuspendLayout();
            SuspendLayout();

            // ========== pnl_topBar ==========
            pnl_topBar.Controls.Add(btn_categoryRefresh);
            pnl_topBar.Controls.Add(btn_categoryDelete);
            pnl_topBar.Controls.Add(btn_categoryEdit);
            pnl_topBar.Controls.Add(btn_categoryAdd);
            pnl_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_topBar.Location = new System.Drawing.Point(0, 0);
            pnl_topBar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_topBar.Name = "pnl_topBar";
            pnl_topBar.Size = new System.Drawing.Size(1587, 102);
            pnl_topBar.TabIndex = 0;

            // ========== btn_categoryAdd ==========
            btn_categoryAdd.Location = new System.Drawing.Point(12, 12);
            btn_categoryAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_categoryAdd.Name = "btn_categoryAdd";
            btn_categoryAdd.Size = new System.Drawing.Size(375, 63);
            btn_categoryAdd.TabIndex = 0;
            btn_categoryAdd.Text = "➕ Thêm";
            btn_categoryAdd.UseVisualStyleBackColor = true;
            btn_categoryAdd.Click += btn_categoryAdd_Click;

            // ========== btn_categoryEdit ==========
            btn_categoryEdit.Location = new System.Drawing.Point(393, 12);
            btn_categoryEdit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_categoryEdit.Name = "btn_categoryEdit";
            btn_categoryEdit.Size = new System.Drawing.Size(402, 63);
            btn_categoryEdit.TabIndex = 1;
            btn_categoryEdit.Text = "✏️ Sửa";
            btn_categoryEdit.UseVisualStyleBackColor = true;
            btn_categoryEdit.Click += btn_categoryEdit_Click;

            // ========== btn_categoryDelete ==========
            btn_categoryDelete.Location = new System.Drawing.Point(801, 12);
            btn_categoryDelete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_categoryDelete.Name = "btn_categoryDelete";
            btn_categoryDelete.Size = new System.Drawing.Size(421, 63);
            btn_categoryDelete.TabIndex = 2;
            btn_categoryDelete.Text = "🗑️ Xóa";
            btn_categoryDelete.UseVisualStyleBackColor = true;
            btn_categoryDelete.Click += btn_categoryDelete_Click;

            // ========== btn_categoryRefresh ==========
            btn_categoryRefresh.Location = new System.Drawing.Point(1228, 12);
            btn_categoryRefresh.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_categoryRefresh.Name = "btn_categoryRefresh";
            btn_categoryRefresh.Size = new System.Drawing.Size(347, 63);
            btn_categoryRefresh.TabIndex = 3;
            btn_categoryRefresh.Text = "🔄 Làm mới";
            btn_categoryRefresh.UseVisualStyleBackColor = true;
            btn_categoryRefresh.Click += btn_categoryRefresh_Click;

            // ========== pnl_status ==========
            pnl_status.Controls.Add(lbl_statusSummary);
            pnl_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_status.Location = new System.Drawing.Point(0, 848);
            pnl_status.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_status.Name = "pnl_status";
            pnl_status.Size = new System.Drawing.Size(1587, 102);
            pnl_status.TabIndex = 1;

            // ========== lbl_statusSummary ==========
            lbl_statusSummary.AutoSize = true;
            lbl_statusSummary.Location = new System.Drawing.Point(26, 30);
            lbl_statusSummary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_statusSummary.Name = "lbl_statusSummary";
            lbl_statusSummary.Size = new System.Drawing.Size(528, 41);
            lbl_statusSummary.TabIndex = 0;
            lbl_statusSummary.Text = "Tổng: 0 danh mục | Đang chọn: Không";

            // ========== pnl_left ==========
            pnl_left.Controls.Add(dgv_listCategory);
            pnl_left.Controls.Add(lbl_search);
            pnl_left.Controls.Add(txt_categorySearch);
            pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            pnl_left.Location = new System.Drawing.Point(0, 102);
            pnl_left.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_left.Name = "pnl_left";
            pnl_left.Size = new System.Drawing.Size(640, 746);
            pnl_left.TabIndex = 2;

            // ========== lbl_search ==========
            lbl_search.Location = new System.Drawing.Point(6, 6);
            lbl_search.Name = "lbl_search";
            lbl_search.Size = new System.Drawing.Size(628, 46);
            lbl_search.TabIndex = 2;
            lbl_search.Text = "🔍 Tìm kiếm danh mục:";

            // ========== txt_categorySearch ==========
            txt_categorySearch.Location = new System.Drawing.Point(6, 55);
            txt_categorySearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txt_categorySearch.Name = "txt_categorySearch";
            txt_categorySearch.Size = new System.Drawing.Size(628, 47);
            txt_categorySearch.TabIndex = 1;
            txt_categorySearch.Text = "Tìm danh mục...";
            txt_categorySearch.ForeColor = System.Drawing.Color.Gray;
            txt_categorySearch.TextChanged += txt_categorySearch_TextChanged;
            txt_categorySearch.Enter += txt_categorySearch_Enter;
            txt_categorySearch.Leave += txt_categorySearch_Leave;

            // ========== dgv_listCategory ==========
            dgv_listCategory.ColumnHeadersHeight = 58;
            dgv_listCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_listCategory.Location = new System.Drawing.Point(6, 110);
            dgv_listCategory.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            dgv_listCategory.Name = "dgv_listCategory";
            dgv_listCategory.RowHeadersWidth = 102;
            dgv_listCategory.Size = new System.Drawing.Size(628, 620);
            dgv_listCategory.TabIndex = 0;
            dgv_listCategory.CellClick += dgv_listCategory_CellClick;
            dgv_listCategory.CellFormatting += dgv_listCategory_CellFormatting;

            // ========== pnl_details ==========
            pnl_details.Controls.Add(btn_categoryCancel);
            pnl_details.Controls.Add(btn_categorySave);
            pnl_details.Controls.Add(cbb_categoryStatus);
            pnl_details.Controls.Add(lbl_categoryStatus);
            pnl_details.Controls.Add(txt_categoryDesc);
            pnl_details.Controls.Add(lbl_categoryDesc);
            pnl_details.Controls.Add(txt_categoryName);
            pnl_details.Controls.Add(lbl_categoryName);
            pnl_details.Controls.Add(lbl_detailsTitle);
            pnl_details.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_details.Location = new System.Drawing.Point(640, 102);
            pnl_details.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_details.Name = "pnl_details";
            pnl_details.Padding = new System.Windows.Forms.Padding(6);
            pnl_details.Size = new System.Drawing.Size(947, 746);
            pnl_details.TabIndex = 3;

            // ========== lbl_detailsTitle ==========
            lbl_detailsTitle.Location = new System.Drawing.Point(6, 12);
            lbl_detailsTitle.Name = "lbl_detailsTitle";
            lbl_detailsTitle.Size = new System.Drawing.Size(935, 46);
            lbl_detailsTitle.TabIndex = 0;
            lbl_detailsTitle.Text = "📋 Thông tin danh mục";
            lbl_detailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);

            // ========== lbl_categoryName ==========
            lbl_categoryName.Location = new System.Drawing.Point(6, 73);
            lbl_categoryName.Name = "lbl_categoryName";
            lbl_categoryName.Size = new System.Drawing.Size(314, 46);
            lbl_categoryName.TabIndex = 1;
            lbl_categoryName.Text = "Tên danh mục *:";

            // ========== txt_categoryName ==========
            txt_categoryName.Location = new System.Drawing.Point(6, 122);
            txt_categoryName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txt_categoryName.Name = "txt_categoryName";
            txt_categoryName.Size = new System.Drawing.Size(929, 47);
            txt_categoryName.TabIndex = 2;

            // ========== lbl_categoryDesc ==========
            lbl_categoryDesc.Location = new System.Drawing.Point(6, 184);
            lbl_categoryDesc.Name = "lbl_categoryDesc";
            lbl_categoryDesc.Size = new System.Drawing.Size(314, 46);
            lbl_categoryDesc.TabIndex = 3;
            lbl_categoryDesc.Text = "Mô tả:";

            // ========== txt_categoryDesc ==========
            txt_categoryDesc.Location = new System.Drawing.Point(6, 233);
            txt_categoryDesc.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txt_categoryDesc.Name = "txt_categoryDesc";
            txt_categoryDesc.Size = new System.Drawing.Size(929, 47);
            txt_categoryDesc.TabIndex = 4;

            // ========== lbl_categoryStatus ==========
            lbl_categoryStatus.Location = new System.Drawing.Point(6, 295);
            lbl_categoryStatus.Name = "lbl_categoryStatus";
            lbl_categoryStatus.Size = new System.Drawing.Size(314, 46);
            lbl_categoryStatus.TabIndex = 5;
            lbl_categoryStatus.Text = "Trạng thái:";

            // ========== cbb_categoryStatus ==========
            cbb_categoryStatus.FormattingEnabled = true;
            cbb_categoryStatus.Items.AddRange(new object[] { "Hoạt động", "Ngừng" });
            cbb_categoryStatus.Location = new System.Drawing.Point(6, 344);
            cbb_categoryStatus.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            cbb_categoryStatus.Name = "cbb_categoryStatus";
            cbb_categoryStatus.Size = new System.Drawing.Size(929, 49);
            cbb_categoryStatus.TabIndex = 6;

            // ========== btn_categorySave ==========
            btn_categorySave.Location = new System.Drawing.Point(6, 635);
            btn_categorySave.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_categorySave.Name = "btn_categorySave";
            btn_categorySave.Size = new System.Drawing.Size(466, 64);
            btn_categorySave.TabIndex = 7;
            btn_categorySave.Text = "💾 Lưu";
            btn_categorySave.UseVisualStyleBackColor = true;
            btn_categorySave.Click += btn_categorySave_Click;

            // ========== btn_categoryCancel ==========
            btn_categoryCancel.Location = new System.Drawing.Point(478, 635);
            btn_categoryCancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_categoryCancel.Name = "btn_categoryCancel";
            btn_categoryCancel.Size = new System.Drawing.Size(457, 64);
            btn_categoryCancel.TabIndex = 8;
            btn_categoryCancel.Text = "❌ Hủy";
            btn_categoryCancel.UseVisualStyleBackColor = true;
            btn_categoryCancel.Click += btn_categoryCancel_Click;

            // ========== FormCategory ==========
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1587, 950);
            Controls.Add(pnl_details);
            Controls.Add(pnl_left);
            Controls.Add(pnl_topBar);
            Controls.Add(pnl_status);
            Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            Name = "FormCategory";
            Text = "Quản lý danh mục sản phẩm";
            Load += FormCategory_Load;
            
            pnl_topBar.ResumeLayout(false);
            pnl_status.ResumeLayout(false);
            pnl_status.PerformLayout();
            pnl_left.ResumeLayout(false);
            pnl_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listCategory).EndInit();
            pnl_details.ResumeLayout(false);
            pnl_details.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Button btn_categoryAdd;
        private System.Windows.Forms.Button btn_categoryEdit;
        private System.Windows.Forms.Button btn_categoryDelete;
        private System.Windows.Forms.Button btn_categoryRefresh;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.Label lbl_statusSummary;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.DataGridView dgv_listCategory;
        private System.Windows.Forms.TextBox txt_categorySearch;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Panel pnl_details;
        private System.Windows.Forms.Label lbl_detailsTitle;
        private System.Windows.Forms.Label lbl_categoryName;
        private System.Windows.Forms.TextBox txt_categoryName;
        private System.Windows.Forms.Label lbl_categoryDesc;
        private System.Windows.Forms.TextBox txt_categoryDesc;
        private System.Windows.Forms.Label lbl_categoryStatus;
        private System.Windows.Forms.ComboBox cbb_categoryStatus;
        private System.Windows.Forms.Button btn_categorySave;
        private System.Windows.Forms.Button btn_categoryCancel;
    }
}