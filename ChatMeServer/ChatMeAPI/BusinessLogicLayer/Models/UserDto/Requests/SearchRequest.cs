using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Models.UserDto.Requests
{
    public class SearchRequest
    {
        [Required]
        public string Filter { get; set; }

        public int UserId { get; set; }
    }
}
