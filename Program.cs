// 1. Referenciák hozzáadása
// - PresentationCore
// - PresentationFramework
// - WindowsBase
// - System.Xaml

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2. Névterek hozzáadása
using System.Windows;
using System.Windows.Controls;


namespace ConsoleToWPF
{
    class Program
    {
        // 3. Szálkezelési opció hozzáadása
        [STAThread]
        static void Main(string[] args)
        {
            //Application myApp = new Application();
            //Window w = new Window();
            //myApp.Run(w);

            //4. opcionális: Console ablak eltüntetése
            //Properties /Application/Output type: Windows application
            MyApplication myApp = new MyApplication();
        }
    }
}
