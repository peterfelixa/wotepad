/*=============================================================================================================
 * ||              Author      : peterfelix
 * ||              Added On    : Tuesday, September 5, 2017 12:39:04 PM
 * ||              Class Name  : AppSettings.cs
 * ||              Language    : CSharp
 * ||              Copyright   : Copyright©Symphion Inc 2003-2017 All Right Reserved
 * ||              Purpose     : App Settings object based on different wings.
 * ==========================================================================================================*/
using System.Drawing;

namespace wotepad.Objects
{
    public static class AppSettings
    {
        public static string SkinName = "McSkin";
        public static bool ShowStatusBar = true;

        public static class AppFont
        {
            public static string Wotepad_FontName = "Tahoma";
            public static float Wotepad_FontSize = 8;
        }

        public static class EditorFont
        {
            public static string Editor_FontName = "Tahoma";
            public static FontStyle Editor_FontStyle = FontStyle.Regular;
            public static float Editor_FontSize = 8;
            public static bool Editor_UnderLine = false;
        }
        public static class EditorSettings
        {
            public static bool Editor_WordWrap = false;
        }
    }
}
