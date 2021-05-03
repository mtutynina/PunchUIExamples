using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PunchUIExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PunchUIExamples.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PunchManager manager;

        public IndexModel(PunchManager manager)
        {
            this.manager = manager;
        }

        public IList<Person> Persons { get; private set; } = Array.Empty<Person>();

        public int Total { get; private set; } = 0;

        /// <summary>
        /// Gets or sets count of items to display on single page.
        /// </summary>
        [BindProperty(Name = "pageSize", SupportsGet = true)]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// Gets or sets count of pages to skip for sort column.
        /// </summary>
        [BindProperty(Name = "currentPage", SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;

        public void OnGet()
        {
            var data = this.manager.GetPersons(this.CurrentPage, this.PageSize);
            this.Persons = data.persons;
            this.Total = data.total;
        }
    }
}
