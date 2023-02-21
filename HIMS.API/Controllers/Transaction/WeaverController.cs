using HIMS.Data.Weaver;
using HIMS.Model.Weaverparam;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HIMS.API.Controllers.Transaction
{


    [ApiController]
    [Route("api/[controller]")]
    
        public class WeaverController : Controller
        {
            public readonly I_YarnMaster _YarnMaster;
             public readonly I_Shademaster _Shademaster;
              public readonly I_MillMaster _MillMaster;
        public readonly I_WeaveItemmaster _WeaveItemmaster;


            public WeaverController(I_YarnMaster yarnMaster,I_Shademaster shademaster,I_MillMaster millMaster,I_WeaveItemmaster weaveItemmaster)
            {
                this._YarnMaster = yarnMaster;
                this._Shademaster = shademaster;
                  this._MillMaster = millMaster;
                  this._WeaveItemmaster = weaveItemmaster;

            }

            //New YarnInsert

            [HttpPost("NewYarnInsert")]
            public IActionResult NewAdmissionSave(Yarnmasterparam Yarnmasterparam)
            {
                var yid = _YarnMaster.Insert(Yarnmasterparam);
                return Ok(yid);
            }

        //New YarnUpdate

        [HttpPost("YarnUpdate")]
        public IActionResult YarnUpdate(Yarnmasterparam Yarnmasterparam)
        {
            var yid = _YarnMaster.Update(Yarnmasterparam);
            return Ok(yid);
        }

        //New ShadeInsert

        [HttpPost("NewShadeInsert")]
        public IActionResult NewShadeInsert(Shademasterparam Shademasterparam)
        {
            var shadeID = _Shademaster.Insert(Shademasterparam);
            return Ok(shadeID);
        }

        //New YarnUpdate

        [HttpPost("ShadeUpdate")]
        public IActionResult YarnUpdate(Shademasterparam Shademasterparam)
        {
            var shadeID = _Shademaster.Update(Shademasterparam);
            return Ok(shadeID);
        }

        //New MillInsert

        [HttpPost("NewMillInsert")]
        public IActionResult NewMillInsert(Millmasterparam Millmasterparam)
        {
            var MillID = _MillMaster.Insert(Millmasterparam);
            return Ok(MillID);
        }

        //New YarnUpdate

        [HttpPost("MillUpdate")]
        public IActionResult YarnUpdate(Millmasterparam Millmasterparam)
        {
            var MillID = _MillMaster.Update(Millmasterparam);
            return Ok(MillID);
        }

        //New ItemInsert

        [HttpPost("NewItemInsert")]
        public IActionResult NewItemInsert(ItemMasterparam ItemMasterparam)
        {
            var ItemID = _WeaveItemmaster.Insert(ItemMasterparam);
            return Ok(ItemID);
        }

        //New YarnUpdate

        [HttpPost("ItemUpdate")]
        public IActionResult ItemUpdate(ItemMasterparam ItemMasterparam)
        {
            var ItemID = _WeaveItemmaster.Update(ItemMasterparam);
            return Ok(ItemID);
        }

    }
    }
