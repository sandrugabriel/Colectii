using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.Models
{
    public class Car
    {

        private int _id;
        private string _marca;
        private string _model;
        private int _year;

        public Car(int id, string marca, string model, int year)
        {
            _id = id;
            _marca = marca;
            _model = model;
            _year = year;
        }

        public int Id { get => _id; set => _id = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }

        public string descriere()
        {
            string t = "";

            t += $"Id: {Id}";
            t += $"Marca: {Marca}";
            t += $"Model: {Model}";
            t += $"Year: {Year}";

            return t;
        }

    }
}
