using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle {
	class Program {
		static void Main(string[] args) {
			var warrior = new Warrior(new Bazooka());
			warrior.Kill();

			Console.ReadLine();
		}
	}
}
