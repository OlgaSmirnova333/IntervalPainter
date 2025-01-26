using SkiaSharp;
using RIntervals.BaseClasses;
using RIntervals.Interfaces;
using System.ComponentModel;
using System.Drawing.Text;
using System;


namespace DrawIntervals
{
    public partial class DrawIntervalsForm : Form
    {
        #region Prts
        enum Operations
        {
            Объединение,
            Пересечение
        }
        private CanvasManager canvasManager;
        private PictureBoxRenderer pictureBoxRenderer;
        private BindingList<Interval<IIntervalSource>> IntervalsTime;
        private TimeSpan Step = new TimeSpan(18, 0, 0);
        private DateTime now = DateTime.Now;
        private DateTime PeriodStart;
        private DateTime PeriodEnd;

        #endregion


        public DrawIntervalsForm()
        {
            InitializeComponent();

            canvasManager = new CanvasManager(drawIntervalsControl2.Width, drawIntervalsControl2.pictureBox1.Height);
            pictureBoxRenderer = new PictureBoxRenderer(drawIntervalsControl2.pictureBox1);
            IntervalsTime = new BindingList<Interval<IIntervalSource>>();
            bindingSource1.DataSource = IntervalsTime;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            comboBox1.DataSource = Enum.GetNames(typeof(Operations));

        }



        private async void btnDraw_Click(object sender, EventArgs e)
        {
            await RenderIntervals(drawIntervalsControl2.pictureBox1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            IntervalsTime.Clear();
            canvasManager.Clear(SKColors.White);
            drawIntervalsControl2.pictureBox1.Invalidate();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var interval = new Interval<IIntervalSource>(selectDateTimeStart.Value, selectDateTimeEnd.Value);
            IntervalsTime.Add(interval);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            selectDateTimeStart.Value = IntervalsTime[IntervalsTime.Count - 1].End;
            selectDateTimeEnd.Value = IntervalsTime[IntervalsTime.Count - 1].End + Step;
        }


        public async Task RenderIntervals(PictureBox pictureBox)
        {

            var intervalDrawer = new IntervalsDrawer(canvasManager.GetCanvas());
            await intervalDrawer.DrawIntervalsAsync(
                IntervalsTime,
                drawIntervalsControl2.Width,
                PeriodStart,
                PeriodEnd
                );

            var bitmap = await canvasManager.GetBitmapAsync();
            var renderer = new PictureBoxRenderer(pictureBox);
            await renderer.RenderAsync(bitmap);

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DateTime dayShiftStart = now.Date.AddHours(8);  
            DateTime dayShiftEnd = now.Date.AddHours(20);

            DateTime nightShiftStart = now.Date.AddHours(20);
            DateTime nightShiftEnd = now.Date.AddDays(1).AddHours(8);

            if (now >= dayShiftStart && now < dayShiftEnd)
            {
                PeriodStart = dayShiftStart;
                PeriodEnd = dayShiftEnd;
            }
            else
            {
                PeriodStart = nightShiftStart;
                PeriodEnd = nightShiftEnd;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PeriodStart = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            PeriodEnd = new DateTime(now.Year, now.Month, now.Day + 1, 0, 0, 0);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DayOfWeek currentDayOfWeek = now.DayOfWeek;
            int offsetMonday = (currentDayOfWeek == DayOfWeek.Sunday ? 6 : (int)currentDayOfWeek - 1);
            DateTime monday = now.AddDays(-offsetMonday);
            int offsetSunday = (7 - (int)currentDayOfWeek) % 7 ;
            DateTime sunday = now.AddDays(offsetSunday + 1);
            PeriodStart = new DateTime(monday.Year, monday.Month, monday.Day, 0, 0, 0);
            PeriodEnd = new DateTime(sunday.Year, sunday.Month, sunday.Day, 0, 0, 0);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int lastDay = DateTime.DaysInMonth(now.Year, now.Month);
            PeriodStart = new DateTime(now.Year, now.Month, 1, 0, 0, 0);
            PeriodEnd = new DateTime(now.Year, now.Month, lastDay, 0, 0, 0);
        }
    }
}


 