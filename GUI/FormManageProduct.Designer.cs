namespace GUI
{
    partial class FormManageProduct
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
            this.pnl_TopBar = new System.Windows.Forms.Panel();
            this.btn_ProductRefresh = new System.Windows.Forms.Button();
            this.btn_Category = new System.Windows.Forms.Button();
            this.btn_ProductDelete = new System.Windows.Forms.Button();
            this.btn_ProductEdit = new System.Windows.Forms.Button();
            this.btn_ProductAdd = new System.Windows.Forms.Button();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.lbl_InventoryWarning = new System.Windows.Forms.Label();
            this.lbl_StatusSummary = new System.Windows.Forms.Label();
            this.pnl_Left = new System.Windows.Forms.Panel();
            this.dgv_CategoryFilter = new System.Windows.Forms.DataGridView();
            this.lbl_CategoryTitle = new System.Windows.Forms.Label();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.dgv_ProductList = new System.Windows.Forms.DataGridView();
            this.pnl_MainTop = new System.Windows.Forms.Panel();
            this.cb_StatusFilter = new System.Windows.Forms.ComboBox();
            this.pnl_TopBar.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryFilter)).BeginInit();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).BeginInit();
            this.pnl_MainTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TopBar
            // 
            this.pnl_TopBar.Controls.Add(this.btn_ProductRefresh);
            this.pnl_TopBar.Controls.Add(this.btn_Category);
            this.pnl_TopBar.Controls.Add(this.btn_ProductDelete);
            this.pnl_TopBar.Controls.Add(this.btn_ProductEdit);
            this.pnl_TopBar.Controls.Add(this.btn_ProductAdd);
            this.pnl_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopBar.Name = "pnl_TopBar";
            this.pnl_TopBar.Size = new System.Drawing.Size(984, 60);
            this.pnl_TopBar.TabIndex = 0;
            // 
            // btn_ProductRefresh
            // 
            this.btn_ProductRefresh.Location = new System.Drawing.Point(440, 15);
            this.btn_ProductRefresh.Name = "btn_ProductRefresh";
            this.btn_ProductRefresh.Size = new System.Drawing.Size(100, 30);
            this.btn_ProductRefresh.TabIndex = 4;
            this.btn_ProductRefresh.Text = "Làm mới";
            this.btn_ProductRefresh.UseVisualStyleBackColor = true;
            this.btn_ProductRefresh.Click += new System.EventHandler(this.btn_ProductRefresh_Click);
            // 
            // btn_Category
            // 
            this.btn_Category.Location = new System.Drawing.Point(340, 15);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(100, 30);
            this.btn_Category.TabIndex = 3;
            this.btn_Category.Text = "Danh mục";
            this.btn_Category.UseVisualStyleBackColor = true;
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
            // 
            // btn_ProductDelete
            // 
            this.btn_ProductDelete.Location = new System.Drawing.Point(240, 15);
            this.btn_ProductDelete.Name = "btn_ProductDelete";
            this.btn_ProductDelete.Size = new System.Drawing.Size(100, 30);
            this.btn_ProductDelete.TabIndex = 2;
            this.btn_ProductDelete.Text = "Xóa";
            this.btn_ProductDelete.UseVisualStyleBackColor = true;
            this.btn_ProductDelete.Click += new System.EventHandler(this.btn_ProductDelete_Click);
            // 
            // btn_ProductEdit
            // 
            this.btn_ProductEdit.Location = new System.Drawing.Point(140, 15);
            this.btn_ProductEdit.Name = "btn_ProductEdit";
            this.btn_ProductEdit.Size = new System.Drawing.Size(100, 30);
            this.btn_ProductEdit.TabIndex = 1;
            this.btn_ProductEdit.Text = "- Sửa";
            this.btn_ProductEdit.UseVisualStyleBackColor = true;
            this.btn_ProductEdit.Click += new System.EventHandler(this.btn_ProductEdit_Click);
            // 
            // btn_ProductAdd
            // 
            this.btn_ProductAdd.Location = new System.Drawing.Point(20, 15);
            this.btn_ProductAdd.Name = "btn_ProductAdd";
            this.btn_ProductAdd.Size = new System.Drawing.Size(120, 30);
            this.btn_ProductAdd.TabIndex = 0;
            this.btn_ProductAdd.Text = "+ Thêm SP";
            this.btn_ProductAdd.UseVisualStyleBackColor = true;
            this.btn_ProductAdd.Click += new System.EventHandler(this.btn_ProductAdd_Click);
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Bottom.Controls.Add(this.lbl_InventoryWarning);
            this.pnl_Bottom.Controls.Add(this.lbl_StatusSummary);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 531);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(984, 30);
            this.pnl_Bottom.TabIndex = 1;
            // 
            // lbl_InventoryWarning
            // 
            this.lbl_InventoryWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_InventoryWarning.AutoSize = true;
            this.lbl_InventoryWarning.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_InventoryWarning.Location = new System.Drawing.Point(750, 6);
            this.lbl_InventoryWarning.Name = "lbl_InventoryWarning";
            this.lbl_InventoryWarning.Size = new System.Drawing.Size(221, 16);
            this.lbl_InventoryWarning.TabIndex = 1;
            this.lbl_InventoryWarning.Text = "Tồn kho thấp: 0 SP | Hết hàng: 0 SP";
            this.lbl_InventoryWarning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_StatusSummary
            // 
            this.lbl_StatusSummary.AutoSize = true;
            this.lbl_StatusSummary.Location = new System.Drawing.Point(12, 6);
            this.lbl_StatusSummary.Name = "lbl_StatusSummary";
            this.lbl_StatusSummary.Size = new System.Drawing.Size(242, 16);
            this.lbl_StatusSummary.TabIndex = 0;
            this.lbl_StatusSummary.Text = "Tổng: 0 sản phẩm | Đang chọn: Không";
            // 
            // pnl_Left
            // 
            this.pnl_Left.BackColor = System.Drawing.Color.White;
            this.pnl_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Left.Controls.Add(this.dgv_CategoryFilter);
            this.pnl_Left.Controls.Add(this.lbl_CategoryTitle);
            this.pnl_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Left.Location = new System.Drawing.Point(0, 60);
            this.pnl_Left.Name = "pnl_Left";
            this.pnl_Left.Size = new System.Drawing.Size(220, 471);
            this.pnl_Left.TabIndex = 2;
            // 
            // dgv_CategoryFilter
            // 
            this.dgv_CategoryFilter.AllowUserToAddRows = false;
            this.dgv_CategoryFilter.AllowUserToDeleteRows = false;
            this.dgv_CategoryFilter.AllowUserToResizeColumns = false;
            this.dgv_CategoryFilter.AllowUserToResizeRows = false;
            this.dgv_CategoryFilter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CategoryFilter.BackgroundColor = System.Drawing.Color.White;
            this.dgv_CategoryFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_CategoryFilter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_CategoryFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CategoryFilter.ColumnHeadersVisible = false;
            this.dgv_CategoryFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CategoryFilter.Location = new System.Drawing.Point(0, 40);
            this.dgv_CategoryFilter.MultiSelect = false;
            this.dgv_CategoryFilter.Name = "dgv_CategoryFilter";
            this.dgv_CategoryFilter.ReadOnly = true;
            this.dgv_CategoryFilter.RowHeadersVisible = false;
            this.dgv_CategoryFilter.RowTemplate.Height = 35;
            this.dgv_CategoryFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CategoryFilter.Size = new System.Drawing.Size(218, 429);
            this.dgv_CategoryFilter.TabIndex = 1;
            this.dgv_CategoryFilter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CategoryFilter_CellClick);
            // 
            // lbl_CategoryTitle
            // 
            this.lbl_CategoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_CategoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CategoryTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_CategoryTitle.Name = "lbl_CategoryTitle";
            this.lbl_CategoryTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_CategoryTitle.Size = new System.Drawing.Size(218, 40);
            this.lbl_CategoryTitle.TabIndex = 0;
            this.lbl_CategoryTitle.Text = "Danh mục";
            this.lbl_CategoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.dgv_ProductList);
            this.pnl_Main.Controls.Add(this.pnl_MainTop);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(220, 60);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Main.Size = new System.Drawing.Size(764, 471);
            this.pnl_Main.TabIndex = 3;
            // 
            // dgv_ProductList
            // 
            this.dgv_ProductList.AllowUserToAddRows = false;
            this.dgv_ProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ProductList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ProductList.Location = new System.Drawing.Point(10, 60);
            this.dgv_ProductList.Name = "dgv_ProductList";
            this.dgv_ProductList.ReadOnly = true;
            this.dgv_ProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProductList.Size = new System.Drawing.Size(744, 401);
            this.dgv_ProductList.TabIndex = 1;
            this.dgv_ProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProductList_CellClick);
            this.dgv_ProductList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ProductList_CellFormatting);
            // 
            // pnl_MainTop
            // 
            this.pnl_MainTop.Controls.Add(this.cb_StatusFilter);
            this.pnl_MainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MainTop.Location = new System.Drawing.Point(10, 10);
            this.pnl_MainTop.Name = "pnl_MainTop";
            this.pnl_MainTop.Size = new System.Drawing.Size(744, 50);
            this.pnl_MainTop.TabIndex = 0;
            // 
            // cb_StatusFilter
            // 
            this.cb_StatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_StatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_StatusFilter.FormattingEnabled = true;
            this.cb_StatusFilter.Items.AddRange(new object[] {
            "Tất cả trạng thái",
            "Còn hàng",
            "Sắp hết",
            "Hết hàng"});
            this.cb_StatusFilter.Location = new System.Drawing.Point(0, 10);
            this.cb_StatusFilter.Name = "cb_StatusFilter";
            this.cb_StatusFilter.Size = new System.Drawing.Size(250, 28);
            this.cb_StatusFilter.TabIndex = 0;
            this.cb_StatusFilter.SelectedIndexChanged += new System.EventHandler(this.cb_StatusFilter_SelectedIndexChanged);
            // 
            // FormManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Left);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_TopBar);
            this.Name = "FormManageProduct";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.FormManageProduct_Load);
            this.pnl_TopBar.ResumeLayout(false);
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Bottom.PerformLayout();
            this.pnl_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryFilter)).EndInit();
            this.pnl_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).EndInit();
            this.pnl_MainTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_TopBar;
        private System.Windows.Forms.Button btn_ProductAdd;
        private System.Windows.Forms.Button btn_ProductEdit;
        private System.Windows.Forms.Button btn_ProductDelete;
        private System.Windows.Forms.Button btn_Category;
        private System.Windows.Forms.Button btn_ProductRefresh;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Label lbl_StatusSummary;
        private System.Windows.Forms.Label lbl_InventoryWarning;
        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.Label lbl_CategoryTitle;
        private System.Windows.Forms.DataGridView dgv_CategoryFilter;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_MainTop;
        private System.Windows.Forms.ComboBox cb_StatusFilter;
        private System.Windows.Forms.DataGridView dgv_ProductList;
    }
}