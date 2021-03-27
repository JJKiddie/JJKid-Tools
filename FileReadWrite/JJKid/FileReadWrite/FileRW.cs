using System.IO;
using System.Text;


namespace JJKid.FileReadWrite
{
    public class FileRW
    {
        //======================================================================
        //  Read
        //======================================================================
        public static string readUTF8TextFile(string fullFilePath)
        {
            string dataFromFile = "";

            if(File.Exists(fullFilePath))
            {
                Encoding encoding = Encoding.GetEncoding("UTF-8");
                StreamReader sr = new StreamReader(fullFilePath, encoding);
                dataFromFile = sr.ReadToEnd();
                sr.Close();
            }

            return dataFromFile;
        }


        //======================================================================
        //  Write
        //======================================================================
        public static void saveToUTF8TextFile(string dataToBeSaved, string fullSavingPath)
        {
            Encoding encoding = Encoding.GetEncoding("UTF-8");
            StreamWriter sw = new StreamWriter(fullSavingPath, false, encoding);

            sw.Write(dataToBeSaved);
            sw.Close();
        }
    }
}
