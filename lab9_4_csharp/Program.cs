using System.Text;

namespace Lab9_Variant4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string inputPath = "input.txt";
            string outputPath = "output.txt";

            Console.WriteLine("=== Вариант 4: Перезапись файла ===");

            if (File.Exists(inputPath))
            {
                // Читаем весь текст целиком
                string content = File.ReadAllText(inputPath);

                // Записываем в новый файл (автоматически перезапишет, если файл есть)
                File.WriteAllText(outputPath, content);

                Console.WriteLine($"Данные из '{inputPath}' успешно записаны в '{outputPath}'.");
            }
            else
            {
                Console.WriteLine($"Файл '{inputPath}' не найден.");
            }

            Console.ReadKey();
        }
    }
}
