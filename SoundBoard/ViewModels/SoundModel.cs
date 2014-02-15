using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoard.ViewModels
{
  public class SoundModel
    {
     

        public List<Photo> imageCourse { get; set; }

        public  List<Photo> imageTestify { get; set; }


        public  List<Photo> imagecontact { get; set; }

        public List<Photo> imagementor { get; set; }

        public  bool IsDataLoaded { get; set; }


        public  void LoadData()
        {
            imagementor = GetMentor();
            imageCourse = GetCourse();
            imageTestify = GetTestimonial();
          //  imageproduct = GetOur_product();
            imagecontact = Getcontact();

            IsDataLoaded = true;
        }
        public  List<Photo> GetCourse()
        {
            String label = "";
            List<Photo> imageList = new List<Photo>();
            for (int i = 1; i <= 19; i++) {
                if (i == 1)
                {
                    label = "Big Data";
                }
                else if (i == 2)
                {
                    label = "Linux Programming";
                }
                else if (i == 3)
                {
                    label = "Linux Admistration";
                }
                else if (i == 4)
                {
                    label = "Machine Learning";
                }
                else if (i == 5)
                {
                    label = "Image Processing";
                }
                else if (i == 6)
                {
                    label = "GSM Archictecture";
                }
                else if (i == 7)
                {
                    label = "Java";
                }
                else if (i == 8)
                {
                    label = "C#";
                }
                else if (i == 9)
                {
                    label = "C++";
                }
                else if (i == 10)
                {
                    label = "Bash";
                }
                else if (i == 11)
                {
                    label = "MySQL";
                }
                
                else if (i == 12)
                {
                    label = "Artificial Intelligence";
                }
                else if (i == 13)
                {
                    label = "JavaScript";
                }
                else if (i == 14)
                {
                    label = "Perl";
                }
               
                else if (i == 15)
                {
                    label = "PHP";
                }
                else if (i == 16)
                {
                    label = "Python";
                }
                else if (i == 17)
                {
                    label = "Web Architecture";
                }
                else if (i == 18)
                {
                    label = "Cloud Computing";
                }
                else if (i == 19)
                {
                    label = "Database Admistration";
                }
            Photo src = new Photo()
            {
                label=label,
                Title = "Courses",
                ImageSource= new Uri(String.Format("/Assets/images/{0}.jpg", i), UriKind.Relative)
            };

            imageList.Add(src);
                
            }
            return imageList;
        }

       public   List<Photo> GetTestimonial()
        {
            String label = "";
            List<Photo> imageList = new List<Photo>();
            
            for (int i = 20; i <= 25; i++) {
                if (i == 20)
                {
                    label = "Detan";
                }
                else if (i == 21)
                {
                    label = "Francis";
                }
                else if (i == 22)
                {
                    label = "Mayowa";
                }
                else if (i == 23)
                {
                    label = "Emeka";
                }
                else if (i == 24)
                {
                    label = "Tope";
                }
                else if (i == 25)
                {
                    label = "Wale";
                }
            Photo src = new Photo()
            {
                label=label,
                Title = "Testimonials",
                ImageSource= new Uri(String.Format("/Assets/images/{0}.jpg", i), UriKind.Relative)
            };

            imageList.Add(src);
            }
                    return imageList;
       }
       //public  List<Photo> GetOur_product()
       // {
       //     String label = "";
       //     List<Photo> imageList = new List<Photo>();
       //     for (int i =11; i <= 15; i++) {
       //         if (i == 11)
       //         {
       //             label = "Meet@me";
       //         }
       //         else if (i == 12)
       //         {
       //             label = "P2MU";
       //         }
       //         else if (i == 13)
       //         {
       //             label = "V2PIX";
       //         }
       //         else if (i == 14)
       //         {
       //             label = "DataPHIX";
       //         }
       //         else if (i == 15)
       //         {
       //             label = "WIN_SDP";
       //         }
       //     Photo src = new Photo()
       //     {
       //         label=label,
       //         Title = "Our Products",
       //         ImageSource= new Uri(String.Format("/Assets/images/{0}.jpg", i), UriKind.Relative)
       //     };

       //     imageList.Add(src);
       //     }
       //             return imageList;
       //         }
           public List<Photo> Getcontact()
        {
            String label = "";
            List<Photo> imageList = new List<Photo>();
            for (int i = 30; i <= 33; i++) {
                if (i ==30)
                {
                    label = "Email";
                }
                else if (i == 31)
                {
                    label = "Facebook";
                }
                else if (i == 32)
                {
                    label = "twitter";
                }
                else if (i ==33)
                {
                    label = "Msisdn";
                }
            Photo src = new Photo()
            {
                label=label,
                Title = "Contacts",
                ImageSource= new Uri(String.Format("/Assets/images/{0}.jpg", i), UriKind.Relative)
            };

            imageList.Add(src);
            }
            return imageList;
           }

           public List<Photo> GetMentor()
           {
               String label = "";
               List<Photo> imageList = new List<Photo>();
               for (int i = 26; i <= 29; i++)
               {
                   if (i == 26)
                   {
                       label = "About SDP";
                   }
                   else if (i == 27)
                   {
                       label = "What we offer";
                   }
                   else if (i == 28)
                   {
                       label = "Requirements";
                   }
                   else if (i == 29)
                   {
                       label = "Duration";
                   }
 
                   Photo src = new Photo()
                   {
                       label = label,
                       Title = "How we Mentor",
                       ImageSource = new Uri(String.Format("/Assets/images/{0}.jpg", i), UriKind.Relative)
                   };

                   imageList.Add(src);
               }
               return imageList;
           }
 //Getting names

    }
}
