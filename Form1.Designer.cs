namespace form_sinhvien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonthem = new Button();
            buttonsua = new Button();
            buttonxoa = new Button();
            buttonlammoi = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textmasv = new TextBox();
            texttensv = new TextBox();
            textlop = new TextBox();
            textdiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(986, 365);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonthem
            // 
            buttonthem.Location = new Point(392, 635);
            buttonthem.Name = "buttonthem";
            buttonthem.Size = new Size(94, 29);
            buttonthem.TabIndex = 1;
            buttonthem.Text = "Thêm ";
            buttonthem.UseVisualStyleBackColor = true;
            buttonthem.Click += buttonthem_Click;
            // 
            // buttonsua
            // 
            buttonsua.Location = new Point(589, 635);
            buttonsua.Name = "buttonsua";
            buttonsua.Size = new Size(94, 29);
            buttonsua.TabIndex = 2;
            buttonsua.Text = "Sửa";
            buttonsua.UseVisualStyleBackColor = true;
            buttonsua.Click += buttonsua_Click;
            // 
            // buttonxoa
            // 
            buttonxoa.Location = new Point(763, 635);
            buttonxoa.Name = "buttonxoa";
            buttonxoa.Size = new Size(94, 29);
            buttonxoa.TabIndex = 3;
            buttonxoa.Text = "Xóa ";
            buttonxoa.UseVisualStyleBackColor = true;
            // 
            // buttonlammoi
            // 
            buttonlammoi.Location = new Point(182, 635);
            buttonlammoi.Name = "buttonlammoi";
            buttonlammoi.Size = new Size(94, 29);
            buttonlammoi.TabIndex = 4;
            buttonlammoi.Text = "Làm mới ";
            buttonlammoi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 441);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã sinh viên ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 524);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 6;
            label2.Text = "Tên sinh viên ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(496, 441);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 7;
            label3.Text = "Lớp ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 523);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 8;
            label4.Text = "Điểm tổng kết ";
            // 
            // textmasv
            // 
            textmasv.Location = new Point(162, 434);
            textmasv.Name = "textmasv";
            textmasv.Size = new Size(279, 27);
            textmasv.TabIndex = 9;
            // 
            // texttensv
            // 
            texttensv.Location = new Point(162, 520);
            texttensv.Name = "texttensv";
            texttensv.Size = new Size(279, 27);
            texttensv.TabIndex = 10;
            // 
            // textlop
            // 
            textlop.Location = new Point(619, 434);
            textlop.Name = "textlop";
            textlop.Size = new Size(261, 27);
            textlop.TabIndex = 11;
            // 
            // textdiem
            // 
            textdiem.Location = new Point(619, 517);
            textdiem.Name = "textdiem";
            textdiem.Size = new Size(261, 27);
            textdiem.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 685);
            Controls.Add(textdiem);
            Controls.Add(textlop);
            Controls.Add(texttensv);
            Controls.Add(textmasv);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonlammoi);
            Controls.Add(buttonxoa);
            Controls.Add(buttonsua);
            Controls.Add(buttonthem);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button buttonthem;
        private Button buttonsua;
        private Button buttonxoa;
        private Button buttonlammoi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textmasv;
        private TextBox texttensv;
        private TextBox textlop;
        private TextBox textdiem;
    }
}
