using Colectii.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.Colecti
{
    public class Stiva
    {
        public void functii()
        {

            User user1 = new User(1, "Adi", 15);
            User user2 = new User(2, "Alex", 20);
            User user3 = new User(3, "Ana", 14);
            User user4 = new User(4, "Sergiu", 18);
            User user5 = new User(5, "Rares", 20);
            User user6 = new User(6, "Ioana", 16);

            Stack<User> stack = new Stack<User>();

            stack.Push(user1);//adauga un stack
            stack.Push(user2);
            stack.Push(user3);
            stack.Push(user4);
            stack.Push(user5);
            stack.Push(user6);

            Console.WriteLine(stack.Pop());//returneaza ultimul element adaugat si il sterge

            Console.WriteLine(stack.Peek());//returneaza ultimul element fara sa l stearga

            Console.WriteLine(stack.Contains(user1));//verifica daca un element este egal cu user1

            User[] users = new User[10];
            stack.CopyTo(users, 3);//copiaza elemetele incepand de la 3 intrun array,adica users

            stack.Clear();//goleste stiva


        }


    }
}
