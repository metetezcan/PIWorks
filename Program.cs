using System;
using System.IO;
using System.Threading;

namespace ConsoleApp1_GetFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ReadingAFile.readMyFile();
            }
            catch (Exception)
            {
                Console.WriteLine("There is an error");
            }
            finally
            {
                Console.WriteLine("Program has finished");
            }
        }
    }
}
