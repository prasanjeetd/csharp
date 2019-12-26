using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Exams
{
    public class ToptalPlaneSeat
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int cnt = 0;

            int prev = A[0];
            int curr = A[1];

            for (int i = 1; i < A.Length - 1; i = i + 2)
            {
                prev = A[i - 1];
                curr = A[i];
                int next = A[i + 1];

                if (curr > prev)
                {
                    if (curr < next)
                    {
                        cnt++;
                    }
                }

                else if (curr < prev)
                {
                    if (curr > next)
                    {
                        cnt++;
                    }
                }

            }

            return cnt;
        }

        public int solution(int N, string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int[,] leftSeat = new int[N, 3];
            int[,] middleSeat = new int[N, 4];
            int[,] rightSeat = new int[N, 3];

            Console.WriteLine("n:" + N + " s:" + S);

            if (!String.IsNullOrWhiteSpace(S.Trim()))
            {

                string[] allocatedSeats = S.Split(' ');

                fillSeats(allocatedSeats, leftSeat, middleSeat, rightSeat);
            }

            return checkAvailibity(N, leftSeat, middleSeat, rightSeat);

        }

        public int checkAvailibity(int N, int[,] leftSeat, int[,] middleSeat, int[,] rightSeat)
        {
            int fourSeatCnt = 0;

            for (int i = 0; i < N; i++)
            {
                int seatCnt = 0;

                for (int j = 1; j < leftSeat.GetLength(1); j++)
                {
                    if (leftSeat[i, j] != 1)
                    {
                        seatCnt++;
                    }
                    else
                    {
                        seatCnt = 0;
                    }
                }

                if (seatCnt != 2)
                {
                    seatCnt = 0;
                }

                for (int j = 0; j < middleSeat.GetLength(1); j++)
                {
                    if (middleSeat[i, j] != 1)
                    {
                        seatCnt++;
                    }
                    else
                    {
                        seatCnt = 0;
                    }

                    if (seatCnt == 4)
                    {
                        fourSeatCnt++;
                        seatCnt = 0;
                    }
                }

                if (seatCnt == 4)
                {
                    fourSeatCnt++;
                    seatCnt = 0;
                }
                else if (seatCnt != 2)
                {
                    seatCnt = 0;
                }


                for (int j = 0; j < rightSeat.GetLength(1); j++)
                {
                    if (middleSeat[i, j] != 1)
                    {
                        seatCnt++;
                    }
                    else
                    {
                        seatCnt = 0;
                    }

                    if (seatCnt == 4)
                    {
                        fourSeatCnt++;
                        seatCnt = 0;
                    }
                }
            }

            return fourSeatCnt;
        }

        public void fillSeats(string[] allocatedSeats, int[,] leftSeat, int[,] middleSeat, int[,] rightSeat)
        {

            Dictionary<char, int> seatMap = new Dictionary<char, int>();
            seatMap.Add('A', 0);
            seatMap.Add('B', 1);
            seatMap.Add('C', 2);

            seatMap.Add('D', 0);
            seatMap.Add('E', 1);
            seatMap.Add('F', 2);
            seatMap.Add('G', 3);

            seatMap.Add('H', 0);
            seatMap.Add('J', 1);
            seatMap.Add('K', 2);

            foreach (string aSeat in allocatedSeats)
            {
                int row = Convert.ToInt16(aSeat[0].ToString());
                char colS = aSeat[1];

                int col = seatMap[colS];

                if ("ABC".Contains(colS.ToString()))
                {
                    leftSeat[--row, col] = 1;
                }
                else if ("DEFG".Contains(colS.ToString()))
                {
                    middleSeat[--row, col] = 1;
                }
                else if ("HJK".Contains(colS.ToString()))
                {
                    rightSeat[--row, col] = 1;
                }

            }

        }
    }
}
