using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormGuest : Form
    {
        // Biến kiểm tra đang ở chế độ thêm mới hay sửa
        private bool isAdding = false;

        // Lưu vị trí dòng đang chọn trong DataGridView
        private int selectedRow = -1;

        public FormGuest()
        {
            InitializeComponent();
        }

        // ==========================
        // FORM LOAD
        // ==========================
        private void FormGuest_Load(object sender, EventArgs e)
        {
            // Hiển thị cột tự động đầy đủ chiều rộng
            dgv_Guest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Chỉ cho phép chọn nguyên dòng
            dgv_Guest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Không cho chọn nhiều dòng
            dgv_Guest.MultiSelect = false;

            // Không cho người dùng tự thêm dòng
            dgv_Guest.AllowUserToAddRows = false;

            // Chỉ đọc dữ liệu
            dgv_Guest.ReadOnly = true;
        }

        // ==========================
        // NÚT THÊM KHÁCH HÀNG
        // ==========================
        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            // Chuyển sang chế độ thêm
            isAdding = true;

            // Xóa dữ liệu cũ trên form
            txt_PhoneNumber.Clear();
            txt_FullName.Clear();
            txt_Address.Clear();

            cbo_CustomerType.SelectedIndex = -1;

            // Đưa con trỏ vào ô SĐT
            txt_PhoneNumber.Focus();
        }

        // ==========================
        // NÚT LƯU
        // ==========================
        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu bắt buộc
            if (string.IsNullOrWhiteSpace(txt_PhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txt_FullName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Nếu đang thêm khách hàng
            if (isAdding)
            {
                dgv_Guest.Rows.Add(
                    txt_PhoneNumber.Text,      // SĐT
                    txt_FullName.Text,         // Họ tên
                    cbo_CustomerType.Text,    // Loại khách
                    0,                         // Điểm tích lũy
                    0,                         // Tổng mua
                    DateTime.Now.ToString("dd/MM/yyyy")
                );

                MessageBox.Show("Thêm khách hàng thành công!");
            }
            else
            {
                // Nếu đang sửa khách hàng
                if (selectedRow >= 0)
                {
                    dgv_Guest.Rows[selectedRow].Cells[0].Value = txt_PhoneNumber.Text;
                    dgv_Guest.Rows[selectedRow].Cells[1].Value = txt_FullName.Text;
                    dgv_Guest.Rows[selectedRow].Cells[2].Value = cbo_CustomerType.Text;

                    MessageBox.Show("Cập nhật khách hàng thành công!");
                }
            }
        }

        // ==========================
        // NÚT SỬA
        // ==========================
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn dòng chưa
            if (dgv_Guest.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!");
                return;
            }

            // Lưu vị trí dòng đang chọn
            selectedRow = dgv_Guest.CurrentRow.Index;

            // Đổ dữ liệu lên form
            txt_PhoneNumber.Text =
                dgv_Guest.Rows[selectedRow].Cells[0].Value?.ToString();

            txt_FullName.Text =
                dgv_Guest.Rows[selectedRow].Cells[1].Value?.ToString();

            cbo_CustomerType.Text =
                dgv_Guest.Rows[selectedRow].Cells[2].Value?.ToString();

            // Chuyển sang chế độ sửa
            isAdding = false;
        }

        // ==========================
        // NÚT HỦY
        // ==========================
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_PhoneNumber.Clear();
            txt_FullName.Clear();
            txt_Address.Clear();

            cbo_CustomerType.SelectedIndex = -1;

            MessageBox.Show("Đã hủy thao tác!");
        }

        // ==========================
        // NÚT LÀM MỚI
        // ==========================
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            // Xóa ô tìm kiếm
            txt_Search.Clear();

            // Xóa dữ liệu trên form
            txt_PhoneNumber.Clear();
            txt_FullName.Clear();
            txt_Address.Clear();

            cbo_CustomerType.SelectedIndex = -1;

            // Bỏ chọn DataGridView
            dgv_Guest.ClearSelection();

            MessageBox.Show("Đã làm mới!");
        }

        // ==========================
        // NÚT LỊCH SỬ MUA
        // ==========================
        private void btn_PurchaseHistory_Click(object sender, EventArgs e)
        {
            if (dgv_Guest.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }

            string customerName =
                dgv_Guest.CurrentRow.Cells[1].Value?.ToString();

            MessageBox.Show(
                "Hiển thị lịch sử mua của khách hàng: "
                + customerName);
        }

        // ==========================
        // CLICK VÀO DÒNG TRONG BẢNG
        // ==========================
        private void dgv_Guest_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            // Nếu click tiêu đề thì bỏ qua
            if (e.RowIndex < 0)
                return;

            selectedRow = e.RowIndex;

            // Hiển thị dữ liệu lên form
            txt_PhoneNumber.Text =
                dgv_Guest.Rows[e.RowIndex].Cells[0].Value?.ToString();

            txt_FullName.Text =
                dgv_Guest.Rows[e.RowIndex].Cells[1].Value?.ToString();

            cbo_CustomerType.Text =
                dgv_Guest.Rows[e.RowIndex].Cells[2].Value?.ToString();
        }

        // ==========================
        // TÌM KIẾM KHÁCH HÀNG
        // ==========================
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_Search.Text.ToLower();

            foreach (DataGridViewRow row in dgv_Guest.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string phone =
                    row.Cells[0].Value?.ToString().ToLower() ?? "";

                string name =
                    row.Cells[1].Value?.ToString().ToLower() ?? "";

                // Hiện dòng nếu tìm thấy SĐT hoặc tên
                row.Visible =
                    phone.Contains(keyword) ||
                    name.Contains(keyword);
            }
        }
    }
}