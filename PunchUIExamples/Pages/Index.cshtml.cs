// -----------------------------------------------------------------------
// <copyright file="Index.cshtml.cs" company="Mariya Tutynina">
// Copyright (c) Mariya Tutynina. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace PunchUIExamples.Pages
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using PunchUIExamples.Models;

    /// <summary>
    /// Index page model.
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly PunchManager manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModel"/> class.
        /// </summary>
        /// <param name="manager">Data access manager.</param>
        public IndexModel(PunchManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// Gets list of persons to display.
        /// </summary>
        public IList<Person> Persons { get; private set; } = Array.Empty<Person>();

        /// <summary>
        /// Gets total count of persons.
        /// </summary>
        public int Total { get; private set; }

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

        /// <summary>
        /// Displays page when reciving GET response.
        /// </summary>
        public void OnGet()
        {
            var data = this.manager.GetPersons(this.CurrentPage, this.PageSize);
            this.Persons = data.persons;
            this.Total = data.total;
        }
    }
}
