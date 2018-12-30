using System.Collections;
using System.Collections.Generic;

namespace first_non_repeating_letter
{
    public class Kata
    {
        public static string FirstNonRepeatingLetter(string word)
        {
            var queue = Enqueue(word);

            while (queue.Count>0)
            {
                var letter = queue.Dequeue();
           
                if (!queue.Contains(letter))
                {
                    return letter.ToString();
                }
            }

            return string.Empty;
        }

        private static Queue<char> Enqueue(string word)
        {
            var queue = new Queue<char>();
            var charArray = word.ToCharArray();
            foreach (var c in charArray)
            {
                queue.Enqueue(c);
            }

            return queue;
        }
    }
}