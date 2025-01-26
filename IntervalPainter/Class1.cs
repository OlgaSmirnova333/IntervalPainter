using SkiaSharp;
using RIntervals.BaseClasses;
using RIntervals.Interfaces;
using System.ComponentModel;
using System.Security.Policy;



// Класс для рисования временных интервалов

public class IntervalDrawer
{
    private SKCanvas _canvas;

    public IntervalDrawer(SKCanvas canvas)
    {
        _canvas = canvas ?? throw new ArgumentNullException(nameof(canvas));
    }

    public async Task DrawIntervalsAsync<T>(
        BindingList<Interval<T>> intervals,
        float canvasWidth,
        DateTime periodStart,
        DateTime periodEnd,
        float yPosition = 200,
        float height = 50
        ) where T : IIntervalSource

    {
        if (intervals == null || intervals.Count == 0)
            throw new ArgumentException("Интервал не может быть пустым или иметь значение null", nameof(intervals));

        if (periodEnd <= periodStart)
            throw new ArgumentException("Конец периода должен быть позже начала периода");

        var rectangles = await Task.Run(() =>
            {
                var totalMinutes = (float)(periodEnd - periodStart).TotalMinutes;
                var scale = canvasWidth / totalMinutes;

                var result = new List<SKRect>();
                foreach (var interval in intervals)
                {
                    var startMinutes = (float)(interval.Start.ToUniversalTime() - periodStart.ToUniversalTime()).TotalMinutes;
                    var endMinutes = (float)(interval.End.ToUniversalTime() - periodStart.ToUniversalTime()).TotalMinutes;
                    if (startMinutes >= 0 && endMinutes <= totalMinutes)
                    {
                        result.Add(new SKRect(startMinutes * scale, yPosition, endMinutes * scale, yPosition + height));

                    }
                }

                return result;
            });
        using var paint = new SKPaint
        {
            Color = new SKColor(255, 38, 40),
            IsStroke = false,
            IsAntialias = true
        };

        foreach (var rect in rectangles)
        {
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
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Размеры холста должны быть больше нуля");

        _bitmap = new SKBitmap(width, height);
        _canvas = new SKCanvas(_bitmap);
    }

    // очистка холста
    public void Clear(SKColor color) => _canvas.Clear(color);

    // Получение холства
    public SKCanvas GetCanvas() => _canvas;

    // преобразование в изображение для дальнейшего использования в PictureBox
    public async Task<Bitmap> GetBitmapAsync()
    {
        using var image = SKImage.FromBitmap(_bitmap);
        using var data = image.Encode(SKEncodedImageFormat.Png, 100);
        using var stream = new MemoryStream();
        await data.SaveToAsync(stream);
        stream.Seek(0, SeekOrigin.Begin);
        return new Bitmap(stream);
    }
}

public static class SKDataExtentions
{
    public static async Task SaveToAsync(this SKData data, Stream stream)
    {
        if (data == null) throw new ArgumentNullException(nameof(data));
        if (stream == null) throw new ArgumentNullException(nameof(stream));

        await stream.WriteAsync(data.ToArray(), 0, (int)data.Size);

    }
}

// Класс для отображения результата в PictureBox
public class PictureBoxRenderer
{
    private PictureBox _pictureBox;

    public PictureBoxRenderer(PictureBox pictureBox)
    {
        _pictureBox = pictureBox ?? throw new ArgumentNullException(nameof(pictureBox));
    }

    public async Task RenderAsync(Bitmap bitmap)
    {
        if (bitmap == null)
            throw new ArgumentNullException(nameof(bitmap));
        await Task.Run(() =>
        {
            _pictureBox.Image = bitmap;
        });
    }
}


