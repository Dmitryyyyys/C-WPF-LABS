using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    static class Program
    {
        [STAThread]///обяз в winforms, или нек. компоненты раб. неправильно
        static void Main()
        {
            Application.EnableVisualStyles();///цвета, шрифты, виз.эл-ты
            Application.SetCompatibleTextRenderingDefault(false);///совместимое отобр.текста по умолч
                                                                 ///нек.эл-ты упр. отобр.текст с пом. новых функций GDI+
            Application.Run(new Form1());///запуск
        }
    }
}
