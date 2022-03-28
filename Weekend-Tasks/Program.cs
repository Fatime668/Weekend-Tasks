using System;
using System.Text.RegularExpressions;

namespace Weekend_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task 2
            //string newSentence = Console.ReadLine();
            //Console.WriteLine(Checked(newSentence));

            //Task 3
            //string newSentence = Console.ReadLine();
            //firstWord(newSentence);

            //Task 4
            //string newSentence = Console.ReadLine();
            //Console.WriteLine(Big(newSentence));

            //Task 5
            //int[] arr = {1,2,3};
            //int num = Convert.ToInt32(Console.ReadLine());
            //AdditionNum(ref arr,num);
        }
        #region Task2
        //public static bool Checked(string sentence)
        //{
        //    if (true)
        //    {
        //        bool hasDigit = false;
        //        bool hasUpper = false;
        //        bool hasLower = false;
        //        foreach (var item in sentence)
        //        {
        //            if (char.IsDigit(item))
        //            {
        //                hasDigit = true;
        //                continue;
        //            }
        //            if (char.IsUpper(item))
        //            {
        //                hasUpper = true;
        //                continue;
        //            }
        //            if (char.IsLower(item))
        //            {
        //                hasLower = true;
        //                continue;
        //            }

        //        }
        //        bool result = hasDigit && hasUpper && hasLower;
        //        return true;
        //    }
        //    return false;
        //}
        #endregion
        #region Task3
        //public static void firstWord(string sentence)
        //{
        //    string[] newStr = sentence.Split();
        //    for (int i = 0; i < newStr.Length; i++)
        //    {
        //        Console.WriteLine(newStr[0]);
        //        break;
        //    }
        //}
        #endregion
        #region Task4
        //public static bool Big(string sentence)
        //{
        //    bool bigFirstWord = false;
        //    bool bigSecondWord = false;

        //    string[] newStr = sentence.Split();
        //    if (newStr.Length == 2)
        //    {
        //        string firstWord = newStr[0];
        //        string secondWord = newStr[1];
        //        if (char.IsUpper(firstWord[0]))
        //        {
        //            bigFirstWord = true;
        //        }
        //        if (char.IsUpper(secondWord[0]))
        //        {
        //            bigSecondWord = true;
        //        }
        //        bool result = bigFirstWord && bigSecondWord;
        //        return result;
        //    }
        //return false;

        //}
        #endregion
        #region Task5
        //public static void AdditionNum(ref int[] arr, int number)
        //{
        //    int[] newArr = new int[arr.Length + 1];
        //    newArr[arr.Length] = number;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        newArr[i]=arr[i];
        //    }
        //    arr = newArr;
        //    foreach (var item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        #endregion
        
    }
}
