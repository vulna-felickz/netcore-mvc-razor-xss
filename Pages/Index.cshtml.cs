using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace netcore_mvc_razor_xss.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string sanitizedData { get; set; }
        public string unsanitizedData { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var data = Request.Query["data"];

            sanitizedData = System.Net.WebUtility.HtmlEncode(data);
            unsanitizedData = data;
        }
    }
}