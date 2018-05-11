/*============================================================================================
 * ||              Author      : Peter Felix A
 * ||              Added On    : 05/22/2017, 15:43
 * ||              Class Name  : FindReplaceObjects.cs
 * ||              Language    : CSharp
 * ||              Copyright   : Copyright(c)Symphion Inc 2003-2017 All Right Reserved
 * =============================================================================================*/

namespace wotepad.Objects
{
    public class FindReplaceObjects
    {
        public enum SearchDirections
        {
            Down,
            Up,
        }
        public static string FindString = string.Empty;
        public static string ReplaceString = string.Empty;
        public static SearchDirections SearchDirection = SearchDirections.Down;
        public static bool MatchCase = false;
        public static int SearchCount = 0;
    }
}