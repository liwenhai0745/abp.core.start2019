using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abp.core.start2019.BookStore;
using abp.core.start2019.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace abp.core.start2019.Web.Pages.Books
{
    public class CreateModalModel : start2019PageModelBase
    {
        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }

        private readonly IBookAppService _bookAppService;

        public CreateModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.CreateAsync(Book);
            return NoContent();
        }
    }
}