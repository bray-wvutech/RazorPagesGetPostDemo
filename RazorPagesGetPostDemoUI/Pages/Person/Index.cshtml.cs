using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesGetPostDemoUI.Models;

namespace RazorPagesGetPostDemoUI.Pages.Person
{
    public class IndexModel : PageModel
    {
        private ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public PersonInfo CurrentPerson { get; set; } = new();

        public void OnGet()
        {
            _logger.LogInformation("Index OnGet called");
        }

        public void OnPost()
        {
            _logger.LogInformation("Index OnPost called");
        }
    }
}
