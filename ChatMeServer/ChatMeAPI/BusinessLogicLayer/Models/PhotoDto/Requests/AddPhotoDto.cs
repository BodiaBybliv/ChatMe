using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Models.PhotoDto.Requests
{
    public class AddPhotoDto
    {
        public int UserId { get; set; }

        [Required]
        public int ConversationId { get; set; }

        [Required]
        public IFormFile UploadedFile { get; set; }
    }
}
