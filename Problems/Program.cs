using System;

namespace Problems
{
    public class Program
    {

        public string Prefix(string input)
        {
            if(input == null)
            {
                return null;
            }


            int x = input.Length;

            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            


            string ans = $"{x},{words.Length}:{input}";
            return ans;
            


        }

        static void Main(string[] args)
        {
            Program p = new Program();
            string test = "what ... did you say??";
            Console.WriteLine(p.Prefix(test));
        }
    }

    
}
