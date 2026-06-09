using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI;

public partial class FormManageShift : Form
{
    private ShiftsBUS _shiftsBus = new ShiftsBUS();
    private ShiftsDTO _currentShift = null;
    private bool _isShiftOpen => _currentShift != null;

    private List<ShiftsDTO> _shiftList = new List<ShiftsDTO>();

    public FormManageShift()
    {
        InitializeComponent();
        ControlStandardization.ApplyFormStandard(this);
        ApplyStyles();
        LoadData();
    }

    private void ApplyStyles()
    {
        // Áp dụng chuẩn cho các panel chính
        ControlStandardization.ApplyTopBarPanelStandard(pnl_top);
        ControlStandardization.ApplyStatusPanelStandard(pnl_footer);

        // Áp dụng chuẩn cho DataGridView
        ControlStandardization.ApplyDataGridViewStandard(dgv_listShift);

        // Đảm bảo Form có nền trắng
        this.BackColor = Color.White;

        // Cập nhật vị trí các nút trong pnl_top
        ControlStandardization.ApplyTopBarButtonStandard(btn_shiftOpen, ButtonPosition.Add);
        ControlStandardization.ApplyTopBarButtonStandard(btn_shiftStop, ButtonPosition.Edit);
        ControlStandardization.ApplyTopBarButtonStandard(btn_shiftHistory, ButtonPosition.Delete);

        foreach (Control ctrl in pnl_top.Controls)
        {
            if (ctrl is Button btn)
            {
                btn.ForeColor = Color.Black;
                btn.UseVisualStyleBackColor = true;
            }
        }

        // Căn chỉnh các card thông tin (panel1-5) trong groupBox1
        groupBox1.Dock = DockStyle.Top;
        groupBox1.Height = 150;
        
        // Dàn đều các card
        int cardWidth = (this.ClientSize.Width - 40) / 5;
        Panel[] cards = { panel1, panel2, panel3, panel4, panel5 };
        for (int i = 0; i < cards.Length; i++)
        {
            cards[i].Width = cardWidth;
            cards[i].Location = new Point(10 + i * cardWidth, 30);
            cards[i].Anchor = AnchorStyles.Top | AnchorStyles.Left;
        }
    }

    private void LoadData()
    {
        _currentShift = _shiftsBus.GetOpenShift(CurrentUser.UserID);
        _shiftList = _shiftsBus.GetAllShifts();
        
        UpdateCards();
        LoadTable();
        UpdateFooter();
    }

    private void UpdateCards()
    {
        lbl_resStatus.Text              = _isShiftOpen ? "Đang mở" : "Đã đóng";
        lbl_resStatus.ForeColor         = _isShiftOpen ? Color.FromArgb(0, 140, 0) : Color.Red;
        
        if (_isShiftOpen)
        {
            lbl_resTime.Text = _currentShift.StartTime.ToString("HH:mm");
            lbl_resMoney.Text = string.Format("{0:N0}", _currentShift.OpeningCash);
            
            var (revenue, profit) = new ReportsBUS().GetDailySummary(CurrentUser.UserID, DateTime.Today);
            lbl_resRevenue.Text = string.Format("{0:N0}", revenue);
            lbl_resActivity.Text = "Đang hoạt động";
        }
        else
        {
            lbl_resTime.Text        = "--:--";
            lbl_resMoney.Text       = "0";
            lbl_resActivity.Text    = "0";
            lbl_resRevenue.Text     = "0";
        }
        lbl_resRevenue.ForeColor = Color.FromArgb(0, 102, 204);
    }

    private void LoadTable()
    {
        dgv_listShift.Rows.Clear();
        dgv_listShift.RowHeadersVisible  = false;
        dgv_listShift.AllowUserToAddRows = false;
        dgv_listShift.ReadOnly           = true;
        dgv_listShift.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;
        dgv_listShift.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255);

        foreach (var s in _shiftList)
        {
            int i = dgv_listShift.Rows.Add(
                s.ShiftCode, 
                CurrentUser.FullName, 
                s.StartTime.ToString("dd/MM HH:mm"), 
                s.EndTime?.ToString("dd/MM HH:mm") ?? "—",
                string.Format("{0:N0}", s.OpeningCash),
                s.ClosingCash > 0 ? string.Format("{0:N0}", s.ClosingCash) : "—",
                s.DifferenceAmount != 0 ? string.Format("{0:N0}", s.DifferenceAmount) : "—",
                s.Status
            );

            var ttCell = dgv_listShift.Rows[i].Cells["col_trangThai"];
            if (s.Status == "Đang mở")
            { ttCell.Style.BackColor = Color.FromArgb(0, 102, 204); ttCell.Style.ForeColor = Color.White; }
            else
            { ttCell.Style.BackColor = Color.FromArgb(100, 100, 100); ttCell.Style.ForeColor = Color.White; }

            var clCell = dgv_listShift.Rows[i].Cells["col_chenhLech"];
            if (s.DifferenceAmount > 0) clCell.Style.ForeColor = Color.Green;
            else if (s.DifferenceAmount < 0) clCell.Style.ForeColor = Color.Red;
        }
    }

    private void UpdateFooter()
    {
        if (_isShiftOpen)
        {
            lbl_footerLeft.Text = $"Ca hiện tại: {_currentShift.ShiftCode} | {CurrentUser.FullName}";
            lbl_footerRight.Text = $"Mở lúc: {_currentShift.StartTime:HH:mm dd/MM}";
        }
        else
        {
            lbl_footerLeft.Text  = "Chưa mở ca";
            lbl_footerRight.Text = "";
        }
    }

    private void btn_moCa_Click(object sender, EventArgs e)
    {
        if (_isShiftOpen)
        {
            MessageBox.Show("Đang có ca đang mở!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Tạm thời fix cứng số tiền đầu ca để demo, thực tế nên có form nhập
        decimal openingCash = 0;
        var result = _shiftsBus.OpenShift(openingCash);
        
        if (result.success)
        {
            LoadData();
            MessageBox.Show("Mở ca thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show(result.error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btn_chotCa_Click(object sender, EventArgs e)
    {
        if (!_isShiftOpen)
        {
            MessageBox.Show("Không có ca nào đang mở!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (MessageBox.Show("Bạn có chắc muốn chốt ca?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            // Tạm thời fix cứng số tiền thực tế
            var result = _shiftsBus.CloseShift(_currentShift.OpeningCash, "Chốt ca tự động");
            if (result.success)
            {
                LoadData();
                MessageBox.Show("Chốt ca thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void button5_Click(object sender, EventArgs e)
    {
        LoadData();
    }

    private void label2_Click_1(object sender, EventArgs e) { }
    private void label2_Click_2(object sender, EventArgs e) { }

    private void lbl_tienDaucaTitle_Click(object sender, EventArgs e)
    {
        
    }
}