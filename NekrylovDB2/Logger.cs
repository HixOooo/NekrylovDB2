using System;
using System.IO;

namespace NekrylovDB2
{
    public static class Logger
    {
        private static readonly string logFilePath = "log.txt";

        public static void Log(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            }
            catch (Exception ex)
            {
                // Если не удалось записать в лог, выводим ошибку в консоль
                Console.WriteLine($"Ошибка при записи в лог: {ex.Message}");
            }
        }
    }
}