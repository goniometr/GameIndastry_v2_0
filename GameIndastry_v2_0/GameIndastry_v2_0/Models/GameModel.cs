using System;
using System.Security.Cryptography.X509Certificates;

namespace GameIndastry_v2_0.Models
{
	public class GameModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Genre { get; set; }
		public DateTime ReleaseDate { get; set; }

		public string Img { get; set; }
	}
}
