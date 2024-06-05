using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Or;
using System.CMD;
using System.Diagnostics;
using System.Security.Cryptography;

namespace T_Or_EXE
{
    public static class Ext_String
    {
        public static System.String Add(this System.String _this, System.String _str)
            => _this + _str;
        public static System.String NR(this System.String _this)
            => _this.Add("\r\n");

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            new List<byte>().MouseX0().MouseY0().Do();
            "Привет мир".WriteLine();
            "".ReadLine();
        }
    }
}
