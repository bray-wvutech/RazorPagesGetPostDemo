using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesGetPostDemoUI.Models;

namespace RazorPagesGetPostDemoUI.Pages.Person
{
    public class AddInfoModel : PageModel
    {
        private readonly ILogger<AddInfoModel> _logger;

        [BindProperty(SupportsGet = true)]
        public PersonInfo CurrentPerson { get; set; } = new();

        public AddInfoModel(ILogger<AddInfoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
            _logger.LogInformation("AddInfo OnGet called");
            _logger.LogInformation($"Name: {CurrentPerson.Name}");
            _logger.LogInformation($"Hometown: {CurrentPerson.Hometown}");
        }

        public IActionResult OnPost() 
        { 
            _logger.LogInformation("AddInfo OnPost called");
            _logger.LogInformation($"Name: {CurrentPerson.Name}");
            _logger.LogInformation($"Hometown: {CurrentPerson.Hometown}");

            if (ModelState.IsValid)
            {
                return RedirectToPage("./Index", CurrentPerson); 
            }
            else
            {
                return Page();
            }
        }
    }
}
