using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            CaiDatDataGridView();
        }

        private void CaiDatDataGridView()
        {
            // Tạo cột cho DataGridView
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("MaDH", "Mã ĐH");
            dataGridView1.Columns.Add("NgayBan", "Ngày bán");
            dataGridView1.Columns.Add("KhachHang", "Khách hàng");
            dataGridView1.Columns.Add("SanPham", "Sản phẩm");
            dataGridView1.Columns.Add("SoLuong", "Số lượng");
            dataGridView1.Columns.Add("DonGia", "Đơn giá");
            dataGridView1.Columns.Add("ThanhTien", "Thành tiền");

            // Định dạng
            dataGridView1.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
        }

        private void TinhTong()
        {
            int tongDon = dataGridView1.Rows.Count;
            decimal tongDT = 0, caoNhat = 0, thapNhat = decimal.MaxValue;

            if (tongDon == 0)
            {
                label1.Text = "Tổng đơn hàng: 0";
                label2.Text = "Tổng doanh thu: 0 đ";
                label3.Text = "Cao nhất: 0 đ";
                label4.Text = "Thấp nhất: 0 đ";
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                decimal thanhTien = Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                tongDT += thanhTien;
                if (thanhTien > caoNhat) caoNhat = thanhTien;
                if (thanhTien < thapNhat) thapNhat = thanhTien;
            }

            label1.Text = "Tổng đơn hàng: " + tongDon;
            label2.Text = "Tổng doanh thu: " + tongDT.ToString("N0") + " đ";
            label3.Text = "Cao nhất: " + caoNhat.ToString("N0") + " đ";
            label4.Text = "Thấp nhất: " + thapNhat.ToString("N0") + " đ";
        }

        // Nút Thêm
        private void button1_Click(object sender, EventArgs e)
        {
            // Mở form thêm đơn hàng ở đây
        }

        // Nút Làm mới
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            TinhTong();
        }

        // Nút Xuất Excel
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xuất Excel đang phát triển!");
        }

        // Nút In hóa đơn
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng in đang phát triển!");
        }
    }
}