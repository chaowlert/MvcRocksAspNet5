using System.Linq;
using Microsoft.AspNet.Mvc;
using DevRock01.Services;

namespace DevRock01.Controllers
{
    public class HomeController
    {
		[Activate]
		protected ICalculator Calc { get; set; }

		public int Add(int a, int b) => Calc.Add(a, b);

        public IActionResult Index()
        {
			return new ViewResult();
        }

		public IActionResult Contact() => new ViewResult();
    }
}