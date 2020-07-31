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
using DndCharGen.Base.SourceData.Races.RaceTraits.Objects;
using DndCharGen.ImageFinder;

namespace DndCharGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeStaticElements();
        }

        private void InitializeStaticElements()
        {
            InitializeStaticImages();
        }

        private void InitializeStaticImages()
        {
            dndLogo.Source = BitmapImageFinder.FindImage("MainWindow", "1200px-Dungeons_&_Dragons_5th_Edition_logo.svg.png");
            dndLogoCustomFont.Source = BitmapImageFinder.FindImage("MainWindow", "2020-07-22 17_15_22-Dungeons & Dragons Font.png");
        }
    }
}
