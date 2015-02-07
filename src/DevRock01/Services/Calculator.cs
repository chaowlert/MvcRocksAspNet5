using Microsoft.Framework.OptionsModel;
using System;

namespace DevRock01.Services
{
	public interface ICalculator
	{
		int Add(int a, int b);
	}
    public class Calculator : ICalculator
    {
		private CalcOptions options;

		public Calculator(IOptions<CalcOptions> options)
		{
			this.options = options.Options;
		}

		public int Add(int a, int b) => (a + b) * options.Multiplier + options.Addition;
    }
}