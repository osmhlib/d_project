using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

public class CustomDatePicker : DateTimePicker
{
    private readonly MaterialSkinManager materialSkinManager;
    private const int ArrowSize = 7; // Розмір стрілки випадаючого календаря

    public CustomDatePicker()
    {
        materialSkinManager = MaterialSkinManager.Instance;
        this.Format = DateTimePickerFormat.Short;
        this.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        this.BackColor = Color.FromArgb(232, 232, 232);
        this.ForeColor = Color.Black;

        this.SetStyle(ControlStyles.UserPaint, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Зафарбовування фону
        using (SolidBrush brush = new SolidBrush(Color.FromArgb(232, 232, 232)))
        {
            e.Graphics.FillRectangle(brush, new Rectangle(0, 0, this.Width, this.Height));
        }

        // Створення тексту
        TextRenderer.DrawText(e.Graphics, this.Text, this.Font, this.ClientRectangle, Color.Black, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

        // Створення стрілки випадаючого календаря
        int arrowX = this.Width - 20;
        int arrowY = (this.Height - ArrowSize) / 2;
        Point[] arrowPoints = {
            new Point(arrowX, arrowY),
            new Point(arrowX + ArrowSize, arrowY),
            new Point(arrowX + (ArrowSize / 2), arrowY + ArrowSize)
        };
        using (SolidBrush brush = new SolidBrush(Color.Black))
        {
            e.Graphics.FillPolygon(brush, arrowPoints);
        }

        // Намалювати межу (тільки нижню межу)
        using (Pen pen = new Pen(Color.FromArgb(0, 0, 0), 1)) 
        {
            e.Graphics.DrawLine(pen, 0, this.Height - 1, this.Width, this.Height - 1);
        }
    }
}
