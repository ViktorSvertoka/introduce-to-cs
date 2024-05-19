namespace introduce_to_c {
    class Program {
        static void Main() {

            Console.WriteLine("Enter the number: ");

            short user_input = Convert.ToInt16(Console.ReadLine());

            switch(user_input) {
                case 5:
                    Console.WriteLine("Number is 5");
                    break;
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 15:
                    Console.WriteLine("Number is 15");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                case 25:
                    Console.WriteLine("Number is 25");
                    break;
                default:
                    Console.WriteLine("Number is unrecognized!");
                    break;
            }
        }
    }
}
