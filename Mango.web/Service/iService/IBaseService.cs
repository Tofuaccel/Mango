using Mango.Services.CouponAPI.Models.Dto;
using Mango.web.Models;

namespace Mango.web.Service.iService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
