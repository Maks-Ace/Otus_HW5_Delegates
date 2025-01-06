using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_HW5_Delegates
{
    public class FileFinder
    {
        public bool _isCanceled = false;
        
        public FileFinder(string folderPath)
        {
            FolderPath = Path.GetFullPath(folderPath);
        }

        public event EventHandler<FileArgs>? FileFound;

        public string FolderPath { get; }

        
        public void Search()
        {
            var files = Directory.EnumerateFiles(FolderPath, "*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                if (_isCanceled == true) break;

                FileFound?.Invoke(this, new FileArgs(file));
                System.Threading.Thread.Sleep(500);
            }
        }

        /// <summary>
        /// Обратабывает команду прерывания в консоли
        /// </summary>
        public void CancelSearch(object? sender, ConsoleCancelEventArgs args)
        {
            // Св-во Cancel устанавить на true, что быпроцесс не завершился.
            args.Cancel = true;
            _isCanceled = true;
            Console.WriteLine("\r\nПоиск файлов прерван");
        }
    }



}
