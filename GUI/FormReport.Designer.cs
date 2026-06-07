using System.ComponentModel;

namespace GUI;

partial class FormReport
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
        panel1 = new System.Windows.Forms.Panel();
        button2 = new System.Windows.Forms.Button();
        button1 = new System.Windows.Forms.Button();
        panel2 = new System.Windows.Forms.Panel();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        button5 = new System.Windows.Forms.Button();
        button6 = new System.Windows.Forms.Button();
        panel3 = new System.Windows.Forms.Panel();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(dateTimePicker2);
        panel1.Controls.Add(dateTimePicker1);
        panel1.Controls.Add(textBox2);
        panel1.Controls.Add(textBox1);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(button1);
        panel1.Location = new System.Drawing.Point(30, 12);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(731, 75);
        panel1.TabIndex = 1;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(612, 17);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(116, 42);
        button2.TabIndex = 1;
        button2.Text = "Làm mới";
        button2.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(490, 19);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(116, 42);
        button1.TabIndex = 0;
        button1.Text = "Thêm";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // panel2
        // 
        panel2.Controls.Add(button3);
        panel2.Controls.Add(button4);
        panel2.Location = new System.Drawing.Point(36, 48);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(731, 75);
        panel2.TabIndex = 3;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(589, 16);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(116, 42);
        button3.TabIndex = 1;
        button3.Text = "button2";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(457, 16);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(116, 42);
        button4.TabIndex = 0;
        button4.Text = "button1";
        button4.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new System.Drawing.Point(43, 116);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(536, 349);
        dataGridView1.TabIndex = 2;
        dataGridView1.Text = "dataGridView1";
        // 
        // button5
        // 
        button5.Location = new System.Drawing.Point(30, 496);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(100, 39);
        button5.TabIndex = 3;
        button5.Text = "Xuất Excel";
        button5.UseVisualStyleBackColor = true;
        // 
        // button6
        // 
        button6.Location = new System.Drawing.Point(463, 494);
        button6.Name = "button6";
        button6.Size = new System.Drawing.Size(105, 41);
        button6.TabIndex = 4;
        button6.Text = "In hóa đơn";
        button6.UseVisualStyleBackColor = true;
        // 
        // panel3
        // 
        panel3.Controls.Add(label4);
        panel3.Controls.Add(label3);
        panel3.Controls.Add(label2);
        panel3.Controls.Add(label1);
        panel3.Location = new System.Drawing.Point(597, 107);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(194, 387);
        panel3.TabIndex = 5;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(13, 25);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(86, 27);
        textBox1.TabIndex = 2;
        textBox1.Text = "Từ ngày";
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(216, 25);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(99, 27);
        textBox2.TabIndex = 3;
        textBox2.Text = "đến ngày";
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dateTimePicker1.Location = new System.Drawing.Point(105, 23);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new System.Drawing.Size(98, 27);
        dateTimePicker1.TabIndex = 4;
        // 
        // dateTimePicker2
        // 
        dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dateTimePicker2.Location = new System.Drawing.Point(321, 25);
        dateTimePicker2.Name = "dateTimePicker2";
        dateTimePicker2.Size = new System.Drawing.Size(121, 27);
        dateTimePicker2.TabIndex = 5;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(14, 41);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(150, 32);
        label1.TabIndex = 0;
        label1.Text = "Tổng số đơn hàng";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(14, 123);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(135, 32);
        label2.TabIndex = 1;
        label2.Text = "Tổng doanh thu";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(14, 202);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(147, 32);
        label3.TabIndex = 2;
        label3.Text = "Doanh thu cao nhất";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(14, 291);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(147, 32);
        label4.TabIndex = 3;
        label4.Text = "Doanh thu thấp nhất";
        // 
        // FormReport
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 547);
        Controls.Add(panel3);
        Controls.Add(button6);
        Controls.Add(button5);
        Controls.Add(dataGridView1);
        Controls.Add(panel1);
        Text = "Báo cáo doanh thu";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        panel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.DateTimePicker dateTimePicker2;

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    #endregion
}