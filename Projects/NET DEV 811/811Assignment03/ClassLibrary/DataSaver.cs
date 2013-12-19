using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _811Assignment03
{
    public class DataSaver
    {
        public string textoutput;
        public string savepath;

        public DataSaver(string output, string path)
        {
            textoutput = output;
            savepath = path;
        }

        public void SaveFile()
        {
            try
            {
                if (File.Exists(savepath))
                {
                    File.Delete(savepath);
                }
                //File.WriteAllText((savepath), (textoutput));
                //this may be a solution to the file save location issue when saving to a folder that doesnt yet exist
                Path.Combine((savepath), (textoutput));
                MessageBox.Show("The file has been saved at " + (savepath), "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DirectoryNotFoundException dirEx)
            {
                MessageBox.Show("The chosen save path " + (savepath) + " is not valid.  Please use an existing file path. " + dirEx.Message, "File Path Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}