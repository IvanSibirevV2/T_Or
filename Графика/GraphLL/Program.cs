using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using T_Or;

namespace System
{
    public class MyBitmap
    {
        List<List<System.Drawing.Color>> _LLColor = new List<List<Color>>();
        public MyBitmap() { }
        public MyBitmap(Bitmap _Bitmap) 
        {

        }

    }
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
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            new List<byte>()
                .MouseX0().MouseY0()
                .MouseY1000().MouseY50()
                .MouseX100().MouseX100()
                .MousBtnLeft()
                .Do()
            ;
            "Привет мир".WriteLine();
            //"".ReadLine();

            //Bitmap _bitmap = new Bitmap(@"Tiger.jpg");
            /*
               _bitmap.Size.Width.ToString().WriteLine();
               _bitmap.Size.Height.ToString().WriteLine();

               new List<object>()
                   .Set(a => 
                   {
                       for (int i = 0; i < _bitmap.Size.Width; i++)
                           for (int j = 0; j < _bitmap.Size.Height; j++)
                       a.Add(new {i=i,j=j});
                   })
                   .AsParallel()
                   .Select(a => a.ToString().WriteLine())
                   .Select(a=>a.ToString().WriteLine())
                   .ToList()
                   ;
               new Color();
            */
            /*
               List<string> _ls = new List<string>();
               for (int i = 0; i < _bitmap.Size.Width; i++)
               {
                   for (int j = 0; j< _bitmap.Size.Height; j++)
                   {
                       Color _Color = _bitmap.GetPixel(i, j);
                       _ls.Add(new {x= i, y= j,r= _Color.R, g= _Color.G, b= _Color.B, a= _Color.A}.ToString());
                   }
               }

                   ;
               Clipboard.SetText(System.String.Join("\n", _ls));
              */

            "Привет мир".WriteLine();
            //"".ReadLine();
        }
    }
}
