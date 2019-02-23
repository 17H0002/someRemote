using System;

namespace Problems
{
    public class Program
    {

        public static string Prefix(string input)
        {
            if(input == null)
            {
                return null;
            }

            else
            {
            int x = input.Length;

            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            


            string ans = $"{x},{words.Length}:{input}";
            return ans;
            }


        }

        static void Main(string[] args)
        {
            string test = "what ... did you say??";
            Console.WriteLine(Prefix(test));
        }
    }

    
}
