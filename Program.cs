using System.IO;

namespace Program
{
    class Program
    {
        static string path = @"C:\Users\demon\Desktop\TemporaryFolder";

        public static void Main(string[] args)
        {
            GetSizeFiles(path);
        }
        public static void GetSizeFiles(string Path)
        {
            Directory.CreateDirectory(Path);
            DirectoryInfo dirInfo = new DirectoryInfo(Path);

            int weight = dirInfo.GetFiles().Length;

            Console.WriteLine("Вес папки до очистки:");
            Console.WriteLine(weight);

            foreach (FileInfo f in dirInfo.GetFiles())
            {
                f.Delete();
            }
            Console.WriteLine("Удалено:");
            Console.WriteLine(weight);
            weight = dirInfo.GetFiles().Length;
            Console.WriteLine("Вес папки после очистки:");
            Console.WriteLine(weight);
        }
    }
}