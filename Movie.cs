using System;

namespace GetterSetter.Movie
{
	class Movie
	{
		public string title{ get; set; }
		public string author{ get; set; }
		public string version{ get; set; }
		
		public Movie(string aTitle, string aAuthor, string aVersion)
		{
			title = aTitle;
			author = aAuthor;
            version = aVersion;
        }
	}
}