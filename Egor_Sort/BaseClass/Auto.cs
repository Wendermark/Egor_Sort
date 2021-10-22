using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Sort.BaseClass
{
    class Auto : IComparable<Auto>
    {
        public string Carname { get; private set; }
        public int Maxspeed { get; private set; }
        public double Cost { get; private set; }
        public byte Discount { get; private set; }
        public int Id { get; private set; }

        public Auto() : this("Noname", 150, 100.0, 5, 1) { }
        public Auto(string CarName, int MaxSpeed, double cost, byte discount, int ID)
        {
            Carname = CarName;
            Maxspeed = MaxSpeed;
            Cost = cost;
            Discount = discount;
            Id = ID;
        }

        public override string ToString() => $"{Id}\tМарка: {Carname}\tМакс. скорость: {Maxspeed}\tЦена: {Cost:C}\tСкидка: {Discount}%";

        public int CompareTo(Auto auto) => Id > auto.Id ? 1 : Id < auto.Id ? -1 : 0;
    }
}
