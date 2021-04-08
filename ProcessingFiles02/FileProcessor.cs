using System;

namespace ProcessingFiles02
{
    public abstract class FileProcessor
    {
        public string rezultFileFormat;
        public abstract void ProcessFile(string fileName);
    }
    public class JsonProcessor:FileProcessor
    {
        public override void ProcessFile(string fileName)
        {
            //Обработка .json файла
            rezultFileFormat = ".json";
        }
    }
    public class HtmlProcessor:FileProcessor
    {
        public override void ProcessFile(string fileName)
        {
            //Обработка .html файла
            rezultFileFormat = ".html";
        }
    }
    public class CssProcessor:FileProcessor
    {
        public override void ProcessFile(string fileName)
        {
            //Обработка .css файла
            rezultFileFormat = ".css";
        }
    }

    public class WithoutExpansionProcessor:FileProcessor
    {
        public override void ProcessFile(string fileName)
        {
            //Обработка файла без расширения
            rezultFileFormat = "without expansion";
        }
    }

    //Добавление классов для обработки новых файлов и соответстующих реализаций ProcessFiles

    public class File
    {
        public string FileName { get; set; }
        public FileProcessor CurrFileProcessor { get; set; }
        public File(string fileName)
        {
            string expansion = null;
            string name = null;
            if (fileName.IndexOf('.') != -1)
            {
                for (int i = fileName.IndexOf('.'); i < fileName.Length; i++)
                    expansion += fileName[i];
                for (int i = 0; i < fileName.IndexOf('.'); i++)
                    name += fileName[i];
                if (name != null && expansion != null && expansion.Length != 1)
                {
                    switch (expansion)
                    {
                        case ".css":
                            CurrFileProcessor = new CssProcessor();
                            break;
                        case ".html":
                            CurrFileProcessor = new HtmlProcessor();
                            break;
                        case ".json":
                            CurrFileProcessor = new JsonProcessor();
                            break;
                        //добавление кейсов для инициализации конкретного обработчика

                    }
                }
            }
            else if (fileName.Length != 0)
            {
                CurrFileProcessor = new WithoutExpansionProcessor();
            }
            else
                CurrFileProcessor = null;
            FileName = fileName;
        }

        public void ExecuteFileProcessor()
        {
            CurrFileProcessor.ProcessFile(FileName);
        }
    }

}
