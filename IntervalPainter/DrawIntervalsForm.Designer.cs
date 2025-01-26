namespace DrawIntervals
{
    partial class DrawIntervalsForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            selectDateTimeStart = new DateTimePicker();
            label5 = new Label();
            selectDateTimeEnd = new DateTimePicker();
            btnDraw = new Button();
            btnClear = new Button();
            comboBox1 = new ComboBox();
            btnAdd = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            drawIntervalsControl2 = new IntervalPainter.DrawIntervalsControl();
            panel1 = new Panel();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            bindingSource1 = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(5, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 77);
            label1.TabIndex = 0;
            label1.Text = "Вид операции";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(5, 77);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(199, 58);
            label2.TabIndex = 1;
            label2.Text = "Добавить интервал";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(5, 135);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(199, 64);
            label3.TabIndex = 2;
            label3.Text = "Начало";
            // 
            // selectDateTimeStart
            // 
            selectDateTimeStart.AllowDrop = true;
            selectDateTimeStart.CustomFormat = "dd.MM.yyyy HH:mm";
            selectDateTimeStart.Dock = DockStyle.Fill;
            selectDateTimeStart.Font = new Font("Segoe UI", 15F);
            selectDateTimeStart.Format = DateTimePickerFormat.Custom;
            selectDateTimeStart.Location = new Point(214, 140);
            selectDateTimeStart.Margin = new Padding(5);
            selectDateTimeStart.Name = "selectDateTimeStart";
            selectDateTimeStart.Size = new Size(207, 34);
            selectDateTimeStart.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(5, 199);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(199, 65);
            label5.TabIndex = 5;
            label5.Text = "Конец";
            // 
            // selectDateTimeEnd
            // 
            selectDateTimeEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            selectDateTimeEnd.Dock = DockStyle.Fill;
            selectDateTimeEnd.Font = new Font("Segoe UI", 15F);
            selectDateTimeEnd.Format = DateTimePickerFormat.Custom;
            selectDateTimeEnd.Location = new Point(214, 204);
            selectDateTimeEnd.Margin = new Padding(5);
            selectDateTimeEnd.Name = "selectDateTimeEnd";
            selectDateTimeEnd.Size = new Size(207, 34);
            selectDateTimeEnd.TabIndex = 6;
            // 
            // btnDraw
            // 
            btnDraw.Dock = DockStyle.Left;
            btnDraw.Font = new Font("Segoe UI", 15F);
            btnDraw.Location = new Point(5, 824);
            btnDraw.Margin = new Padding(5);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(113, 77);
            btnDraw.TabIndex = 9;
            btnDraw.Text = "Рисовать";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Right;
            btnClear.Font = new Font("Segoe UI", 15F);
            btnClear.Location = new Point(431, 824);
            btnClear.Margin = new Padding(5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 77);
            btnClear.TabIndex = 10;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.Font = new Font("Segoe UI", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(214, 5);
            comboBox1.Margin = new Padding(5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 36);
            comboBox1.TabIndex = 12;
            comboBox1.UseWaitCursor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(btnAdd, 3);
            btnAdd.ImageAlign = ContentAlignment.BottomRight;
            btnAdd.Location = new Point(114, 367);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(318, 49);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Добавить";
            btnAdd.TextAlign = ContentAlignment.BottomCenter;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.1525421F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.8474579F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1101F));
            tableLayoutPanel1.Controls.Add(btnClear, 2, 7);
            tableLayoutPanel1.Controls.Add(btnDraw, 0, 7);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(selectDateTimeEnd, 1, 3);
            tableLayoutPanel1.Controls.Add(selectDateTimeStart, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 6);
            tableLayoutPanel1.Controls.Add(drawIntervalsControl2, 3, 1);
            tableLayoutPanel1.Controls.Add(panel1, 3, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 4);
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 57.1428566F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42.8571434F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 398F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1648, 906);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 3);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 424);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(540, 392);
            dataGridView1.TabIndex = 14;
            // 
            // drawIntervalsControl2
            // 
            drawIntervalsControl2.Dock = DockStyle.Fill;
            drawIntervalsControl2.Location = new Point(549, 81);
            drawIntervalsControl2.Margin = new Padding(3, 4, 3, 4);
            drawIntervalsControl2.Name = "drawIntervalsControl2";
            tableLayoutPanel1.SetRowSpan(drawIntervalsControl2, 6);
            drawIntervalsControl2.Size = new Size(1096, 734);
            drawIntervalsControl2.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(549, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 71);
            panel1.TabIndex = 18;
            // 
            // radioButton4
            // 
            radioButton4.Location = new Point(831, 17);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(196, 32);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Месяц";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.Location = new Point(590, 9);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(169, 48);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Неделя";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.Location = new Point(337, 13);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(167, 40);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Сутки";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.Location = new Point(64, 17);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(154, 36);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Смена";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(button1, 3);
            button1.Location = new Point(114, 267);
            button1.Name = "button1";
            button1.Size = new Size(318, 92);
            button1.TabIndex = 15;
            button1.Text = "Генерировать с шагом";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DrawIntervalsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1648, 906);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5);
            Name = "DrawIntervalsForm";
            Text = "Рисование интервалов";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker selectDateTimeStart;
        private Label label5;
        private DateTimePicker selectDateTimeEnd;
        private Button btnDraw;
        private Button btnClear;
        private ComboBox comboBox1;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private Button button1;
        private IntervalPainter.DrawIntervalsControl drawIntervalsControl2;
        private Panel panel1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
