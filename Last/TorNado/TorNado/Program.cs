using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorNado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new List<Comander>()
                .Set_Add(new Comander().Set(_nVirtKey: 65, _Description:"A"))
                .Select(a=>a.ToAnonimus())
                .Select(a => a.ToString())
                .ToList()
                .ForEach(x => x.WriteLine())
                ;
            "".ReadLine();
            //писать в классах в обычном ооп задолбешся, по этому вся хреновня будет на ветвлениях

            //класс заержки

            //таки написать класс для одной клавиши и сделать его сттическим
            //    узнать прожата ли клавиша 
            //    опустить клавишу
            //    поднять клавишу

        }
    }
}
