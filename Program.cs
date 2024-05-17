namespace RepeatedSubstringpattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Please enter  string");
            String BigString = Console.ReadLine();
            Boolean Output = RepeatedSubstringPattern(BigString);

            Console.WriteLine("Output is: " + Output);
        }
        static Boolean RepeatedSubstringPattern(String s)
        {
            Boolean isSubstring = true;
            int lengthOfSubstring = 0;
            String sub = s[0].ToString(); ;

            String firstLetter = s[0].ToString();

            for(int i=1; i < s.Length; i++)
            {
                String next = s[i].ToString();

                if (next.Equals(firstLetter))
                {
                    lengthOfSubstring = i;
                    break;
                }
                else
                {
                    sub = sub + next;
                }
            }
            if ((s.Length == 0)||(lengthOfSubstring == 0))
            {
                return false;
            }
            else if (s.Length >0)
            {
                int lCheck = s.Length % lengthOfSubstring;

                if (lCheck != 0) { return false; }
            }

            Console.WriteLine(sub+"length ="+lengthOfSubstring);
            for(int i=0; i <=s.Length-lengthOfSubstring; i=i+lengthOfSubstring)
            {
                for(int j=0; j <lengthOfSubstring; j++)
                {
                    Console.WriteLine("i " + i + "j " + j);
                    if (!sub[j].Equals(s[i+j]))
                    {
                        isSubstring = false;
                    }
                }
            }

            return isSubstring;
        }
    }
}
