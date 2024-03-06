using Prism.Regions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RegionTest.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            //定義Region
            RegionManager.SetRegionName(Header, "HeaderRegion");
            RegionManager.SetRegionName(Menu, "MenuRegion");
            RegionManager.SetRegionName(Content, "ContentRegion");

            //為指定區域指定頁面
            regionManager.RegisterViewWithRegion("HeaderRegion", typeof(Header));
            regionManager.RegisterViewWithRegion("MenuRegion", typeof(Menu));
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Content));
        }
    }
}