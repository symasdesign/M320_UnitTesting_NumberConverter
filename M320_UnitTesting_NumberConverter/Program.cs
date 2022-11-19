﻿namespace NumberConverter {
    internal class Program {
        static void Main(string[] args) {
            NumberConverter converter = new NumberConverter();

            Console.WriteLine($"Round up:                 12.5f  =>  {converter.RoundUp(12.5f)}\n");
            Console.WriteLine($"Round down:               16.8f  =>  {converter.RoundDown(16.8f)}\n");
            Console.WriteLine($"Round to 10^1:           136.2f  =>  {converter.RoundToPowerOfTen(136.2f, 1)}");
            Console.WriteLine($"Round to 10^2:           136.2f  =>  {converter.RoundToPowerOfTen(136.2f, 2)}");
            Console.WriteLine($"Round to 10^3:           136.2f  =>  {converter.RoundToPowerOfTen(136.2f, 3)}\n");
            Console.WriteLine($"Round to 10^1: siebenundzwanzig  =>  {converter.RoundToPowerOfTen("siebenundzwanzig")}");
            Console.WriteLine($"Round to 10^2: siebenundzwanzig  =>  {converter.RoundToPowerOfTen("siebenundzwanzig", 2)}\n");
        }
    }
}