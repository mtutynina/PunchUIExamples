// -----------------------------------------------------------------------
// <copyright file="PunchManager.cs" company="Mariya Tutynina">
// Copyright (c) Mariya Tutynina. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace PunchUIExamples
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
    using PunchUIExamples.Models;

    /// <summary>
    /// Data access manager.
    /// </summary>
    public class PunchManager
    {
        /// <summary>
        /// Get persons list by filter criteria.
        /// </summary>
        /// <param name="currentPage">Current page number.</param>
        /// <param name="pageSize">Page size.</param>
        /// <returns>Person data list.</returns>
        public (IList<Person> persons, int total) GetPersons(int currentPage, int pageSize)
        {
            var persons = GetPersonsTestData();
            var skip = (currentPage - 1) * pageSize;
            var filtered = persons.Skip(skip).Take(pageSize);
            return (filtered.ToList(), persons.Count);
        }

        private static IList<Person> GetPersonsTestData()
        {
            using StreamReader r = new StreamReader("Data/persons.json");
            var json = r.ReadToEnd();
            var persons = JsonConvert.DeserializeObject<Person[]>(json);
            if (persons == null)
            {
                return Array.Empty<Person>().ToList();
            }

            return persons;
        }
    }
}
