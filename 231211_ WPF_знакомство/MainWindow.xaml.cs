using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //базовые свойства
            InitializeComponent();
            AllowsTransparency = true;
            Icon;
            IsActive;
            Left;
            Top;
            Owner;
            ResizeMode = ResizeMode.CanResize;
            RestoreBounds;
            ShowActivated;
            ShowInTaskbar = true;// true только у главного окна
            Topmost = true;//ПОВЕРХ ВСЕХ ОКОН   
            WindowStartupLocation;
            WindowState = WindowState.Normal;
            Acivated;
            Closed;
            ContentRendered;//контент отображен
            LocationChanged;
            SourceInitialized;
            StateChanged;
            Activate();
            Close();
            Show();
            ShowDialog();
            SizeToContent.Height;// автоподстройка под высоту
            WindowStartupLocation = WindowStartupLocation;
            WindowStyle = WindowStyle.ToolWindow;//рамка


        }
    }
}
