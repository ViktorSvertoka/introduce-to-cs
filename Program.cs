using System;

namespace introduce_to_c {
    class Program {
        static void Main() {

            Robot bot = new Robot();
            bot.setValues("Bot", 800, new byte[] {0, 0, 0});
            bot.printValues();


            Robot killer = new Robot();
            killer.setValues("Killer", 1000, new byte[] {0, 0, 10});
            killer.printValues();

            
        }
    }
}

