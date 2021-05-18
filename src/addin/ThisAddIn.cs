using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Visio_Multi_Page_Layer_Selector.Helper;
using Visio_Multi_Page_Layer_Selector.Properties;
using Visio = Microsoft.Office.Interop.Visio;

namespace Visio_Multi_Page_Layer_Selector
{
    public partial class ThisAddIn
    {
        private PanelManager _panelManager;

        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            _panelManager = new PanelManager(this);
            // ToDo: Document close event

            Initialize_Localizing();
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
            _panelManager.Dispose();

        }

        public void TogglePanel()
        {
            _panelManager.TogglePanel(Application.ActiveWindow);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            Startup += ThisAddIn_Startup;
            Shutdown += ThisAddIn_Shutdown;
        }

        private void Initialize_Localizing()
        {
            var lcid = Application.LanguageSettings.LanguageID[Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUI];
            var culture = new CultureInfo(lcid); // selected in the Office

            var languages = new[] { "de", "en", "fr", "es", "ru", "pl", "zh-cn", "pt", "nl", "it" };
            if (languages.Any(language => language == culture.TwoLetterISOLanguageName))
            {
                Resources.Culture = culture;
                // _ribbonHandler.Invalidate();
            }
        }
    }
}
