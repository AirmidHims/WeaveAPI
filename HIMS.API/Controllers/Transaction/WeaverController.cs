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
        public readonly I_INVLoommaster _INVLoommaster;
        public readonly I_INVQualitymaster _INVQualitymaster;
        public readonly I_INVLocationmaster _INVLocationmaster;
        public readonly I_INVAddlessmaster _INVAddlessmaster;


        public WeaverController(I_YarnMaster yarnMaster,I_Shademaster shademaster,I_MillMaster millMaster,I_WeaveItemmaster weaveItemmaster,
               I_INVAddlessmaster iNVAddlessmaster, I_INVLocationmaster iNVLocationmaster, I_INVLoommaster iNVLoommaster, I_INVQualitymaster iNVQualitymaster)
            {
                this._YarnMaster = yarnMaster;
                this._Shademaster = shademaster;
                  this._MillMaster = millMaster;
                  this._WeaveItemmaster = weaveItemmaster;
            this._INVLocationmaster = iNVLocationmaster;
            this._INVAddlessmaster = iNVAddlessmaster;
            this._INVLoommaster = iNVLoommaster;
            this._INVQualitymaster = iNVQualitymaster;

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
        //New INVQuality

        [HttpPost("NewQualityInsert")]
        public IActionResult NewQualityInsert(INVQualitymasterparam INVQualitymasterparam)
        {
            var ID = _INVQualitymaster.Insert(INVQualitymasterparam);
            return Ok(ID);
        }

        //New INVQuality

        [HttpPost("NewQualityUpdate")]
        public IActionResult NewQualityUpdate(INVQualitymasterparam INVQualitymasterparam)
        {
            var ID = _INVQualitymaster.Update(INVQualitymasterparam);
            return Ok(ID);
        }


        //New Location

        [HttpPost("NewLocationInsert")]
        public IActionResult NewLocationInsert(INVLocationmasterparam INVLocationmasterparam)
        {
            var ID = _INVLocationmaster.Insert(INVLocationmasterparam);
            return Ok(ID);
        }

        //New Location

        [HttpPost("NewLocationUpdate")]
        public IActionResult NewLocationUpdate(INVLocationmasterparam INVLocationmasterparam)
        {
            var ItemID = _INVLocationmaster.Update(INVLocationmasterparam);
            return Ok(ItemID);
        }


        //New Loom

        [HttpPost("NewLoomInsert")]
        public IActionResult NewLoomInsert(INVLoommasterparam INVLoommasterparam)
        {
            var ID = _INVLoommaster.Insert(INVLoommasterparam);
            return Ok(ID);
        }

        //New Location

        [HttpPost("NewLoomUpdate")]
        public IActionResult NewLoomUpdate(INVLoommasterparam INVLoommasterparam)
        {
            var ItemID = _INVLoommaster.Update(INVLoommasterparam);
            return Ok(ItemID);
        }


        //New Addless

        [HttpPost("NewAddlessInsert")]
        public IActionResult NewAddlessInsert(INVAddlessmasterparam INVAddlessmasterparam)
        {
            var ID = _INVAddlessmaster.Insert(INVAddlessmasterparam);
            return Ok(ID);
        }

        //New Location

        [HttpPost("NewAddlessUpdate")]
        public IActionResult NewLocationUpdate(INVAddlessmasterparam INVAddlessmasterparam)
        {
            var ItemID = _INVAddlessmaster.Update(INVAddlessmasterparam);
            return Ok(ItemID);
        }

    }
    }
