using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace DndCharGen.ImageFinder
{
    public static class BitmapImageFinder
    {
        public static BitmapImage FindImage(string screen, string image)
        {
            try
            {
                BitmapImage bmi = new BitmapImage(new Uri($"Tools/ImageFinder/Images/{screen}/{image}", UriKind.Relative));
                return bmi;
            }
            catch
            {
                //Add error handling here
                throw new Exception();
            }
        }
    }
}
