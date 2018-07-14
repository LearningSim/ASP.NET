using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle;

namespace Ninject {
	class Program {
		public static IKernel AppKernel;
		static void Main(string[] args) {
			AppKernel = new StandardKernel(new WeaponInjectModule());

			var warrior = AppKernel.Get<Warrior>();
			warrior.Kill();

			var warrior2 = new SecondWarrior();
			warrior2.Kill();

			var warrior3 = AppKernel.Get<ThirdWarrior>();
			warrior3.Kill();

			Console.ReadLine();
		}
	}
}
