using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TorNado;

namespace System
{
	public static class ListComander
	{
        /// <summary>AddComander</summary>
        public static List<Comander> AC(this List<Comander> _this, System.Byte _nVirtKey, System.String _Description)
        {
			_this.Add(new Comander().Set(_nVirtKey:_nVirtKey,_Description:_Description));
			return _this;
		}

		public static List<Comander> p_ListComander = new List<Comander>()
			.AC(0x01, "_MousBtnLeft")
			.AC(0x02, "_MousBtnRight")
            .AC(0x04, "_MousBtnMiddle")
            .AC(0x08, "_Backspace")
            .AC(0x09, "_TAB")
            .AC(0x0D, "_ENTER")
            .AC(0x10, "_SHIFT")
            .AC(0x11, "_CTRL")
            .AC(0x12, "_ALT")
            .AC(0x13,"_PAUSE")
            .AC(0x14, "_CAPSLOCK")
            .AC(0x1B, "_ESCAPE")
            .AC(0x20, "_SPACE")
            .AC(0x21, "_PAGEUP")
            .AC(0x22, "_PAGEDOWN")
            .AC(0x23, "_END")
            .AC(0x24, "_HOME")
            .AC(0x25, "_arrow.LEFT")
            .AC(0x26, "_arrow.UP")
            .AC(0x27, "_arrow.RIGHT")
            .AC(0x28, "_arrow.DOWN")
            .AC(0x2D, "_INSERT")
            .AC(0x2E, "_DELETE")
            
            .AC(0x30, "_0")
            .AC(0x31, "_1")
            .AC(0x32, "_2")
            .AC(0x33, "_3")
            .AC(0x34, "_4")
            .AC(0x35, "_5")
            .AC(0x36, "_6")
            .AC(0x37, "_7")
            .AC(0x38, "_8")
            .AC(0x39, "_9")

            .AC(0x41, "_A")
            .AC(0x42, "_B")
            .AC(0x43, "_C")
            .AC(0x44, "_D")
            .AC(0x45, "_E")
            .AC(0x46, "_F")
            .AC(0x47, "_G")
            .AC(0x48, "_H")
            .AC(0x49, "_I")
            .AC(0x4A, "_J")
            .AC(0x4B, "_K")
            .AC(0x4C, "_L")
            .AC(0x4D, "_M")
            .AC(0x4E, "_N")
            .AC(0x4F, "_O")
            .AC(0x50, "_P")
            .AC(0x51, "_Q")
            .AC(0x52, "_R")
            .AC(0x53, "_S")
            .AC(0x54, "_T")
            .AC(0x55, "_U")
            .AC(0x56, "_V")
            .AC(0x57, "_W")
            .AC(0x58, "_X")
            .AC(0x59, "_Y")
            .AC(0x5A, "_Z")
            .AC(0x5B, "_WIN")
            .AC(0x5B, "_LWIN")
            .AC(0x5C, "_RWIN")
            .AC(0x5D, "_KeyApplication")
            .AC(0x60, "_NumPad0")
            .AC(0x61, "_NumPad1")
            .AC(0x62, "_NumPad2")
            .AC(0x63, "_NumPad3")
            .AC(0x64, "_NumPad4")
            .AC(0x65, "_NumPad5")
            .AC(0x66, "_NumPad6")
            .AC(0x67, "_NumPad7")
            .AC(0x68, "_NumPad8")
            .AC(0x69, "_NumPad9")
            .AC(0x6A, "_NumPad*")
            .AC(0x6B, "_NumPad+")
            .AC(0x6D, "_NumPad-")
            .AC(0x6E, "_NumPad.")
            .AC(0x6F, "_NumPad/")
            .AC(0x70, "_F1")
            .AC(0x71, "_F2")
            .AC(0x72, "_F3")
            .AC(0x73, "_F4")
            .AC(0x74, "_F5")
            .AC(0x75, "_F6")
            .AC(0x76, "_F7")
            .AC(0x77, "_F8")
            .AC(0x78, "_F9")
            .AC(0x79, "_F10")
            .AC(0x7A, "_F11")
            .AC(0x7B, "_F12")
            .AC(0x90, "_NumLock")
            .AC(0x91, "_ScrollLock")
            .AC(0x9A, "_PrintScreen")
            .AC(0xBA, "_;")
            .AC(0xBB, "_equ")


.AC(0xBC,"_,")
.AC(0xBD,"_-")
.AC(0xBE,"_.")
.AC(0xBF,"_/")
.AC(0xC0,"_ ~")
.AC(0xDB,"_[")
.AC(0xDC,@"_\ ")
.AC(0xDD,"_]")
.AC(0xDE,"_'")

            ;
        /*


          */
    }
}
