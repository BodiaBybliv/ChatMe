using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Models.PhotoDto.Requests
{
    public class GetPhotoDtoRequest
    {
        [Required]
        public int id { get; set; }
    }
}
