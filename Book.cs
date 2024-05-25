using System;

namespace introduce_to_c {

    struct Book {

        public string title, avtor, intro;

        public short pages;

        public void setValues(string title, string avtor) {
            this.title = title;
            this.avtor = avtor;
        }

        public void printValues() {
            Console.WriteLine(this.avtor + " write the book: <" + this.title + ">");
        }
    }
}