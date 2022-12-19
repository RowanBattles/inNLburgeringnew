using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class OverOnsModel : PageModel
{
    private readonly ILogger<OverOnsModel> _logger;

    public OverOnsModel(ILogger<OverOnsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

