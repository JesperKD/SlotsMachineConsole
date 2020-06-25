using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotsMachineConsole
{
    public class Logic
    {
        public int slot1 = 0;
        public int slot2 = 0;
        public int slot3 = 0;
        private List<int> slotList = new List<int>();

        /// <summary>
        /// rolls 3 random values and adds them to a list
        /// </summary>
        public void Pull()
        {
            slotList.Clear();
            Random random = new Random();
            slot1 = random.Next(5);
            slot2 = random.Next(5);
            slot3 = random.Next(5);

            slotList.Add(slot1);
            slotList.Add(slot2);
            slotList.Add(slot3);

            Console.WriteLine("Press a button to pull handle");
            Console.ReadKey();
            Console.WriteLine("Result: " + ResultCheck(slotList));
            Console.WriteLine();
        }

        /// <summary>
        /// Groups the elements of the list and gives result depending on the amount of duplicate values
        /// </summary>
        /// <param name="slotList"></param>
        /// <returns></returns>
        private string ResultCheck(List<int> slotList)
        {
            string result = string.Empty;

            var query = slotList.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => new { Element = y.Key, Counter = y.Count() })
              .ToList();

            int dupes = 0;
            foreach (var item in query)
            {
                dupes = item.Counter;
            }

            switch (dupes)
            {
                case 0:
                    result = "Nothing";
                    break;
                case 1:
                    result = "Nothing";
                    break;
                case 2:
                    result = "Two of the same, Money back";
                    break;
                case 3:
                    result = "JACKPOT! YOU WON SOME E-PUSS!!!";
                    break;
            }

            return result;
        }
    }
}
