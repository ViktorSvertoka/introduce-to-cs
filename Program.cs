using System.IO;

namespace introduce_to_c {
    class Program {
        static void Main() {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            using(FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate)) {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);

                stream.Write(array, 0, array.Length);

            }

            using(FileStream stream1 = File.OpenRead("info.txt")) {
                byte[] array = new byte[stream1.Length];
                stream1.Read(array, 0, array.Length);

                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine(textFromFile);

            }
        }
    }
}

