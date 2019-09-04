using System;

namespace isogram_csharp_problem
{
    public static class IsogramClass
    {
        public static bool Isogram(string phrase)
        {
            //var phraseInLowerCase = phrase.ToLower();
            var phraseCharArray = phrase.ToCharArray();
            var flag = true;
            for(var i = 0; i<phraseCharArray.Length-1;i++)
            {
                if((phraseCharArray[i]>='a' && phraseCharArray[i]<='z')||(phraseCharArray[i] >= 'A' && phraseCharArray[i] <= 'Z'))
                {
                    for(var j=i+1;j<phraseCharArray.Length;j++)
                    {
                        if(phraseCharArray[i]==phraseCharArray[j])
                        {
                            flag = false;
                            break;
                        }
                    }
                    if(flag == false)
                        break;
                }
            }
            return flag;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var phrase = Console.ReadLine();
            //IsogramClass isogramClass = new IsogramClass();
            Console.WriteLine(IsogramClass.Isogram(phrase));
        }
    }
}
