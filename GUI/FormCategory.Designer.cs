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
            this.pnl_TopBar = new System.Windows.Forms.Panel();
            this.btn_CategoryRefresh = new System.Windows.Forms.Button();
            this.btn_CategoryDelete = new System.Windows.Forms.Button();
            this.btn_CategoryEdit = new System.Windows.Forms.Button();
            this.btn_CategoryAdd = new System.Windows.Forms.Button();
            this.pnl_Right = new System.Windows.Forms.Panel();
            this.btn_CategoryCancel = new System.Windows.Forms.Button();
            this.btn_CategorySave = new System.Windows.Forms.Button();
            this.cb_CategoryStatus = new System.Windows.Forms.ComboBox();
            this.lbl_CategoryStatus = new System.Windows.Forms.Label();
            this.txt_CategoryDesc = new System.Windows.Forms.TextBox();
            this.lbl_CategoryDesc = new System.Windows.Forms.Label();
            this.txt_CategoryName = new System.Windows.Forms.TextBox();
            this.lbl_CategoryName = new System.Windows.Forms.Label();
            this.lbl_SectionTitle = new System.Windows.Forms.Label();
            this.pnl_Left = new System.Windows.Forms.Panel();
            this.dgv_CategoryList = new System.Windows.Forms.DataGridView();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.txt_CategorySearch = new System.Windows.Forms.TextBox();
            this.pnl_Status = new System.Windows.Forms.Panel();
            this.lbl_StatusSummary = new System.Windows.Forms.Label();
            this.pnl_TopBar.SuspendLayout();
            this.pnl_Right.SuspendLayout();
            this.pnl_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryList)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.pnl_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TopBar
            // 
            this.pnl_TopBar.Controls.Add(this.btn_CategoryRefresh);
            this.pnl_TopBar.Controls.Add(this.btn_CategoryDelete);
            this.pnl_TopBar.Controls.Add(this.btn_CategoryEdit);
            this.pnl_TopBar.Controls.Add(this.btn_CategoryAdd);
            this.pnl_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopBar.Name = "pnl_TopBar";
            this.pnl_TopBar.Size = new System.Drawing.Size(944, 60);
            this.pnl_TopBar.TabIndex = 0;
            // 
            // btn_CategoryRefresh
            // 
            this.btn_CategoryRefresh.Location = new System.Drawing.Point(380, 15);
            this.btn_CategoryRefresh.Name = "btn_CategoryRefresh";
            this.btn_CategoryRefresh.Size = new System.Drawing.Size(100, 30);
            this.btn_CategoryRefresh.TabIndex = 3;
            this.btn_CategoryRefresh.Text = "Làm mới";
            this.btn_CategoryRefresh.UseVisualStyleBackColor = true;
            this.btn_CategoryRefresh.Click += new System.EventHandler(this.btn_CategoryRefresh_Click);
            // 
            // btn_CategoryDelete
            // 
            this.btn_CategoryDelete.Location = new System.Drawing.Point(260, 15);
            this.btn_CategoryDelete.Name = "btn_CategoryDelete";
            this.btn_CategoryDelete.Size = new System.Drawing.Size(100, 30);
            this.btn_CategoryDelete.TabIndex = 2;
            this.btn_CategoryDelete.Text = "Xóa";
            this.btn_CategoryDelete.UseVisualStyleBackColor = true;
            this.btn_CategoryDelete.Click += new System.EventHandler(this.btn_CategoryDelete_Click);
            // 
            // btn_CategoryEdit
            // 
            this.btn_CategoryEdit.Location = new System.Drawing.Point(140, 15);
            this.btn_CategoryEdit.Name = "btn_CategoryEdit";
            this.btn_CategoryEdit.Size = new System.Drawing.Size(100, 30);
            this.btn_CategoryEdit.TabIndex = 1;
            this.btn_CategoryEdit.Text = "- Sửa";
            this.btn_CategoryEdit.UseVisualStyleBackColor = true;
            this.btn_CategoryEdit.Click += new System.EventHandler(this.btn_CategoryEdit_Click);
            // 
            // btn_CategoryAdd
            // 
            this.btn_CategoryAdd.Location = new System.Drawing.Point(20, 15);
            this.btn_CategoryAdd.Name = "btn_CategoryAdd";
            this.btn_CategoryAdd.Size = new System.Drawing.Size(100, 30);
            this.btn_CategoryAdd.TabIndex = 0;
            this.btn_CategoryAdd.Text = "+ Thêm";
            this.btn_CategoryAdd.UseVisualStyleBackColor = true;
            this.btn_CategoryAdd.Click += new System.EventHandler(this.btn_CategoryAdd_Click);
            // 
            // pnl_Right
            // 
            this.pnl_Right.BackColor = System.Drawing.Color.White;
            this.pnl_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Right.Controls.Add(this.btn_CategoryCancel);
            this.pnl_Right.Controls.Add(this.btn_CategorySave);
            this.pnl_Right.Controls.Add(this.cb_CategoryStatus);
            this.pnl_Right.Controls.Add(this.lbl_CategoryStatus);
            this.pnl_Right.Controls.Add(this.txt_CategoryDesc);
            this.pnl_Right.Controls.Add(this.lbl_CategoryDesc);
            this.pnl_Right.Controls.Add(this.txt_CategoryName);
            this.pnl_Right.Controls.Add(this.lbl_CategoryName);
            this.pnl_Right.Controls.Add(this.lbl_SectionTitle);
            this.pnl_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Right.Location = new System.Drawing.Point(624, 60);
            this.pnl_Right.Name = "pnl_Right";
            this.pnl_Right.Size = new System.Drawing.Size(320, 471);
            this.pnl_Right.TabIndex = 2;
            // 
            // btn_CategoryCancel
            // 
            this.btn_CategoryCancel.Location = new System.Drawing.Point(165, 390);
            this.btn_CategoryCancel.Name = "btn_CategoryCancel";
            this.btn_CategoryCancel.Size = new System.Drawing.Size(100, 35);
            this.btn_CategoryCancel.TabIndex = 8;
            this.btn_CategoryCancel.Text = "Hủy";
            this.btn_CategoryCancel.UseVisualStyleBackColor = true;
            this.btn_CategoryCancel.Click += new System.EventHandler(this.btn_CategoryCancel_Click);
            // 
            // btn_CategorySave
            // 
            this.btn_CategorySave.Location = new System.Drawing.Point(50, 390);
            this.btn_CategorySave.Name = "btn_CategorySave";
            this.btn_CategorySave.Size = new System.Drawing.Size(100, 35);
            this.btn_CategorySave.TabIndex = 7;
            this.btn_CategorySave.Text = "Lưu";
            this.btn_CategorySave.UseVisualStyleBackColor = true;
            this.btn_CategorySave.Click += new System.EventHandler(this.btn_CategorySave_Click);
            // 
            // cb_CategoryStatus
            // 
            this.cb_CategoryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CategoryStatus.FormattingEnabled = true;
            this.cb_CategoryStatus.Items.AddRange(new object[] {
            "Hoạt động",
            "Ngừng"});
            this.cb_CategoryStatus.Location = new System.Drawing.Point(20, 320);
            this.cb_CategoryStatus.Name = "cb_CategoryStatus";
            this.cb_CategoryStatus.Size = new System.Drawing.Size(275, 24);
            this.cb_CategoryStatus.TabIndex = 6;
            // 
            // lbl_CategoryStatus
            // 
            this.lbl_CategoryStatus.AutoSize = true;
            this.lbl_CategoryStatus.Location = new System.Drawing.Point(17, 300);
            this.lbl_CategoryStatus.Name = "lbl_CategoryStatus";
            this.lbl_CategoryStatus.Size = new System.Drawing.Size(70, 16);
            this.lbl_CategoryStatus.TabIndex = 5;
            this.lbl_CategoryStatus.Text = "Trạng thái:";
            // 
            // txt_CategoryDesc
            // 
            this.txt_CategoryDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CategoryDesc.Location = new System.Drawing.Point(20, 150);
            this.txt_CategoryDesc.Multiline = true;
            this.txt_CategoryDesc.Name = "txt_CategoryDesc";
            this.txt_CategoryDesc.Size = new System.Drawing.Size(275, 120);
            this.txt_CategoryDesc.TabIndex = 4;
            // 
            // lbl_CategoryDesc
            // 
            this.lbl_CategoryDesc.AutoSize = true;
            this.lbl_CategoryDesc.Location = new System.Drawing.Point(17, 130);
            this.lbl_CategoryDesc.Name = "lbl_CategoryDesc";
            this.lbl_CategoryDesc.Size = new System.Drawing.Size(43, 16);
            this.lbl_CategoryDesc.TabIndex = 3;
            this.lbl_CategoryDesc.Text = "Mô tả:";
            // 
            // txt_CategoryName
            // 
            this.txt_CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CategoryName.Location = new System.Drawing.Point(20, 80);
            this.txt_CategoryName.Name = "txt_CategoryName";
            this.txt_CategoryName.Size = new System.Drawing.Size(275, 27);
            this.txt_CategoryName.TabIndex = 2;
            // 
            // lbl_CategoryName
            // 
            this.lbl_CategoryName.AutoSize = true;
            this.lbl_CategoryName.Location = new System.Drawing.Point(17, 60);
            this.lbl_CategoryName.Name = "lbl_CategoryName";
            this.lbl_CategoryName.Size = new System.Drawing.Size(101, 16);
            this.lbl_CategoryName.TabIndex = 1;
            this.lbl_CategoryName.Text = "Tên danh mục *:";
            // 
            // lbl_SectionTitle
            // 
            this.lbl_SectionTitle.AutoSize = true;
            this.lbl_SectionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SectionTitle.Location = new System.Drawing.Point(16, 15);
            this.lbl_SectionTitle.Name = "lbl_SectionTitle";
            this.lbl_SectionTitle.Size = new System.Drawing.Size(173, 20);
            this.lbl_SectionTitle.TabIndex = 0;
            this.lbl_SectionTitle.Text = "Thông tin danh mục";
            // 
            // pnl_Left
            // 
            this.pnl_Left.Controls.Add(this.dgv_CategoryList);
            this.pnl_Left.Controls.Add(this.pnl_Search);
            this.pnl_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Left.Location = new System.Drawing.Point(0, 60);
            this.pnl_Left.Name = "pnl_Left";
            this.pnl_Left.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.pnl_Left.Size = new System.Drawing.Size(624, 471);
            this.pnl_Left.TabIndex = 1;
            // 
            // dgv_CategoryList
            // 
            this.dgv_CategoryList.AllowUserToAddRows = false;
            this.dgv_CategoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CategoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CategoryList.Location = new System.Drawing.Point(10, 50);
            this.dgv_CategoryList.Name = "dgv_CategoryList";
            this.dgv_CategoryList.ReadOnly = true;
            this.dgv_CategoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CategoryList.Size = new System.Drawing.Size(604, 411);
            this.dgv_CategoryList.TabIndex = 1;
            this.dgv_CategoryList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CategoryList_CellClick);
            this.dgv_CategoryList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CategoryList_CellFormatting);
            // 
            // pnl_Search
            // 
            this.pnl_Search.Controls.Add(this.txt_CategorySearch);
            this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Search.Location = new System.Drawing.Point(10, 0);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(604, 50);
            this.pnl_Search.TabIndex = 0;
            // 
            // txt_CategorySearch
            // 
            this.txt_CategorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CategorySearch.Location = new System.Drawing.Point(0, 10);
            this.txt_CategorySearch.Name = "txt_CategorySearch";
            this.txt_CategorySearch.Size = new System.Drawing.Size(300, 27);
            this.txt_CategorySearch.TabIndex = 0;
            this.txt_CategorySearch.Text = "Tìm danh mục...";
            this.txt_CategorySearch.TextChanged += new System.EventHandler(this.txt_CategorySearch_TextChanged);
            this.txt_CategorySearch.Enter += new System.EventHandler(this.txt_CategorySearch_Enter);
            this.txt_CategorySearch.Leave += new System.EventHandler(this.txt_CategorySearch_Leave);
            // 
            // pnl_Status
            // 
            this.pnl_Status.Controls.Add(this.lbl_StatusSummary);
            this.pnl_Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Status.Location = new System.Drawing.Point(0, 531);
            this.pnl_Status.Name = "pnl_Status";
            this.pnl_Status.Size = new System.Drawing.Size(944, 30);
            this.pnl_Status.TabIndex = 3;
            // 
            // lbl_StatusSummary
            // 
            this.lbl_StatusSummary.AutoSize = true;
            this.lbl_StatusSummary.Location = new System.Drawing.Point(12, 7);
            this.lbl_StatusSummary.Name = "lbl_StatusSummary";
            this.lbl_StatusSummary.Size = new System.Drawing.Size(232, 16);
            this.lbl_StatusSummary.TabIndex = 0;
            this.lbl_StatusSummary.Text = "Tổng: 0 danh mục | Đang chọn: Không";
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.pnl_Left);
            this.Controls.Add(this.pnl_Right);
            this.Controls.Add(this.pnl_TopBar);
            this.Controls.Add(this.pnl_Status);
            this.Name = "FormCategory";
            this.Text = "Quản lý danh mục sản phẩm";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            this.pnl_TopBar.ResumeLayout(false);
            this.pnl_Right.ResumeLayout(false);
            this.pnl_Right.PerformLayout();
            this.pnl_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryList)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            this.pnl_Status.ResumeLayout(false);
            this.pnl_Status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_TopBar;
        private System.Windows.Forms.Button btn_CategoryAdd;
        private System.Windows.Forms.Button btn_CategoryEdit;
        private System.Windows.Forms.Button btn_CategoryDelete;
        private System.Windows.Forms.Button btn_CategoryRefresh;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.Label lbl_SectionTitle;
        private System.Windows.Forms.Label lbl_CategoryName;
        private System.Windows.Forms.TextBox txt_CategoryName;
        private System.Windows.Forms.Label lbl_CategoryDesc;
        private System.Windows.Forms.TextBox txt_CategoryDesc;
        private System.Windows.Forms.Label lbl_CategoryStatus;
        private System.Windows.Forms.ComboBox cb_CategoryStatus;
        private System.Windows.Forms.Button btn_CategorySave;
        private System.Windows.Forms.Button btn_CategoryCancel;
        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.DataGridView dgv_CategoryList;
        private System.Windows.Forms.Panel pnl_Search;
        private System.Windows.Forms.TextBox txt_CategorySearch;
        private System.Windows.Forms.Panel pnl_Status;
        private System.Windows.Forms.Label lbl_StatusSummary;
    }
}