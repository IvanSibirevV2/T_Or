using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Or
{
    public static class Ext_ListByte
    {
        public static List<byte> _(this List<byte> _this, byte _bvk)
            => _this.Set_Add(_bvk);
        public static List<byte> _(this List<byte> _this, byte _bvk1, byte _bvk2, byte _bvk3, byte _bvk4)
            => _this.Set_Add(_bvk1).Set_Add(_bvk2).Set_Add(_bvk3).Set_Add(_bvk4);
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        #region 0x00000001..0x00000004 MouseBtn
        public static List<byte> MousBtnLeft(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x01);
        public static List<byte> MousBtnRight(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x02);
        public static List<byte> MousBtnMiddle(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x04);
        #endregion
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public static List<byte> Backspace(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x08);
        public static List<byte> Tab(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x09);
        public static List<byte> Enter(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x0D);
        public static List<byte> Shift(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x10);
        public static List<byte> Ctrl(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x11);
        public static List<byte> Alt(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x12);
        public static List<byte> Pause(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x13);
        public static List<byte> CapsLock(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x14);
        public static List<byte> Escape(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x1B);
        public static List<byte> Space(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x20);
        public static List<byte> PageUp(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x21);
        public static List<byte> PageDown(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x22);
        public static List<byte> End(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x23);
        public static List<byte> Home(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x24);
        public static List<byte> Insert(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x2D);
        public static List<byte> Delete(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x2E);
        public static List<byte> Win(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x5B);
        public static List<byte> WinLeft(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x5B);
        public static List<byte> WinRight(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x5C);
        public static List<byte> KeyApplication(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x5D);
        public static List<byte> ScrollLock(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x91);
        public static List<byte> PrintScreen(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x9A);
        public static List<byte> СommaPoint(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0xBA);
        public static List<byte> EQUally(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0xBB);
        public static List<byte> Сomma(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0xBC);
        public static List<byte> Minus(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0xBD);
        public static List<byte> Dot(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0xBE);
        public static List<byte> Slash(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0xBF);
        public static List<byte> Tilda(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0xC0);
        public static List<byte> SqueaBraketBegin(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0xDB);
        public static List<byte> UnSlash(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0xDC);
        public static List<byte> SqueaBraketEnd(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0xDD);
        public static List<byte> MarkUno(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0xDE);
        //////////////////////////////////////////////////

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        public static List<byte> ArrowLeft(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x25);
        public static List<byte> ArrowUp(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x26);
        public static List<byte> ArrowRight(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x27);
        public static List<byte> ArrowDown(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x28);
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        //
        public static List<byte> _0(this List<byte> _this) => _this._(0x30);
        public static List<byte> _0_Down(this List<byte> _this) => _this._(0xF1, 0x30);
        public static List<byte> _0_Up(this List<byte> _this) => _this._(0xF2, 0x30);
        //
        public static List<byte> _1(this List<byte> _this) => _this._(0x31);
        public static List<byte> _1_Down(this List<byte> _this) => _this._(0xF1, 0x31);
        public static List<byte> _1_Up(this List<byte> _this) => _this._(0xF2, 0x31);
        //
        public static List<byte> _2(this List<byte> _this) => _this._(0x32);
        public static List<byte> _2_Down(this List<byte> _this) => _this._(0xF1, 0x32);
        public static List<byte> _2_Up(this List<byte> _this) => _this._(0xF2, 0x32);
        //
        public static List<byte> _3(this List<byte> _this) => _this._(0x33);
        public static List<byte> _3_Down(this List<byte> _this) => _this._(0xF1, 0x33);
        public static List<byte> _3_Up(this List<byte> _this) => _this._(0xF2, 0x33);
        //
        public static List<byte> _4(this List<byte> _this) => _this._(0x34);
        public static List<byte> _4_Down(this List<byte> _this) => _this._(0xF1, 0x34);
        public static List<byte> _4_Up(this List<byte> _this) => _this._(0xF2, 0x34);
        //
        public static List<byte> _5(this List<byte> _this) => _this._(0x35);
        public static List<byte> _5_Down(this List<byte> _this) => _this._(0xF1, 0x35);
        public static List<byte> _5_Up(this List<byte> _this) => _this._(0xF2, 0x35);
        //
        public static List<byte> _6(this List<byte> _this) => _this._(0x36);
        public static List<byte> _6_Down(this List<byte> _this) => _this._(0xF1, 0x31);
        public static List<byte> _6_Up(this List<byte> _this) => _this._(0xF2, 0x31);
        //
        public static List<byte> _7(this List<byte> _this) => _this._(0x37);
        public static List<byte> _7_Down(this List<byte> _this) => _this._(0xF1, 0x37);
        public static List<byte> _7_Up(this List<byte> _this) => _this._(0xF2, 0x37);
        //
        public static List<byte> _8(this List<byte> _this) => _this._(0x38);
        public static List<byte> _8_Down(this List<byte> _this) => _this._(0xF1, 0x38);
        public static List<byte> _8_Up(this List<byte> _this) => _this._(0xF2, 0x38);
        //
        public static List<byte> _9(this List<byte> _this) => _this._(0x39);
        public static List<byte> _9_Down(this List<byte> _this) => _this._(0xF1, 0x39);
        public static List<byte> _9_Up(this List<byte> _this) => _this._(0xF2, 0x39);
        //
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public static List<byte> A(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x41);
        public static List<byte> B(this List<byte> _this) 
            => _this._(0x00, 0x00, 0x00, 0x42);
        public static List<byte> C(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x43);
        public static List<byte> D(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x44);
        public static List<byte> E(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x45);
        public static List<byte> F(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x46);
        public static List<byte> G(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x47);
        public static List<byte> H(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x48);
        public static List<byte> I(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x49);
        public static List<byte> J(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x4A);
        public static List<byte> K(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x4B);
        public static List<byte> L(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x4C);
        public static List<byte> M(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x4D);
        public static List<byte> N(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x4E);
        public static List<byte> O(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x4F);
        public static List<byte> P(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x50);
        public static List<byte> Q(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x51);
        public static List<byte> R(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x52);
        public static List<byte> S(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x53);
        public static List<byte> T(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x54);
        public static List<byte> U(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x55);
        public static List<byte> V(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x56);
        public static List<byte> W(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x57);
        public static List<byte> X(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x58);
        public static List<byte> Y(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x59);
        public static List<byte> Z(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x5A);
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static List<byte> NumPad0(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x60);
        public static List<byte> NumPad1(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x61);
        public static List<byte> NumPad2(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x62);
        public static List<byte> NumPad3(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x63);
        public static List<byte> NumPad4(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x64);
        public static List<byte> NumPad5(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x65);
        public static List<byte> NumPad6(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x66);
        public static List<byte> NumPad7(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x67);
        public static List<byte> NumPad8(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x68);
        public static List<byte> NumPad9(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x69);
        public static List<byte> NumPadStar(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x6A);
        public static List<byte> NumPadPlas(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x6B);
        public static List<byte> NumPadMinus(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x6D);
        public static List<byte> NumPadDot(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x6E);
        public static List<byte> NumPadSlash(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x6F);
        public static List<byte> NumLock(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x90);
        //////////////////////////////////////////////////////////////////////////////////
        public static List<byte> F1(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x70);
        public static List<byte> F2(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x71);
        public static List<byte> F3(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x72);
        public static List<byte> F4(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x73);
        public static List<byte> F5(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x74);
        public static List<byte> F6(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x75);
        public static List<byte> F7(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x76);
        public static List<byte> F8(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x77);
        public static List<byte> F9(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x78);
        public static List<byte> F10(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x79);
        public static List<byte> F11(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x7A);
        public static List<byte> F12(this List<byte> _this)
            => _this._(0x00, 0x00, 0x00, 0x7B);
        //////////////////////////////////////////////////////////////////////////////////
        //
        public static List<byte> Backspace(this List<byte> _this) => _this._(0x08);
        public static List<byte> Backspace_Down(this List<byte> _this) => _this._(0xF1, 0x08);
        public static List<byte> Backspace_Up(this List<byte> _this) => _this._(0xF2, 0x08);
        //
        public static List<byte> Tab(this List<byte> _this) => _this._(0x09);
        public static List<byte> Tab_Down(this List<byte> _this) => _this._(0xF1, 0x09);
        public static List<byte> Tab_Up(this List<byte> _this) => _this._(0xF2, 0x09);
        //
        public static List<byte> Enter(this List<byte> _this) => _this._(0x0D);
        public static List<byte> Enter_Down(this List<byte> _this) => _this._(0xF1, 0x0D);
        public static List<byte> Enter_Up(this List<byte> _this) => _this._(0xF2, 0x0D);
        //
        public static List<byte> Shift(this List<byte> _this) => _this._(0x10);
        public static List<byte> Shift_Down(this List<byte> _this) => _this._(0xF1, 0x10);
        public static List<byte> Shift_Up(this List<byte> _this) => _this._(0xF2, 0x10);
        //
        public static List<byte> Ctrl(this List<byte> _this) => _this._(0x11);
        public static List<byte> Ctrl_Down(this List<byte> _this) => _this._(0xF1, 0x11);
        public static List<byte> Ctrl_Up(this List<byte> _this) => _this._(0xF2, 0x11);
        //
        public static List<byte> Alt(this List<byte> _this) => _this._(0x12);
        public static List<byte> Alt_Down(this List<byte> _this) => _this._(0xF1, 0x12);
        public static List<byte> Alt_Up(this List<byte> _this) => _this._(0xF2, 0x12);
        //
        public static List<byte> Pause(this List<byte> _this) => _this._(0x13);
        public static List<byte> Pause_Down(this List<byte> _this) => _this._(0xF1, 0x13);
        public static List<byte> Pause_Up(this List<byte> _this) => _this._(0xF2, 0x13);
        //
        public static List<byte> CapsLock(this List<byte> _this) => _this._(0x14);
        public static List<byte> CapsLock_Down(this List<byte> _this) => _this._(0xF1, 0x14);
        public static List<byte> CapsLock_Up(this List<byte> _this) => _this._(0xF2, 0x14);
        //
        public static List<byte> Escape(this List<byte> _this) => _this._(0x1B);
        public static List<byte> Escape_Down(this List<byte> _this) => _this._(0xF1, 0x1B);
        public static List<byte> Escape_Up(this List<byte> _this) => _this._(0xF2, 0x1B);
        //
        public static List<byte> Space(this List<byte> _this) => _this._(0x20);
        public static List<byte> Space_Down(this List<byte> _this) => _this._(0xF1, 0x20);
        public static List<byte> Space_Up(this List<byte> _this) => _this._(0xF2, 0x20);
        //
        public static List<byte> PageUp(this List<byte> _this) => _this._(0x21);
        public static List<byte> PageUp_Down(this List<byte> _this) => _this._(0xF1, 0x21);
        public static List<byte> PageUp_Up(this List<byte> _this) => _this._(0xF2, 0x21);
        //
        public static List<byte> PageDown(this List<byte> _this) => _this._(0x22);
        public static List<byte> PageDown_Down(this List<byte> _this) => _this._(0xF1, 0x22);
        public static List<byte> PageDown_Up(this List<byte> _this) => _this._(0xF2, 0x22);
        //
        public static List<byte> End(this List<byte> _this) => _this._(0x23);
        public static List<byte> End_Down(this List<byte> _this) => _this._(0xF1, 0x23);
        public static List<byte> End_Up(this List<byte> _this) => _this._(0xF2, 0x23);
        //
        public static List<byte> Home(this List<byte> _this) => _this._(0x24);
        public static List<byte> Home_Down(this List<byte> _this) => _this._(0xF1, 0x24);
        public static List<byte> Home_Up(this List<byte> _this) => _this._(0xF2, 0x24);
        //
        public static List<byte> Insert(this List<byte> _this) => _this._(0x2D);
        public static List<byte> Insert_Down(this List<byte> _this) => _this._(0xF1, 0x2D);
        public static List<byte> Insert_Up(this List<byte> _this) => _this._(0xF2, 0x2D);
        //
        public static List<byte> Delete(this List<byte> _this) => _this._(0x2E);
        public static List<byte> Delete_Down(this List<byte> _this) => _this._(0xF1, 0x2E);
        public static List<byte> Delete_Up(this List<byte> _this) => _this._(0xF2, 0x2E);
        //
        public static List<byte> Win(this List<byte> _this) => _this._(0x5B);
        public static List<byte> Win_Down(this List<byte> _this) => _this._(0xF1, 0x5B);
        public static List<byte> Win_Up(this List<byte> _this) => _this._(0xF2, 0x5B);
        //
        public static List<byte> WinLeft(this List<byte> _this) => _this._(0x5B);
        public static List<byte> WinLeft_Down(this List<byte> _this) => _this._(0xF1, 0x5B);
        public static List<byte> WinLeft_Up(this List<byte> _this) => _this._(0xF2, 0x5B);
        //
        public static List<byte> WinRight(this List<byte> _this) => _this._(0x5C);
        public static List<byte> WinRight_Down(this List<byte> _this) => _this._(0xF1, 0x5C);
        public static List<byte> WinRight_Up(this List<byte> _this) => _this._(0xF2, 0x5C);
        //
        public static List<byte> KeyApplication(this List<byte> _this) => _this._(0x5D);
        public static List<byte> KeyApplication_Down(this List<byte> _this) => _this._(0xF1, 0x5D);
        public static List<byte> KeyApplication_Up(this List<byte> _this) => _this._(0xF2, 0x5D);
        //
        public static List<byte> ScrollLock(this List<byte> _this) => _this._(0x91);
        public static List<byte> ScrollLock_Down(this List<byte> _this) => _this._(0xF1, 0x91);
        public static List<byte> ScrollLock_Up(this List<byte> _this) => _this._(0xF2, 0x91);
        //
        public static List<byte> PrintScreen(this List<byte> _this) => _this._(0x9A);
        public static List<byte> PrintScreen_Down(this List<byte> _this) => _this._(0xF1, 0x9A);
        public static List<byte> PrintScreen_Up(this List<byte> _this) => _this._(0xF2, 0x9A);
        //
        public static List<byte> СommaPoint(this List<byte> _this) => _this._(0xBA);
        public static List<byte> СommaPoint_Down(this List<byte> _this) => _this._(0xF1, 0xBA);
        public static List<byte> СommaPoint_Up(this List<byte> _this) => _this._(0xF2, 0xBA);
        //
        public static List<byte> EQUally(this List<byte> _this) => _this._(0xBB);
        public static List<byte> EQUally_Down(this List<byte> _this) => _this._(0xF1, 0xBB);
        public static List<byte> EQUally_Up(this List<byte> _this) => _this._(0xF2, 0xBB);
        //
        public static List<byte> Сomma(this List<byte> _this) => _this._(0xBC);
        public static List<byte> Сomma_Down(this List<byte> _this) => _this._(0xF1, 0xBC);
        public static List<byte> Сomma_Up(this List<byte> _this) => _this._(0xF2, 0xBC);
        //
        public static List<byte> Minus(this List<byte> _this) => _this._(0xBD);
        public static List<byte> Minus_Down(this List<byte> _this) => _this._(0xF1, 0xBD);
        public static List<byte> Minus_Up(this List<byte> _this) => _this._(0xF2, 0xBD);
        //
        public static List<byte> Dot(this List<byte> _this) => _this._(0xBE);
        public static List<byte> Dot_Down(this List<byte> _this) => _this._(0xF1, 0xBE);
        public static List<byte> Dot_Up(this List<byte> _this) => _this._(0xF2, 0xBE);
        //
        public static List<byte> Slash(this List<byte> _this) => _this._(0xBF);
        public static List<byte> Slash_Down(this List<byte> _this) => _this._(0xF1, 0xBF);
        public static List<byte> Slash_Up(this List<byte> _this) => _this._(0xF2, 0xBF);
        //
        public static List<byte> Tilda(this List<byte> _this) => _this._(0xC0);
        public static List<byte> Tilda_Down(this List<byte> _this) => _this._(0xF1, 0xC0);
        public static List<byte> Tilda_Up(this List<byte> _this) => _this._(0xF2, 0xC0);
        //
        public static List<byte> SqueaBraketBegin(this List<byte> _this) => _this._(0xDB);
        public static List<byte> SqueaBraketBegin_Down(this List<byte> _this) => _this._(0xF1, 0xDB);
        public static List<byte> SqueaBraketBegin_Up(this List<byte> _this) => _this._(0xF2, 0xDB);
        //
        public static List<byte> UnSlash(this List<byte> _this) => _this._(0xDC);
        public static List<byte> UnSlash_Down(this List<byte> _this) => _this._(0xF1, 0xDC);
        public static List<byte> UnSlash_Up(this List<byte> _this) => _this._(0xF2, 0xDC);
        //
        public static List<byte> SqueaBraketEnd(this List<byte> _this) => _this._(0xDD);
        public static List<byte> SqueaBraketEnd_Down(this List<byte> _this) => _this._(0xF1, 0xDD);
        public static List<byte> SqueaBraketEnd_Up(this List<byte> _this) => _this._(0xF2, 0xDD);
        //
        public static List<byte> MarkUno(this List<byte> _this) => _this._(0xDE);
        public static List<byte> MarkUno_Down(this List<byte> _this) => _this._(0xF1, 0xDE);
        public static List<byte> MarkUno_Up(this List<byte> _this) => _this._(0xF2, 0xDE);
        // Перечень 16 битных комианд.
        public static List<byte> _MouseRX0(this List<byte> _this) => _this._(0x00).Set_Add((byte)0x01);
        public static List<byte> _MouseRX1(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x02);
        public static List<byte> _MouseRX5(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x03);
        public static List<byte> _MouseRX25(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x04);
        public static List<byte> _MouseRX50(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x05);
        public static List<byte> _MouseRX100(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x06);
        public static List<byte> _MouseRX250(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x07);
        public static List<byte> _MouseRX500(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x08);
        public static List<byte> _MouseRX_1(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x09);
        public static List<byte> _MouseRX_5(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x0A);
        public static List<byte> _MouseRX_25(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x0B);
        public static List<byte> _MouseRX_50(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x0C);
        public static List<byte> _MouseRX_100(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x0D);
        public static List<byte> _MouseRX_250(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x0E);
        public static List<byte> _MouseRX_500(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x0F);
        //
        public static List<byte> _MouseRY0(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x11);
        public static List<byte> _MouseRY1(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x12);
        public static List<byte> _MouseRY5(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x13);
        public static List<byte> _MouseRY25(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x14);
        public static List<byte> _MouseRY50(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x15);
        public static List<byte> _MouseRY100(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x16);
        public static List<byte> _MouseRY250(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x17);
        public static List<byte> _MouseRY500(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x18);
        public static List<byte> _MouseRY_1(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x19);
        public static List<byte> _MouseRY_5(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x1A);
        public static List<byte> _MouseRY_25(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x1B);
        public static List<byte> _MouseRY_50(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x1C);
        public static List<byte> _MouseRY_100(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x1D);
        public static List<byte> _MouseRY_250(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x1E);
        public static List<byte> _MouseRY_500(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x1F);
        //
        public static List<byte> _Sleep_25(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x21);
        public static List<byte> _Sleep_50(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x22);
        public static List<byte> _Sleep_100(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x23);
        public static List<byte> _Sleep_500(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x24);
        public static List<byte> _Sleep_1000(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x25);
        public static List<byte> _Sleep_5000(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x26);
        //////////////////////////////////////////////////
        ///

        // Перечень 16 битных комианд.
        public static List<byte> _MouseRX0(this List<byte> _this) => _this._(0x00).Set_Add((byte)0x01);
        public static List<byte> _MouseRX1(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x02);
        public static List<byte> _MouseRX5(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x03);
        public static List<byte> _MouseRX25(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x04);
        public static List<byte> _MouseRX50(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x05);
        public static List<byte> _MouseRX100(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x06);
        public static List<byte> _MouseRX250(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x07);
        public static List<byte> _MouseRX500(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x08);
        public static List<byte> _MouseRX_1(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x09);
        public static List<byte> _MouseRX_5(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x0A);
        public static List<byte> _MouseRX_25(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x0B);
        public static List<byte> _MouseRX_50(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x0C);
        public static List<byte> _MouseRX_100(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x0D);
        public static List<byte> _MouseRX_250(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x0E);
        public static List<byte> _MouseRX_500(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x0F);
        //
        public static List<byte> _MouseRY0(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x11);
        public static List<byte> _MouseRY1(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x12);
        public static List<byte> _MouseRY5(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x13);
        public static List<byte> _MouseRY25(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x14);
        public static List<byte> _MouseRY50(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x15);
        public static List<byte> _MouseRY100(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x16);
        public static List<byte> _MouseRY250(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x17);
        public static List<byte> _MouseRY500(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x18);
        public static List<byte> _MouseRY_1(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x19);
        public static List<byte> _MouseRY_5(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x1A);
        public static List<byte> _MouseRY_25(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x1B);
        public static List<byte> _MouseRY_50(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x1C);
        public static List<byte> _MouseRY_100(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x1D);
        public static List<byte> _MouseRY_250(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x1E);
        public static List<byte> _MouseRY_500(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x1F);
        //
        public static List<byte> _Sleep_25(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x21);
        public static List<byte> _Sleep_50(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x22);
        public static List<byte> _Sleep_100(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x23);
        public static List<byte> _Sleep_500(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x24);
        public static List<byte> _Sleep_1000(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x25);
        public static List<byte> _Sleep_5000(this List<byte> _this) => _this.Set_Add((byte)0x00).Set_Add((byte)0x26);
        z

    }
    public class Astra
    {
        public System.Byte p_Byte1 = 0x00;
        public System.Byte p_Byte2 = 0x00;
        public System.Byte p_Byte3 = 0x00;
        public System.Byte p_Byte4 = 0x00;
        public Astra Do() 
        {
            switch(p_Byte1)
            {
                case 0x00:; break;
            }
            return this;
        }
    }
        
    }
}
