using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingFiles01
{
    public class FileProcessor
    {
        public string rezultFileFormat = null;
        public void ProcessFile(string fileName)
        {
            Console.WriteLine("Начало выполнения ProcessFile(...)");
            string expansion = null;
            string name=null;
            if (fileName.IndexOf('.')!=-1)
            {
                for (int i = fileName.IndexOf('.'); i < fileName.Length; i++)
                    expansion += fileName[i];
                for (int i = 0; i < fileName.IndexOf('.'); i++)
                    name += fileName[i];
                if (name != null && expansion != null && expansion.Length != 1)
                {
                    rezultFileFormat = expansion;
                    switch (rezultFileFormat)
                    {
                        case ".css":
                            Console.WriteLine("Обработка *.css ...");
                            break;
                        case ".html":
                            Console.WriteLine("Обработка *.html ...");
                            break;
                        case ".json":
                            Console.WriteLine("Обработка *.json ...");
                            break;
                        //добавление кейсов для обработки новых форматов


                        default:
                            Console.WriteLine($"Обработка файла с форматом *{rezultFileFormat} не неализована!");
                            break;
                    }
                }
                else
                    Console.WriteLine("Неправильный формат! обработка невозможна!");
            }
            else if(fileName.Length!=0)
            {
                rezultFileFormat = "without expansion";
                Console.WriteLine("Данный файл не имеет расширения.");
            }
            else
            {
                Console.WriteLine("В параметр ProcessFile(...) подалась пустая строка");
            }
            Console.WriteLine("Конец выполнения ProcessFile(...)");
        }
    }
}
