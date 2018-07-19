using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JunBoard.Models
{
	public class Board
	{
		[Key]
		public int Board_Num { get; set; }
		[DisplayName("제목")]
		public string Title { get; set; }
		[DisplayName("작성자")]
		public string Writer { get; set; }
		
		[DisplayName("내용")]
		public string Content { get; set; }
	}
}