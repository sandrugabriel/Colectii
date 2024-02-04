using Colectii.Colecti;
using Colectii.Models;
using System.Collections;
using System.Runtime.Intrinsics.X86;

internal class Program
{

    private static void Main(string[] args)
    {

        //1.List
        Lista lista = new Lista();
        //lista.functii();

        //2.Queue
        Coada queue = new Coada();
        //queue.functii();

        //3.Stack
        Stiva stiva = new Stiva();
        //stiva.functii();

        //4.HashSet
        HashSets hashSets = new HashSets();
        //hashSets.functii();

        //5.SortedSet
        SortedSets sortedSets = new SortedSets();
        //sortedSets.functii();

        //6.Dictionary
        Dictionarys dictionarys = new Dictionarys();
        dictionarys.functii();

    }
}