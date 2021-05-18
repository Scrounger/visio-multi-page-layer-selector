using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Visio = Microsoft.Office.Interop.Visio;

namespace Visio_Multi_Page_Layer_Selector.Helper
{
    class MyLayer
    {
        [JsonIgnore]
        public Image ImgAddToDefault
        {
            get
            {
                if (this.IsDefault == false)
                {
                    return new Bitmap(Properties.Resources.img_defaults_add, 20, 20);
                }

                return new Bitmap(Properties.Resources.img_default_exist, 20, 20);
            }
        }
        public string Name { get; set; }
        public bool Visible { get; set; }
        public bool Print { get; set; }
        public bool Active { get; set; }
        public bool Lock { get; set; }
        public bool Snap { get; set; }
        public bool Glue { get; set; }
        [JsonIgnore]
        public bool IsDefault { get; set; }

        public MyLayer(string name, bool visible, bool print, bool active, bool _lock, bool snap, bool glue, bool isDefault)
        {
            this.Name = name;
            this.Visible = visible;
            this.Print = print;
            this.Active = active;
            this.Lock = _lock;
            this.Snap = snap;
            this.Glue = glue;
            this.IsDefault = isDefault;
        }

        public static List<MyLayer> GetList()
        {
            List<MyLayer> list = new List<MyLayer>();

            List<MyDefaults> myDefaultsList = MyDefaults.getList();

            foreach (Visio.Page page in MyVisio.App.ActiveDocument.Pages)
            {
                foreach (Visio.Layer layer in page.Layers)
                {
                    MyLayer layerObj = null;

                    int myDefaultsIndex = myDefaultsList.FindIndex(i => i.Name == layer.Name);
                    if (myDefaultsIndex >= 0)
                    {
                        layerObj = new MyLayer(layer.Name,
                            myDefaultsList[myDefaultsIndex].Visible,
                            myDefaultsList[myDefaultsIndex].Print,
                            myDefaultsList[myDefaultsIndex].Active,
                            myDefaultsList[myDefaultsIndex].Lock,
                            myDefaultsList[myDefaultsIndex].Snap,
                            myDefaultsList[myDefaultsIndex].Glue,
                            true);
                    }
                    else
                    {
                        layerObj = new MyLayer(layer.Name,
                            layer.CellsC[(int)Visio.VisCellIndices.visLayerVisible].Formula == "1",
                            layer.CellsC[(int)Visio.VisCellIndices.visLayerPrint].Formula == "1",
                            layer.CellsC[(int)Visio.VisCellIndices.visLayerActive].Formula == "1",
                            layer.CellsC[(int)Visio.VisCellIndices.visLayerLock].Formula == "1",
                            layer.CellsC[(int)Visio.VisCellIndices.visLayerSnap].Formula == "1",
                            layer.CellsC[(int)Visio.VisCellIndices.visLayerGlue].Formula == "1",
                            false);
                    }

                    if (list.FindIndex(i => i.Name == layer.Name) < 0)
                    {
                        list.Add(layerObj);
                    }
                }
            }

            return list.OrderBy(i => i.Name).ToList();
        }
    }
}
