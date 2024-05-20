

namespace introduce_to_c {
    class Program {
        static void Main() {
            string word = "Hello";
            word += "!";
            word = String.Concat(word, "!!");
            Console.WriteLine(word);

            string people = "Alex,Bob,John";
            string[] names = people.Split(new char[]{','});
            foreach(string el in names)
            Console.WriteLine(el);


        }
    }
}

