using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoundBoard.Service;

namespace SoundBoard.ViewModels
{
 class imageViewModel
    {

        SoundModel soundmodel;

        public imageViewModel()
        {
            soundmodel = new SoundModel();
            soundmodel.LoadData();
        }
        public List<Key_label<string, Photo>> GroupedCourses
        {
            get
            {
                var icons = soundmodel.imageCourse;

                var groupedicon =
                    from icon in icons
                    orderby icon.Title
                    group icon by icon.Title into Iconset
                    select new Key_label<string, Photo>(Iconset);

                return new List<Key_label<string, Photo>>(groupedicon);
            }
        }
        public  List<Key_label<string, Photo>> GroupedTestimonials
        {
            get
            {

                var icons = soundmodel.imageTestify;

                var groupedicon =
                    from icon in icons
                    orderby icon.Title
                    group icon by icon.Title into Iconset
                    select new Key_label<string, Photo>(Iconset);

                return new List<Key_label<string, Photo>>(groupedicon);
            }
        }
        //public  List<Key_label<string, Photo>> Groupedour_product
        //{
        //    get
        //    {

        //        var icons = soundmodel.imageproduct;

        //        var groupedicon =
        //            from icon in icons
        //            orderby icon.Title
        //            group icon by icon.Title into Iconset
        //            select new Key_label<string, Photo>(Iconset);

        //        return new List<Key_label<string, Photo>>(groupedicon);
        //    }
        //}
        public List<Key_label<string, Photo>> GroupedContacts
        {
            get
            {
                var icons = soundmodel.imagecontact;

                var groupedicon =
                    from icon in icons
                    orderby icon.Title
                    group icon by icon.Title into Iconset
                    select new Key_label<string, Photo>(Iconset);

                return new List<Key_label<string, Photo>>(groupedicon);
            }
        }
        public List<Key_label<string, Photo>> GroupedMentor
        {
            get
            {
                var icons = soundmodel.imagementor;

                var groupedicon =
                    from icon in icons
                    orderby icon.Title
                    group icon by icon.Title into Iconset
                    select new Key_label<string, Photo>(Iconset);

                return new List<Key_label<string, Photo>>(groupedicon);
            }
        }
    }
}
