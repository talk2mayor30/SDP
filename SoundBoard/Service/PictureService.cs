using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoundBoard.ViewModels;

namespace SoundBoard.Service
{
    class PictureService
    {
        
        public static List<Photo> GetPhotos()
        {
            List<Photo> imageList = new List<Photo>();
            Random _rnd = new Random(42 * 42);
            DateTime start = new DateTime(2010, 1, 1);

            for (int i = 1; i <=5; i++)
            {
                Photo imageData = new Photo()
                {
                    ImageSource = new Uri(String.Format("/Assets/images/{0}.png", i), UriKind.Relative) 
                };

                imageList.Add(imageData);
            }

            return imageList;
        }
    }
    
}
