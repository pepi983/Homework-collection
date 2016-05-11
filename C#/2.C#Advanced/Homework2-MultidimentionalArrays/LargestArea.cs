using System;
using System.Collections;
using System.Linq;

namespace LargestArea
{
    class LargestArea
    {

        static BitArray[] isChecked;

        static void Main()
        {
            short[] Sizes = Console.ReadLine()
                                   .Trim(' ')
                                   .Split(' ')
                                   .Select(short.Parse)
                                   .ToArray();

            int[][] Searched = new int[Sizes[0]][];

            isChecked = new BitArray[Searched.Length];

            for (int Row = 0; Row < Searched.Length; Row++)
            {
                Searched[Row] = Console.ReadLine()
                                       .Trim(' ')
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToArray();

                isChecked[Row] = new BitArray(Searched[Row].Length);
            }

            var MaxSequence = int.MinValue;

            for (int Row = 0;
                     Row < Searched.Length;
                     Row++)
            {
                for (int Col = 0;
                         Col < Searched[Row].Length;
                         Col++)
                {
                    int CurrentSeq = 1;

                    if (isChecked[Row][Col] == false)
                    {
                        isChecked[Row][Col] = true;

                        CurrentSeq = CheckElement
                                      (
                                        Row,
                                        Col,
                                        CurrentSeq,
                                        Searched
                                      );
                    }

                    MaxSequence = CurrentSeq > MaxSequence ?
                                  CurrentSeq : MaxSequence;
                }
            }
            Console.WriteLine(MaxSequence);
        }

        public static int CheckElement
                          (
                            int Row,
                            int Col,
                            int CurrentSeq,
                            int[][] Searched
                          )
        {
            if (Row + 1 < Searched.Length)
            {
                if (Searched[Row + 1][Col] ==
                    Searched[Row][Col] &&
                    isChecked[Row + 1][Col] == false)
                {
                    CurrentSeq++;

                    isChecked[Row + 1][Col] = true;

                    CurrentSeq = CheckElement
                                  (
                                      Row + 1,
                                      Col,
                                      CurrentSeq,
                                      Searched
                                  );
                }
            }

            if (Col + 1 < Searched[Row].Length)
            {
                if (Searched[Row][Col + 1] ==
                    Searched[Row][Col] &&
                    isChecked[Row][Col + 1] == false)
                {
                    CurrentSeq++;

                    isChecked[Row][Col + 1] = true;

                    CurrentSeq = CheckElement
                                  (
                                      Row,
                                      Col + 1,
                                      CurrentSeq,
                                      Searched
                                  );
                }
            }

            if (Row - 1 >= 0)
            {
                if (Searched[Row - 1][Col] ==
                    Searched[Row][Col] &&
                    isChecked[Row - 1][Col] == false)
                {
                    CurrentSeq++;

                    isChecked[Row - 1][Col] = true;

                    CurrentSeq = CheckElement
                                  (
                                      Row - 1,
                                      Col,
                                      CurrentSeq,
                                      Searched
                                  );
                }
            }

            if (Col - 1 >= 0)
            {
                if (Searched[Row][Col - 1] ==
                    Searched[Row][Col] &&
                    isChecked[Row][Col - 1] == false)
                {
                    CurrentSeq++;

                    isChecked[Row][Col - 1] = true;

                    CurrentSeq = CheckElement
                                  (
                                      Row,
                                      Col - 1,
                                      CurrentSeq,
                                      Searched
                                  );
                }
            }

            return CurrentSeq;
        }
    }
}