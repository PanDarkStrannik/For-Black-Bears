using System;

namespace ForBlackBears
{
    public class Program
    {
        private const int _linesValue = 4;
        private const int _columesValue = 9;

        private static void Main(string[] args)
        {
            char[,] array = new char[_linesValue, _columesValue]
            {
            {'_','*','_','_','_','_','_','_','_'},
            {'*','_','_','_','*','_','*','_','_'},
            {'_','*','_','_','*','*','*','_','*'},
            {'*','*','_','*','*','*','*','_','*'}
            };

            Console.WriteLine($"Изначальный массив:");

            for (int line = 0; line < _linesValue; line++)
            {
                for (int colum = 0; colum < _columesValue; colum++)
                    Console.Write($"{array[line, colum]} ");
                Console.WriteLine();
            }

            int arrayCenterIndex = _columesValue / 2;

            Console.WriteLine(arrayCenterIndex);

            for (int line = 0; line < _linesValue; line++)
            {
                for (int colum = 0; colum < _columesValue; colum++)
                {
                    if (array[line, colum] == '*')
                    {
                        for (int fromCenterOffset = 0; fromCenterOffset <= arrayCenterIndex; fromCenterOffset++)
                        {
                            if (array[line, arrayCenterIndex + fromCenterOffset] == '_')
                            {
                                Swap(ref array[line, colum], ref array[line, arrayCenterIndex + fromCenterOffset]);
                                break;
                            }
                            else if (array[line, arrayCenterIndex - fromCenterOffset] == '_')
                            {
                                Swap(ref array[line, colum], ref array[line, arrayCenterIndex - fromCenterOffset]);
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Новый массив:");
            for (int line = 0; line < _linesValue; line++)
            {
                for (int colum = 0; colum < _columesValue; colum++)
                    Console.Write($"{array[line, colum]} ");
                Console.WriteLine();
            }

        }

        private static void Swap<T>(ref T value1, ref T value2)
        {
            var temp = value1;
            value1 = value2;
            value2 = temp;
        }
    }
}
