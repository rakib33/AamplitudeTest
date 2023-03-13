using System;
using System.Collections.Generic;

namespace AptitudeTest
{
    class Program
    {
        private static  void Main(string[] args)
        {

            #region 2-User Class
            //while (true)
            //{
            //    var user = new User();
            //    Console.WriteLine("Please enter the username, or q to exit ");
            //    var userName = Console.ReadLine();

            //    if (userName == "q")
            //    {
            //        break;
            //    }
            //    user.Add(userName);
            //    Console.WriteLine($"number of added user { user.GetUsersCount()}");
            //}
            #endregion

            #region 3-John the Robot
            ////Humanoid obj = new Dancing();
            ////Console.WriteLine(obj.ShowSkill());
            //var john = new Humanoid(new Dancing());
            //Console.WriteLine(john.ShowSkill()); //print dancing
            //var alex = new Humanoid(new Cooking());
            //Console.WriteLine(alex.ShowSkill());//print cooking
            //var bob = new Humanoid();
            //Console.WriteLine(bob.ShowSkill());//print no skill is defined
            #endregion

            #region 4-Alexa Settings
            ////https://stackoverflow.com/questions/63968447/passing-lambda-expression-to-a-method-c-sharp
            ////https://medium.com/swlh/how-to-write-methods-in-csharp-which-take-lambdas-as-parameters-ccce4944b490

            //var alexa = new Alexa();
            //Console.WriteLine(alexa.Talk()); //print hello, i am Alexa
            //alexa.Configure(x =>
            //{
            //    x.GreetingMessage = "Hello {OwnerName}, I am at your service";
            //    x.OwnerName = "Bob Marley";
            //});
            //Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, I am at your service
            #endregion

            #region 6- Construction Game
            //   var myHouse = new Building()
            //.AddKitchen()
            //.AddBedroom("master")
            //.AddBedroom("guest")
            //.AddBalcony();

            //   var normalHouse = myHouse.Build();

            //   //kitchen, master room, guest room, balcony
            //   Console.WriteLine(normalHouse.Describe());

            //   myHouse.AddKitchen().AddBedroom("another");

            //   var luxuryHouse = myHouse.Build();

            //   //it only shows the kitchen after build
            //   //kitchen, master room, guest room, balcony, kitchen, another room
            //   Console.WriteLine(luxuryHouse.Describe());


            #endregion

            #region BinarySearch
            //int[] arr = { 1, 2, 4, 5, 6, 12, 34, 45, 67, 89 };
            //int target = 45;
            //int arrLength = arr.Length;
            //Console.WriteLine("Binary search target:" + target);
            //Console.WriteLine("Binary search target index:" + BinarySearch(arr, target, 0, arrLength));
            //Console.ReadKey();
            #endregion

            #region Valid Parenthesis Problem
            //ValidParentheses validParentheses = new ValidParentheses();
            //string input = "()";
            ////Console.WriteLine(validParentheses.ValidInitialSolution("()")); // true
            ////Console.WriteLine(validParentheses.ValidGoodSolution("()[]{}")); // true
            ////Console.WriteLine(validParentheses.ValidGoodSolution("(]")); // false
            ////Console.WriteLine(validParentheses.ValidInitialSolution("([)]")); // false
            //Console.WriteLine(validParentheses.ValidInitialSolution("{[]}")); // true
            //Console.WriteLine(validParentheses.ValidInitialSolution("[()]{}{[()()]()}")); // true
            //Console.WriteLine();
            #endregion

            #region BubbleShort
            //int[] unshortarray = { 2,4,8,5,1};
            //BubbleShortAlgorithom.BubbleShort(ref unshortarray);
            ////print
            //foreach (var item in unshortarray) {
            //    Console.WriteLine(item);
            //}
            #endregion

            #region InsertionShort
            //int[] arr = { 12, 11, 13, 5, 6 };
            //InsertionShortAlgorithm.InsertionShort(ref arr);
            ////print
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region TwoSum
            //int[] nums = { 2, 7, 11, 15 };
            //var result = TwoSumProblem.TwoSumEfficient(nums, 9);
            #endregion

            #region RomanToInteger
            // var sum = RomanToInteger.RomanToInt("LVIII");
            #endregion
            #region BankLaserBeam
            //string[] input = { "011001", "000000", "010100", "001000" };
            //var beamNo = BankLaserBeams.NumberOfBeams(input);
            #endregion

            #region AsynchornousTest
            //AsyanchronousTest ayanchornousTest = new AsyanchronousTest();
            //ayanchornousTest.MainLoop();
            #endregion
            #region LongestSubstring
            //int num = LongestSubString.LengthOfLongestSubstring("dvdw");
            #endregion

            #region PlusMinutesProblem
            //plusMinusProblem.plusMinus(new List<int> { 1, 1,0,-1,-1 });
            //Console.ReadLine();
            #endregion
            #region MaxMinSum
            //MaxMinSumProblem.miniMaxSum(new List<int> {5,4,7,6,3});
            //Console.WriteLine();
            #endregion

            #region  AveryMaxSum           
            //long sum = aVeryBigSumProblem.aVeryBigSum(new List<long> { 1000000001 ,1000000002 ,1000000003 ,1000000004 ,1000000005 });
            //Console.WriteLine(sum);          
            #endregion

            #region TimeConversationProblem
            string result = TimeConversationProblem.TimeConversion("12:00:00AM");
            Console.WriteLine(result);
            #endregion
        }

