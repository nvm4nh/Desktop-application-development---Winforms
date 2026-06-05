using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormManageProduct : Form
    {
        // Khai báo BUS (Sử dụng ProductBUS thực tế của bạn)
        // private readonly ProductsBUS _productBUS = new ProductsBUS();
        // private readonly CategoriesBUS _categoryBUS = new CategoriesBUS();

        // Dữ liệu tạm để giả lập logic lọc theo ảnh (thay bằng List<ProductsDTO> thật)
        private object _originalProductList;
        private string _selectedCategoryID = "All"; // Lưu id danh mục đang chọn
        private string _selectedProductID = null;

        public FormManageProduct()
        {
            InitializeComponent();
        }

        private void FormManageProduct_Load(object sender, EventArgs e)
        {
            cb_StatusFilter.SelectedIndex = 0; // Mặc định "Tất cả trạng thái"
            LoadCategories();
            LoadProducts();
        }

        private void LoadCategories()
        {
            // TODO: Thay bằng list CategoriesDTO thực tế từ database
            // Var categories = _categoryBUS.GetAll();
            // Dưới đây là cách tạo bảng ảo để nhúng vào DataGridView hiển thị Danh mục (Có đếm số lượng SP)
            var dtCategories = new System.Data.DataTable();
            dtCategories.Columns.Add("CatID", typeof(string));
            dtCategories.Columns.Add("CatName", typeof(string));
            dtCategories.Columns.Add("Count", typeof(string));

            dtCategories.Rows.Add("All", "Tất cả", "24");
            dtCategories.Rows.Add("DM01", "Điện thoại", "12");
            dtCategories.Rows.Add("DM02", "Máy tính bảng", "5");
            dtCategories.Rows.Add("DM03", "Phụ kiện", "4");
            dtCategories.Rows.Add("DM04", "Tai nghe", "3");

            dgv_CategoryFilter.DataSource = dtCategories;
            dgv_CategoryFilter.Columns["CatID"].Visible = false; // Ẩn mã ID

            // Format cho giao diện đẹp giống menu danh mục bên trái
            dgv_CategoryFilter.Columns["CatName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CategoryFilter.Columns["Count"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_CategoryFilter.Columns["Count"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_CategoryFilter.Columns["Count"].DefaultCellStyle.ForeColor = Color.White;
            dgv_CategoryFilter.Columns["Count"].DefaultCellStyle.BackColor = Color.Navy; // Giả lập huy hiệu đếm số lượng
            dgv_CategoryFilter.ClearSelection();
        }

        private void LoadProducts()
        {
            // TODO: Gọi _originalProductList = _productBUS.GetAll();
            // Gán hiển thị dgv_ProductList.DataSource = _originalProductList;

            UpdateBottomStatus();
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            // Hàm xử lý máy lọc (Kết hợp Danh mục bên trái & ComboBox trạng thái bên phải)
            // if (_originalProductList == null) return;
            // var filtered = _originalProductList.Where(p => ...).ToList();
            // dgv_ProductList.DataSource = filtered;

            UpdateBottomStatus();
        }

        private void UpdateBottomStatus()
        {
            int totalProducts = dgv_ProductList.Rows.Count;
            string selectedName = "Không";

            if (dgv_ProductList.SelectedRows.Count > 0)
            {
                // Giả định cột Tên SP là index 1 hoặc có Name là "ProductName"
                selectedName = dgv_ProductList.SelectedRows[0].Cells["ProductName"]?.Value?.ToString() ?? "Không";
            }

            lbl_StatusSummary.Text = $"Tổng: {totalProducts} sản phẩm | Đang chọn: {selectedName}";

            // TODO: Dùng hàm LINQ đếm thực tế tồn kho < 5 là sắp hết, = 0 là hết hàng
            // int lowStock = _originalProductList.Count(p => p.Stock > 0 && p.Stock <= 5);
            // int outOfStock = _originalProductList.Count(p => p.Stock == 0);
            // lbl_InventoryWarning.Text = $"Tồn kho thấp: {lowStock} SP | Hết hàng: {outOfStock} SP";
        }

        // --- SỰ KIỆN TƯƠNG TÁC LƯỚI ---

        private void dgv_CategoryFilter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedCategoryID = dgv_CategoryFilter.Rows[e.RowIndex].Cells["CatID"].Value.ToString();
                ApplyFilters(); // Lọc lại danh sách sản phẩm theo danh mục
            }
        }

        private void dgv_ProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedProductID = dgv_ProductList.Rows[e.RowIndex].Cells["ProductID"]?.Value.ToString();
                UpdateBottomStatus();
            }
        }

        private void dgv_ProductList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Format màu sắc dựa trên Trạng thái hoặc số lượng tồn kho (Theo ảnh chuẩn)
            if (dgv_ProductList.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "Còn hàng")
                    e.CellStyle.ForeColor = Color.Green;
                else if (status == "Sắp hết")
                    e.CellStyle.ForeColor = Color.DarkGoldenrod; // Màu vàng cam
                else if (status == "Hết hàng")
                    e.CellStyle.ForeColor = Color.Red;

                e.FormattingApplied = true;
            }
            // Format giá tiền (VNĐ)
            else if (dgv_ProductList.Columns[e.ColumnIndex].Name == "Price" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal price))
                {
                    e.Value = price.ToString("#,##0");
                    e.FormattingApplied = true;
                }
            }
        }

        private void cb_StatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        // --- CÁC NÚT THANH CÔNG CỤ TÌM/THÊM/SỬA/XÓA ---

        private void btn_ProductAdd_Click(object sender, EventArgs e)
        {
            // Form này chỉ xem dạng Master, Thêm mới sẽ mở Dialog
            MessageBox.Show("Mở form nhập liệu Thêm Sản Phẩm (FormProductDetail)...", "Chức năng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // FormProductDetail frm = new FormProductDetail();
            // if (frm.ShowDialog() == DialogResult.OK) { LoadProducts(); }
        }

        private void btn_ProductEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedProductID))
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Mở form sửa sản phẩm mã: {_selectedProductID}", "Chức năng");
        }

        private void btn_ProductDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedProductID))
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Gọi BUS xóa
                // _productBUS.Delete(_selectedProductID);
                MessageBox.Show("Xóa thành công!");
                LoadProducts(); // Refresh danh sách
            }
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            // Nút "Danh mục" trên TopBar -> Thường để mở nhanh Form quản lý Danh mục (FormCategory)
            MessageBox.Show("Mở Form Quản lý danh mục...", "Điều hướng");
        }

        private void btn_ProductRefresh_Click(object sender, EventArgs e)
        {
            cb_StatusFilter.SelectedIndex = 0;
            LoadCategories();
            LoadProducts();
        }
    }
}