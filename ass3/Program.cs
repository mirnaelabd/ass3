using ass3.delgate;

namespace ass3
{
    // step 0 : declar delegate   

    public delegate int StringFuncdelagte(string str);
    /*    // New Class [Delegate]
        // Any Reference From This Delegate Can Refer To 
        // Function Or More [Pointer To Function]
        // This Function May be Static Function [Class Member Function]
        // This Function May be Non Static Function [Object Member Function]
        // But These Functions Must be with the Same Signature of The Delegate 
        // Regardless Function Name & Access Modifier
    */



    // public delegate bool Conditionalfuncdelegate<TD>(TD x);

    #region Built in Delagte 
    //built in delegate :
    //1- perdicate 

    //can refer to Function that Take One parameter {of any datatype} only and must be return bool 

    //2-Func 

    //Can refer to function can take [0-16] parameter and must be Return 
    //func<>

    //3.Action
    //can refer to function can take [0-16] parameter and must be Void 
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region delgate 
            /*     //int x = StringFunction.GetCountUpperChars(); // invalid 
                 // decalr reference from delgate 
                 StringFuncdelagte stringFunDelegte;
                 //step 02 intialize Refernce from delagte 
                 //   stringFunction = new StringFuncdelagte(StringFunction.GetCountUpperChars);
                 //syntax suger
                 stringFunDelegte = StringFunction.GetCountUpperChars;
                 *//*int result = stringFunDelegte.Invoke("OmAr Alaa");
                 Console.WriteLine(result);*/
            /*    stringFunDelegte += StringFunction.GetCountLowerChars;
                int result =stringFunDelegte.Invoke("OmAr Alaa");
                Console.WriteLine(result);*//*

            stringFunDelegte -= StringFunction.GetCountLowerChars;
            int result = stringFunDelegte.Invoke("OmAr Alaa");
            Console.WriteLine(result);
*/
            #endregion
            #region Ex01

            /*   int[] number = { 1, 4, 3, 2, 5, 8, 7, 9, 12 };
               SortAlgorithms.Bubblesort(number,Comparefunction.CompareLess);
               foreach (int i in number)
               {
                   Console.Write($"{i} ");
               }
               Console.WriteLine();
               SortAlgorithms.Bubblesort(number, Comparefunction.CompareGrt);

               foreach (int i in number)
               {
                   Console.Write($"{i} ");

               }*/
            #endregion
            #region EX02
            /*            string[] Names = { "Ahmed", "Mona", "Amr", "Kareem", "Maha" };
                        Func<string,string ,bool> compareFunc = Comparefunction.SortAscending;
                        SortAlgorithms<string>.Bubblesort(Names, compareFunc);
                        //   SortAlgorithms<string>.Bubblesort(Name, Comparefunction.SortDescending);
                        foreach (string i in Names)
                        {
                            Console.Write($"{i} ");
                        }*/




            #endregion
            #region Example 3 
            #region E03

            /*    List<int> list = Enumerable.Range(0, 100).ToList();
                List<int> OddNumber = Helper.GetElementBasedOnPassedFunction(list, Conditionalfunctions.CheckOdd);


                Console.WriteLine("Odd Number");
                foreach (int number in OddNumber)
                {
                    Console.Write($"{number} ");
                }
                List<int> EvenNumber = Helper.GetElementBasedOnPassedFunction(list, Conditionalfunctions.CheckEven);

                Console.WriteLine("\nEven Number");
                foreach (int number in EvenNumber)
                {
                    Console.Write($"{number} ");
                }

                List<int> numberdivisiableby7 = Helper.GetElementBasedOnPassedFunction(list, Conditionalfunctions.CheckDivisiableby7);

                Console.WriteLine("\nnumber divisiableby 7");
                foreach (int number in numberdivisiableby7)
                {
                    Console.Write($"{number} ");
                }
                List<int> numberdivisiableby10 = Helper.GetElementBasedOnPassedFunction(list, Conditionalfunctions.CheckDivisiableby10);

                Console.WriteLine("\nnumber divisiableby 10");
                foreach (int number in numberdivisiableby10)
                {
                    Console.Write($"{number} ");
                }*/

            #endregion
            #region Ex03 generic 
            /*            List<string> Names = new List<string>() { "Ahmed", "Omar", "May", "Kareem", "Manar" };

                        List<string> Result = Helper.GetElementBasedOnPassedFunction(Names, Conditionalfunctions.CheckStringLength);
                        foreach (string Name in Result)
                        {
                            Console.WriteLine(Name);

                        }*/
            #endregion


            #endregion

            #region buit in delagte  Anonymous Method

         //  Predicate<int> predicate;
          //  predicate = (x) => { return x > 0; };
            var Predicate = (int x) => { return x > 0; };
             //   Console.WriteLine(predicate(10));
          //  Func<int, string> func;
            var func = (int X) => { return X.ToString(); };
            //Console.WriteLine(func(5));

            Action<string> action;
            action = (Name) => { Console.WriteLine($"hello {Name}"); };
            action("Mona");
            #endregion

        }
    }
}
