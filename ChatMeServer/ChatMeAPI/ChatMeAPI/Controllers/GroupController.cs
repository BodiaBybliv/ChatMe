using Application.Models.ConversationDto.Requests;
using BusinessLogicLayer.IServices;
using InfrastructureLayer.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class GroupController : ControllerBase
    {
        private IGroupService _conversationService;

        public GroupController(IGroupService conversationService)
        {
            _conversationService = conversationService;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewGroupMember([FromBody] AddConversationMemberRequest request)
        {
            request.UserId = HttpContext.GetUserId();

            await this._conversationService.AddConversationMemberAsync(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> LeaveGroup([FromBody] LeaveGroupRequest request)
        {
            request.UserId = HttpContext.GetUserId();

            await this._conversationService.LeaveGroupAsync(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateGroup([FromBody] AddGroupRequest request)
        {
            request.UserId = HttpContext.GetUserId();

            await _conversationService.CreateGroupAsync(request);

            return Ok();
        }
    }
}
