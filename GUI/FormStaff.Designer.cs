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

        private void InitializeComponent()
        {
            this.pnl_TopBar = new System.Windows.Forms.Panel();
            this.btn_StaffRefresh = new System.Windows.Forms.Button();
            this.btn_StaffResetPass = new System.Windows.Forms.Button();
            this.btn_StaffDisable = new System.Windows.Forms.Button();
            this.btn_StaffEdit = new System.Windows.Forms.Button();
            this.btn_StaffAdd = new System.Windows.Forms.Button();
            this.pnl_Left = new System.Windows.Forms.Panel();
            this.dgv_StaffList = new System.Windows.Forms.DataGridView();
            this.pnl_Right = new System.Windows.Forms.Panel();
            this.btn_StaffCancel = new System.Windows.Forms.Button();
            this.btn_StaffSave = new System.Windows.Forms.Button();
            this.cb_Role = new System.Windows.Forms.ComboBox();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_SectionTitle = new System.Windows.Forms.Label();
            this.pnl_TopBar.SuspendLayout();
            this.pnl_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StaffList)).BeginInit();
            this.pnl_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TopBar
            // 
            this.pnl_TopBar.Controls.Add(this.btn_StaffRefresh);
            this.pnl_TopBar.Controls.Add(this.btn_StaffResetPass);
            this.pnl_TopBar.Controls.Add(this.btn_StaffDisable);
            this.pnl_TopBar.Controls.Add(this.btn_StaffEdit);
            this.pnl_TopBar.Controls.Add(this.btn_StaffAdd);
            this.pnl_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopBar.Name = "pnl_TopBar";
            this.pnl_TopBar.Size = new System.Drawing.Size(984, 60);
            this.pnl_TopBar.TabIndex = 0;
            // 
            // btn_StaffRefresh
            // 
            this.btn_StaffRefresh.Location = new System.Drawing.Point(540, 15);
            this.btn_StaffRefresh.Name = "btn_StaffRefresh";
            this.btn_StaffRefresh.Size = new System.Drawing.Size(100, 30);
            this.btn_StaffRefresh.TabIndex = 4;
            this.btn_StaffRefresh.Text = "Làm mới";
            this.btn_StaffRefresh.UseVisualStyleBackColor = true;
            this.btn_StaffRefresh.Click += new System.EventHandler(this.btn_StaffRefresh_Click);
            // 
            // btn_StaffResetPass
            // 
            this.btn_StaffResetPass.Location = new System.Drawing.Point(400, 15);
            this.btn_StaffResetPass.Name = "btn_StaffResetPass";
            this.btn_StaffResetPass.Size = new System.Drawing.Size(120, 30);
            this.btn_StaffResetPass.TabIndex = 3;
            this.btn_StaffResetPass.Text = "Đổi mật khẩu";
            this.btn_StaffResetPass.UseVisualStyleBackColor = true;
            this.btn_StaffResetPass.Click += new System.EventHandler(this.btn_StaffResetPass_Click);
            // 
            // btn_StaffDisable
            // 
            this.btn_StaffDisable.Location = new System.Drawing.Point(260, 15);
            this.btn_StaffDisable.Name = "btn_StaffDisable";
            this.btn_StaffDisable.Size = new System.Drawing.Size(120, 30);
            this.btn_StaffDisable.TabIndex = 2;
            this.btn_StaffDisable.Text = "Vô hiệu hóa";
            this.btn_StaffDisable.UseVisualStyleBackColor = true;
            this.btn_StaffDisable.Click += new System.EventHandler(this.btn_StaffDisable_Click);
            // 
            // btn_StaffEdit
            // 
            this.btn_StaffEdit.Location = new System.Drawing.Point(140, 15);
            this.btn_StaffEdit.Name = "btn_StaffEdit";
            this.btn_StaffEdit.Size = new System.Drawing.Size(100, 30);
            this.btn_StaffEdit.TabIndex = 1;
            this.btn_StaffEdit.Text = "- Sửa";
            this.btn_StaffEdit.UseVisualStyleBackColor = true;
            this.btn_StaffEdit.Click += new System.EventHandler(this.btn_StaffEdit_Click);
            // 
            // btn_StaffAdd
            // 
            this.btn_StaffAdd.Location = new System.Drawing.Point(20, 15);
            this.btn_StaffAdd.Name = "btn_StaffAdd";
            this.btn_StaffAdd.Size = new System.Drawing.Size(100, 30);
            this.btn_StaffAdd.TabIndex = 0;
            this.btn_StaffAdd.Text = "+ Thêm NV";
            this.btn_StaffAdd.UseVisualStyleBackColor = true;
            this.btn_StaffAdd.Click += new System.EventHandler(this.btn_StaffAdd_Click);
            // 
            // pnl_Left
            // 
            this.pnl_Left.Controls.Add(this.dgv_StaffList);
            this.pnl_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Left.Location = new System.Drawing.Point(0, 60);
            this.pnl_Left.Name = "pnl_Left";
            this.pnl_Left.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Left.Size = new System.Drawing.Size(684, 501);
            this.pnl_Left.TabIndex = 1;
            // 
            // dgv_StaffList
            // 
            this.dgv_StaffList.AllowUserToAddRows = false;
            this.dgv_StaffList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_StaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StaffList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_StaffList.Location = new System.Drawing.Point(10, 10);
            this.dgv_StaffList.Name = "dgv_StaffList";
            this.dgv_StaffList.ReadOnly = true;
            this.dgv_StaffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_StaffList.Size = new System.Drawing.Size(664, 481);
            this.dgv_StaffList.TabIndex = 0;
            this.dgv_StaffList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StaffList_CellClick);
            this.dgv_StaffList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_StaffList_CellFormatting);
            // 
            // pnl_Right
            // 
            this.pnl_Right.BackColor = System.Drawing.Color.White;
            this.pnl_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Right.Controls.Add(this.btn_StaffCancel);
            this.pnl_Right.Controls.Add(this.btn_StaffSave);
            this.pnl_Right.Controls.Add(this.cb_Role);
            this.pnl_Right.Controls.Add(this.lbl_Role);
            this.pnl_Right.Controls.Add(this.txt_Phone);
            this.pnl_Right.Controls.Add(this.lbl_Phone);
            this.pnl_Right.Controls.Add(this.txt_Password);
            this.pnl_Right.Controls.Add(this.lbl_Password);
            this.pnl_Right.Controls.Add(this.txt_Username);
            this.pnl_Right.Controls.Add(this.lbl_Username);
            this.pnl_Right.Controls.Add(this.txt_FullName);
            this.pnl_Right.Controls.Add(this.lbl_FullName);
            this.pnl_Right.Controls.Add(this.lbl_SectionTitle);
            this.pnl_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Right.Location = new System.Drawing.Point(684, 60);
            this.pnl_Right.Name = "pnl_Right";
            this.pnl_Right.Size = new System.Drawing.Size(300, 501);
            this.pnl_Right.TabIndex = 2;
            // 
            // btn_StaffCancel
            // 
            this.btn_StaffCancel.Location = new System.Drawing.Point(155, 410);
            this.btn_StaffCancel.Name = "btn_StaffCancel";
            this.btn_StaffCancel.Size = new System.Drawing.Size(100, 35);
            this.btn_StaffCancel.TabIndex = 12;
            this.btn_StaffCancel.Text = "Hủy";
            this.btn_StaffCancel.UseVisualStyleBackColor = true;
            this.btn_StaffCancel.Click += new System.EventHandler(this.btn_StaffCancel_Click);
            // 
            // btn_StaffSave
            // 
            this.btn_StaffSave.Location = new System.Drawing.Point(40, 410);
            this.btn_StaffSave.Name = "btn_StaffSave";
            this.btn_StaffSave.Size = new System.Drawing.Size(100, 35);
            this.btn_StaffSave.TabIndex = 11;
            this.btn_StaffSave.Text = "Lưu";
            this.btn_StaffSave.UseVisualStyleBackColor = true;
            this.btn_StaffSave.Click += new System.EventHandler(this.btn_StaffSave_Click);
            // 
            // cb_Role
            // 
            this.cb_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Items.AddRange(new object[] {
            "Admin",
            "Quản lý",
            "Thu ngân",
            "Kho",
            "Kỹ thuật"});
            this.cb_Role.Location = new System.Drawing.Point(20, 350);
            this.cb_Role.Name = "cb_Role";
            this.cb_Role.Size = new System.Drawing.Size(255, 24);
            this.cb_Role.TabIndex = 10;
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Location = new System.Drawing.Point(17, 330);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(48, 16);
            this.lbl_Role.TabIndex = 9;
            this.lbl_Role.Text = "Vai trò:";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(20, 280);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(255, 27);
            this.txt_Phone.TabIndex = 8;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(17, 260);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(88, 16);
            this.lbl_Phone.TabIndex = 7;
            this.lbl_Phone.Text = "Số điện thoại:";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(20, 210);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(255, 27);
            this.txt_Password.TabIndex = 6;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(17, 190);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(64, 16);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Mật khẩu:";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(20, 140);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(255, 27);
            this.txt_Username.TabIndex = 4;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(17, 120);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(76, 16);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "Tài khoản *:";
            // 
            // txt_FullName
            // 
            this.txt_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FullName.Location = new System.Drawing.Point(20, 70);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(255, 27);
            this.txt_FullName.TabIndex = 2;
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Location = new System.Drawing.Point(17, 50);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(55, 16);
            this.lbl_FullName.TabIndex = 1;
            this.lbl_FullName.Text = "Họ tên *:";
            // 
            // lbl_SectionTitle
            // 
            this.lbl_SectionTitle.AutoSize = true;
            this.lbl_SectionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SectionTitle.Location = new System.Drawing.Point(16, 15);
            this.lbl_SectionTitle.Name = "lbl_SectionTitle";
            this.lbl_SectionTitle.Size = new System.Drawing.Size(176, 20);
            this.lbl_SectionTitle.TabIndex = 0;
            this.lbl_SectionTitle.Text = "Thông tin nhân viên";
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnl_Left);
            this.Controls.Add(this.pnl_Right);
            this.Controls.Add(this.pnl_TopBar);
            this.Name = "FormStaff";
            this.Text = "FormStaff - Quản lý nhân viên";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            this.pnl_TopBar.ResumeLayout(false);
            this.pnl_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StaffList)).EndInit();
            this.pnl_Right.ResumeLayout(false);
            this.pnl_Right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_TopBar;
        private System.Windows.Forms.Button btn_StaffAdd;
        private System.Windows.Forms.Button btn_StaffEdit;
        private System.Windows.Forms.Button btn_StaffDisable;
        private System.Windows.Forms.Button btn_StaffResetPass;
        private System.Windows.Forms.Button btn_StaffRefresh;
        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.DataGridView dgv_StaffList;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.Label lbl_SectionTitle;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.ComboBox cb_Role;
        private System.Windows.Forms.Button btn_StaffSave;
        private System.Windows.Forms.Button btn_StaffCancel;
    }
}