using Application.Models.MessageDto;
using BusinessLogicLayer.Models.PhotoDto.Requests;
using BusinessLogicLayer.Models.UserDto.Requests;
using BusinessLogicLayer.Models.UserDto.Responces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IServices
{
    public interface IUserService
    {
        Task<GetUserDto> GetUserInfoAsync(GetUserInfoRequest request);

        Task UpdateUserAsync(UpdateUserDto model);

        Task<List<SearchUserDto>> SearchUserAsync(SearchRequest request);

        Task BlockUserAsync(BlockUserRequest request);

        Task UnBlockUserAsync(BlockUserRequest request);

        Task<bool> CheckStatusAsync(AddMessageDto request);

        Task ChangePhotoAsync(AddPhotoDto model);
    }
}
