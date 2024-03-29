﻿using HIMS.Data.Weaver;
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
        public readonly I_INVTransportMaster _INVTransportMaster;
        public readonly I_INVDefectMaster _INVDefectMaster;
        public readonly I_INVBeamMaster _INVBeamMaster;
        public readonly I_LoomTypemaster _LoomTypemaster;
        public readonly I_RollTypemaster _RollTypemaster;
        public readonly I_PartyAccount _PartyAccount;
        public readonly I_ContractBooking _ContractBooking;
        public readonly I_DdesignMaster _DdesignMaster;
        public readonly I_YarnInward _YarnInward;
        public readonly I_Yarnoutwards _Yarnoutwards;
        public readonly I_BeamInward _BeamInward;
        public WeaverController(I_YarnMaster yarnMaster,I_Shademaster shademaster,I_MillMaster millMaster,I_WeaveItemmaster weaveItemmaster,
               I_INVAddlessmaster iNVAddlessmaster, I_INVLocationmaster iNVLocationmaster, I_INVLoommaster iNVLoommaster, I_INVQualitymaster iNVQualitymaster,
               I_INVBeamMaster beamMaster, I_INVDefectMaster defectMaster, I_INVTransportMaster transportMaster,I_RollTypemaster rollTypemaster,I_LoomTypemaster loomTypemaster,
               I_PartyAccount partyAccount,I_ContractBooking contractBooking, I_DdesignMaster ddesignMaster,I_YarnInward yarnInward,I_BeamInward beamInward
            ,I_Yarnoutwards  yarnoutwards)
            {
                this._YarnMaster = yarnMaster;
                this._Shademaster = shademaster;
                this._MillMaster = millMaster;
                this._WeaveItemmaster = weaveItemmaster;
                this._INVLocationmaster = iNVLocationmaster;
                this._INVAddlessmaster = iNVAddlessmaster;
                this._INVLoommaster = iNVLoommaster;
                this._INVQualitymaster = iNVQualitymaster;
                this._INVDefectMaster = defectMaster;
                this._INVTransportMaster = transportMaster;
                this._INVBeamMaster = beamMaster;
                this._RollTypemaster = rollTypemaster;
                this._LoomTypemaster = loomTypemaster;
            this._PartyAccount = partyAccount;
            this._ContractBooking = contractBooking;
            this._DdesignMaster = ddesignMaster;
            this._YarnInward = yarnInward;
            this._Yarnoutwards = yarnoutwards;
            this._BeamInward = beamInward;
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

        //New Beam

        [HttpPost("NewBeamInsert")]
        public IActionResult NewBeamInsert(INVBeamMasterparam INVBeamMasterparam)
        {
            var ID = _INVBeamMaster.Insert(INVBeamMasterparam);
            return Ok(ID);
        }

        //Update Beam

        [HttpPost("BeamUpdate")]
        public IActionResult BeamUpdate(INVBeamMasterparam INVBeamMasterparam)
        {
            var ItemID = _INVBeamMaster.Update(INVBeamMasterparam);
            return Ok(ItemID);
        }

        //New Defect

        [HttpPost("NewDefectInsert")]
        public IActionResult NewDefectInsert(INVDefectMasterparam INVDefectMasterparam)
        {
            var ID = _INVDefectMaster.Insert(INVDefectMasterparam);
            return Ok(ID);
        }

        //Update Defect

        [HttpPost("DefectUpdate")]
        public IActionResult DefectUpdate(INVDefectMasterparam INVDefectMasterparam)
        {
            var ItemID = _INVDefectMaster.Update(INVDefectMasterparam);
            return Ok(ItemID);
        }


        //New Transport

        [HttpPost("NewTransportInsert")]
        public IActionResult NewTransportInsert(INVTransportMasterparam INVTransportMasterparam)
        {
            var ID = _INVTransportMaster.Insert(INVTransportMasterparam);
            return Ok(ID);
        }

        //Update Transport

        [HttpPost("TransportUpdate")]
        public IActionResult TransportUpdate(INVTransportMasterparam INVTransportMasterparam)
        {
            var ItemID = _INVTransportMaster.Update(INVTransportMasterparam);
            return Ok(ItemID);
        }

        //New LoomType

        [HttpPost("NewLoomTypeInsert")]
        public IActionResult NewLoomTypeInsert(LoomTypemasterparam LoomTypemasterparam)
        {
            var ID = _LoomTypemaster.Insert(LoomTypemasterparam);
            return Ok(ID);
        }

        //Update Transport

        [HttpPost("LoomTypeUpdate")]
        public IActionResult LoomTypeUpdate(LoomTypemasterparam LoomTypemasterparam)
        {
            var ItemID = _LoomTypemaster.Update(LoomTypemasterparam);
            return Ok(ItemID);
        }

        //New RollType

        [HttpPost("NewRollTypeInsert")]
        public IActionResult NewRollTypeInsert(Rolltypemasterparam Rolltypemasterparam)
        {
            var ID = _RollTypemaster.Insert(Rolltypemasterparam);
            return Ok(ID);
        }

        //Update RollType

        [HttpPost("RollTypeUpdate")]
        public IActionResult RollTypeUpdate(Rolltypemasterparam Rolltypemasterparam)
        {
            var ItemID = _RollTypemaster.Update(Rolltypemasterparam);
            return Ok(ItemID);
        }

        //New Account

        [HttpPost("NewAccountInsert")]
        public IActionResult NewAccountInsert(PartyAccountParam PartyAccountParam)
        {
            var ID = _PartyAccount.Insert(PartyAccountParam);
            return Ok(ID);
        }

        //Update Account

        [HttpPost("AccountUpdate")]
        public IActionResult AccountUpdate(PartyAccountParam PartyAccountParam)
        {
            var ItemID = _PartyAccount.Update(PartyAccountParam);
            return Ok(ItemID);
        }

        //New ContractBooking

        [HttpPost("NewContractInsert")]
        public IActionResult NewContractInsert(ContractBookingparam ContractBookingparam)
        {
            var ID = _ContractBooking.Insert(ContractBookingparam);
            return Ok(ID);
        }

        //Update Account

        [HttpPost("ContractInsertUpdate")]
        public IActionResult ContractInsertUpdate(ContractBookingparam ContractBookingparam)
        {
            var ItemID = _ContractBooking.Update(ContractBookingparam);
            return Ok(ItemID);
        }

        //New Design

        [HttpPost("NewDesignInsert")]
        public IActionResult NewDesignInsert(DesignMasterParam DesignMasterParam)
        {
            var ID = _DdesignMaster.Insert(DesignMasterParam);
            return Ok(ID);
        }

        //Update Design

        [HttpPost("DesignUpdate")]
        public IActionResult DesignUpdate(DesignMasterParam DesignMasterParam)
        {
            var ItemID = _DdesignMaster.Update(DesignMasterParam);
            return Ok(ItemID);
        }

        //New YarnInward

        [HttpPost("NewYarnInwardInsert")]
        public IActionResult NewYarnInwardInsert(YarnInwardparam YarnInwardparam)
        {
            var ID = _YarnInward.Insert(YarnInwardparam);
            return Ok(ID);
        }

        //Update YarnInward

        [HttpPost("YarnInwardUpdate")]
        public IActionResult YarnInwardUpdate(YarnInwardparam YarnInwardparam)
        {
            var ItemID = _YarnInward.Update(YarnInwardparam);
            return Ok(ItemID);
        }

        //New YarnOutward

        [HttpPost("NewYarnOutwardInsert")]
        public IActionResult NewYarnOutwardInsert(YarnOutwardparam YarnOutwardparam)
        {
            var ID = _Yarnoutwards.Insert(YarnOutwardparam);
            return Ok(ID);
        }

        //Update YarnOutward

        [HttpPost("YarnOutwardUpdate")]
        public IActionResult YarnOutwardUpdate(YarnOutwardparam YarnOutwardparam)
        {
            var ItemID = _Yarnoutwards.Update(YarnOutwardparam);
            return Ok(ItemID);
        }


        //New BeamInward

        [HttpPost("NewBeamInwardInsert")]
        public IActionResult NewBeamInwardInsert(BeamInwardparam BeamInwardparam)
        {
            var ID = _BeamInward.Insert(BeamInwardparam);
            return Ok(ID);
        }

        //Update BeamInward

        [HttpPost("BeamInwardUpdate")]
        public IActionResult BeamInwardUpdate(BeamInwardparam BeamInwardparam)
        {
            var ItemID = _BeamInward.Update(BeamInwardparam);
            return Ok(ItemID);
        }
    }
    }
