using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Visio = Microsoft.Office.Interop.Visio;
using Newtonsoft.Json;

namespace Visio_Multi_Page_Layer_Selector.Helper
{
    class MyDefaults
    {
        [JsonIgnore]
        public Image imgDelete
        {
            get
            {
                return new Bitmap(Properties.Resources.img_delete, 20, 20);
            }
        }
        public string Name { get; set; }
        public bool Visible { get; set; }
        public bool Print { get; set; }
        public bool Active { get; set; }
        public bool Lock { get; set; }
        public bool Snap { get; set; }
        public bool Glue { get; set; }

        public MyDefaults(string name, bool visible, bool print, bool active, bool _lock, bool snap, bool glue)
        {
            this.Name = name;
            this.Visible = visible;
            this.Print = print;
            this.Active = active;
            this.Lock = _lock;
            this.Snap = snap;
            this.Glue = glue;
        }

        public static List<MyDefaults> getList()
        {
            List<MyDefaults> list = new List<MyDefaults>();

            if (!String.IsNullOrEmpty(MyDocumentProperties.DefaultsList))
            {
                list = JsonConvert.DeserializeObject<List<MyDefaults>>(MyDocumentProperties.DefaultsList);
            }

            return list != null && list.Count > 0 ? list.OrderBy(i => i.Name).ToList() : list;
        }

        public static void SaveList(List<MyDefaults> list)
        {
            MyDocumentProperties.DefaultsList = JsonConvert.SerializeObject(list);
        }
    }
}
