using System;
using System.Numerics;

class Pascal {
    public static void Main(string[]args) {
        setUp();
    }
    public static void setUp() {
        Console.WriteLine("Please enter the desired number of rows");
        int Rows;
        Rows = Convert.ToInt32(Console.ReadLine());
        BigInteger[][] triangle = new BigInteger[Rows][];

        for (int i = 0; i < Rows; i++) {
            BigInteger[] row = new BigInteger[i+1];
            triangle[i] = row;
            triangle[i][0] = 1;
            triangle[i][triangle[i].Length-1] = 1;
        }
        for (int i = 2; i < Rows; i++) {
            for (int j = 1; j < triangle[i].Length-1; j++) {
                triangle[i][j] = triangle[i-1][j]+triangle[i-1][j-1];
            }
        }
        for (int i = 0; i < Rows; i++)
        {   
            Console.WriteLine();
            for (int j = 0; j < triangle[i].Length; j++)
            {
                Console.Write(triangle[i][j] + ",");
            }

        
        }
        Console.WriteLine();
        Console.WriteLine();
        setUp();
    }
}