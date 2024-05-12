using APBD_Task_6.Models;
using Microsoft.AspNetCore.Mvc;
using Zadanie5.Services;

namespace Zadanie5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehousesController : ControllerBase
    {
        private readonly IWarehouseService _warehouseService;

        public WarehousesController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct(ProductWarehouse product)
        {
            int idProductWarehouse = await _warehouseService.AddProduct(product);
            return Ok();
        }
    }
}
