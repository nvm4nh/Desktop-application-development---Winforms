namespace GUI
{
    partial class FormIntoWarehouse
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
            btn_history = new System.Windows.Forms.Button();
            btn_cancelReceipt = new System.Windows.Forms.Button();
            btn_confirmReceipt = new System.Windows.Forms.Button();
            btn_createReceipt = new System.Windows.Forms.Button();
            pnl_meta = new System.Windows.Forms.Panel();
            btn_addProduct = new System.Windows.Forms.Button();
            txt_receiptCode = new System.Windows.Forms.TextBox();
            lbl_receiptCode = new System.Windows.Forms.Label();
            cbb_suppliers = new System.Windows.Forms.ComboBox();
            lbl_supplier = new System.Windows.Forms.Label();
            dgv_details = new System.Windows.Forms.DataGridView();
            pnl_summary = new System.Windows.Forms.Panel();
            lbl_totalAmount = new System.Windows.Forms.Label();
            lbl_totalQty = new System.Windows.Forms.Label();
            pnl_footer = new System.Windows.Forms.Panel();
            lbl_bottomNcc = new System.Windows.Forms.Label();
            lbl_bottomStatus = new System.Windows.Forms.Label();
            pnl_header.SuspendLayout();
            pnl_meta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_details).BeginInit();
            pnl_summary.SuspendLayout();
            pnl_footer.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_header
            // 
            pnl_header.Controls.Add(btn_history);
            pnl_header.Controls.Add(btn_cancelReceipt);
            pnl_header.Controls.Add(btn_confirmReceipt);
            pnl_header.Controls.Add(btn_createReceipt);
            pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_header.Location = new System.Drawing.Point(0, 0);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new System.Drawing.Size(1606, 77);
            pnl_header.TabIndex = 3;
            // 
            // btn_history
            // 
            btn_history.Location = new System.Drawing.Point(1178, 12);
            btn_history.Name = "btn_history";
            btn_history.Size = new System.Drawing.Size(416, 59);
            btn_history.TabIndex = 0;
            btn_history.Text = "📋 Lịch sử nhập";
            btn_history.Click += btn_history_Click;
            // 
            // btn_cancelReceipt
            // 
            btn_cancelReceipt.Location = new System.Drawing.Point(771, 12);
            btn_cancelReceipt.Name = "btn_cancelReceipt";
            btn_cancelReceipt.Size = new System.Drawing.Size(401, 59);
            btn_cancelReceipt.TabIndex = 1;
            btn_cancelReceipt.Text = "❌ Hủy phiếu";
            btn_cancelReceipt.Click += btn_cancelReceipt_Click;
            // 
            // btn_confirmReceipt
            // 
            btn_confirmReceipt.Location = new System.Drawing.Point(395, 12);
            btn_confirmReceipt.Name = "btn_confirmReceipt";
            btn_confirmReceipt.Size = new System.Drawing.Size(370, 59);
            btn_confirmReceipt.TabIndex = 2;
            btn_confirmReceipt.Text = "✔️ Xác nhận nhập";
            btn_confirmReceipt.Click += btn_confirmReceipt_Click;
            // 
            // btn_createReceipt
            // 
            btn_createReceipt.Location = new System.Drawing.Point(12, 12);
            btn_createReceipt.Name = "btn_createReceipt";
            btn_createReceipt.Size = new System.Drawing.Size(377, 59);
            btn_createReceipt.TabIndex = 3;
            btn_createReceipt.Text = "＋ Tạo phiếu nhập";
            btn_createReceipt.Click += btn_createReceipt_Click;
            // 
            // pnl_meta
            // 
            pnl_meta.Controls.Add(btn_addProduct);
            pnl_meta.Controls.Add(txt_receiptCode);
            pnl_meta.Controls.Add(lbl_receiptCode);
            pnl_meta.Controls.Add(cbb_suppliers);
            pnl_meta.Controls.Add(lbl_supplier);
            pnl_meta.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_meta.Location = new System.Drawing.Point(0, 77);
            pnl_meta.Name = "pnl_meta";
            pnl_meta.Size = new System.Drawing.Size(1606, 97);
            pnl_meta.TabIndex = 2;
            // 
            // btn_addProduct
            // 
            btn_addProduct.Location = new System.Drawing.Point(1372, 13);
            btn_addProduct.Name = "btn_addProduct";
            btn_addProduct.Size = new System.Drawing.Size(222, 59);
            btn_addProduct.TabIndex = 0;
            btn_addProduct.Text = "Thêm\r\n";
            btn_addProduct.Click += btn_addProduct_Click;
            // 
            // txt_receiptCode
            // 
            txt_receiptCode.Location = new System.Drawing.Point(814, 19);
            txt_receiptCode.Name = "txt_receiptCode";
            txt_receiptCode.Size = new System.Drawing.Size(358, 47);
            txt_receiptCode.TabIndex = 1;
            txt_receiptCode.TextChanged += txt_receiptCode_TextChanged;
            // 
            // lbl_receiptCode
            // 
            lbl_receiptCode.Location = new System.Drawing.Point(624, 19);
            lbl_receiptCode.Name = "lbl_receiptCode";
            lbl_receiptCode.Size = new System.Drawing.Size(184, 47);
            lbl_receiptCode.TabIndex = 2;
            lbl_receiptCode.Text = "Mã phiếu:";
            lbl_receiptCode.Click += lbl_receiptCode_Click;
            // 
            // cbb_suppliers
            // 
            cbb_suppliers.Location = new System.Drawing.Point(237, 19);
            cbb_suppliers.Name = "cbb_suppliers";
            cbb_suppliers.Size = new System.Drawing.Size(381, 49);
            cbb_suppliers.TabIndex = 3;
            // 
            // lbl_supplier
            // 
            lbl_supplier.Location = new System.Drawing.Point(15, 19);
            lbl_supplier.Name = "lbl_supplier";
            lbl_supplier.Size = new System.Drawing.Size(216, 53);
            lbl_supplier.TabIndex = 4;
            lbl_supplier.Text = "Nhà cung cấp:";
            // 
            // dgv_details
            // 
            dgv_details.ColumnHeadersHeight = 29;
            dgv_details.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_details.Location = new System.Drawing.Point(0, 174);
            dgv_details.Name = "dgv_details";
            dgv_details.RowHeadersWidth = 51;
            dgv_details.Size = new System.Drawing.Size(1606, 679);
            dgv_details.TabIndex = 0;
            // 
            // pnl_summary
            // 
            pnl_summary.Controls.Add(lbl_totalAmount);
            pnl_summary.Controls.Add(lbl_totalQty);
            pnl_summary.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_summary.Location = new System.Drawing.Point(0, 853);
            pnl_summary.Name = "pnl_summary";
            pnl_summary.Size = new System.Drawing.Size(1606, 61);
            pnl_summary.TabIndex = 1;
            // 
            // lbl_totalAmount
            // 
            lbl_totalAmount.Location = new System.Drawing.Point(771, 5);
            lbl_totalAmount.Name = "lbl_totalAmount";
            lbl_totalAmount.Size = new System.Drawing.Size(823, 50);
            lbl_totalAmount.TabIndex = 0;
            lbl_totalAmount.Text = "Tổng tiền: 165,000,000 đ";
            // 
            // lbl_totalQty
            // 
            lbl_totalQty.Location = new System.Drawing.Point(15, 5);
            lbl_totalQty.Name = "lbl_totalQty";
            lbl_totalQty.Size = new System.Drawing.Size(750, 50);
            lbl_totalQty.TabIndex = 1;
            lbl_totalQty.Text = "Tổng SL: 15";
            // 
            // pnl_footer
            // 
            pnl_footer.Controls.Add(lbl_bottomNcc);
            pnl_footer.Controls.Add(lbl_bottomStatus);
            pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_footer.Location = new System.Drawing.Point(0, 914);
            pnl_footer.Name = "pnl_footer";
            pnl_footer.Size = new System.Drawing.Size(1606, 62);
            pnl_footer.TabIndex = 4;
            // 
            // lbl_bottomNcc
            // 
            lbl_bottomNcc.Location = new System.Drawing.Point(771, 3);
            lbl_bottomNcc.Name = "lbl_bottomNcc";
            lbl_bottomNcc.Size = new System.Drawing.Size(823, 50);
            lbl_bottomNcc.TabIndex = 0;
            lbl_bottomNcc.Text = "NCC: Apple VN";
            // 
            // lbl_bottomStatus
            // 
            lbl_bottomStatus.Location = new System.Drawing.Point(15, 3);
            lbl_bottomStatus.Name = "lbl_bottomStatus";
            lbl_bottomStatus.Size = new System.Drawing.Size(750, 50);
            lbl_bottomStatus.TabIndex = 1;
            lbl_bottomStatus.Text = "Phiếu: PN20240601 — Chưa xác nhận";
            // 
            // FormIntoWarehouse
            // 
            ClientSize = new System.Drawing.Size(1606, 976);
            Controls.Add(dgv_details);
            Controls.Add(pnl_summary);
            Controls.Add(pnl_meta);
            Controls.Add(pnl_header);
            Controls.Add(pnl_footer);
            Text = "Nhập kho";
            Load += FormIntoWarehouse_Load;
            pnl_header.ResumeLayout(false);
            pnl_meta.ResumeLayout(false);
            pnl_meta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_details).EndInit();
            pnl_summary.ResumeLayout(false);
            pnl_footer.ResumeLayout(false);
            ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_cancelReceipt;
        private System.Windows.Forms.Button btn_confirmReceipt;
        private System.Windows.Forms.Button btn_createReceipt;
        private System.Windows.Forms.Panel pnl_meta;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.TextBox txt_receiptCode;
        private System.Windows.Forms.Label lbl_receiptCode;
        private System.Windows.Forms.ComboBox cbb_suppliers;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.DataGridView dgv_details;
        private System.Windows.Forms.Panel pnl_summary;
        private System.Windows.Forms.Label lbl_totalAmount;
        private System.Windows.Forms.Label lbl_totalQty;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Label lbl_bottomNcc;
        private System.Windows.Forms.Label lbl_bottomStatus;
    }
}