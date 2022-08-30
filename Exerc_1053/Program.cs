using System;
using System.Globalization;

namespace Exerc_1053 {
    class Program {
        static void Main(string[] args) {

            int t = int.Parse(Console.ReadLine());


            for (int i = 0; i < t; i++) {

                int n = int.Parse(Console.ReadLine());

                for (int e = 0; e < n; e++) {

                   
                    string[] vet = Console.ReadLine().Split(' ');

                   string X = vet[0];
                   string Y = vet[1];
                    string[] coluna = new string[5];
                    int[] linha = new int[5] { 1, 2, 3, 4, 5 };
                    
                    coluna[0]= "A";
                    coluna[1]= "B";
                    coluna[2]= "C";
                    coluna[3]= "D";
                    coluna[4]= "E";


                    if (i+t *1 == 1) {
                        Console.ReadLine();
                        Console.WriteLine("Case 1:" + coluna + linha ) ;
                    }
                }

            }Console.ReadKey();
        }
    }
}
