﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problem8: IProblem
    {
        public string Solve()
        {
            string the1000DigitNumber =
                     "73167176531330624919225119674426574742355349194934969" +
                     "83520312774506326239578318016984801869478851843858615" +
                     "60789112949495459501737958331952853208805511125406987" +
                     "47158523863050715693290963295227443043557668966489504" +
                     "45244523161731856403098711121722383113622298934233803" +
                     "08135336276614282806444486645238749303589072962904915" +
                     "60440772390713810515859307960866701724271218839987979" +
                     "08792274921901699720888093776657273330010533678812202" +
                     "35421809751254540594752243525849077116705560136048395" +
                     "86446706324415722155397536978179778461740649551492908" +
                     "62569321978468622482839722413756570560574902614079729" +
                     "68652414535100474821663704844031998900088952434506585" +
                     "41227588666881164271714799244429282308634656748139191" +
                     "23162824586178664583591245665294765456828489128831426" +
                     "07690042242190226710556263211111093705442175069416589" +
                     "60408071984038509624554443629812309878799272442849091" +
                     "88845801561660979191338754992005240636899125607176060" +
                     "58861164671094050775410022569831552000559357297257163" +
                     "6269561882670428252483600823257530420752963450";

            return BiggestTheThirteenAdjDigitsIn(the1000DigitNumber, 4).ToString();
        }

        long BiggestTheThirteenAdjDigitsIn(string N, int adjNumbersCount)
        {
            var theNumber = new List<byte>();
            var thirteenAdjacentList = new List<int[]>();
            var adjacentNumsProducts = new List<long>();

            foreach (char ch in N)
                theNumber.Add(byte.Parse(ch.ToString()));

            for (int i = 0; i < N.Length; i++)
            {
                bool adjacentsHasAValueGraterThan0 = true;
                var adjacentNums = new int[adjNumbersCount];

                for (int j = i; j < i + adjNumbersCount; j++)
                {
                    if (theNumber[j] == 0) { adjacentsHasAValueGraterThan0 = false; break;}

                    adjacentNums[j-i] = theNumber[j];
                }

                if (adjacentsHasAValueGraterThan0)
                {
                    thirteenAdjacentList.Add(adjacentNums);
                }
            }

            foreach (var thirteenAdjacent in thirteenAdjacentList)
            {
                long adjacentProduct = 1;
                foreach (var adjacentNum in thirteenAdjacent)
                {
                    adjacentProduct *= adjacentNum;
                }
                adjacentNumsProducts.Add(adjacentProduct);
            }

            return adjacentNumsProducts.Max();
        }
    }

}
