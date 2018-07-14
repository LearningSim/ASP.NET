using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle;
using CommonServiceLocator;
using Unity.ServiceLocation;

namespace Unity {
	class Program {
		static void Main(string[] args) {
			var container = new WeaponContainer();

			var warrior = container.Resolve<Warrior>();
			warrior.Kill();

			var serviceProvider = new UnityServiceLocator(container);
			ServiceLocator.SetLocatorProvider(() => serviceProvider);
			var warrior2 = new SecondWarrior();
			warrior2.Kill();

			Console.ReadLine();
		}
	}
}
