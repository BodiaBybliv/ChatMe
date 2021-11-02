using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using BusinessLogicLayer.Models.PhotoDto;


namespace BusinessLogicLayer.IServices.IHelpers
{
    public interface IPhotoHelper
    {
        Task<string> SavePhotoAsync(IFormFile uploadedFile);

        Task<string> SavePhotoFromUriAsync(string uri);

        Task DeletePhotoAsync(string photo);
    }
}
