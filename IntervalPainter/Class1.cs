using SkiaSharp;
using RIntervals.BaseClasses;
using RIntervals.Interfaces;



// Класс для рисования временных интервалов

public class IntervalDrawer
{
    private SKCanvas _canvas;

    public IntervalDrawer(SKCanvas canvas)
    {
        _canvas = canvas;
    }

    public void DrawIntervals<T>(List<Interval<T>> intervals, float canvasWidth) where T : IIntervalSource
    {
        // вычисление масштаба (в качестве интервала общего взала месяц, наверное, стоит добавить какой-то первоначальный
        // ввод интервала, внутри которого будут другие интервалы)
        var PeriodStart = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Local);
        var PeriodEnd = new DateTime(2025, 2, 1, 0, 0, 0, DateTimeKind.Local);
        var MinCount = (long)(PeriodEnd.ToUniversalTime() - PeriodStart.ToUniversalTime()).TotalMinutes;
        var Scale = canvasWidth / MinCount;

        // Строим интервалы с учётом рассчитанного масштаба
        foreach (var interval in intervals)
        {            
            var TS = (long) (interval.Start.ToUniversalTime() - PeriodStart.ToUniversalTime()).TotalMinutes;
            var TE = (long)(interval.End.ToUniversalTime() - PeriodStart.ToUniversalTime()).TotalMinutes;
            var rect = new SKRect(TS * Scale, 200, TE * Scale, 250);
            var paint = new SKPaint
            {
                Color = new SKColor(255, 38, 40),
                IsStroke = false,
                IsAntialias = true
            };
            _canvas.DrawRect(rect, paint);
        }
    }
}


// Класс для управления холстом
public class CanvasManager
{
    private SKBitmap _bitmap;
    private SKCanvas _canvas;

    public CanvasManager(int width, int height)
    {
        _bitmap = new SKBitmap(width, height);
        _canvas = new SKCanvas(_bitmap);
    }

    // очистка холста
    public void Clear(SKColor color)
    {
        _canvas.Clear(color);
    }

    // Получение холства
    public SKCanvas GetCanvas()
    {
        return _canvas;
    }

    // преобразование в изображение для дальнейшего использования в PictureBox
    public Bitmap GetBitmap()
    {
        using (var image = SKImage.FromBitmap(_bitmap))
        using (var data = image.Encode(SKEncodedImageFormat.Png, 100))
        using (var stream = new MemoryStream())
        {
            data.SaveTo(stream);
            return new Bitmap(stream);
        }
    }
}

// Класс для отображения результата в PictureBox
public class PictureBoxRenderer
{
    private PictureBox _pictureBox;

    public PictureBoxRenderer(PictureBox pictureBox)
    {
        _pictureBox = pictureBox;
    }

    public void Render(Bitmap bitmap)
    {
        _pictureBox.Image = bitmap;
    }
}


