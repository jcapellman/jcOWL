using System;

namespace jcOWL.ConsoleTest {
    class Program {
        static void Main(string[] args) {
            var oManager = new jcOWLManager();

            Console.WriteLine(oManager.Run());

            Console.ReadKey();
        }
    }
}