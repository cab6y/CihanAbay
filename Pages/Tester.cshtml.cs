using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.IO;

namespace CihanAbay.Pages
{
    public class TesterModel : PageModel
    {
        [BindProperty]
        public string result { get; set; } = "";
        public void OnGet(string? test)
        {
            result = test;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                string path = @"Ýndirilenler/testCihan";

                bool fileExist = System.IO.File.Exists(path);
                if (fileExist)
                {
                    return Redirect("/Tester?test=true");
                }
                else
                {
                    return Redirect("/Tester?test=false");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
