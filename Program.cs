using System;

namespace introduce_to_c {
    class Program {
        static void Main() {

            Robot bot = new Robot("Bot", 800, new byte[] {0, 0, 0});
            bot.printValues();


            Killer killer = new Killer("Killer", 1000, new byte[] {0, 0, 10}, 100);
            killer.printValues();
            killer.Health = 100;
            killer.Lazer();

            
        }
    }
}

