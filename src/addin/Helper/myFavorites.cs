using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Visio_Multi_Page_Layer_Selector.Helper
{
    class MyFavorites
    {

        [JsonIgnore]
        public Image ImgCheck
        {
            get
            {
                return new Bitmap(Properties.Resources.img_check, 20, 20);
            }
        }

        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public List<MyLayer> Layers { get; set; }

        [JsonIgnore]
        public Image ImgDelete
        {
            get
            {
                return new Bitmap(Properties.Resources.img_delete, 20, 20);
            }
        }

        public MyFavorites(string name, DateTime dateTime, List<MyLayer> layers)
        {
            this.Name = name;
            this.DateTime = dateTime;
            this.Layers = layers;
        }

        public static List<MyFavorites> GetList()
        {
            List<MyFavorites> list = new List<MyFavorites>();

            if (!String.IsNullOrEmpty(Properties.Settings.Default.myFavorites_list))
            {
                list = JsonConvert.DeserializeObject<List<MyFavorites>>(Properties.Settings.Default.myFavorites_list);
            }

            return list.OrderBy(i => i.Name).ToList();
        }

        public static void SaveList(List<MyFavorites> list)
        {
            Properties.Settings.Default.myFavorites_list = JsonConvert.SerializeObject(list);
            Properties.Settings.Default.Save();
        }
    }
}
