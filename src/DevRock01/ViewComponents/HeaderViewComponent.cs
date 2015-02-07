using Microsoft.AspNet.Mvc;
using System;

namespace DevRock01.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
		public IViewComponentResult Invoke(int level, string content)
		{
			if (level == 1)
			{
				return View("h1", content);
			}
			else
			{
				return View("h2", content);
			}
		}

	}
}