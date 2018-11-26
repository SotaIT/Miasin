using System;

namespace Miasin.Services.Domain
{
    /*
     * 1. Author nickname is the Id used everywhere
     * 2. A User can have more than one author
     */
    /// <summary>
    /// Author
    /// </summary>
    public class Author: BaseEntity<string>
    {
        /// <summary>
        /// User.Identity.Name
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Created datetime
        /// </summary>
        public DateTimeOffset? Created { get; set; }
    }
}