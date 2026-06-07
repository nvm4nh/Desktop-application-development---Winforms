using System.ComponentModel;

namespace GUI;

partial class FormManageShift
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
        dataGridView1 = new System.Windows.Forms.DataGridView();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        panel1 = new System.Windows.Forms.Panel();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        comboBox1 = new System.Windows.Forms.ComboBox();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new System.Drawing.Point(37, 110);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(797, 406);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(25, 553);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(122, 41);
        button1.TabIndex = 1;
        button1.Text = "Thêm";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(244, 553);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(122, 41);
        button2.TabIndex = 2;
        button2.Text = "Sửa";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(469, 553);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(122, 41);
        button3.TabIndex = 3;
        button3.Text = "Xóa";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(698, 553);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(122, 41);
        button4.TabIndex = 4;
        button4.Text = "Làm mới";
        button4.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(30, 21);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(110, 41);
        label1.TabIndex = 5;
        label1.Text = "Mã nhân viên";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(237, 21);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(110, 41);
        label2.TabIndex = 6;
        label2.Text = "Tên nhân viên";
        label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(703, 21);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(110, 27);
        label3.TabIndex = 7;
        label3.Text = "Ngày làm";
        label3.Click += label3_Click;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(462, 21);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(110, 27);
        label4.TabIndex = 8;
        label4.Text = "Ca làm việc";
        // 
        // panel1
        // 
        panel1.Controls.Add(comboBox1);
        panel1.Controls.Add(dateTimePicker1);
        panel1.Controls.Add(textBox2);
        panel1.Controls.Add(textBox1);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Location = new System.Drawing.Point(7, 7);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(853, 94);
        panel1.TabIndex = 9;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(18, 54);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(126, 27);
        textBox1.TabIndex = 9;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(221, 54);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(126, 27);
        textBox2.TabIndex = 10;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dateTimePicker1.Location = new System.Drawing.Point(658, 51);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new System.Drawing.Size(155, 27);
        dateTimePicker1.TabIndex = 11;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(452, 53);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(120, 28);
        comboBox1.TabIndex = 12;
        // 
        // FormManageShift
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(906, 606);
        Controls.Add(panel1);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(dataGridView1);
        Text = "Quản lí ca làm việc";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.DateTimePicker dateTimePicker1;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
}