using Colectii.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.Colecti
{
    public class Lista
    {
        public void functii()
        {
            User user1 = new User(1, "Adi", 15);
            User user2 = new User(2, "Alex", 20);
            User user3 = new User(3, "Ana", 14);
            User user4 = new User(4, "Sergiu", 18);
            User user5 = new User(5, "Rares", 20);
            User user6 = new User(6, "Ioana", 16);

            //1.List
            List<User> users = new List<User>() { user1, user2 };
            List<User> users2 = new List<User>() { user3, user4 };

            users.AddRange(users2);//users = {user1, user2, user3, user4};

            users.Sort();//sorteaza lista crescator

            Console.WriteLine(users.Contains(user5));// daca contine acel item

            Console.WriteLine(users.Find(x => x.Age == 20) + "\n");//primul item care are age= 20

            users.Remove(user1);//sterge itemul user1 din lista, daca users[i].Id == user1.Id

            /*foreach (User user in users)
            {
                Console.WriteLine(user.descriere()+"\n");
            }*/

            users.RemoveAt(1);//sterge pozitia 1

            users.Reverse(); //inverseaza lista

            users.Add(user1);

            List<User> list = users.Slice(0, 3); // returneaza o lista incepand de la 0 cu dim 3, de la lista users

            foreach (User user in list)
            {
                Console.WriteLine(user.descriere() + "\n");
            }

            Console.WriteLine(users.TrueForAll(x => x.Age >= 12));//verifica daca toate elemintele indeplineste conditia

        }
       
    }
}
