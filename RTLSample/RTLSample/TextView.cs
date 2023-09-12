using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTLSample
{
    public class TextView : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 5;
            canvas.FontSize = 18;           
            canvas.DrawRectangle(dirtyRect);
            canvas.DrawString("Hello World", dirtyRect.X + 5, dirtyRect.Y + 5, dirtyRect.Width - 10, dirtyRect.Height - 10 -150, HorizontalAlignment.Left, VerticalAlignment.Center);
            canvas.DrawString("مرحبا بالعالم", dirtyRect.X + 5, dirtyRect.Y + 5 + 150, dirtyRect.Width - 10, dirtyRect.Height - 10 - 150, HorizontalAlignment.Left, VerticalAlignment.Center);
        }
    }
}
