using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Exams
{

    public class AmazonInterviewQuestion
    {
        /// <summary>
        /// http://www.geeksforgeeks.org/maximize-number-0s-flipping-subarray/
        /// </summary>
        public void MaxNumberOf0sByFlippingSubarray()
        {
            int[] array = { 0, 1, 0, 0, 1, 1, 0 };

            int lastOneCount = 0;
            int currentOneCount = 0;
            int zeroCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                var element = array[i];

                if (element == 1)
                    currentOneCount++;
                else
                {
                    if (currentOneCount > lastOneCount)
                        lastOneCount = currentOneCount;
                    currentOneCount = 0;
                    zeroCount++;
                }
            }

            var maximumZeros = lastOneCount + zeroCount;
        }

        /// <summary>
        /// http://www.geeksforgeeks.org/find-a-tour-that-visits-all-stations/
        /// </summary>
        public void FistCircularTour()
        {
            //{4, 6}, {6, 5}, {7, 3} and {4, 5}

            List<PetrolPump> ppumps = new List<PetrolPump> {
               new PetrolPump { Petrol=4, DistanceToNextPump=6 },
                new PetrolPump { Petrol=6, DistanceToNextPump=5 },
               new PetrolPump { Petrol=7, DistanceToNextPump=3 },
                new PetrolPump { Petrol=4, DistanceToNextPump=5 }
            };

            int truckPetrol = 0;
            PetrolPump start;

            for (int i = 0; i < ppumps.Count; i++)
            {
                var ppump = ppumps[i];

                if (ppump.Petrol >= ppump.DistanceToNextPump)
                {
                    truckPetrol = ppump.Petrol - ppump.DistanceToNextPump;

                    int visit = CheckNextVisits(ppumps, i + 1, truckPetrol);
                    if (visit == ppumps.Count)
                    {
                        start = ppump;
                        break;
                    }
                }

                truckPetrol = 0;
            }

        }

        public int CheckNextVisits(List<PetrolPump> ppumps, int next, int truckPetrol)
        {
            int visit = 1;
            do
            {

                var nextppump = ppumps[next];
                truckPetrol += nextppump.Petrol;

                if (truckPetrol >= nextppump.DistanceToNextPump)
                {
                    truckPetrol -= nextppump.DistanceToNextPump;
                    visit++;
                    next++;

                    if (next == ppumps.Count)
                        next = next % ppumps.Count;
                }
                else
                {
                    break;
                }

            } while (visit < ppumps.Count);

            return visit;

        }

        public struct PetrolPump
        {
            public int Petrol;
            public int DistanceToNextPump;
        }

    }

}
