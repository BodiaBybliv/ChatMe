using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Models.UserDto.Requests
{
    public class BlockUserRequest
    {
        [Required]
        public int UserIdToBlock { get; set; }

        public int UserId { get; set; }
    }
}