        #region BinarySearch
        private static int BinarySearch(int[] arr, int target, int arrLowIndex, int arrhighIndex)
        {
            int midIndex = (arrLowIndex + arrhighIndex) / 2;

            if (target == arr[midIndex])
                return midIndex;
            else if (target > arr[midIndex])
                return BinarySearch(arr, target, midIndex + 1, arrhighIndex);
            else if (target < arr[midIndex])
                return BinarySearch(arr, target, arrLowIndex, midIndex - 1);
            else
                return -1;
        }
        #endregion

        #region BigSum

        public void BigSum() {
            // int[] arr = new int[] { 1, 6, 1, 2, 6, 1, 6, 6 };
            int[] arr = new int[] { 1, 2, 1, 5, 5, 3, 3, 3, 4 };

            int N = arr.Length;
            if (N >= 2)
                Console.Write("Max Pair Sum is " + Challenge(arr));
            Console.Read();
        }
        public  int Challenge(int[] input)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int maxRepeate = 1;
            int maxNeighbourSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int key = input[i];
                if (!dictionary.ContainsKey(key))
                {
                    dictionary.Add(key, 1);
                }
                else
                {
                    dictionary[key]++;
                    int currentVal = dictionary[key];
                    if (currentVal > maxRepeate)
                    {
                        maxRepeate = currentVal;
                    }
                }
            }

