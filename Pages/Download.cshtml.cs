using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class DownloadModel : PageModel
{
    private readonly ILogger<DownloadModel> _logger;

    public DownloadModel(ILogger<DownloadModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

