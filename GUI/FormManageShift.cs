using System;
using System.Windows.Forms;

namespace GUI;

public partial class FormManageShift : Form
{
    public FormManageShift()
    {
        InitializeComponent();
    }

    private void FormManageShift_Load(object sender, EventArgs e)
    {
        // Thêm ca làm việc vào ComboBox
        comboBox1.Items.AddRange(new string[] { "Ca sáng", "Ca chiều", "Ca tối" });
        comboBox1.SelectedIndex = 0;

        // Cài đặt DataGridView
        CaiDatDataGridView();
    }

    private void CaiDatDataGridView()
    {
        dataGridView1.Columns.Clear();
        dataGridView1.Columns.Add("MaNV", "Mã nhân viên");
        dataGridView1.Columns.Add("TenNV", "Tên nhân viên");
        dataGridView1.Columns.Add("Ca", "Ca làm việc");
        dataGridView1.Columns.Add("NgayLam", "Ngày làm");

        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.RowHeadersVisible = false;
        dataGridView1.AllowUserToAddRows = false;
    }

    // Nút Thêm
    private void button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        dataGridView1.Rows.Add(
            textBox1.Text,
            textBox2.Text,
            comboBox1.SelectedItem.ToString(),
            dateTimePicker1.Value.ToString("dd/MM/yyyy")
        );

        XoaTrang();
    }

    // Nút Sửa
    private void button2_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DataGridViewRow row = dataGridView1.SelectedRows[0];
        row.Cells["MaNV"].Value = textBox1.Text;
        row.Cells["TenNV"].Value = textBox2.Text;
        row.Cells["Ca"].Value = comboBox1.SelectedItem.ToString();
        row.Cells["NgayLam"].Value = dateTimePicker1.Value.ToString("dd/MM/yyyy");

        XoaTrang();
    }

    // Nút Xóa
    private void button3_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
        }
    }

    // Nút Làm mới
    private void button4_Click(object sender, EventArgs e)
    {
        XoaTrang();
    }

    // Click vào dòng trong DataGridView để load lên ô nhập
    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells["MaNV"].Value?.ToString();
            textBox2.Text = row.Cells["TenNV"].Value?.ToString();
            comboBox1.SelectedItem = row.Cells["Ca"].Value?.ToString();
            if (DateTime.TryParseExact(row.Cells["NgayLam"].Value?.ToString(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime ngay))
            {
                dateTimePicker1.Value = ngay;
            }
        }
    }

    private void XoaTrang()
    {
        textBox1.Clear();
        textBox2.Clear();
        comboBox1.SelectedIndex = 0;
        dateTimePicker1.Value = DateTime.Now;
    }

    private void label2_Click(object sender, EventArgs e) { }
    private void label3_Click(object sender, EventArgs e) { }
}
