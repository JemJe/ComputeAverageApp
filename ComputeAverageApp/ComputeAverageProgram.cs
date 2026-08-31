using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            try
            {
                float[] grades = new float[5];
                float sum = 0;

                Console.WriteLine("----------------------- [ Grades ] -----------------------");
                Console.WriteLine("Enter 5 grades separated by new line:");

                for (int i = 0; i < grades.Length; i++)
                {
                    Console.Write(": ");
                    grades[i] = Convert.ToSingle(Console.ReadLine());
                    sum += grades[i];
                }

                float average = sum / grades.Length;
                double roundedAverage = Math.Round(average);

                Console.WriteLine("\n====================== [ RESULTS ] =======================");
                Console.WriteLine("The average is " + average + " and round off to " + roundedAverage);
                Console.WriteLine("==========================================================");
            }
            catch (FormatException)
            {
                Console.WriteLine("\n[!] ERROR: Invalid input.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n[!] ERROR: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
}