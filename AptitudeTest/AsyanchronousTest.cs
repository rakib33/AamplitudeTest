using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AptitudeTest
{
   public class AsyanchronousTest
    {

        public async void MainLoop() {

            for (int i = 1; i < 10; i++) {
                Console.WriteLine("From Main Thread: i = " +i);
                int sum = await SubLoop(i);
                Console.WriteLine("From Main Thread: i = " + i+1);
                Console.WriteLine("From Main Thread: i = " + i+2);
            
            }
            Console.ReadLine();
        }

        public async Task<int> SubLoop(int max) {
            int sum = 0;
            for (int i = 0; i <= max; i++) {
                sum += i;
            }
            Console.WriteLine("      From Sub Thread: sum =" + sum);
            return sum;
        }
    }
}
