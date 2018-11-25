using System;

namespace Miasin.Services.Domain
{
    public class Author: BaseEntity<string>
    {
        /// <summary>
        /// User.Identity.Name
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Registered datetime
        /// </summary>
        public DateTimeOffset? Registered { get; set; }
    }
}