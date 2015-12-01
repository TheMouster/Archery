using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Windows.Forms;

namespace ClassifiedDevelopment.Archery
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] filePaths)
        {
            if (filePaths.Length < 1)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmArcheryFileCreator());                
            }
            else
            {
                foreach (var filePath in filePaths)
                {
                    CopyFolder(filePath);
                }
            }
        }

        static void CopyFolder(String filePath)
        {
            //Instantiate an archive script document.
            ArchiveScript archiveScript = ArchiveScript.LoadFromFile(filePath);
            
            //Execute the script.
            try
            {
                //Acquire the source attributes
                FileAttributes sourceAttributes = File.GetAttributes(archiveScript.Source);

                //Note that HasFlag will throw an exception if the path provided doesnʼt exist.
                if (!sourceAttributes.HasFlag(FileAttributes.Directory))
                {
                    MessageBox.Show($"\"{archiveScript.Source}\" is not a directory. Please edit \"{filePath}\" to correct it.");
                    return;
                }

                //Only copy the directory if the path provided is actually a directory.
                if (sourceAttributes.HasFlag(FileAttributes.Directory))
                    FileSystem.CopyDirectory(archiveScript.Source, archiveScript.Destination.Replace("##FILEDATE##", DateTime.Now.ToString("yyyy-MM-dd HHmm")), UIOption.AllDialogs, UICancelOption.DoNothing);
            }
            catch (DirectoryNotFoundException)
            {
                //Inform the user that the specified directory doesnʼt exist.
                MessageBox.Show($"\"{archiveScript.Source}\" doesnʼt exist. Please edit \"{filePath}\" to correct it.");                
            }
            catch (ArgumentException)
            {
                //Inform the user that the specified path doesnʼt represent a direcotry.
                MessageBox.Show($"\"{archiveScript.Source}\" is not a directory. Please edit \"{filePath}\" to correct it.");
            }
        }
    }
}
