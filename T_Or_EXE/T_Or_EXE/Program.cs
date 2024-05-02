using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Or;
using System.CMD;
using System.Diagnostics;

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
            "rmdir T_Or /s /q".Execute_CMDoor_V0().WriteLine();
            System.IO.File.Exists("nircmd.exe").ToString().WriteLine();
            ""
            .Add("@ECHO off").NR()
            .Add("ECHO %cd%").NR()
            .Add(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe -NoExit -command ""git clone --depth 1 https://github.com/IvanSibirevV2/T_Or.git;exit;"" ").NR()
               .Execute_CMDoor_V0().WriteLine()
               ;
            ""
            .Add("@ECHO off").NR()
            .Add("cd T_Or").NR()
            .Add("cd T_Or_EXE").NR()
            .Add("cd packages").NR()
            .Add("cd T_Or").NR()
            .Add("cd bin").NR()
            .Add("cd Debug").NR()


            .Add("ECHO %cd%").NR()
            .Execute_CMDoor_V0().WriteLine();


            
            ;
            "Привет мир".WriteLine();
            "".ReadLine();
        }
    }
}
