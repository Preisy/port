using System;
using System.Reflection.Emit;
using ConsoleApp1;


// internal class Sequence<T> : ListSequence<T> {
//     public Sequence() : base() { }
//
//     public Sequence(params T[] argv) : base(argv) { }
//     
//     public Sequence<T> slice(int startIndex, int endIndex) {
//         
//
//         return list;
//     }
// }


namespace ConsoleApp1 {
    internal class Programm {
        static void Main(string[] args) {
            // ListSequence<string> seq = new ListSequence<string>();
            ListSequence<string> seq = new ListSequence<string>("1", "2", "3", "4", "5");
            // ArraySequence<string> seq = new ArraySequence<string>();
            // ArraySequence<string> seq = new ArraySequence<string>("1", "2", "3", "4", "5");
            // seq.append("1");
            // seq.append("2");
            // seq.append("3");
            // seq.append("4");
            // seq.append("5");

            ListSequence<string> sliced = seq.slice(1, 3);
            // ArraySequence<string> sliced = seq.slice(1, 3);
            
            seq.print();
            sliced.print();
        }
    }
}