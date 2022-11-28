using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class FileWorker
    {
        private static readonly Lazy<FileWorker> instance =
            new Lazy<FileWorker>(() => new FileWorker());
        public static FileWorker Instance { get { return instance.Value; } }
        public string FilePath { get; }
        public string Text { get; private set; }

        private FileWorker()
        {
            FilePath = "text.txt";
            ReadTextFromFile();
        }
        public void Save()
        {
            using(var writer = new StreamWriter(FilePath))
            {
                writer.WriteLine(Text);
            }
        }
        public void WriteText(string text)
        {
            Text += text;
        }
        private void ReadTextFromFile()
        {
            if (!File.Exists(FilePath))
            {
                Text = "";
            }
            else
            {
                using (var reader = new StreamReader(FilePath))
                {
                    Text = reader.ReadToEnd();
                }
            }
        }
    }
}
