using Application.Models.ChatDto.Requests;
using Application.Models.ChatDto.Responces;
using Application.Models.ConversationDto.Requests;
using Application.Models.ConversationDto.Responces;
using BusinessLogicLayer.Models.PhotoDto.Requests;
using BusinessLogicLayer.Models.UserDto.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BusinessLogicLayer.IServices
{
    public interface IConversationService
    {
        Task CreateChatAsync(AddConversationRequest request);

        Task<List<GetConversationDto>> GetConversationsAsync(GetChatsRequestDto request);

        Task ChangePhotoAsync(AddPhotoDto model);

        Task<List<SearchConversationResponce>> SearchConversation(SearchRequest request);

        Task DeleteConversationAsync(DeleteRequest request);
    }
}
