using System.ComponentModel;

namespace GUI
;

partial class FormSell
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        dgv_Cart = new DataGridView();
        col_ProductName = new DataGridViewTextBoxColumn();
        col_SerialNumber = new DataGridViewTextBoxColumn();
        col_Quantity = new DataGridViewTextBoxColumn();
        col_UnitPrice = new DataGridViewTextBoxColumn();
        col_TotalPrice = new DataGridViewTextBoxColumn();
        col_Remove = new DataGridViewTextBoxColumn();
        backgroundWorker1 = new BackgroundWorker();
        grp_Action = new GroupBox();
        btn_Promotion = new Button();
        btn_Customer = new Button();
        txt_SearchProduct = new TextBox();
        grp_Search = new GroupBox();
        btnTodayInvoice = new Button();
        btn_CancelInvoice = new Button();
        btn_Print = new Button();
        btn_Payment = new Button();
        lbl_FinalTotal = new Label();
        lbl_Discount = new Label();
        lbl_SubTotal = new Label();
        groupBox3 = new GroupBox();
        groupBox4 = new GroupBox();
        btn_ConfirmPayment = new Button();
        cbo_PaymentMethod = new ComboBox();
        ((ISupportInitialize)dgv_Cart).BeginInit();
        grp_Action.SuspendLayout();
        grp_Search.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox4.SuspendLayout();
        SuspendLayout();
        // 
        // dgv_Cart
        // 
        dgv_Cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_Cart.Columns.AddRange(new DataGridViewColumn[] { col_ProductName, col_SerialNumber, col_Quantity, col_UnitPrice, col_TotalPrice, col_Remove });
        dgv_Cart.Location = new Point(12, 227);
        dgv_Cart.Name = "dgv_Cart";
        dgv_Cart.RowHeadersWidth = 51;
        dgv_Cart.Size = new Size(812, 198);
        dgv_Cart.TabIndex = 4;
        dgv_Cart.CellContentClick += dgv_Cart_CellContentClick;
        // 
        // col_ProductName
        // 
        col_ProductName.HeaderText = "Tên SP\n";
        col_ProductName.MinimumWidth = 6;
        col_ProductName.Name = "col_ProductName";
        col_ProductName.Width = 125;
        // 
        // col_SerialNumber
        // 
        col_SerialNumber.HeaderText = "Serial";
        col_SerialNumber.MinimumWidth = 6;
        col_SerialNumber.Name = "col_SerialNumber";
        col_SerialNumber.Width = 125;
        // 
        // col_Quantity
        // 
        col_Quantity.HeaderText = "SL";
        col_Quantity.MinimumWidth = 6;
        col_Quantity.Name = "col_Quantity";
        col_Quantity.Width = 125;
        // 
        // col_UnitPrice
        // 
        col_UnitPrice.HeaderText = "Đơn giá\n";
        col_UnitPrice.MinimumWidth = 6;
        col_UnitPrice.Name = "col_UnitPrice";
        col_UnitPrice.Width = 125;
        // 
        // col_TotalPrice
        // 
        col_TotalPrice.HeaderText = "Thành tiền\n";
        col_TotalPrice.MinimumWidth = 6;
        col_TotalPrice.Name = "col_TotalPrice";
        col_TotalPrice.Width = 125;
        // 
        // col_Remove
        // 
        col_Remove.HeaderText = "Xóa";
        col_Remove.MinimumWidth = 6;
        col_Remove.Name = "col_Remove";
        col_Remove.Width = 125;
        // 
        // grp_Action
        // 
        grp_Action.Controls.Add(btn_Promotion);
        grp_Action.Controls.Add(btn_Customer);
        grp_Action.Controls.Add(txt_SearchProduct);
        grp_Action.Location = new Point(12, 108);
        grp_Action.Name = "grp_Action";
        grp_Action.Size = new Size(713, 100);
        grp_Action.TabIndex = 5;
        grp_Action.TabStop = false;
        // 
        // btn_Promotion
        // 
        btn_Promotion.Location = new Point(531, 29);
        btn_Promotion.Name = "btn_Promotion";
        btn_Promotion.Size = new Size(164, 51);
        btn_Promotion.TabIndex = 2;
        btn_Promotion.Text = "Mã KM";
        btn_Promotion.UseVisualStyleBackColor = true;
        btn_Promotion.Click += btn_Promotion_Click;
        // 
        // btn_Customer
        // 
        btn_Customer.Location = new Point(329, 29);
        btn_Customer.Name = "btn_Customer";
        btn_Customer.Size = new Size(164, 51);
        btn_Customer.TabIndex = 1;
        btn_Customer.Text = " Khách Hàng";
        btn_Customer.UseVisualStyleBackColor = true;
        // 
        // txt_SearchProduct
        // 
        txt_SearchProduct.Location = new Point(29, 41);
        txt_SearchProduct.Name = "txt_SearchProduct";
        txt_SearchProduct.Size = new Size(279, 27);
        txt_SearchProduct.TabIndex = 0;
        // 
        // grp_Search
        // 
        grp_Search.Controls.Add(btnTodayInvoice);
        grp_Search.Controls.Add(btn_CancelInvoice);
        grp_Search.Controls.Add(btn_Print);
        grp_Search.Controls.Add(btn_Payment);
        grp_Search.Location = new Point(12, 6);
        grp_Search.Name = "grp_Search";
        grp_Search.Size = new Size(713, 96);
        grp_Search.TabIndex = 6;
        grp_Search.TabStop = false;
        // 
        // btnTodayInvoice
        // 
        btnTodayInvoice.Location = new Point(513, 29);
        btnTodayInvoice.Name = "btnTodayInvoice";
        btnTodayInvoice.Size = new Size(161, 42);
        btnTodayInvoice.TabIndex = 13;
        btnTodayInvoice.Text = "Hóa Đơn Hôm Nay";
        btnTodayInvoice.UseVisualStyleBackColor = true;
        // 
        // btn_CancelInvoice
        // 
        btn_CancelInvoice.Location = new Point(329, 29);
        btn_CancelInvoice.Name = "btn_CancelInvoice";
        btn_CancelInvoice.Size = new Size(153, 42);
        btn_CancelInvoice.TabIndex = 12;
        btn_CancelInvoice.Text = "Hủy Hóa Đơn";
        btn_CancelInvoice.UseVisualStyleBackColor = true;
        // 
        // btn_Print
        // 
        btn_Print.Location = new Point(174, 29);
        btn_Print.Name = "btn_Print";
        btn_Print.Size = new Size(134, 42);
        btn_Print.TabIndex = 11;
        btn_Print.Text = "In Hóa Đơn";
        btn_Print.UseVisualStyleBackColor = true;
        // 
        // btn_Payment
        // 
        btn_Payment.Location = new Point(18, 29);
        btn_Payment.Name = "btn_Payment";
        btn_Payment.Size = new Size(132, 42);
        btn_Payment.TabIndex = 10;
        btn_Payment.Text = "Thanh Toán";
        btn_Payment.UseVisualStyleBackColor = true;
        // 
        // lbl_FinalTotal
        // 
        lbl_FinalTotal.AutoSize = true;
        lbl_FinalTotal.Location = new Point(19, 101);
        lbl_FinalTotal.Name = "lbl_FinalTotal";
        lbl_FinalTotal.Size = new Size(83, 20);
        lbl_FinalTotal.TabIndex = 6;
        lbl_FinalTotal.Text = "Tổng cộng:";
        // 
        // lbl_Discount
        // 
        lbl_Discount.AutoSize = true;
        lbl_Discount.Location = new Point(19, 59);
        lbl_Discount.Name = "lbl_Discount";
        lbl_Discount.Size = new Size(72, 20);
        lbl_Discount.TabIndex = 4;
        lbl_Discount.Text = "Giảm giá:\n";
        // 
        // lbl_SubTotal
        // 
        lbl_SubTotal.AutoSize = true;
        lbl_SubTotal.Location = new Point(19, 23);
        lbl_SubTotal.Name = "lbl_SubTotal";
        lbl_SubTotal.Size = new Size(70, 20);
        lbl_SubTotal.TabIndex = 2;
        lbl_SubTotal.Text = "Tạm tính:\n";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(lbl_SubTotal);
        groupBox3.Controls.Add(lbl_Discount);
        groupBox3.Controls.Add(lbl_FinalTotal);
        groupBox3.Location = new Point(12, 431);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(812, 137);
        groupBox3.TabIndex = 7;
        groupBox3.TabStop = false;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(btn_ConfirmPayment);
        groupBox4.Controls.Add(cbo_PaymentMethod);
        groupBox4.Location = new Point(12, 574);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(812, 164);
        groupBox4.TabIndex = 8;
        groupBox4.TabStop = false;
        groupBox4.Text = "groupBox4";
        // 
        // btn_ConfirmPayment
        // 
        btn_ConfirmPayment.Location = new Point(387, 37);
        btn_ConfirmPayment.Name = "btn_ConfirmPayment";
        btn_ConfirmPayment.Size = new Size(164, 51);
        btn_ConfirmPayment.TabIndex = 3;
        btn_ConfirmPayment.Text = "Xác Nhận Thanh Toán";
        btn_ConfirmPayment.UseVisualStyleBackColor = true;
        // 
        // cbo_PaymentMethod
        // 
        cbo_PaymentMethod.FormattingEnabled = true;
        cbo_PaymentMethod.Items.AddRange(new object[] { "Cash", "Banking", "Momo", "ZaloPay", "Credit Card" });
        cbo_PaymentMethod.Location = new Point(18, 49);
        cbo_PaymentMethod.Name = "cbo_PaymentMethod";
        cbo_PaymentMethod.Size = new Size(309, 28);
        cbo_PaymentMethod.TabIndex = 0;
        // 
        // FormSell
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1253, 750);
        Controls.Add(groupBox4);
        Controls.Add(groupBox3);
        Controls.Add(grp_Search);
        Controls.Add(grp_Action);
        Controls.Add(dgv_Cart);
        Name = "FormSell";
        Text = "FormSell";
        ((ISupportInitialize)dgv_Cart).EndInit();
        grp_Action.ResumeLayout(false);
        grp_Action.PerformLayout();
        grp_Search.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox4.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private DataGridView dgv_Cart;
    private BackgroundWorker backgroundWorker1;
    private GroupBox grp_Action;
    private GroupBox grp_Search;
    private Label lbl_FinalTotal;
    private Label lbl_Discount;
    private Label lbl_SubTotal;
    private Button btn_Print;
    private Button btn_Payment;
    private TextBox txt_SearchProduct;
    private Button btnTodayInvoice;
    private Button btn_CancelInvoice;
    private Button btn_Promotion;
    private Button btn_Customer;
    private DataGridViewTextBoxColumn col_ProductName;
    private DataGridViewTextBoxColumn col_SerialNumber;
    private DataGridViewTextBoxColumn col_Quantity;
    private DataGridViewTextBoxColumn col_UnitPrice;
    private DataGridViewTextBoxColumn col_TotalPrice;
    private DataGridViewTextBoxColumn col_Remove;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private ComboBox cbo_PaymentMethod;
    private Button btn_ConfirmPayment;
}