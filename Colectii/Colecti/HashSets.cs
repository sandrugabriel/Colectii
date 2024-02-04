using Colectii.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.Colecti
{
    public class HashSets
    {

        public void functii()
        {

            User user1 = new User(1, "Adi", 15);
            User user2 = new User(2, "Alex", 20);
            User user3 = new User(3, "Ana", 14);
            User user4 = new User(4, "Sergiu", 18);
            User user5 = new User(5, "Rares", 20);
            User user6 = new User(6, "Ioana", 16);


            HashSet<User> hashSet = new HashSet<User>();
            //!!!NU ADAUGA ACELASI USER!!!

            hashSet.Add(user1);//il adauga doar daca nu il gaseste in hashSet
            hashSet.Add(user2);
            hashSet.Add(user3);
            hashSet.Add(user4);
            hashSet.Add(user1);


            HashSet<User> hashSet1 = new HashSet<User>() { user3, user5, user6 };

            hashSet.ExceptWith(hashSet1); //sterge din hashSet toti useri din hashSet1 

            hashSet.RemoveWhere(x => x.Age >= 16); //sterge din hashSet toti useri care au Age >= 16


            hashSet1.Add(user1);
            hashSet.Add(user2);
            hashSet.Add(user3);
            hashSet.Add(user4);

            Console.WriteLine(hashSet.Overlaps(hashSet1)); // returneaza true daca gaseste cel putin un user comun
                                                           // din hashSet in hashSet1

            Console.WriteLine(hashSet.SetEquals(hashSet1));// returneaza true daca amandoua hashSets eu aceeasi useri

            hashSet.UnionWith(hashSet1);//insereaza toti useri din hashSet1 in hashSet, cei care nu sunt in hashSet

            foreach (var item in hashSet)
            {
                Console.WriteLine(item.ToString());
            }

            hashSet.Remove(user6);//sterge din hashSet userul 6

        }

    }
}
