using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormCategory : Form
    {
        private readonly CategoriesBUS _categoryBUS = new CategoriesBUS();
        private List<CategoriesDTO> _originalList = new List<CategoriesDTO>();

        private int _selectedCategoryID = -1;
        private bool _isAdding = false;

        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            LoadData();
            SetInputState(false);
        }

        private void LoadData()
        {
            // Lấy toàn bộ danh sách gốc từ BUS
            _originalList = _categoryBUS.GetAll() ?? new List<CategoriesDTO>();
            dgv_CategoryList.DataSource = _originalList;

            // Định dạng tên cột hiển thị lên DataGridView
            if (dgv_CategoryList.Columns["CategoryID"] != null) dgv_CategoryList.Columns["CategoryID"].HeaderText = "Mã DM";
            if (dgv_CategoryList.Columns["CategoryName"] != null) dgv_CategoryList.Columns["CategoryName"].HeaderText = "Tên danh mục";
            if (dgv_CategoryList.Columns["Description"] != null) dgv_CategoryList.Columns["Description"].HeaderText = "Mô tả";
            if (dgv_CategoryList.Columns["Status"] != null) dgv_CategoryList.Columns["Status"].HeaderText = "Trạng thái";

            dgv_CategoryList.ClearSelection();
            _selectedCategoryID = -1;
            UpdateStatusStrip("Không");
        }

        private void dgv_CategoryList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Format màu sắc chữ dựa theo giá trị text thô lưu trong database ("Hoat dong" / "Ngung")
            if (dgv_CategoryList.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string rawStatus = e.Value.ToString();
                if (rawStatus == "Hoat dong")
                {
                    e.Value = "Hoạt động";
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    e.Value = "Ngừng";
                    e.CellStyle.ForeColor = Color.Red;
                }
                e.FormattingApplied = true;
            }
        }

        private void dgv_CategoryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !_isAdding)
            {
                DataGridViewRow row = dgv_CategoryList.Rows[e.RowIndex];

                _selectedCategoryID = Convert.ToInt32(row.Cells["CategoryID"].Value);
                txt_CategoryName.Text = row.Cells["CategoryName"].Value?.ToString();
                txt_CategoryDesc.Text = row.Cells["Description"].Value?.ToString();

                string rawStatus = row.Cells["Status"].Value?.ToString();
                cb_CategoryStatus.Text = (rawStatus == "Hoat dong") ? "Hoạt động" : "Ngừng";

                UpdateStatusStrip(txt_CategoryName.Text);
            }
        }

        // --- ĐIỀU KHIỂN ĐÓNG/MỞ TRẠNG THÁI FORM ---

        private void SetInputState(bool isEnabled)
        {
            txt_CategoryName.Enabled = isEnabled;
            txt_CategoryDesc.Enabled = isEnabled;
            cb_CategoryStatus.Enabled = isEnabled;

            btn_CategorySave.Enabled = isEnabled;
            btn_CategoryCancel.Enabled = isEnabled;

            btn_CategoryAdd.Enabled = !isEnabled;
            btn_CategoryEdit.Enabled = !isEnabled;
            btn_CategoryDelete.Enabled = !isEnabled;
            dgv_CategoryList.Enabled = !isEnabled;
        }

        private void ClearInputs()
        {
            txt_CategoryName.Clear();
            txt_CategoryDesc.Clear();
            cb_CategoryStatus.SelectedIndex = -1;
        }

        private void UpdateStatusStrip(string currentSelection)
        {
            lbl_StatusSummary.Text = $"Tổng: {_originalList.Count} danh mục | Đang chọn: {currentSelection}";
        }

        // --- CÁC NÚT ĐIỀU HƯỚNG THANH CÔNG CỤ (TOPBAR) ---

        private void btn_CategoryAdd_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            ClearInputs();
            SetInputState(true);
            cb_CategoryStatus.Text = "Hoạt động"; // Mặc định tạo mới là Hoạt động
            txt_CategoryName.Focus();
        }

        private void btn_CategoryEdit_Click(object sender, EventArgs e)
        {
            if (_selectedCategoryID == -1)
            {
                MessageBox.Show("Vui lòng lựa chọn một danh mục cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _isAdding = false;
            SetInputState(true);
        }

        private void btn_CategoryDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCategoryID == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = MessageBox.Show($"Bạn có thực sự muốn xóa danh mục '{txt_CategoryName.Text}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                // Gọi hàm Delete từ tầng BUS của bạn (Nhận vào int id, trả về Tuple (bool, string))
                var (success, error) = _categoryBUS.Delete(_selectedCategoryID);
                if (success)
                {
                    MessageBox.Show("Xóa danh mục thành công!", "Thông báo");
                    btn_CategoryRefresh_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Không thể xóa: " + error, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_CategoryRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearInputs();
            SetInputState(false);
            txt_CategorySearch.Text = "Tìm danh mục...";
            txt_CategorySearch.ForeColor = Color.Gray;
        }

        private void btn_CategoryCancel_Click(object sender, EventArgs e)
        {
            _isAdding = false;
            ClearInputs();
            SetInputState(false);
        }

        private void btn_CategorySave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_CategoryName.Text))
            {
                MessageBox.Show("Tên danh mục không được phép để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var category = new CategoriesDTO
            {
                CategoryName = txt_CategoryName.Text.Trim(),
                Description = txt_CategoryDesc.Text.Trim(),
                Status = (cb_CategoryStatus.Text == "Hoạt động") ? "Hoat dong" : "Ngung" // Chuyển đổi chuẩn chuỗi mapping DB
            };

            bool success;
            string error;

            if (_isAdding)
            {
                (success, error) = _categoryBUS.Insert(category);
            }
            else
            {
                category.CategoryID = _selectedCategoryID;
                (success, error) = _categoryBUS.Update(category);
            }

            if (success)
            {
                MessageBox.Show(_isAdding ? "Thêm danh mục mới thành công!" : "Cập nhật danh mục thành công!", "Thông báo");
                btn_CategoryRefresh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Thao tác thất bại: " + error, "Lỗi xử lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- XỬ LÝ TÌM KIẾM NHANH (MÁY LỌC TRỰC TIẾP TRÊN LIST KHÔNG LÀM PHIỀN BUS/DAL) ---

        private void txt_CategorySearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_CategorySearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword) || txt_CategorySearch.Text == "Tìm danh mục...")
            {
                dgv_CategoryList.DataSource = _originalList;
            }
            else
            {
                var filtered = _originalList.Where(c =>
                    c.CategoryID.ToString().Contains(keyword) ||
                    (!string.IsNullOrEmpty(c.CategoryName) && c.CategoryName.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(c.Description) && c.Description.ToLower().Contains(keyword))
                ).ToList();

                dgv_CategoryList.DataSource = filtered;
            }
        }

        private void txt_CategorySearch_Enter(object sender, EventArgs e)
        {
            if (txt_CategorySearch.Text == "Tìm danh mục...")
            {
                txt_CategorySearch.Text = "";
                txt_CategorySearch.ForeColor = Color.Black;
            }
        }

        private void txt_CategorySearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_CategorySearch.Text))
            {
                txt_CategorySearch.Text = "Tìm danh mục...";
                txt_CategorySearch.ForeColor = Color.Gray;
            }
        }
    }
}