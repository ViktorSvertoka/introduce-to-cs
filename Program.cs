namespace introduce_to_c {
    class Program {
        static void Main() {
            // for(byte i = 0; i <= 10; i++) {
            //     Console.WriteLine("Element: {0}", i);
            // }

            //  for(float i = 200; i > 10; i /= 2) {
            //     Console.WriteLine("Element: {0}", i);
            // }

            // byte j = 0;
            // while(j < 10) {
            //     Console.WriteLine("Element: {0}", j);
            //     j++;
            // }

            // byte i = 10;
            // while(i >= 1) {
            //     Console.WriteLine("Element: {0}", i);
            //     i--;
            // }

            // bool isHasCar = true;
            // while(isHasCar) {
            //     string end = Console.ReadLine();
            //     if(end == "end") {
            //         isHasCar = false;
            //     }
            // }

            // byte i = 100;

            // do
            // {
            //     Console.WriteLine("Element: " + i);
            // } while (i < 10);

            for(short i = 0; i < 10; i++) {
                // if (i > 5)
                //     break;

                if (i % 2 == 0)
                    continue;

                Console.WriteLine("Element: " + i);
            }
        }
    }
}
