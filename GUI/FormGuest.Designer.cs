using System.ComponentModel;

namespace GUI;

partial class FormGuest
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
        mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
        dgv_Guest = new DataGridView();
        btn_AddCustomer = new Button();
        btn_Edit = new Button();
        btn_PurchaseHistory = new Button();
        btn_Refresh = new Button();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        label1 = new Label();
        groupBox3 = new GroupBox();
        txt_Search = new TextBox();
        col_Phone = new DataGridViewTextBoxColumn();
        col_Name = new DataGridViewTextBoxColumn();
        col_Type = new DataGridViewTextBoxColumn();
        col_Point = new DataGridViewTextBoxColumn();
        col_Total = new DataGridViewTextBoxColumn();
        col_Date = new DataGridViewTextBoxColumn();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        btn_Save = new Button();
        btn_Cancel = new Button();
        cbo_CustomerType = new ComboBox();
        txt_Address = new TextBox();
        txt_FullName = new TextBox();
        txt_PhoneNumber = new TextBox();
        ((ISupportInitialize)dgv_Guest).BeginInit();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // mySqlCommand1
        // 
        mySqlCommand1.CacheAge = 0;
        mySqlCommand1.Connection = null;
        mySqlCommand1.EnableCaching = false;
        mySqlCommand1.Transaction = null;
        // 
        // dgv_Guest
        // 
        dgv_Guest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_Guest.Columns.AddRange(new DataGridViewColumn[] { col_Phone, col_Name, col_Type, col_Point, col_Total, col_Date });
        dgv_Guest.Location = new Point(8, 93);
        dgv_Guest.Margin = new Padding(1);
        dgv_Guest.Name = "dgv_Guest";
        dgv_Guest.RowHeadersWidth = 51;
        dgv_Guest.Size = new Size(752, 319);
        dgv_Guest.TabIndex = 1;
        // 
        // btn_AddCustomer
        // 
        btn_AddCustomer.Location = new Point(19, 43);
        btn_AddCustomer.Name = "btn_AddCustomer";
        btn_AddCustomer.Size = new Size(140, 54);
        btn_AddCustomer.TabIndex = 2;
        btn_AddCustomer.Text = "Thêm KH";
        btn_AddCustomer.UseVisualStyleBackColor = true;
        // 
        // btn_Edit
        // 
        btn_Edit.Location = new Point(175, 43);
        btn_Edit.Name = "btn_Edit";
        btn_Edit.Size = new Size(140, 54);
        btn_Edit.TabIndex = 3;
        btn_Edit.Text = "Sửa";
        btn_Edit.UseVisualStyleBackColor = true;
        btn_Edit.Click += btn_Edit_Click;
        // 
        // btn_PurchaseHistory
        // 
        btn_PurchaseHistory.Location = new Point(333, 43);
        btn_PurchaseHistory.Name = "btn_PurchaseHistory";
        btn_PurchaseHistory.Size = new Size(140, 54);
        btn_PurchaseHistory.TabIndex = 4;
        btn_PurchaseHistory.Text = "Lịch sử mua";
        btn_PurchaseHistory.UseVisualStyleBackColor = true;
        // 
        // btn_Refresh
        // 
        btn_Refresh.Location = new Point(498, 43);
        btn_Refresh.Name = "btn_Refresh";
        btn_Refresh.Size = new Size(140, 54);
        btn_Refresh.TabIndex = 5;
        btn_Refresh.Text = "Làm mới";
        btn_Refresh.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btn_AddCustomer);
        groupBox1.Controls.Add(btn_Refresh);
        groupBox1.Controls.Add(btn_Edit);
        groupBox1.Controls.Add(btn_PurchaseHistory);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(659, 131);
        groupBox1.TabIndex = 6;
        groupBox1.TabStop = false;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(txt_Search);
        groupBox2.Controls.Add(label1);
        groupBox2.Controls.Add(dgv_Guest);
        groupBox2.Location = new Point(12, 149);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(764, 549);
        groupBox2.TabIndex = 7;
        groupBox2.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(28, 34);
        label1.Name = "label1";
        label1.Size = new Size(72, 20);
        label1.TabIndex = 0;
        label1.Text = "Tìm Kiếm";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(txt_PhoneNumber);
        groupBox3.Controls.Add(txt_FullName);
        groupBox3.Controls.Add(txt_Address);
        groupBox3.Controls.Add(cbo_CustomerType);
        groupBox3.Controls.Add(btn_Save);
        groupBox3.Controls.Add(btn_Cancel);
        groupBox3.Controls.Add(label6);
        groupBox3.Controls.Add(label5);
        groupBox3.Controls.Add(label4);
        groupBox3.Controls.Add(label3);
        groupBox3.Controls.Add(label2);
        groupBox3.Location = new Point(795, 26);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(334, 554);
        groupBox3.TabIndex = 8;
        groupBox3.TabStop = false;
        groupBox3.Text = "groupBox3";
        // 
        // txt_Search
        // 
        txt_Search.Location = new Point(106, 34);
        txt_Search.Name = "txt_Search";
        txt_Search.Size = new Size(311, 27);
        txt_Search.TabIndex = 2;
        txt_Search.Text = "🔍 Tìm theo SĐT, tên khách hàng...";
        // 
        // col_Phone
        // 
        col_Phone.HeaderText = "SĐT";
        col_Phone.MinimumWidth = 6;
        col_Phone.Name = "col_Phone";
        col_Phone.Width = 125;
        // 
        // col_Name
        // 
        col_Name.HeaderText = "Họ tên";
        col_Name.MinimumWidth = 6;
        col_Name.Name = "col_Name";
        col_Name.Width = 125;
        // 
        // col_Type
        // 
        col_Type.HeaderText = "Loại KH";
        col_Type.MinimumWidth = 6;
        col_Type.Name = "col_Type";
        col_Type.Width = 125;
        // 
        // col_Point
        // 
        col_Point.HeaderText = "Điểm tích lũy";
        col_Point.MinimumWidth = 6;
        col_Point.Name = "col_Point";
        col_Point.Width = 125;
        // 
        // col_Total
        // 
        col_Total.HeaderText = "Tổng mua";
        col_Total.MinimumWidth = 6;
        col_Total.Name = "col_Total";
        col_Total.Width = 125;
        // 
        // col_Date
        // 
        col_Date.HeaderText = "Ngày tạo";
        col_Date.MinimumWidth = 6;
        col_Date.Name = "col_Date";
        col_Date.Width = 125;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(20, 29);
        label2.Name = "label2";
        label2.Size = new Size(187, 20);
        label2.TabIndex = 3;
        label2.Text = "THÔNG TIN KHÁCH HÀNG";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(20, 63);
        label3.Name = "label3";
        label3.Size = new Size(36, 20);
        label3.TabIndex = 4;
        label3.Text = "SĐT";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(20, 148);
        label4.Name = "label4";
        label4.Size = new Size(56, 20);
        label4.TabIndex = 5;
        label4.Text = "Họ Tên";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(20, 216);
        label5.Name = "label5";
        label5.Size = new Size(57, 20);
        label5.TabIndex = 6;
        label5.Text = "Địa Chỉ";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(20, 285);
        label6.Name = "label6";
        label6.Size = new Size(81, 20);
        label6.TabIndex = 7;
        label6.Text = "Loại Khách";
        // 
        // btn_Save
        // 
        btn_Save.Location = new Point(20, 459);
        btn_Save.Name = "btn_Save";
        btn_Save.Size = new Size(140, 54);
        btn_Save.TabIndex = 6;
        btn_Save.Text = "Lưu";
        btn_Save.UseVisualStyleBackColor = true;
        // 
        // btn_Cancel
        // 
        btn_Cancel.Location = new Point(188, 459);
        btn_Cancel.Name = "btn_Cancel";
        btn_Cancel.Size = new Size(140, 54);
        btn_Cancel.TabIndex = 7;
        btn_Cancel.Text = "Hủy";
        btn_Cancel.UseVisualStyleBackColor = true;
        // 
        // cbo_CustomerType
        // 
        cbo_CustomerType.FormattingEnabled = true;
        cbo_CustomerType.Items.AddRange(new object[] { "Thường", "Thân thiết", "VIP" });
        cbo_CustomerType.Location = new Point(20, 328);
        cbo_CustomerType.Name = "cbo_CustomerType";
        cbo_CustomerType.Size = new Size(246, 28);
        cbo_CustomerType.TabIndex = 8;
        // 
        // txt_Address
        // 
        txt_Address.Location = new Point(20, 239);
        txt_Address.Name = "txt_Address";
        txt_Address.Size = new Size(267, 27);
        txt_Address.TabIndex = 3;
        // 
        // txt_FullName
        // 
        txt_FullName.Location = new Point(20, 171);
        txt_FullName.Name = "txt_FullName";
        txt_FullName.Size = new Size(267, 27);
        txt_FullName.TabIndex = 9;
        // 
        // txt_PhoneNumber
        // 
        txt_PhoneNumber.Location = new Point(20, 90);
        txt_PhoneNumber.Name = "txt_PhoneNumber";
        txt_PhoneNumber.Size = new Size(267, 27);
        txt_PhoneNumber.TabIndex = 10;
        // 
        // FormGuest
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1320, 690);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Name = "FormGuest";
        Text = "FormGuest";
        Load += FormGuest_Load;
        ((ISupportInitialize)dgv_Guest).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    private DataGridView dgv_Guest;
    private Button btn_AddCustomer;
    private Button btn_Edit;
    private Button btn_PurchaseHistory;
    private Button btn_Refresh;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private Label label1;
    private GroupBox groupBox3;
    private DataGridViewTextBoxColumn col_Phone;
    private DataGridViewTextBoxColumn col_Name;
    private DataGridViewTextBoxColumn col_Type;
    private DataGridViewTextBoxColumn col_Point;
    private DataGridViewTextBoxColumn col_Total;
    private DataGridViewTextBoxColumn col_Date;
    private TextBox txt_Search;
    private Label label3;
    private Label label2;
    private Label label4;
    private TextBox txt_PhoneNumber;
    private TextBox txt_FullName;
    private TextBox txt_Address;
    private ComboBox cbo_CustomerType;
    private Button btn_Save;
    private Button btn_Cancel;
    private Label label6;
    private Label label5;
}