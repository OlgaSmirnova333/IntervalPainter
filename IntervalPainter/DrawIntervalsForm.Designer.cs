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
            lblOperationType = new Label();
            lblAddInterval = new Label();
            lblBegin = new Label();
            selectDateTimeStart = new DateTimePicker();
            lblEnd = new Label();
            selectDateTimeEnd = new DateTimePicker();
            btnDraw = new Button();
            btnClear = new Button();
            selectOperation = new ComboBox();
            btnAdd = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView = new DataGridView();
            drawIntervalsControl2 = new IntervalPainter.DrawIntervalsControl();
            panel1 = new Panel();
            rbMonth = new RadioButton();
            rbWeek = new RadioButton();
            rbDay = new RadioButton();
            rbShift = new RadioButton();
            btnGenerateWithStep = new Button();
            bindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblOperationType
            // 
            lblOperationType.Dock = DockStyle.Fill;
            lblOperationType.Font = new Font("Segoe UI", 15F);
            lblOperationType.ImageAlign = ContentAlignment.TopLeft;
            lblOperationType.Location = new Point(5, 0);
            lblOperationType.Margin = new Padding(5, 0, 5, 0);
            lblOperationType.Name = "lblOperationType";
            lblOperationType.Size = new Size(199, 77);
            lblOperationType.TabIndex = 0;
            lblOperationType.Text = "Вид операции";
            // 
            // lblAddInterval
            // 
            lblAddInterval.AutoSize = true;
            lblAddInterval.Dock = DockStyle.Fill;
            lblAddInterval.Font = new Font("Segoe UI", 15F);
            lblAddInterval.Location = new Point(5, 77);
            lblAddInterval.Margin = new Padding(5, 0, 5, 0);
            lblAddInterval.Name = "lblAddInterval";
            lblAddInterval.Size = new Size(199, 58);
            lblAddInterval.TabIndex = 1;
            lblAddInterval.Text = "Добавить интервал";
            // 
            // lblBegin
            // 
            lblBegin.AutoSize = true;
            lblBegin.Dock = DockStyle.Fill;
            lblBegin.Font = new Font("Segoe UI", 15F);
            lblBegin.Location = new Point(5, 135);
            lblBegin.Margin = new Padding(5, 0, 5, 0);
            lblBegin.Name = "lblBegin";
            lblBegin.Size = new Size(199, 64);
            lblBegin.TabIndex = 2;
            lblBegin.Text = "Начало";
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
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Dock = DockStyle.Fill;
            lblEnd.Font = new Font("Segoe UI", 15F);
            lblEnd.Location = new Point(5, 199);
            lblEnd.Margin = new Padding(5, 0, 5, 0);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(199, 65);
            lblEnd.TabIndex = 5;
            lblEnd.Text = "Конец";
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
            // selectOperation
            // 
            selectOperation.Dock = DockStyle.Fill;
            selectOperation.Font = new Font("Segoe UI", 15F);
            selectOperation.FormattingEnabled = true;
            selectOperation.Location = new Point(214, 5);
            selectOperation.Margin = new Padding(5);
            selectOperation.Name = "selectOperation";
            selectOperation.Size = new Size(207, 36);
            selectOperation.TabIndex = 12;
            selectOperation.UseWaitCursor = true;
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
            tableLayoutPanel1.Controls.Add(lblAddInterval, 0, 1);
            tableLayoutPanel1.Controls.Add(lblBegin, 0, 2);
            tableLayoutPanel1.Controls.Add(lblEnd, 0, 3);
            tableLayoutPanel1.Controls.Add(selectDateTimeEnd, 1, 3);
            tableLayoutPanel1.Controls.Add(selectDateTimeStart, 1, 2);
            tableLayoutPanel1.Controls.Add(selectOperation, 1, 0);
            tableLayoutPanel1.Controls.Add(lblOperationType, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView, 0, 6);
            tableLayoutPanel1.Controls.Add(drawIntervalsControl2, 3, 1);
            tableLayoutPanel1.Controls.Add(panel1, 3, 0);
            tableLayoutPanel1.Controls.Add(btnGenerateWithStep, 0, 4);
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
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView, 3);
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 424);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(540, 392);
            dataGridView.TabIndex = 14;
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
            panel1.Controls.Add(rbMonth);
            panel1.Controls.Add(rbWeek);
            panel1.Controls.Add(rbDay);
            panel1.Controls.Add(rbShift);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(549, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 71);
            panel1.TabIndex = 18;
            // 
            // rbMonth
            // 
            rbMonth.Location = new Point(831, 17);
            rbMonth.Name = "rbMonth";
            rbMonth.Size = new Size(196, 32);
            rbMonth.TabIndex = 3;
            rbMonth.TabStop = true;
            rbMonth.Text = "Месяц";
            rbMonth.UseVisualStyleBackColor = true;
            rbMonth.CheckedChanged += rbMonth_CheckedChanged;
            // 
            // rbWeek
            // 
            rbWeek.Location = new Point(590, 9);
            rbWeek.Name = "rbWeek";
            rbWeek.Size = new Size(169, 48);
            rbWeek.TabIndex = 2;
            rbWeek.TabStop = true;
            rbWeek.Text = "Неделя";
            rbWeek.UseVisualStyleBackColor = true;
            rbWeek.CheckedChanged += rbWeek_CheckedChanged;
            // 
            // rbDay
            // 
            rbDay.Location = new Point(337, 13);
            rbDay.Name = "rbDay";
            rbDay.Size = new Size(167, 40);
            rbDay.TabIndex = 1;
            rbDay.TabStop = true;
            rbDay.Text = "Сутки";
            rbDay.UseVisualStyleBackColor = true;
            rbDay.CheckedChanged += rbDay_CheckedChanged;
            // 
            // rbShift
            // 
            rbShift.Location = new Point(64, 17);
            rbShift.Name = "rbShift";
            rbShift.Size = new Size(154, 36);
            rbShift.TabIndex = 0;
            rbShift.TabStop = true;
            rbShift.Text = "Смена";
            rbShift.UseVisualStyleBackColor = true;
            rbShift.CheckedChanged += rbShift_CheckedChanged;
            // 
            // btnGenerateWithStep
            // 
            btnGenerateWithStep.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(btnGenerateWithStep, 3);
            btnGenerateWithStep.Location = new Point(114, 267);
            btnGenerateWithStep.Name = "btnGenerateWithStep";
            btnGenerateWithStep.Size = new Size(318, 92);
            btnGenerateWithStep.TabIndex = 15;
            btnGenerateWithStep.Text = "Генерировать с шагом";
            btnGenerateWithStep.UseVisualStyleBackColor = true;
            btnGenerateWithStep.Click += btnGenerateWithStep_Click;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblOperationType;
        private Label lblAddInterval;
        private Label lblBegin;
        private DateTimePicker selectDateTimeStart;
        private Label lblEnd;
        private DateTimePicker selectDateTimeEnd;
        private Button btnDraw;
        private Button btnClear;
        private ComboBox selectOperation;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView;
        private BindingSource bindingSource;
        private Button btnGenerateWithStep;
        private IntervalPainter.DrawIntervalsControl drawIntervalsControl2;
        private Panel panel1;
        private RadioButton rbMonth;
        private RadioButton rbWeek;
        private RadioButton rbDay;
        private RadioButton rbShift;
    }
}
