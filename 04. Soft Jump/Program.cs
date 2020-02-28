using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Soft_Jump
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = Math.Abs(input[0]);
            int columns = Math.Abs(input[1]);

            int counterJump = 0;

            char[,] playGround = new char[rows, columns];

            // fill the playground
            for (int i = 0; i < rows; i++)
            {
                string rowsFull = Console.ReadLine();
                for (int j = 0; j < rowsFull.Length; j++)
                {
                    playGround[i, j] = rowsFull[j];
                }
            }

            int numberTry = int.Parse(Console.ReadLine());

            bool playerWin = false;

            // moving target rows
            for (int j = 0; j < numberTry; j++)
            {
                int[] moveRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int rowTarget = Math.Abs(moveRow[0]);
                int countRowMove = moveRow[1];

                //create tempRow miror copy of currRow
                char[] tempRow = new char[playGround.GetLength(1)];

                for (int f = 0; f < playGround.GetLength(1); f++)
                {
                    tempRow[f] = playGround[rowTarget, f];
                }

                //rewrite original cells with temp + move;
                for (int k = 0; k < tempRow.Length; k++)
                {
                    char currElement = tempRow[k];

                    int newColumnIndex = k + countRowMove;
                    if (newColumnIndex > playGround.GetLength(1) - 1)
                    {
                        newColumnIndex = newColumnIndex % playGround.GetLength(1);
                    }
                    playGround[rowTarget, newColumnIndex] = tempRow[k];
                }

                int indexRowPlayer = 0;
                int indexColumnPlayer = 0;

                //find Player position;
                for (int i = 0; i < playGround.GetLength(0); i++)
                {
                    for (int k = 0; k < playGround.GetLength(1); k++)
                    {
                        if (playGround[i, k] == 'S')
                        {
                            indexRowPlayer = i;
                            indexColumnPlayer = k;
                        }
                    }
                }

                if (playGround[indexRowPlayer - 1, indexColumnPlayer] == '-')
                {
                    playGround[indexRowPlayer - 1, indexColumnPlayer] = 'S';
                    if (counterJump == 0)
                    {
                        playGround[indexRowPlayer, indexColumnPlayer] = '0';
                    }
                    else
                    {
                        playGround[indexRowPlayer, indexColumnPlayer] = '-';
                    }
                    indexRowPlayer--;
                    counterJump++;
                }
                if (indexRowPlayer == 0)
                {
                    playerWin = true;
                    break;
                }
            }

            if (playerWin)
            {
                Console.WriteLine("Win");
            }
            else
            {
                Console.WriteLine("Lose");
            }
            Console.WriteLine($"Total Jumps: {counterJump}");
            for (int i = 0; i < playGround.GetLength(0); i++)
            {
                for (int j = 0; j < playGround.GetLength(1); j++)
                {
                    Console.Write(playGround[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
