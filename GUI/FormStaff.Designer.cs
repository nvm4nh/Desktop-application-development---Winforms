namespace GUI
{
    partial class FormStaff
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_topBar = new Panel();
            btn_staffRefresh = new Button();
            btn_staffResetPass = new Button();
            btn_staffDisable = new Button();
            btn_staffEdit = new Button();
            btn_staffAdd = new Button();
            pnl_status = new Panel();
            lbl_statusSummary = new Label();
            pnl_left = new Panel();
            dgv_staffList = new DataGridView();
            pnl_right = new Panel();
            btn_staffCancel = new Button();
            btn_staffSave = new Button();
            cbb_role = new ComboBox();
            lbl_Role = new Label();
            txt_phone = new TextBox();
            lbl_Phone = new Label();
            txt_password = new TextBox();
            lbl_Password = new Label();
            txt_username = new TextBox();
            lbl_Username = new Label();
            txt_fullName = new TextBox();
            lbl_FullName = new Label();
            lbl_SectionTitle = new Label();
            groupBox1 = new GroupBox();
            pnl_topBar.SuspendLayout();
            pnl_status.SuspendLayout();
            pnl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_staffList).BeginInit();
            pnl_right.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_topBar
            // 
            pnl_topBar.Controls.Add(btn_staffRefresh);
            pnl_topBar.Controls.Add(btn_staffResetPass);
            pnl_topBar.Controls.Add(btn_staffDisable);
            pnl_topBar.Controls.Add(btn_staffEdit);
            pnl_topBar.Controls.Add(btn_staffAdd);
            pnl_topBar.Dock = DockStyle.Top;
            pnl_topBar.Location = new Point(0, 0);
            pnl_topBar.Margin = new Padding(6, 8, 6, 8);
            pnl_topBar.Name = "pnl_topBar";
            pnl_topBar.Size = new Size(1587, 102);
            pnl_topBar.TabIndex = 0;
            // 
            // btn_staffRefresh
            // 
            btn_staffRefresh.Location = new Point(1228, 12);
            btn_staffRefresh.Margin = new Padding(6, 8, 6, 8);
            btn_staffRefresh.Name = "btn_staffRefresh";
            btn_staffRefresh.Size = new Size(347, 63);
            btn_staffRefresh.TabIndex = 4;
            btn_staffRefresh.Text = "🔄 Làm mới";
            btn_staffRefresh.UseVisualStyleBackColor = true;
            btn_staffRefresh.Visible = false;
            btn_staffRefresh.Click += btn_StaffRefresh_Click;
            // 
            // btn_staffResetPass
            // 
            btn_staffResetPass.Location = new Point(1228, 12);
            btn_staffResetPass.Margin = new Padding(6, 8, 6, 8);
            btn_staffResetPass.Name = "btn_staffResetPass";
            btn_staffResetPass.Size = new Size(347, 63);
            btn_staffResetPass.TabIndex = 3;
            btn_staffResetPass.Text = "🔑 Đổi mật khẩu";
            btn_staffResetPass.UseVisualStyleBackColor = true;
            btn_staffResetPass.Click += btn_StaffResetPass_Click;
            // 
            // btn_staffDisable
            // 
            btn_staffDisable.Location = new Point(801, 12);
            btn_staffDisable.Margin = new Padding(6, 8, 6, 8);
            btn_staffDisable.Name = "btn_staffDisable";
            btn_staffDisable.Size = new Size(421, 63);
            btn_staffDisable.TabIndex = 2;
            btn_staffDisable.Text = "🔒 Vô hiệu hóa";
            btn_staffDisable.UseVisualStyleBackColor = true;
            btn_staffDisable.Click += btn_StaffDisable_Click;
            // 
            // btn_staffEdit
            // 
            btn_staffEdit.Location = new Point(393, 12);
            btn_staffEdit.Margin = new Padding(6, 8, 6, 8);
            btn_staffEdit.Name = "btn_staffEdit";
            btn_staffEdit.Size = new Size(402, 63);
            btn_staffEdit.TabIndex = 1;
            btn_staffEdit.Text = "✏️ Sửa";
            btn_staffEdit.UseVisualStyleBackColor = true;
            btn_staffEdit.Click += btn_StaffEdit_Click;
            // 
            // btn_staffAdd
            // 
            btn_staffAdd.Location = new Point(12, 12);
            btn_staffAdd.Margin = new Padding(6, 8, 6, 8);
            btn_staffAdd.Name = "btn_staffAdd";
            btn_staffAdd.Size = new Size(375, 63);
            btn_staffAdd.TabIndex = 0;
            btn_staffAdd.Text = "➕ Thêm NV";
            btn_staffAdd.UseVisualStyleBackColor = true;
            btn_staffAdd.Click += btn_StaffAdd_Click;
            // 
            // pnl_status
            // 
            pnl_status.Controls.Add(lbl_statusSummary);
            pnl_status.Dock = DockStyle.Bottom;
            pnl_status.Location = new Point(0, 848);
            pnl_status.Margin = new Padding(6, 8, 6, 8);
            pnl_status.Name = "pnl_status";
            pnl_status.Size = new Size(1587, 102);
            pnl_status.TabIndex = 1;
            // 
            // lbl_statusSummary
            // 
            lbl_statusSummary.AutoSize = true;
            lbl_statusSummary.Location = new Point(26, 30);
            lbl_statusSummary.Margin = new Padding(6, 0, 6, 0);
            lbl_statusSummary.Name = "lbl_statusSummary";
            lbl_statusSummary.Size = new Size(524, 41);
            lbl_statusSummary.TabIndex = 0;
            lbl_statusSummary.Text = "Tổng: 0 nhân viên | Đang chọn: Không";
            // 
            // pnl_left
            // 
            pnl_left.Controls.Add(groupBox1);
            pnl_left.Controls.Add(dgv_staffList);
            pnl_left.Dock = DockStyle.Left;
            pnl_left.Location = new Point(0, 102);
            pnl_left.Margin = new Padding(6, 8, 6, 8);
            pnl_left.Name = "pnl_left";
            pnl_left.Size = new Size(640, 746);
            pnl_left.TabIndex = 2;
            // 
            // dgv_staffList
            // 
            dgv_staffList.ColumnHeadersHeight = 58;
            dgv_staffList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_staffList.Dock = DockStyle.Fill;
            dgv_staffList.Location = new Point(0, 0);
            dgv_staffList.Margin = new Padding(6, 8, 6, 8);
            dgv_staffList.Name = "dgv_staffList";
            dgv_staffList.RowHeadersWidth = 102;
            dgv_staffList.Size = new Size(640, 746);
            dgv_staffList.TabIndex = 0;
            dgv_staffList.CellClick += dgv_StaffList_CellClick;
            dgv_staffList.CellFormatting += dgv_StaffList_CellFormatting;
            // 
            // pnl_right
            // 
            pnl_right.Controls.Add(btn_staffCancel);
            pnl_right.Controls.Add(btn_staffSave);
            pnl_right.Controls.Add(cbb_role);
            pnl_right.Controls.Add(lbl_Role);
            pnl_right.Controls.Add(txt_phone);
            pnl_right.Controls.Add(lbl_Phone);
            pnl_right.Controls.Add(txt_password);
            pnl_right.Controls.Add(lbl_Password);
            pnl_right.Controls.Add(txt_username);
            pnl_right.Controls.Add(lbl_Username);
            pnl_right.Controls.Add(txt_fullName);
            pnl_right.Controls.Add(lbl_FullName);
            pnl_right.Controls.Add(lbl_SectionTitle);
            pnl_right.Dock = DockStyle.Fill;
            pnl_right.Location = new Point(640, 102);
            pnl_right.Margin = new Padding(6, 8, 6, 8);
            pnl_right.Name = "pnl_right";
            pnl_right.Padding = new Padding(6);
            pnl_right.Size = new Size(947, 746);
            pnl_right.TabIndex = 3;
            // 
            // btn_staffCancel
            // 
            btn_staffCancel.Location = new Point(478, 635);
            btn_staffCancel.Margin = new Padding(6, 8, 6, 8);
            btn_staffCancel.Name = "btn_staffCancel";
            btn_staffCancel.Size = new Size(457, 64);
            btn_staffCancel.TabIndex = 12;
            btn_staffCancel.Text = "❌ Hủy";
            btn_staffCancel.UseVisualStyleBackColor = true;
            btn_staffCancel.Click += btn_StaffCancel_Click;
            // 
            // btn_staffSave
            // 
            btn_staffSave.Location = new Point(6, 635);
            btn_staffSave.Margin = new Padding(6, 8, 6, 8);
            btn_staffSave.Name = "btn_staffSave";
            btn_staffSave.Size = new Size(466, 64);
            btn_staffSave.TabIndex = 11;
            btn_staffSave.Text = "💾 Lưu";
            btn_staffSave.UseVisualStyleBackColor = true;
            btn_staffSave.Click += btn_StaffSave_Click;
            // 
            // cbb_role
            // 
            cbb_role.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_role.FormattingEnabled = true;
            cbb_role.Items.AddRange(new object[] { "Admin", "Quản lý", "Thu ngân", "Kho", "Kỹ thuật" });
            cbb_role.Location = new Point(6, 566);
            cbb_role.Margin = new Padding(6, 8, 6, 8);
            cbb_role.Name = "cbb_role";
            cbb_role.Size = new Size(929, 49);
            cbb_role.TabIndex = 10;
            // 
            // lbl_Role
            // 
            lbl_Role.Location = new Point(6, 517);
            lbl_Role.Name = "lbl_Role";
            lbl_Role.Size = new Size(314, 46);
            lbl_Role.TabIndex = 9;
            lbl_Role.Text = "Vai trò:";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(6, 455);
            txt_phone.Margin = new Padding(6, 8, 6, 8);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(929, 47);
            txt_phone.TabIndex = 8;
            // 
            // lbl_Phone
            // 
            lbl_Phone.Location = new Point(6, 406);
            lbl_Phone.Name = "lbl_Phone";
            lbl_Phone.Size = new Size(314, 46);
            lbl_Phone.TabIndex = 7;
            lbl_Phone.Text = "Số điện thoại:";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(6, 344);
            txt_password.Margin = new Padding(6, 8, 6, 8);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(929, 47);
            txt_password.TabIndex = 6;
            txt_password.UseSystemPasswordChar = true;
            // 
            // lbl_Password
            // 
            lbl_Password.Location = new Point(6, 295);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(314, 46);
            lbl_Password.TabIndex = 5;
            lbl_Password.Text = "Mật khẩu *:";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(6, 233);
            txt_username.Margin = new Padding(6, 8, 6, 8);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(929, 47);
            txt_username.TabIndex = 4;
            // 
            // lbl_Username
            // 
            lbl_Username.Location = new Point(6, 184);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(314, 46);
            lbl_Username.TabIndex = 3;
            lbl_Username.Text = "Tài khoản *:";
            // 
            // txt_fullName
            // 
            txt_fullName.Location = new Point(6, 122);
            txt_fullName.Margin = new Padding(6, 8, 6, 8);
            txt_fullName.Name = "txt_fullName";
            txt_fullName.Size = new Size(929, 47);
            txt_fullName.TabIndex = 2;
            // 
            // lbl_FullName
            // 
            lbl_FullName.Location = new Point(6, 73);
            lbl_FullName.Name = "lbl_FullName";
            lbl_FullName.Size = new Size(314, 46);
            lbl_FullName.TabIndex = 1;
            lbl_FullName.Text = "Họ tên *:";
            // 
            // lbl_SectionTitle
            // 
            lbl_SectionTitle.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lbl_SectionTitle.Location = new Point(6, 12);
            lbl_SectionTitle.Name = "lbl_SectionTitle";
            lbl_SectionTitle.Size = new Size(935, 46);
            lbl_SectionTitle.TabIndex = 0;
            lbl_SectionTitle.Text = "👤 Thông tin nhân viên";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(268, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 250);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // FormStaff
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1587, 950);
            Controls.Add(pnl_right);
            Controls.Add(pnl_left);
            Controls.Add(pnl_status);
            Controls.Add(pnl_topBar);
            Margin = new Padding(6, 8, 6, 8);
            Name = "FormStaff";
            Text = "Quản lý nhân viên";
            Load += FormStaff_Load;
            pnl_topBar.ResumeLayout(false);
            pnl_status.ResumeLayout(false);
            pnl_status.PerformLayout();
            pnl_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_staffList).EndInit();
            pnl_right.ResumeLayout(false);
            pnl_right.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Button btn_staffAdd;
        private System.Windows.Forms.Button btn_staffEdit;
        private System.Windows.Forms.Button btn_staffDisable;
        private System.Windows.Forms.Button btn_staffResetPass;
        private System.Windows.Forms.Button btn_staffRefresh;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.Label lbl_statusSummary;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.DataGridView dgv_staffList;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Label lbl_SectionTitle;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.TextBox txt_fullName;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.ComboBox cbb_role;
        private System.Windows.Forms.Button btn_staffSave;
        private System.Windows.Forms.Button btn_staffCancel;
        private GroupBox groupBox1;
    }
}