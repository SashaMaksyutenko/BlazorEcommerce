using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AdressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AdressController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<Address>>>GetAddress()
        {
            return await _addressService.GetAddress();  
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Address>>>AddOrUpdateAddress(Address address)
        {
            return await _addressService.AddOrUpdateAddress(address);
        }
    }
}
