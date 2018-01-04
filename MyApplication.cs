using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ConsoleToWPF
{
    class MyApplication : Application
    {
        Window MyWindow; 
        Button MyButton;
        Button MyButton2;
        Label MyLabel;
        Grid MyGrid; // elrendezési (Layout) komponens
        TextBox MyTb;

        static Random R = new Random();

        public MyApplication()
        {
            MyWindow = new Window
            {
                Width = 800,
                Height = 600
            };
            MyWindow.SizeChanged += MyWindow_SizeChanged;

            MyLabel = new Label
            {
                Content = "Alma",
                Margin = new Thickness(300, 100, 0, 0)
            };

            MyTb = new TextBox
            {
                Width = 200,
                Height = 20,
                Margin = new Thickness(300, 200, 0, 0)
            };
            MyTb.TextChanged += MyTb_TextChanged;



            MyGrid = new Grid();
            //mySp = new StackPanel();
            MyWindow.Title = $"{MyGrid.ActualWidth}x{MyGrid.ActualHeight}";

            MyButton = new Button
            {
                Content = "Click Me 1",
                Width = 200,
                Height = 50,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(10, 10, 0, 0)
            };
            MyButton.Click += MyButton_Click;

            MyButton2 = new Button
            {
                Content = "Click Me 2",
                Width = 200,
                Height = 50,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(10, 100, 0, 0)
            };
            MyButton2.Click += MyButton2_Click;

            MyGrid.Children.Add(MyButton);
            MyGrid.Children.Add(MyButton2);
            MyGrid.Children.Add(MyLabel);
            MyGrid.Children.Add(MyTb);
            // mySp.Children.Add(MyButton);
            // mySp.Children.Add(new Label() { Content = "Alma" });
            // mySp.Children.Add(MyButton2);

            MyWindow.Content = MyGrid;
            // MyWindow.Content = mySp;

            Run(MyWindow);
        }

        private void MyButton2_Click(object sender, RoutedEventArgs e)
        {
            int top = R.Next(0, (int)(MyGrid.ActualHeight - MyButton.ActualHeight));
            int left = R.Next(0, (int)(MyGrid.ActualWidth - MyButton.ActualWidth));
            MyButton.Margin = new Thickness(left, top, 0, 0);
            MyWindow.Title = $"x={left} y={top}";
        }

        private void MyTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            MyWindow.Title = MyTb.Text;
        }

        private void MyWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //MyWindow.Title = $"{MyWindow.ActualWidth}x{MyWindow.ActualHeight}";
            MyWindow.Title = $"{MyGrid.ActualWidth}x{MyGrid.ActualHeight}";
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            int top = R.Next(0, (int)(MyGrid.ActualHeight- MyButton2.ActualHeight));
            int left = R.Next(0, (int)(MyGrid.ActualWidth-MyButton2.ActualWidth));
            MyButton2.Margin = new Thickness(left, top, 0, 0);
            MyWindow.Title = $"x={left} y={top}";
        }
    }
}
