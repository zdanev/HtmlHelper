using System.IO;

namespace HtmlHelper
{
    public static class Ext 
    {
        public static void SaveToFile(this string text, string fileName)
        {
            using (var file = new StreamWriter(fileName))
            {
                file.Write(text);
            }
        }
    }
}