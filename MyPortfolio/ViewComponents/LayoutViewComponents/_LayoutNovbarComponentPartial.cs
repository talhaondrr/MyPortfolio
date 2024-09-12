using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context; 

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNovbarComponentPartial: ViewComponent 
	{
        MyPortfolioContex contex = new MyPortfolioContex();
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
