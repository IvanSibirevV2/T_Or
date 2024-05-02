using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_2
{
    public static class Ext_
    {
        public static System.Drawing.Image LoadFromeFile(this System.Drawing.Image _this, string _FileName = "Tiger.jpg")
        {
            System.IO.FileStream _file = new System.IO.FileStream(_FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Inheritable);
            _this = Image.FromStream(_file);
            _file.Close();
            return _this;
        }
    }

    public partial class Form1 : Form
    {
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                pictureBox1.Image = pictureBox1.Image.LoadFromeFile(openFileDialog1.FileName);
            }
            catch { }
        }
        public Form1() {
        InitializeComponent();
        pen = new Pen (Brushes.Blue, 0.8f); //цвет и толщина линии выделения
        pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; //штрихи
        selRect = new Rectangle (0, 0, 0, 0);
        flag = false;
        }
        Image Img;
        Rectangle selRect; //выделенный прямоугольник
        Point orig; //точка для привязки прямоугольника
        Pen pen; //перо для отрисовки
	    bool flag; //флажок показывает, находимся ли в режиме выделения части рисунка


    private void повернутьВокруг0YToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (pictureBox1.Image != null)
        {
            Bitmap bitmap1 = new Bitmap(pictureBox1.Image);
            if (bitmap1 != null)
            {
                bitmap1.RotateFlip(RotateFlipType.Rotate180FlipY);
                pictureBox1.Image = bitmap1;
            }
        }
    }

    private void уменьшитьВ2РазаToolStripMenuItem_Click (object sender, EventArgs e)
    {
        if (pictureBox1.Image == null) return;
        Bitmap  bitmap1 = new Bitmap (pictureBox1.Image); //взяли рисунок из компоненты
        Graphics  Gr1 = Graphics.FromImage (bitmap1); 
        //получили поверхность рисования из исходного рисунка
        Bitmap  bitmap2 = new Bitmap (bitmap1.Width / 2, bitmap1.Height / 2, Gr1);
        //сделали вдвое меньший рисунок с тем же разрешением
        Graphics  Gr2 = Graphics.FromImage (bitmap2); 
        //получили поверхность рисования из меньшего рисунка
        Rectangle compressionRectangle = new Rectangle 
            (0, 0, bitmap1.Width / 2, bitmap1.Height / 2); //определили масштабирующий прямоугольник
        Gr2.DrawImage (bitmap1, compressionRectangle);
        //отрисовали на поверхности второго рисунка первый со сжатием
        Pen  MyPen = new Pen (Color.Red); //на измененном рисунке можно что-то подрисовать
        Gr2.DrawRectangle (MyPen, 0, 0, bitmap2.Width - 1, bitmap2.Height - 1);
        //например, сделать красную рамку
        pictureBox1.Image = bitmap2; //назначили второй рисунок компоненте
        pictureBox1.Size = bitmap2.Size; //поставили размер компоненты по размерам нового рисунка
        this.ClientSize = pictureBox1.Size; //...и такой же размер клиентской формы
    }

    private void сохранитьToolStripMenuItem_Click (object sender, EventArgs e)
    {
        if (pictureBox1.Image == null) return;
        Bitmap bitmap1 = new Bitmap (pictureBox1.Image);
        try 
        {
            bitmap1.Save (openFileDialog1.FileName);
            //Сохраняем под именем из диалога открытия файла
            //Может вызвать исключение, если исходный файл ещё открыт
        }
        catch (Exception ex) {
            MessageBox.Show (ex.Message + "\nНе удалось сохранить файл",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
    }

    private void прозрачныйЦветToolStripMenuItem_Click (object sender, EventArgs e)
    {
        if (pictureBox1.Image == null) return;
        Bitmap bitmap1 = new Bitmap (pictureBox1.Image);
        if (colorDialog1.ShowDialog () == DialogResult.OK)
        {
            bitmap1.MakeTransparent (colorDialog1.Color);
            pictureBox1.Image = bitmap1;
        }
    }

    private void фильтроватьПоПикселямToolStripMenuItem_Click (object sender, EventArgs e)
    {
        if (pictureBox1.Image == null) return;
        Bitmap bitmap1 = new Bitmap (pictureBox1.Image);
        for (int x = 0; x < bitmap1.Width; x++)
        for (int y = 0; y < bitmap1.Height; y++) {
            Color pixelColor = bitmap1.GetPixel (x, y);
            if (pixelColor.R > 250 && pixelColor.G > 250 && pixelColor.B > 250)
            continue; //не фильтруем пиксели, чей цвет близок к белому 
            Color newColor = Color.FromArgb (pixelColor.R, pixelColor.G, pixelColor.B / 2);
            bitmap1.SetPixel (x, y, newColor);
        }
        pictureBox1.Image = bitmap1;
    }

    private void оттенкиСерогоToolStripMenuItem_Click (object sender, EventArgs e)
    {
        if (pictureBox1.Image == null) return;
        Bitmap bitmap1 = new Bitmap (pictureBox1.Image);
        Bitmap bitmap2 = new Bitmap (bitmap1.Width, bitmap1.Height);
        Graphics g = Graphics.FromImage (bitmap2);
        float [] [] Map = {
            new float[] {0.30f, 0.30f, 0.30f, 0.00f, 0.00f },
            new float[] {0.59f, 0.59f, 0.59f, 0.00f, 0.00f },
            new float[] {0.11f, 0.11f, 0.11f, 0.00f, 0.00f },
            new float[] {0.00f, 0.00f, 0.00f, 1.00f, 0.00f },
            new float[] {0.00f, 0.00f, 0.00f, 0.00f, 1.00f }
        };
        System.Drawing.Imaging.ColorMatrix GrayscaleMatrix = 
        new System.Drawing.Imaging.ColorMatrix (Map);
        System.Drawing.Imaging.ImageAttributes attributes = 
        new System.Drawing.Imaging.ImageAttributes ();
        attributes.SetColorMatrix (GrayscaleMatrix);
        Rectangle rect = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
        g.DrawImage (bitmap1, rect, 0, 0, bitmap1.Width, bitmap1.Height, 
        GraphicsUnit.Pixel, attributes);
        pictureBox1.Image = bitmap2;
    }

    private void растянутьИСохранитьToolStripMenuItem_Click (object sender, EventArgs e)
    {
        if (pictureBox1.Image == null) return;
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.Dock = DockStyle.Fill; //установили растягивание
        Bitmap bitmap1 = new Bitmap (pictureBox1.Image);
        Bitmap bitmap2 = new Bitmap (pictureBox1.Width, pictureBox1.Height);
            //у 2-го рисунка - размер компоненты
        Graphics g = Graphics.FromImage (bitmap2);
            //получили графический контекст из 2-го рисунка
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
            //настроили режим интерполяции
        g.DrawImage (bitmap1, new Rectangle(0,0, bitmap2.Width, bitmap2.Height));
            //отрисовали в контекст 2-го рисунка исходный, неискажённый риунок
        pictureBox1.Image = bitmap2; //назначили искажённый рисунок компоненте
        сохранитьToolStripMenuItem_Click (this, e); //вызвали метод сохранения
        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        pictureBox1.Dock = DockStyle.None; //восстановили свойства
        pictureBox1.Image = bitmap1; //вернули старый рисунок
    }

    private void pictureBox1_Paint (object sender, PaintEventArgs e)
    {
        //Этот обработчик мы создали в конструкторе
        //Для ситуации, когда выделяем рамку
        e.Graphics.DrawRectangle (Pens.Black, selRect);
    }
    private void Selection_Paint (object sender, PaintEventArgs  e)
    {
        //Добавили свой обработчик Paint для остальных ситуаций
        e.Graphics.DrawRectangle (pen, selRect);
    }

    private void pictureBox1_MouseDown (object sender, MouseEventArgs e)
    {
        //Этот обработчик мы создали в конструкторе
        //Нажали мышку - включаем наш обработчик и выключаем стандартный
        pictureBox1.Paint -= new PaintEventHandler (pictureBox1_Paint);
        pictureBox1.Paint += new PaintEventHandler (Selection_Paint);
        orig = e.Location; //запомнили, где начало выделения
        flag = true;
    }

    private void pictureBox1_MouseUp (object sender, MouseEventArgs e)
    {
        //Этот обработчик мы создали в конструкторе
        //отжали мышку - всё наоборот
        pictureBox1.Paint -= new PaintEventHandler (Selection_Paint);
        pictureBox1.Paint += new PaintEventHandler (pictureBox1_Paint);
        pictureBox1.Invalidate (); //принудительно перерисовать
        flag = false; //выйти из режима выделения
    }

    private void pictureBox1_MouseMove (object sender, MouseEventArgs e)
    {
        //Этот обработчик мы создали в конструкторе
        if (flag) { //если в режиме выделения
        selRect = GetSelectionRectangle (orig, e.Location); //запоминаем выделенное
        if (e.Button == MouseButtons.Left) {
            pictureBox1.Refresh (); //рефрешим картинку по нажатию левой кнопки
        }
        }
    }

    private Rectangle GetSelectionRectangle (Point orig, Point location)
    {
        //Этот метод пришлось написать, чтобы координаты выделения правильно запоминались
        //независимо от того, в какую сторону тащим курсор мыши
        Rectangle rect = new Rectangle ();
        int dX = location.X - orig.X, dY = location.Y - orig.Y;
        System.Drawing.Size size = new System.Drawing.Size (Math.Abs (dX), Math.Abs (dY));
        //размеры текущего выделения
        if (dX >= 0 && dY >= 0) rect = new Rectangle (orig, size);
        else if (dX < 0 && dY > 0) rect = new Rectangle (location.X, orig.Y, size.Width, size.Height);
        else if (dX > 0 && dY < 0) rect = new Rectangle (orig.X, location.Y, size.Width, size.Height);
        else rect = new Rectangle (location, size);
        return rect;
    }

    private void обрезатьПоРамкеToolStripMenuItem_Click (object sender, EventArgs e)
    {
        if (pictureBox1.Image == null) return;
        if (selRect.Width>0 && selRect.Height>0) {
        Bitmap bitmap1 = new Bitmap (pictureBox1.Image);
        Bitmap bitmap2 = new Bitmap (selRect.Width, selRect.Height);
        Graphics g = Graphics.FromImage (bitmap2);
        g.DrawImage (bitmap1, 0, 0, selRect, GraphicsUnit.Pixel);
        pictureBox1.Image = bitmap2;
        selRect = new Rectangle (0, 0, 0, 0);
        }
    }

    ////////////////////////
    }
}
