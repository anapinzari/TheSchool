using TheSchool.Models;
using System;
using System.Collections.Generic;

namespace TheSchool
{
    class Program
    {
        static void Main(string[] args)
		{
			var cars = new List<Car>();
			cars.Add(new Car());
			cars.Add(new Car());
			cars.Add(new Car());



			var carShop = new Shop<Car, object, object>();
			carShop.AddItem(new Car());
			carShop.AddItem(new Car());
			carShop.AddItem(new Car());
			var car = carShop.BuyItem();
			car = carShop.BuyItem();
			car = carShop.BuyItem();

			var toyShop = new Shop<Toy, object, object>();
			toyShop.AddItem(new Toy(1));
			toyShop.AddItem(new Toy(1));
			toyShop.AddItem(new Toy(1));
			var toy = toyShop.BuyItem();
			toy = toyShop.BuyItem();
			toy = toyShop.BuyItem();

			var obj = new Classs();
			var result = obj.MehtodName<int, string, Car>(5, "string");
			obj.MehtodName<bool, double, Car>(true, 6d);

			Console.ReadKey();
		}
	}

	class Classs
	{
		public TReturn MehtodName<TParam1, TParam2, TReturn>(TParam1 param1, TParam2 param2)
			where TReturn: new()
		{
			return new TReturn();
		}
	}

	class Shop<TItem1, TItem2, TItem3>
		where TItem1: class, TItem2
		where TItem2: class, new()
	{
		private List<TItem1> Items { get; set; } = new List<TItem1>();

		public void AddItem(TItem1 item)
		{
			Items.Add(item);
		}

		public TItem1 BuyItem()
		{
			var item = Items[Items.Count - 1];
			Items.Remove(item);
			return item;
		}
	}

	class Car { }
	class Toy { public Toy(int x) { } }

	class CarShop
	{
		private Car[] Items { get; set; } = new Car[1000];
		private int CurrentIndex { get; set; } = 0;

		public void AddItem(Car item)
		{
			Items[CurrentIndex] = item;
			CurrentIndex++;
		}

		public Car BuyItem()
		{
			CurrentIndex--;
			var item = Items[CurrentIndex];
			Items[CurrentIndex] = null;
			return item;
		}
	}

	class ToyShop
	{
		private Toy[] Items { get; set; } = new Toy[1000];
		private int CurrentIndex { get; set; } = 0;

		public void AddItem(Toy item)
		{
			Items[CurrentIndex] = item;
			CurrentIndex++;
		}

		public Toy BuyItem()
		{
			CurrentIndex--;
			var item = Items[CurrentIndex];
			Items[CurrentIndex] = null;
			return item;
		}
	}
}
    