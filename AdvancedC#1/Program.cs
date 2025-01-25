using AdvancedC_1.Q1.Range;
using AdvancedC_1.Q4.FixedSize;

namespace AdvancedC_1
{
    internal class Program
    {
        #region FunQ2
        public static int[] Reverse(int[] value)
        {
            int start = 0;
            int end = value.Length - 1;

            while (start < end)
            {
                int arr = value[start];
                value[start] = value[end];
                value[end] = arr;
                start++;
                end--;
            }

            return value;

        }
        #endregion
        #region FunQ3
        //to Return List
        public static List<int> GetEven(int[] value)
        {

            List<int> Arr = [];
            for (int i = 0; i < value.Length; i++)
            {

                if (value[i] % 2 == 0)
                {

                    Arr.Add(value[i]);
                }
                continue;

            }
            return Arr;
        }
        // to return Array
        public static int[] GetEvenArr(int[] Arr) {
        
            int[] arr;
            int count = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            int index = 0;

            arr = new int[count];
            for (int i = 0;i < Arr.Length; i++)
            {
                if(Arr[i] % 2 == 0)
                {
                    arr[index] = Arr[i];
                    index++;
                }
            }
            return arr;
        }
        #endregion
        #region FunQ5
        public static int FindNonRepeatedChar(string word)
        {
            Dictionary<char, int> list = new Dictionary<char, int>();
            foreach (char s in word)
            {
                if (list.ContainsKey(s))
                {
                    // to check if the charater is repeated so add its count++
                    list[s]++;

                }
                else
                {
                    // if the character is first appearance make its count 1
                    list[s] = 1;
                }

            }
            for (int i = 0; i < word.Length; i++)
            {
                if (list[word[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        } 
        #endregion

        static void Main(string[] args)
        {
            #region Q1
            //var r1 = new Range<int>(20, 10);
            //r1.Length();
            //Console.WriteLine(r1.IsRange(15)); 
            #endregion
            #region Q2
            //int[] Arr = { 1, 2, 3, 4, 5 };
            #region For RangeClass
            //var r1 = new Range<int>(10, 5);
            //r1.Reverse(Arr);
            //foreach (int i in Arr)
            //{
            //    Console.Write(i);
            //} 
            #endregion
            //Reverse(Arr);
            //foreach (int i in Arr)
            //{
            //    Console.Write($"{i} ");
            //} 
            #endregion
            #region Q3
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[]Result= GetEvenArr(arr);
            ////List<int>Result=GetEven(arr);
            //foreach (int i in Result)
            //{

            //    Console.Write($"{i} ");
            //}
            #endregion
            #region Q4
            //FixedSizeList<int> list = new FixedSizeList<int>(5);
            //list.Add(2);
            //list.Add(5);
            //list.Add(4);
            //list.Add(9);
            //list.Add(2);
            ////for (int i = 0; i < list.Capacity; i++)
            ////{
            ////    Console.Write($"{list.Get(i)} ");
            ////}
            //list.Get(5);
            ////Console.WriteLine();
            //list.Add(6);
            //Console.WriteLine();
            ////FixedSizeList<int> list2 = new FixedSizeList<int>(-1); 
            #endregion
            #region Q5
            //string word = "aabbccw";
            //int index = FindNonRepeatedChar(word);
            //Console.WriteLine(index); 
            #endregion







        }
    }
}
