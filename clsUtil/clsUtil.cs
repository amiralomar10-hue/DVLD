using System;
using System.IO;
using System.Linq;
using System.Text;

namespace DVLD.Global_Classes
{
    public static class clsUtil
    {
        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;

            return GenerateGUID() + extn;
        }

        public static string GenerateGUID()
        {
            return Guid.NewGuid().ToString();
        }

        public static bool CreateFolderIfDoesNotExist(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CopyImageToProjectFolder(ref string sourceFile)
        {
            string destinationFolder = @"C:\DVLD-People-Images\";

            // التأكد من وجود المجلد
            if (!CreateFolderIfDoesNotExist(destinationFolder))
            {
                return false;
            }

            // تحديد مسار الملف الجديد
            string destinationFilePath = Path.Combine(destinationFolder, ReplaceFileNameWithGUID(sourceFile));

            try
            {
                File.Copy(sourceFile, destinationFilePath, true);
                sourceFile = destinationFilePath; 
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
       public static string EncryptText(string Text, short EncryptionKey = 2)
        {
            StringBuilder stringBuilder = new StringBuilder(Text);

            for (int i = 0; i < Text.Length; i++)
            {

                stringBuilder[i] = Convert.ToChar(Convert.ToInt32(Text[i]) + EncryptionKey);
            }
            Text = stringBuilder.ToString();

            return Text;

        }

        public static string DecryptText(string Text, short EncryptionKey = 2)
        {
            StringBuilder stringBuilder = new StringBuilder(Text);
            for (int i = 0; i < Text.Length; i++)
            {

                stringBuilder[i]= Convert.ToChar(Convert.ToInt32(Text[i]) - EncryptionKey);

            }
            Text = stringBuilder.ToString();
            return Text;

        }
    }
}
