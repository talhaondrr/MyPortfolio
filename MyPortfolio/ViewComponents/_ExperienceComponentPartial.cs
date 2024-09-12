using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext context =new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Experiences.ToList();
            return View(value);
        }

    }
}
