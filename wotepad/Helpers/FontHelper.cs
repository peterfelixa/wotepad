/*=============================================================================================================
 * ||              Author      : peterfelix
 * ||              Added On    : Tuesday, September 5, 2017 12:38:35 PM
 * ||              Class Name  : FontHelper.cs
 * ||              Language    : CSharp
 * ||              Copyright   : Copyright©Symphion Inc 2003-2017 All Right Reserved
 * ||              Purpose     : Finding Font Style from given Font Style String.
 * ==========================================================================================================*/
using System.Drawing;

namespace wotepad.Helpers
{
    public class FontHelper
    {
        public static FontStyle GetFontStyle(string fontStyle)
        {
            FontStyle fs = FontStyle.Regular;
            switch (fontStyle)
            {
                case "Regular":
                    fs = FontStyle.Regular;
                    break;
                case "Bold":
                    fs = FontStyle.Bold;
                    break;
                case "Italic":
                    fs = FontStyle.Italic;
                    break;
                case "Bold Italic":
                    fs = FontStyle.Bold | FontStyle.Italic;
                    break;
                default:
                    fs = FontStyle.Regular;
                    break;
            }
            return fs;
        }
    }
}