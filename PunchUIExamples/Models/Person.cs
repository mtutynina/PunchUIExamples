// -----------------------------------------------------------------------
// <copyright file="Person.cs" company="Mariya Tutynina">
// Copyright (c) Mariya Tutynina. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace PunchUIExamples.Models
{
    /// <summary>
    /// Single person informatiom.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="firstName">Person first name.</param>
        /// <param name="lastName">Person last name.</param>
        /// <param name="company">Company name where pwerson works.</param>
        /// <param name="address">Person living address.</param>
        /// <param name="salary">Person salary.</param>
        /// <param name="email">Person email.</param>
        public Person(string firstName, string lastName, string company, string address, int salary, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Company = company;
            this.Address = address;
            this.Salary = salary;
            this.Email = email;
        }

        /// <summary>
        /// Gets or sets peson first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets person last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets company name where pwerson works.
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Gets or sets person living address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets person's salary.
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// Gets or sets person e-mail.
        /// </summary>
        public string Email { get; set; }
    }
}
