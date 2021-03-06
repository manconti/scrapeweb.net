﻿using System.Collections.Generic;
using System.Linq;

namespace ScrapeWeb.Models
{
    /// <summary>
    /// It represents the outcome that ScrapeWeb has generated.
    /// </summary>
    public class Outcome
    {
        /// <summary>
        /// Get the descriptive title of the extract, used in the CSV and Email for reference.
        /// </summary>
        public string Title
        {
            get;
            internal set;
        }
        /// <summary>
        /// Get the full URL of the page scraped.
        /// </summary>
        public string Url
        {
            get;
            internal set;
        }
        /// <summary>
        /// Get the value identifying if the searched keywords have been found; If the configuration does not select keywords the value is ignored.
        /// </summary>
        public bool KeywordsFound
        {
            get {
                return this.HighlightedOutputElements.Any();
            }
        }
        /// <summary>
        /// Get the collection of elements extracted by ScrapeWeb. This collection contains highlighted HTML elements and is used by ScrapeWeb for sending the email.
        /// </summary>
        public List<string> HighlightedOutputElements;
        /// <summary>
        /// Get the collection of elements extracted by ScrapeWeb. This collection is used as part of the CSV. 
        /// </summary>
        public List<string> TextOnlyOutputElements;

        public Outcome()
        {
            HighlightedOutputElements = new List<string>();
            TextOnlyOutputElements = new List<string>();

        }
    }
}
