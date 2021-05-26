using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visio = Microsoft.Office.Interop.Visio;

namespace Visio_Multi_Page_Layer_Selector.Helper
{
    class MyDocumentProperties
    {
        public static bool ShowVisible
        {
            get
            {
                string result = ReadProperty(GetPropertyName());
                return !string.IsNullOrEmpty(result) ? Convert.ToBoolean(result) : true;
            }
            set
            {
                WriteProperty(GetPropertyName(), value);
            }
        }

        public static bool ShowPrint
        {
            get
            {
                string result = ReadProperty(GetPropertyName());
                return !string.IsNullOrEmpty(result) ? Convert.ToBoolean(result) : true;
            }
            set
            {
                WriteProperty(GetPropertyName(), value);
            }
        }

        public static bool ShowActive
        {
            get
            {
                string result = ReadProperty(GetPropertyName());
                return !string.IsNullOrEmpty(result) ? Convert.ToBoolean(result) : true;
            }
            set
            {
                WriteProperty(GetPropertyName(), value);
            }
        }

        public static bool ShowLock
        {
            get
            {
                string result = ReadProperty(GetPropertyName());
                return !string.IsNullOrEmpty(result) ? Convert.ToBoolean(result) : true;
            }
            set
            {
                WriteProperty(GetPropertyName(), value);
            }
        }

        public static bool ShowSnap
        {
            get
            {
                string result = ReadProperty(GetPropertyName());
                return !string.IsNullOrEmpty(result) ? Convert.ToBoolean(result) : true;
            }
            set
            {
                WriteProperty(GetPropertyName(), value);
            }
        }

        public static bool ShowGlue
        {
            get
            {
                string result = ReadProperty(GetPropertyName());
                return !string.IsNullOrEmpty(result) ? Convert.ToBoolean(result) : true;
            }
            set
            {
                WriteProperty(GetPropertyName(), value);
            }
        }


        public static bool ShowFavVisible
        {
            get
            {
                string result = ReadProperty(GetPropertyName());
                return !string.IsNullOrEmpty(result) ? Convert.ToBoolean(result) : false;
            }
            set
            {
                WriteProperty(GetPropertyName(), value);
            }
        }

        public static bool ShowFavPrint
        {
            get
            {
                string result = ReadProperty(GetPropertyName());
                return !string.IsNullOrEmpty(result) ? Convert.ToBoolean(result) : false;
            }
            set
            {
                WriteProperty(GetPropertyName(), value);
            }
        }

        public static bool ShowFavActive
        {
            get
            {
                string result = ReadProperty(GetPropertyName());
                return !string.IsNullOrEmpty(result) ? Convert.ToBoolean(result) : false;
            }
            set
            {
                WriteProperty(GetPropertyName(), value);
            }
        }

        public static bool ShowFavLock
        {
            get
            {
                string result = ReadProperty(GetPropertyName());
                return !string.IsNullOrEmpty(result) ? Convert.ToBoolean(result) : true;
            }
            set
            {
                WriteProperty(GetPropertyName(), value);
            }
        }

        public static bool ShowFavSnap
        {
            get
            {
                string result = ReadProperty(GetPropertyName());
                return !string.IsNullOrEmpty(result) ? Convert.ToBoolean(result) : true;
            }
            set
            {
                WriteProperty(GetPropertyName(), value);
            }
        }

        public static bool ShowFavGlue
        {
            get
            {
                string result = ReadProperty(GetPropertyName());
                return !string.IsNullOrEmpty(result) ? Convert.ToBoolean(result) : true;
            }
            set
            {
                WriteProperty(GetPropertyName(), value);
            }
        }

        public static string FavoritesList
        {
            get
            {
                return ReadProperty(GetPropertyName());
            }
            set
            {
                WriteProperty(GetPropertyName(), value);
            }
        }

        public static string DefaultsList
        {
            get
            {
                return ReadProperty(GetPropertyName());
            }
            set
            {
                WriteProperty(GetPropertyName(), value);
            }
        }

        private static void WriteProperty(string PropertyName, object value)
        {
            Visio.Shape docShape = MyVisio.App.ActiveDocument.DocumentSheet;
            string propName = String.Format("mpls_{0}", PropertyName);

            PrepareCellOnDocumentSheet(docShape, propName);

            docShape.CellsU["User." + propName].FormulaForceU = StringToFormulaForString(value.ToString());
        }

        private static string ReadProperty(string PropertyName)
        {
            Visio.Shape docShape = MyVisio.App.ActiveDocument.DocumentSheet;
            string propName = String.Format("mpls_{0}", PropertyName);

            if (docShape.CellExistsU["User." + propName, (short)Visio.VisExistsFlags.visExistsAnywhere] != 0)
            {
                return docShape.CellsU["User." + propName].ResultStr[Visio.VisUnitCodes.visNoCast];
            }

            return null;
        }

        private static void PrepareCellOnDocumentSheet(Visio.Shape shape, string PropertyName)
        {
            short section = (short)Visio.VisSectionIndices.visSectionUser;

            if (shape.SectionExists[section, (short)Visio.VisExistsFlags.visExistsAnywhere] == 0)
            {
                shape.AddSection(section);
            }

            if (shape.CellExistsU["User." + PropertyName, (short)Visio.VisExistsFlags.visExistsAnywhere] == 0)
            {
                shape.AddNamedRow(section, PropertyName, (short)Visio.VisRowTags.visTagDefault);
            }
        }

        public static string StringToFormulaForString(string inputValue)
        {
            string result = "";
            string quote = "\"";
            string quoteQuote = "\"\"";

            try
            {

                result = inputValue != null ? inputValue : String.Empty;

                // Replace all (") with ("").
                result = result.Replace(quote, quoteQuote);

                // Add ("") around the whole string.
                result = quote + result + quote;
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.WriteLine(err.Message);
                throw;
            }

            return result;
        }

        private static string GetPropertyName()
        {
            StackTrace callStackTrace = new StackTrace();
            StackFrame propertyFrame = callStackTrace.GetFrame(1); // 1: below GetPropertyName frame
            string properyAccessorName = propertyFrame.GetMethod().Name;

            return properyAccessorName.Replace("get_", "").Replace("set_", "");
        }
    }
}
