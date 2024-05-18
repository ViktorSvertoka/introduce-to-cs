namespace introduce_to_c {
    class Program {
        static void Main() {

            // Console.WriteLine(Math.Round(4.99f));
            // Console.WriteLine(Math.Ceiling(4.99f));
            // Console.WriteLine(Math.Floor(4.99f));

            // Console.WriteLine(Math.Min(5, 0));
            // Console.WriteLine(Math.Max(5, 0));

            Console.WriteLine("Enter the radius of the circle");

            double radius = Convert.ToDouble(Console.ReadLine());
            
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("The area of a circle with radius {0} is {1}", radius, area);
        }
    }
}
