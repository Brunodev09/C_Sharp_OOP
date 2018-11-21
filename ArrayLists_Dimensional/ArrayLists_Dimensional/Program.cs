using System;

namespace ArrayLists_Dimensional{
    class MainClass{
        public static void Main(string[] args){
            string[,] matrix; //2d array declaration
            string[,,] dim_matrix; //3d array declaration

            int[,] array = new int[,]{ //to access 2 --> array[0][1] (Java, C++) --> array[0,1] (C#)
                {1,2,3},{4,5,6},{7,8,9}
            };
            int checkDimension = array.Rank;
            Console.WriteLine(array[0,1]);
            Console.WriteLine("Central value --> '{0}'", array[1,1]); //C# prints variables like C
            Console.WriteLine("The array has {0} dimensions", checkDimension);
            jaggedArrays();

            int[] myGrades = new int[] { 6, 5, 7, 10, 15 };
            Console.WriteLine("-------------");
            Console.WriteLine("Average --> " + getAvg(myGrades)); 
        }

        public static void jaggedArrays() {
            int[][] jagged = new int[3][];
            jagged[0] = new int[5]; //Arrays within array
            jagged[1] = new int[3];
            jagged[2] = new int[2];

            jagged[0] = new int[] { 2, 3, 4, 5, 6 };
            jagged[1] = new int[] { 1, 2, 3 };
            jagged[2] = new int[] { 6, 6 };

            Console.WriteLine("The central value of the jagged array is --> '{0}'", jagged[0][2]);

            for (int i = 0; i < jagged.Length; i++) {
                Console.WriteLine("-------------");
                Console.WriteLine("Element index: {0}", i);
                for (int j = 0; j < jagged[i].Length; j++) {
                    Console.WriteLine("{0}", jagged[i][j]);
                }
            }

        }

        public static double getAvg(int[] grades) {
            int size = grades.Length;
            int sum = 0;
            for (int i = 0; i < size; i++) {
                sum += grades[i];
            }
            return (double)sum / size;
        }


    }
}
