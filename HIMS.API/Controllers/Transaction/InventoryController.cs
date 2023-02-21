using HIMS.Data.Inventory;
using HIMS.Model.Inventory;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HIMS.API.Controllers.Transaction
{
    [ApiController]
    [Route("api/[controller]")]

    public class InventoryController : Controller
    {

        public readonly I_Workorder _Worlorder;


        public InventoryController(I_Workorder workorder)
        {
            this._Worlorder = workorder;

        }

        //New Workorder

        [HttpPost("NewWorkorderInsert")]
        public IActionResult NewWorkorderInsert(Workorderparam Workorderparam)
        {
            var yid = _Worlorder.Insert(Workorderparam);
            return Ok(yid);
        }
    }
}