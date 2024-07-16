using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class Board
    {
        [Key]
        public int Id { get; set; } // PK

        [Required]
        [MaxLength(50)] // NVARCHAR(50) 사이즈 지정을 하려면...
        public string Name { get; set; } // 작성자명

        [MaxLength(20)]
        public string UserId{ get; set; } // 작성자 아이디

        [Required]
        [MaxLength(250)]
        public string Title{ get; set; } // 게시글 제목

        public string Contents{ get; set; } // 게시글 내용

        public int Hit{ get; set; } // 읽은 횟수

        public DateTime RegDate { get; set; } = DateTime.Now; // 게시글 작성일자

        public DateTime ModDate{ get; set; } // 게시글 최종 수정일자
    }
}
