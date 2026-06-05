using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormStaff : Form
    {
        private readonly UsersBUS _userBUS = new UsersBUS();

        private int _selectedUserID = -1;
        private bool _isAdding = false; // Cờ kiểm tra đang ở chế độ Thêm mới hay Sửa

        public FormStaff()
        {
            InitializeComponent();
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            LoadData();
            SetInputState(false); // Khóa form bên phải khi mới mở lên
        }

        private void LoadData()
        {
            List<UsersDTO> list = _userBUS.GetAll();
            dgv_StaffList.DataSource = list;

            // Ẩn cột mật khẩu và format lại giao diện lưới
            if (dgv_StaffList.Columns["Password"] != null)
                dgv_StaffList.Columns["Password"].Visible = false;

            if (dgv_StaffList.Columns["CreatedAt"] != null)
                dgv_StaffList.Columns["CreatedAt"].Visible = false;

            // Đổi tên Header cho chuẩn layout
            if (dgv_StaffList.Columns["UserID"] != null) dgv_StaffList.Columns["UserID"].HeaderText = "Mã NV";
            if (dgv_StaffList.Columns["FullName"] != null) dgv_StaffList.Columns["FullName"].HeaderText = "Họ tên";
            if (dgv_StaffList.Columns["Username"] != null) dgv_StaffList.Columns["Username"].HeaderText = "Tài khoản";
            if (dgv_StaffList.Columns["Phone"] != null) dgv_StaffList.Columns["Phone"].HeaderText = "SĐT";

            // Xóa rác lựa chọn
            dgv_StaffList.ClearSelection();
            _selectedUserID = -1;
        }

        // Đổ màu cột Trạng Thái (Xanh: Hoạt động / Đỏ: Vô hiệu) và dịch RoleID sang chữ
        private void dgv_StaffList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_StaffList.Columns[e.ColumnIndex].Name == "IsActive" && e.Value != null)
            {
                bool isActive = (bool)e.Value;
                e.Value = isActive ? "Hoạt động" : "Vô hiệu";
                e.CellStyle.ForeColor = isActive ? Color.Green : Color.Red;
                e.FormattingApplied = true;
            }
            else if (dgv_StaffList.Columns[e.ColumnIndex].Name == "RoleID" && e.Value != null)
            {
                int roleId = (int)e.Value;
                e.Value = GetRoleName(roleId);
                e.FormattingApplied = true;
            }
        }

        private void dgv_StaffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !_isAdding)
            {
                DataGridViewRow row = dgv_StaffList.Rows[e.RowIndex];

                _selectedUserID = Convert.ToInt32(row.Cells["UserID"].Value);
                txt_FullName.Text = row.Cells["FullName"].Value?.ToString();
                txt_Username.Text = row.Cells["Username"].Value?.ToString();
                txt_Phone.Text = row.Cells["Phone"].Value?.ToString();
                txt_Password.Text = "******"; // Chỉ hiển thị giả để bảo mật

                int roleId = Convert.ToInt32(row.Cells["RoleID"].Value);
                cb_Role.Text = GetRoleName(roleId);
            }
        }

        // --- CÁC HÀM XỬ LÝ TRẠNG THÁI GIAO DIỆN ---

        private void SetInputState(bool isEnabled)
        {
            // Bật/tắt các textbox bên phải
            txt_FullName.Enabled = isEnabled;
            txt_Username.Enabled = isEnabled;
            txt_Password.Enabled = isEnabled;
            txt_Phone.Enabled = isEnabled;
            cb_Role.Enabled = isEnabled;

            // Bật/tắt nút Lưu/Hủy
            btn_StaffSave.Enabled = isEnabled;
            btn_StaffCancel.Enabled = isEnabled;

            // Bật tắt các nút chức năng bên trên
            btn_StaffAdd.Enabled = !isEnabled;
            btn_StaffEdit.Enabled = !isEnabled;
            btn_StaffDisable.Enabled = !isEnabled;
            btn_StaffResetPass.Enabled = !isEnabled;
            dgv_StaffList.Enabled = !isEnabled;
        }

        private void ClearInputs()
        {
            txt_FullName.Clear();
            txt_Username.Clear();
            txt_Password.Clear();
            txt_Phone.Clear();
            cb_Role.SelectedIndex = -1;
        }

        // --- CHỨC NĂNG BUTTON TRÊN TOOLBAR ---

        private void btn_StaffAdd_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            ClearInputs();
            SetInputState(true);
            cb_Role.SelectedIndex = 1; // Default chọn Quản lý / Thu ngân
            txt_Username.Focus();
        }

        private void btn_StaffEdit_Click(object sender, EventArgs e)
        {
            if (_selectedUserID == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _isAdding = false;
            SetInputState(true);
            txt_Username.Enabled = false; // Không cho sửa Username (Quy chuẩn chung)
            txt_Password.Enabled = false; // Sửa pass phải dùng nút Đổi mật khẩu
        }

        private void btn_StaffRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearInputs();
            SetInputState(false);
        }

        private void btn_StaffCancel_Click(object sender, EventArgs e)
        {
            _isAdding = false;
            ClearInputs();
            SetInputState(false);
        }

        private void btn_StaffSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_FullName.Text) || string.IsNullOrWhiteSpace(txt_Username.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ Họ tên và Tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new UsersDTO
            {
                FullName = txt_FullName.Text,
                Username = txt_Username.Text,
                Phone = txt_Phone.Text,
                RoleID = GetRoleID(cb_Role.Text),
                IsActive = true // Mặc định khi tạo mới/sửa là hoạt động
            };

            bool success;
            string error;

            if (_isAdding)
            {
                user.Password = string.IsNullOrWhiteSpace(txt_Password.Text) ? "123456" : txt_Password.Text; // Mặc định nếu k nhập
                (success, error) = _userBUS.Insert(user);
            }
            else
            {
                user.UserID = _selectedUserID;
                // Giữ nguyên Password cũ bằng cách không map (Nếu backend của bạn bắt buộc, hãy gọi DB lấy lại pass cũ)
                // Hoặc giả sử Update không đổi pass nếu chuỗi rỗng
                (success, error) = _userBUS.Update(user);
            }

            if (success)
            {
                MessageBox.Show(_isAdding ? "Thêm mới thành công!" : "Sửa thông tin thành công!", "Thông báo");
                btn_StaffRefresh_Click(null, null); // Tải lại form
            }
            else
            {
                MessageBox.Show("Lỗi: " + error, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_StaffDisable_Click(object sender, EventArgs e)
        {
            if (_selectedUserID == -1) return;

            if (MessageBox.Show("Bạn có chắc muốn vô hiệu hóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Dùng hàm Update để đè IsActive = false
                var disabledUser = new UsersDTO
                {
                    UserID = _selectedUserID,
                    Username = txt_Username.Text, // Giữ nguyên các trường khác
                    FullName = txt_FullName.Text,
                    Phone = txt_Phone.Text,
                    RoleID = GetRoleID(cb_Role.Text),
                    IsActive = false // <- Điểm mấu chốt
                };

                var (success, err) = _userBUS.Update(disabledUser);
                if (success) btn_StaffRefresh_Click(null, null);
            }
        }

        private void btn_StaffResetPass_Click(object sender, EventArgs e)
        {
            if (_selectedUserID == -1) return;

            if (MessageBox.Show("Đổi mật khẩu tài khoản này về mặc định: '123456'?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Dùng hàm Update để đè lại Password
                var resetUser = new UsersDTO
                {
                    UserID = _selectedUserID,
                    Username = txt_Username.Text,
                    FullName = txt_FullName.Text,
                    Phone = txt_Phone.Text,
                    RoleID = GetRoleID(cb_Role.Text),
                    IsActive = true,
                    Password = "123456" // <- Đè pass
                };

                var (success, err) = _userBUS.Update(resetUser);
                if (success) MessageBox.Show("Reset mật khẩu thành công!", "Thông báo");
            }
        }

        // --- HÀM BỔ TRỢ CHUYỂN ĐỔI ROLE ---

        private string GetRoleName(int roleId)
        {
            switch (roleId)
            {
                case 1: return "Admin";
                case 2: return "Quản lý";
                case 3: return "Thu ngân";
                case 4: return "Kho";
                case 5: return "Kỹ thuật";
                default: return "Nhân viên";
            }
        }

        private int GetRoleID(string roleName)
        {
            switch (roleName)
            {
                case "Admin": return 1;
                case "Quản lý": return 2;
                case "Thu ngân": return 3;
                case "Kho": return 4;
                case "Kỹ thuật": return 5;
                default: return 6;
            }
        }
    }
}