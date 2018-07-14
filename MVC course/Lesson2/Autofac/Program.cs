using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle;

namespace Autofac {
	class Program {
		static void Main(string[] args) {
			var builder = new ContainerBuilder();
			builder.RegisterType<Bazooka>().As<IWeapon>();
			builder.RegisterType<Warrior>();
			builder.Register(x => x.Resolve<Bazooka>());

			var container = builder.Build();

			var warrior = container.Resolve<Warrior>();
			warrior.Kill();

			Console.ReadLine();
		}
	}
}
