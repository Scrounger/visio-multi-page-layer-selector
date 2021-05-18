using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Visio_Multi_Page_Layer_Selector.Helper;
using Visio = Microsoft.Office.Interop.Visio;
using Log = System.Diagnostics;

namespace Visio_Multi_Page_Layer_Selector
{
    public partial class AddinRibbonComponent
    {
        private void AddinRibbonComponent_Load(object sender, RibbonUIEventArgs e)
        {
            MyVisio.App.DocumentOpened += new Visio.EApplication_DocumentOpenedEventHandler(OnDocumentOpenOrCreated);
            MyVisio.App.DocumentCreated += new Visio.EApplication_DocumentCreatedEventHandler(OnDocumentOpenOrCreated);
            MyVisio.App.BeforeDocumentClose += new Visio.EApplication_BeforeDocumentCloseEventHandler(OnBeforeDocumentClose);
            
            ToggleEnable();

            Initialize_Translation();
        }

        private void OnDocumentOpenOrCreated(Visio.Document doc)
        {
            ToggleEnable();
        }

        private void OnBeforeDocumentClose(Visio.Document doc)
        {
            ToggleEnable();
        }

        private void ButtonToggle_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.TogglePanel();
        }

        private void Initialize_Translation()
        {
            TogglePanel.Label = Properties.Resources.loc_show_layer_selector;
            btnAbout.Label = Properties.Resources.loc_about;
        }

        private void ToggleEnable()
        {            
            bool enabled = MyVisio.App.Application.ActiveDocument?.EditorCount > 0;
            TogglePanel.Enabled = enabled;
            btnAbout.Enabled = enabled;
        }

        private void BtnAbout_Click(object sender, RibbonControlEventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
