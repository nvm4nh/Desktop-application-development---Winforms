using System.ComponentModel;

namespace GUI;

partial class FormSell
{
    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dgv_cart = new System.Windows.Forms.DataGridView();
        backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        grp_Action = new System.Windows.Forms.GroupBox();
        btn_promotion = new System.Windows.Forms.Button();
        btn_customer = new System.Windows.Forms.Button();
        txt_searchProduct = new System.Windows.Forms.TextBox();
        pnl_top = new System.Windows.Forms.Panel();
        btn_todayInvoice = new System.Windows.Forms.Button();
        btn_payment = new System.Windows.Forms.Button();
        btn_cancelInvoice = new System.Windows.Forms.Button();
        btn_print = new System.Windows.Forms.Button();
        groupBox3 = new System.Windows.Forms.GroupBox();
        lbl_subTotal = new System.Windows.Forms.Label();
        lbl_discount = new System.Windows.Forms.Label();
        lbl_finalTotal = new System.Windows.Forms.Label();
        groupBox4 = new System.Windows.Forms.GroupBox();
        cbo_paymentMethod = new System.Windows.Forms.ComboBox();
        btn_confirmPayment = new System.Windows.Forms.Button();
        col_productsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_serielsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_Remove = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgv_cart).BeginInit();
        grp_Action.SuspendLayout();
        pnl_top.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox4.SuspendLayout();
        SuspendLayout();
        // 
        // dgv_cart
        // 
        dgv_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { col_productsName, col_serielsNumber, col_Quantity, col_UnitPrice, col_TotalPrice, col_Remove });
        dgv_cart.Location = new System.Drawing.Point(-1, 191);
        dgv_cart.Name = "dgv_cart";
        dgv_cart.RowHeadersWidth = 51;
        dgv_cart.Size = new System.Drawing.Size(1650, 349);
        dgv_cart.TabIndex = 4;
        dgv_cart.CellContentClick += dgv_Cart_CellContentClick;
        // 
        // grp_Action
        // 
        grp_Action.Controls.Add(btn_promotion);
        grp_Action.Controls.Add(btn_customer);
        grp_Action.Controls.Add(txt_searchProduct);
        grp_Action.Location = new System.Drawing.Point(-1, 85);
        grp_Action.Name = "grp_Action";
        grp_Action.Size = new System.Drawing.Size(1650, 100);
        grp_Action.TabIndex = 5;
        grp_Action.TabStop = false;
        grp_Action.Enter += grp_Action_Enter;
        // 
        // btn_promotion
        // 
        btn_promotion.Location = new System.Drawing.Point(1215, 28);
        btn_promotion.Name = "btn_promotion";
        btn_promotion.Size = new System.Drawing.Size(417, 49);
        btn_promotion.TabIndex = 2;
        btn_promotion.Text = "Mã KM";
        btn_promotion.UseVisualStyleBackColor = true;
        btn_promotion.Click += btn_Promotion_Click;
        // 
        // btn_customer
        // 
        btn_customer.Location = new System.Drawing.Point(780, 28);
        btn_customer.Name = "btn_customer";
        btn_customer.Size = new System.Drawing.Size(429, 49);
        btn_customer.TabIndex = 1;
        btn_customer.Text = "SĐT Khách Hàng";
        btn_customer.UseVisualStyleBackColor = true;
        btn_customer.Click += btn_Customer_Click;
        // 
        // txt_searchProduct
        // 
        txt_searchProduct.Location = new System.Drawing.Point(13, 28);
        txt_searchProduct.Name = "txt_searchProduct";
        txt_searchProduct.PlaceholderText = "Quét mã SP / Serial...";
        txt_searchProduct.Size = new System.Drawing.Size(761, 47);
        txt_searchProduct.TabIndex = 0;
        // 
        // pnl_top
        // 
        pnl_top.Controls.Add(btn_todayInvoice);
        pnl_top.Controls.Add(btn_payment);
        pnl_top.Controls.Add(btn_cancelInvoice);
        pnl_top.Controls.Add(btn_print);
        pnl_top.Location = new System.Drawing.Point(-1, -2);
        pnl_top.Name = "pnl_top";
        pnl_top.Size = new System.Drawing.Size(1650, 81);
        pnl_top.TabIndex = 9;
        // 
        // btn_todayInvoice
        // 
        btn_todayInvoice.Location = new System.Drawing.Point(1215, 14);
        btn_todayInvoice.Name = "btn_todayInvoice";
        btn_todayInvoice.Size = new System.Drawing.Size(417, 57);
        btn_todayInvoice.TabIndex = 13;
        btn_todayInvoice.Text = "Hóa Đơn Hôm Nay";
        btn_todayInvoice.UseVisualStyleBackColor = true;
        btn_todayInvoice.Click += btnTodayInvoice_Click;
        // 
        // btn_payment
        // 
        btn_payment.Location = new System.Drawing.Point(13, 14);
        btn_payment.Name = "btn_payment";
        btn_payment.Size = new System.Drawing.Size(363, 57);
        btn_payment.TabIndex = 10;
        btn_payment.Text = "Thanh Toán";
        btn_payment.UseVisualStyleBackColor = true;
        btn_payment.Click += btn_Payment_Click;
        // 
        // btn_cancelInvoice
        // 
        btn_cancelInvoice.Location = new System.Drawing.Point(780, 14);
        btn_cancelInvoice.Name = "btn_cancelInvoice";
        btn_cancelInvoice.Size = new System.Drawing.Size(429, 57);
        btn_cancelInvoice.TabIndex = 12;
        btn_cancelInvoice.Text = "Hủy Hóa Đơn";
        btn_cancelInvoice.UseVisualStyleBackColor = true;
        btn_cancelInvoice.Click += btn_CancelInvoice_Click;
        // 
        // btn_print
        // 
        btn_print.Location = new System.Drawing.Point(382, 14);
        btn_print.Name = "btn_print";
        btn_print.Size = new System.Drawing.Size(392, 57);
        btn_print.TabIndex = 11;
        btn_print.Text = "In Hóa Đơn";
        btn_print.UseVisualStyleBackColor = true;
        btn_print.Click += btn_Print_Click;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(lbl_subTotal);
        groupBox3.Controls.Add(lbl_discount);
        groupBox3.Controls.Add(lbl_finalTotal);
        groupBox3.Location = new System.Drawing.Point(-1, 546);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(1650, 165);
        groupBox3.TabIndex = 7;
        groupBox3.TabStop = false;
        // 
        // lbl_subTotal
        // 
        lbl_subTotal.AutoSize = true;
        lbl_subTotal.Location = new System.Drawing.Point(13, 18);
        lbl_subTotal.Name = "lbl_subTotal";
        lbl_subTotal.Size = new System.Drawing.Size(141, 41);
        lbl_subTotal.TabIndex = 2;
        lbl_subTotal.Text = "Tạm tính:";
        // 
        // lbl_discount
        // 
        lbl_discount.AutoSize = true;
        lbl_discount.ForeColor = System.Drawing.Color.OrangeRed;
        lbl_discount.Location = new System.Drawing.Point(13, 69);
        lbl_discount.Name = "lbl_discount";
        lbl_discount.Size = new System.Drawing.Size(142, 41);
        lbl_discount.TabIndex = 4;
        lbl_discount.Text = "Giảm giá:";
        // 
        // lbl_finalTotal
        // 
        lbl_finalTotal.AutoSize = true;
        lbl_finalTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lbl_finalTotal.ForeColor = System.Drawing.Color.DarkGreen;
        lbl_finalTotal.Location = new System.Drawing.Point(6, 114);
        lbl_finalTotal.Name = "lbl_finalTotal";
        lbl_finalTotal.Size = new System.Drawing.Size(233, 54);
        lbl_finalTotal.TabIndex = 6;
        lbl_finalTotal.Text = "Tổng cộng:";
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(cbo_paymentMethod);
        groupBox4.Controls.Add(btn_confirmPayment);
        groupBox4.Location = new System.Drawing.Point(-1, 717);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new System.Drawing.Size(1652, 164);
        groupBox4.TabIndex = 8;
        groupBox4.TabStop = false;
        // 
        // cbo_paymentMethod
        // 
        cbo_paymentMethod.FormattingEnabled = true;
        cbo_paymentMethod.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "MoMo", "ZaloPay", "Thẻ tín dụng" });
        cbo_paymentMethod.Location = new System.Drawing.Point(13, 34);
        cbo_paymentMethod.Name = "cbo_paymentMethod";
        cbo_paymentMethod.Size = new System.Drawing.Size(1619, 49);
        cbo_paymentMethod.TabIndex = 0;
        // 
        // btn_confirmPayment
        // 
        btn_confirmPayment.Location = new System.Drawing.Point(13, 89);
        btn_confirmPayment.Name = "btn_confirmPayment";
        btn_confirmPayment.Size = new System.Drawing.Size(1619, 57);
        btn_confirmPayment.TabIndex = 3;
        btn_confirmPayment.Text = "Xác Nhận Thanh Toán";
        btn_confirmPayment.UseVisualStyleBackColor = true;
        btn_confirmPayment.Click += btn_ConfirmPayment_Click;
        // 
        // col_productsName
        // 
        col_productsName.HeaderText = "Tên SP";
        col_productsName.MinimumWidth = 12;
        col_productsName.Name = "col_productsName";
        col_productsName.Width = 250;
        // 
        // col_serielsNumber
        // 
        col_serielsNumber.HeaderText = "Serial";
        col_serielsNumber.MinimumWidth = 12;
        col_serielsNumber.Name = "col_serielsNumber";
        col_serielsNumber.Width = 200;
        // 
        // col_Quantity
        // 
        col_Quantity.HeaderText = "SL";
        col_Quantity.MinimumWidth = 12;
        col_Quantity.Name = "col_Quantity";
        col_Quantity.Width = 80;
        // 
        // col_UnitPrice
        // 
        col_UnitPrice.HeaderText = "Đơn giá";
        col_UnitPrice.MinimumWidth = 12;
        col_UnitPrice.Name = "col_UnitPrice";
        col_UnitPrice.Width = 150;
        // 
        // col_TotalPrice
        // 
        col_TotalPrice.HeaderText = "Thành tiền";
        col_TotalPrice.MinimumWidth = 12;
        col_TotalPrice.Name = "col_TotalPrice";
        col_TotalPrice.Width = 150;
        // 
        // col_Remove
        // 
        col_Remove.HeaderText = "Xóa";
        col_Remove.MinimumWidth = 12;
        col_Remove.Name = "col_Remove";
        col_Remove.Width = 70;
        // 
        // FormSell
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1643, 894);
        Controls.Add(pnl_top);
        Controls.Add(grp_Action);
        Controls.Add(dgv_cart);
        Controls.Add(groupBox3);
        Controls.Add(groupBox4);
        Margin = new System.Windows.Forms.Padding(6);
        Text = "Bán hàng";
        ((System.ComponentModel.ISupportInitialize)dgv_cart).EndInit();
        grp_Action.ResumeLayout(false);
        grp_Action.PerformLayout();
        pnl_top.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox4.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridViewTextBoxColumn col_productsName;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_serielsNumber;

    #endregion

    private System.Windows.Forms.DataGridView dgv_cart;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.GroupBox grp_Action;
    private System.Windows.Forms.Button btn_promotion;
    private System.Windows.Forms.Button btn_customer;
    private System.Windows.Forms.TextBox txt_searchProduct;
    private System.Windows.Forms.Panel pnl_top;
    private System.Windows.Forms.Button btn_todayInvoice;
    private System.Windows.Forms.Button btn_cancelInvoice;
    private System.Windows.Forms.Button btn_print;
    private System.Windows.Forms.Button btn_payment;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label lbl_subTotal;
    private System.Windows.Forms.Label lbl_discount;
    private System.Windows.Forms.Label lbl_finalTotal;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.ComboBox cbo_paymentMethod;
    private System.Windows.Forms.Button btn_confirmPayment;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_Quantity;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_UnitPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_TotalPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_Remove;
}