            for (int j = 1; j < input.Length; j++)
            {
                int currentKey = input[j];
                int dicValue = dictionary[currentKey];

                int neighbourKey = input[j - 1];
                int neighbourValue = dictionary[neighbourKey];

                if (dicValue >= maxRepeate - 1 && neighbourValue >= maxRepeate - 1)
                {
                    int sum = input[j] + input[j - 1];
                    if (sum > maxNeighbourSum)
                    {
                        maxNeighbourSum = sum;
                    }
                }
            }
            return maxNeighbourSum;
        }




        //public static int Challenge(int[] A)
        //{

        //        int M = A.Length;
        //        // Initialize the biggest sum to the first two elements of the array

        //    int biggestSum = A[0] + A[1];
        //    // Iterate through the array and keep track of the current biggest sum
        //    for (int i = 1; i < A.Length-1; i++)
        //        {
        //            // Calculate the sum of the current element and the next element
        //            int currentSum = A[i] + A[i + 1];

        //            // If the current sum is bigger than the biggest sum, update the biggest sum
        //            if (currentSum > biggestSum)
        //            {
        //                biggestSum = currentSum;
        //            }
        //        }

        //        return biggestSum;

        //}

        #endregion

        #region 2-User Class
        public class User
        {
            private static int instances = 0;
            public void Add(string userName)
            {
                instances++;
            }

            public int GetUsersCount()
            {
                return instances;
            }
        }
        #endregion

        #region 3-John the Robot

        public interface IHumanoid
        {
            string ShowSkill();
        }
        public class Humanoid
        {
            private readonly IHumanoid _humanoidInstance;
            public Humanoid(IHumanoid humanoid)
            {
                _humanoidInstance = humanoid;
            }

            public Humanoid()
            {
            }

            public string ShowSkill()
            {
                if (_humanoidInstance != null)
                    return _humanoidInstance.ShowSkill();
                else
                {
                    return "no skill is defined";
                }
            }
        }
        public class Dancing : IHumanoid
        {      
            public string ShowSkill()
            {
                return "dancing";
            }
        }

        public class Cooking : IHumanoid
        {   
            public string ShowSkill()
            {
                return "cooking";
            }
        }

        #endregion

        #region 4-Alexa Settings
        public class Configuration
        {
            public string GreetingMessage { get; set; }
            public string OwnerName { get; set; }
        }
        public class Alexa
        {
            private Configuration _configration { get; set; }       
            public Alexa()
            {
                _configration = new Configuration
                {
                    GreetingMessage = "Hello, I am Alexa."
                };
            }

            public void Configure(Action<Configuration> configuration)
            {
                //Finally, you may wonder what configuration(_configration); 
                //is doing.Its actually short-hand for configuration.Invoke(_configration);, 
                //which will execute the Action delegate, passing _configration as the Configuration parameter.

                //configuration(_configration); //short form
                //for the null-conditional member access is invoking delegates in a thread-safe way with much less code. 
                configuration?.Invoke(_configration);
                _configration.GreetingMessage = _configration.GreetingMessage.Replace(@"{OwnerName}", _configration.OwnerName);
                //this is thread - safe because the compiler generates code to evaluate PropertyChanged one time only, 
                // keeping the result in a temporary variable.You need to explicitly call the Invoke method because
                // there is no null - conditional delegate invocation syntax PropertyChanged ? (e).

                //I usually use Invoke() because you can use the null - check and people reading through the code can 
                //more easily see that a delegate is being use.null - check MyDelegate mydelegate = null;
                //mydelegate?.Invoke("Reza");
                //mydelegate("Reza"); // Error: System.NullReferenceException


            }

            public string Talk()
            {
                return _configration.GreetingMessage;
            }
        }
        #endregion


        #region 6- Construction Game
        public class Building : IBuilder
        {
            string[] build = new string[1];
            //StringBuilder build = new StringBuilder();           
            string constructedBuilding;
            int index = 0;
            private void ConstructBuilding(string construct)
            {
                if (index > 0)
                    Array.Resize(ref build, index + 1); //available from .net 3.5

                build[index] = construct;
                index++;
                // Routine.IncreaseArray(ref build, 1);

            }
            public Building AddBalcony()
            {
                ConstructBuilding("balcony");
                return this;
            }

            public Building AddBedroom(string roomType)
            {
                ConstructBuilding(roomType + " room");
                return this;
            }

            public Building AddKitchen()
            {
                ConstructBuilding("kitchen");
                return this;
            }

            public Building Build()
            {
                constructedBuilding = string.Join(", ", build);
                return this;
            }

            public string Describe()
            {
                //return constructedBuilding;
                return constructedBuilding;
            }

        }
        public interface IBuilder
        {
            Building AddKitchen();
            Building AddBedroom(string bedroom);
            Building AddBalcony();

            Building Build();
            string Describe();
        }

        #endregion

        #region 5-MethodSignature
        //static async Task Main(string[] args)
        //{
        //    var (averageSalary, numberOfEmployee) = await SomeCalculation(0L, 10, 0L == 10L);
        //    Console.WriteLine(averageSalary + "  " + numberOfEmployee);
        //    Console.Read();
        //}
        //public static async Task<(long averageSalary, long numberOfEmployee)> SomeCalculation(long num1, long num2, bool b)
        //{
        //    long averageSalary = (num1 * num2) / num2; // average calculation
        //    long numberOfEmployee = num2; // guess num2 is total employee 

        //    return (averageSalary, numberOfEmployee);
        //}
        #endregion

    }
}
