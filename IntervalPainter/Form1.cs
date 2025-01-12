using SkiaSharp;
using RIntervals.BaseClasses;
using RIntervals.Interfaces;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private CanvasManager canvasManager;
        private PictureBoxRenderer pictureBoxRenderer;
        private List<Interval<IIntervalSource>> IntervalsTime;



        public Form1()
        {
            InitializeComponent();


            canvasManager = new CanvasManager(pictureBox1.Width, pictureBox1.Height);
            pictureBoxRenderer = new PictureBoxRenderer(pictureBox1);
            IntervalsTime = new List<Interval<IIntervalSource>>();

        }



        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Очистка холста
            canvasManager.Clear(SKColors.White);

            // Рисование интервалов
            var intervalDrawer = new IntervalDrawer(canvasManager.GetCanvas());
            intervalDrawer.DrawIntervals(IntervalsTime, pictureBox1.Width);

            // Отображение результата
            var bitmap = canvasManager.GetBitmap();
            pictureBoxRenderer.Render(bitmap);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            canvasManager.Clear(SKColors.White);
            var bitmap = canvasManager.GetBitmap();
            pictureBoxRenderer.Render(bitmap);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var interval = new Interval<IIntervalSource>(selectDateTimeStart.Value, selectDateTimeEnd.Value);
            IntervalsTime.Add(interval);
            listBox1.Items.Add(selectDateTimeStart.Value.ToString() + "-" + selectDateTimeEnd.Value.ToString());
           


        }
    }
}


 