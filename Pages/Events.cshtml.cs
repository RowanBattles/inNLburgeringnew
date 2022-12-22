using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class Eventmodel : PageModel
{
    private readonly ILogger<Eventmodel> _logger;

    public Eventmodel(ILogger<Eventmodel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
