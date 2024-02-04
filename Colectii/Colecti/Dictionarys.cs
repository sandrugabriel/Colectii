using Colectii.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.Colecti
{
    public class Dictionarys
    {

        public void functii()
        {

            User user1 = new User(1, "Adi", 15);
            User user2 = new User(2, "Alex", 20);
            User user3 = new User(3, "Ana", 14);
            User user4 = new User(4, "Sergiu", 18);
            User user5 = new User(5, "Rares", 20);
            User user6 = new User(6, "Ioana", 16);

            Dictionary<string, User> dictionary = new Dictionary<string, User>();
            List<string> users = new List<string>() { "user1" , "user2" , "user3" , "user4" , "user5" , "user6" };

            //!!!Key trebuie sa fie unic, daca nu o sa dea eroare!!!(DOAR DACA VALUE NU ESTE O LISTA)
            //Iar Value poate sa se repete 

            dictionary.Add("user1", user1);
            dictionary.Add("user2", user2);
            dictionary.Add("user3", user3);
            dictionary.Add("user4", user4);
            dictionary.Add("user5", user5);
            dictionary.Add("user6", user2);
           

            Console.WriteLine(dictionary.ContainsKey("user2"));//verifica daca in dictionary exista cheia usre2
            Console.WriteLine(dictionary.ContainsValue(user2));//verifica daca in dictionary exista value lui user2 

            Console.WriteLine(dictionary.EnsureCapacity(20));//verifica daca dictionary poate sa contina pana la 20, si returneaza
                                                             //numarul de intrari

            Console.WriteLine(dictionary.TryAdd("user1",user1));//verifica daca poate sa l adauge

            dictionary.Remove("user2");//se sterge din dictionary keia 2

            var keys = dictionary.Keys;

            Console.WriteLine("\n\nCheile dictionarului sunt:");
            foreach (string key in keys) Console.WriteLine($"{key}");

            Console.WriteLine("\n\nValorile dictionarului sunt:");
            foreach (string key in keys) Console.WriteLine($"{dictionary[key]}");

            Console.WriteLine("\n\n\nPerechile dictionarului sunt:");
            foreach (string key in keys) Console.WriteLine($"Cheia {key} conntine id-ul userului {dictionary[key].Name}");

        }

    }
}
