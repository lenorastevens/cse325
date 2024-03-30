using MasteryProteinVendors.Models;
using MasteryProteinVendors.Services;
using Microsoft.AspNetCore.Mvc;

namespace MasteryProteinVendors.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendorsController : ControllerBase
    {
        private readonly VendorsService _vendorsService;

        public VendorsController(VendorsService vendorsService) => _vendorsService = vendorsService;

        [HttpGet]
        public async Task<List<Vendor>> Get() => await _vendorsService.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Vendor>> Get(string id)
        {
            var vendor = await _vendorsService.GetAsync(id);

            if (vendor is null)
            {
                return NotFound();
            }

            return vendor;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Vendor newVendor)
        {
            await _vendorsService.CreateAsync(newVendor);

            return CreatedAtAction(nameof(Get), new { id = newVendor.Id }, newVendor);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Vendor updatedVendor)
        {
            var vendor = await _vendorsService.GetAsync(id);

            if (vendor is null)
            {
                return NotFound();
            }

            updatedVendor.Id = vendor.Id;

            await _vendorsService.UpdateAsync(id, updatedVendor);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var vendor = await _vendorsService.GetAsync(id);

            if (vendor is null)
            {
                return NotFound();
            }

            await _vendorsService.RemoveAsync(id);

            return NoContent();
        }
    }
}
