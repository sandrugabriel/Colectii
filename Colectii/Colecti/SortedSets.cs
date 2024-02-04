using Colectii.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.Colecti
{
    public class SortedSets
    {

        public void functii()
        {


            User user1 = new User(1, "Adi", 15);
            User user2 = new User(2, "Alex", 20);
            User user3 = new User(3, "Ana", 14);
            User user4 = new User(4, "Sergiu", 18);
            User user5 = new User(5, "Rares", 20);
            User user6 = new User(6, "Ioana", 16);

            SortedSet<User> sortedSets = new SortedSet<User>();
            //!!!NU ADAUGA ACELASI USER!!!

            sortedSets.Add(user1);//adauga in sortedSet userul si il ordoneaza dupa CompareTo 
            sortedSets.Add(user2);
            sortedSets.Add(user3);
            sortedSets.Add(user4);
            sortedSets.Add(user1);



            sortedSets.RemoveWhere(x => x.Age < 18);//sterge din sortedSet toti useri daca age <=18



            SortedSet<User> badUsers = new SortedSet<User>() { user1 };
            sortedSets.ExceptWith(badUsers);//sterge din sortedSet toti useri din badUsers


            sortedSets.Add(user1);
            sortedSets.Add(user2);
            sortedSets.Add(user3);
            sortedSets.Add(user4);
            sortedSets.Add(user1);


            SortedSet<User> sortedBetween = sortedSets.GetViewBetween(user3, user4);// returneaza o lista in care ai doar useri
                                                                                    //care sunt mai mari decat user3 si mai mici
                                                                                    //decat user4 sau EGALI, se ai dupa CompareTo


            

            var reverse = sortedSets.Reverse();//imi returneaza intr-o variabila lista rasturnata
            foreach (var item in reverse)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(sortedSets.SetEquals(badUsers));// returneaza true daca amandoua sortedSets eu aceeasi useri

            sortedSets.UnionWith(sortedBetween);//insereaza toti useri din sortedBetween in sortedStes,
                                                //cei care nu sunt in deja in sortedSets

            
        }

    }
}
