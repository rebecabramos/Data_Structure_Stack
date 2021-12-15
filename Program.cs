using System;

namespace Stack
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha();
            Console.WriteLine($"Adcionando na Pilha: {s.Empilha(1)}");
            Console.WriteLine($"Adcionando na Pilha: {s.Empilha(10)}");
            Console.WriteLine($"Adcionando na Pilha: {s.Empilha(100)}");
            Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine($"Desempilhando: {s.Desempilha()}");
            Console.WriteLine($"Desempilhando: {s.Desempilha()}");
            Console.WriteLine($"Desempilhando: {s.Desempilha()}");
        }
    }
}
