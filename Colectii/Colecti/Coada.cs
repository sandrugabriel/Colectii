using Colectii.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.Colecti
{
    public class Coada
    {

        public void functii()
        {

            User user1 = new User(1, "Adi", 15);
            User user2 = new User(2, "Alex", 20);
            User user3 = new User(3, "Ana", 14);
            User user4 = new User(4, "Sergiu", 18);
            User user5 = new User(5, "Rares", 20);
            User user6 = new User(6, "Ioana", 16);

            Queue<User> queue = new Queue<User>();

            queue.Enqueue(user1); // adauga user1 in coada
            queue.Enqueue(user2);   
            queue.Enqueue(user3);
            queue.Enqueue(user4);
            queue.Enqueue(user5);
            queue.Enqueue(user6);

            queue.Dequeue(); //sterge din coada primul element care a fost adaugat, adica user1

            queue.Contains(user1);//daca este un element egal cu user1

            Console.WriteLine(queue.Peek());//returneaza primul element fara sa l stearga

            queue.Clear();//golseste coada

            User[] array = new User[100];
            array = queue.ToArray();// copiaza coada intr-un vector

            queue.CopyTo(array,4);//insereaza in array primele 4 elemente
        }

    }
}
