using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

public class CustomDataGridView : DataGridView
{
    private readonly MaterialSkinManager materialSkinManager;

    public CustomDataGridView()
    {
        materialSkinManager = MaterialSkinManager.Instance;
        this.EnableHeadersVisualStyles = false;
        this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        // Встановлення стилів за замовчуванням
        this.BackgroundColor = Color.FromArgb(242, 242, 242); 
        this.BorderStyle = BorderStyle.None;
        this.GridColor = materialSkinManager.ColorScheme.LightPrimaryColor;

        // Встановлення стилю заголовків стовпчиків
        var columnHeaderStyle = new DataGridViewCellStyle
        {
            BackColor = Color.FromArgb(55, 71, 79), 
            ForeColor = materialSkinManager.ColorScheme.TextColor,
            Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel),
            SelectionBackColor = Color.LightBlue, 
            SelectionForeColor = materialSkinManager.ColorScheme.TextColor,
            Alignment = DataGridViewContentAlignment.MiddleLeft
        };
        this.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

        // Встановлення стилю заголовків рядків
        var rowHeaderStyle = new DataGridViewCellStyle
        {
            BackColor = Color.FromArgb(55, 71, 79),
            ForeColor = materialSkinManager.ColorScheme.TextColor,
            Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel), 
            SelectionBackColor = Color.LightBlue,
            SelectionForeColor = materialSkinManager.ColorScheme.TextColor
        };
        this.RowHeadersDefaultCellStyle = rowHeaderStyle;

        // Set rows style
        var rowsStyle = new DataGridViewCellStyle
        {
            BackColor = Color.FromArgb(242, 242, 242),
            ForeColor = materialSkinManager.ColorScheme.TextColor,
            Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel), 
            SelectionBackColor = Color.LightBlue, 
            SelectionForeColor = materialSkinManager.ColorScheme.TextColor
        };
        this.DefaultCellStyle = rowsStyle;
    }
}
