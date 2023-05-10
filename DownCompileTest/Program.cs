using System;

namespace DownCompileTest; 
internal class Program {
    static void Main(string[] args) {
        ExammpleClass bob = new("Hello World", 5);
        (string printableText, int aNumber) = bob;
        Console.WriteLine(
            $$"""
            {
                "name": {{bob}}
            }
            """);
        // Pause before exit
        Console.ReadKey();
    }
    record class ExammpleClass(string Text, int Number);
}
