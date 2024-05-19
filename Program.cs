namespace introduce_to_c {
    class Program {
        static void Main() {

            // int[] nums = new int[5];
            // nums[0] = 250;
            // nums[1] = 200;
            // nums[2] = 150;
            // nums[3] = 100;
            // nums[4] = 50;

            // Console.WriteLine("Elements: " + nums[0]);

            // string[] words = new string[] {"John", "Bob", "Alex"};

            // words[1] = "Josh";

            // for(byte i = 0; i < words.Length; i++) {
            //     Console.WriteLine("El: " + words[i]);

            // }

            // short[] numbers = new short[10];
            // short summa = 0;

            // Random random = new Random();

            // for(byte i = 0; i < numbers.Length; i++) {

            //     numbers[i] = Convert.ToInt16(random.Next(-15, 15));

            //     Console.WriteLine("Elements: " + numbers[i]);

            //     summa += numbers[i];
            // }
            // Console.WriteLine("Summa: " + summa);

            // char[,] symbols = new char[2, 3];
            // symbols[0, 0] = 'H';
            // Console.WriteLine(symbols[0, 0]);

            int[,] nums = new int[,] {
                {4, 6, 7},
                {5, 7, 3},
                {3, 3, 2}
            };

            nums[1, 2] = 56;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(nums[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}

