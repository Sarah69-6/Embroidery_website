using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Embroidery_website.Models
{
	public class Photo
	{
		private string folder;

		public string Path { get; set; }

		public string Description { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Photos" /> class.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="description">The description.</param>
		public Photo(string path, string description)
		{
			Path = path;
			Description = description;
		}

		public Photo(string folder)
		{
			this.folder = folder;
		}
	}
}