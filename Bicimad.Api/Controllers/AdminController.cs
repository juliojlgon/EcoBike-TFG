﻿using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Http;
using Bicimad.Api.Attributes;
using Bicimad.Api.Models.Admin;
using Bicimad.Enums;
using Bicimad.Services.Command.Commands.MetaConfig;
using Bicimad.Services.Command.Interface;
using Bicimad.Services.Query.Interfaces;

namespace Bicimad.Api.Controllers
{
    [AdminAuthorize]
    public class AdminController : BaseController
    {
        private readonly IMetaConfigCommandService _metaConfigCommandService;
        private readonly IMetaConfigQueryService _metaconfigQueryService;
        private readonly IStationCommandService _stationCommandService;
        private readonly IStationQueryService _stationQueryService;

        public AdminController(IMetaConfigQueryService metaconfigQueryService,
            IMetaConfigCommandService metaConfigCommandService, IStationQueryService stationQueryService,
            IStationCommandService stationCommandService)
        {
            _metaconfigQueryService = metaconfigQueryService;
            _metaConfigCommandService = metaConfigCommandService;
            _stationQueryService = stationQueryService;
            _stationCommandService = stationCommandService;
        }

        /// <summary>
        /// Return a list with all data relative station admin.
        /// Admin required.
        /// </summary>
        /// <returns>Json of stations.</returns>
        public virtual IHttpActionResult GetAdminStationList()
        {
            var stations = _stationQueryService.GetStations().ToList();
            var metaBasePrice = _metaconfigQueryService.Get(MetaConfigKey.BasePrice).FirstOrDefault();
            var baseprice = metaBasePrice != null ? metaBasePrice.MetaValue : "5";


            var model = new AdminStationModel
            {
                BasePrice = double.Parse(baseprice, NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo),
                Stations = stations,
                TotalCount = stations.Count,
                DiscConst = "0",
                DiscPorc = "0",
                DiscountType = DiscountType.Constant
            };
            return Ok(model);
        }

        /// <summary>
        /// Change the base price that rest of application use
        /// for calculate the price-
        /// </summary>
        /// <param name="basePrice"></param>
        /// <returns>Ok if everything is correct otherwise BadRequest</returns>
        public virtual IHttpActionResult SetBasePrice(double? basePrice)
        {
            if (!basePrice.HasValue)
                basePrice = 5;

            var command = new CreateMetaConfigCommand
            {
                MetaKey = MetaConfigKey.BasePrice,
                DeleteExistentKeys = true,
                MetaValue = basePrice.Value.ToString(CultureInfo.InvariantCulture)
            };

            var result = _metaConfigCommandService.Create(command);

            if (result.Success)
            {
                return Ok("Base Price Changed");
            }
            return BadRequest(result.FirstErrorMessage);
        }

        /// <summary>
        /// Change the discount type and or the discount values of selected stations.
        /// </summary>
        /// <param name="stationIds">List of stationId's</param>
        /// <param name="discountType">0 for constant value. 1 for percent</param>
        /// <param name="discConst">Decimal value</param>
        /// <param name="discPorc">value between 0 and 1</param>
        /// <returns></returns>
        [HttpPost]
        public virtual IHttpActionResult SetDiscounts(List<string> stationIds, DiscountType discountType,
            string discConst,
            string discPorc)
        {
            if (discConst == null) discConst = "0";
            if (discPorc == null) discPorc = "0";
            var c = double.Parse(discConst, NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
            var p = double.Parse(discPorc, NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);

            var result = _stationCommandService.SetDiscounts(stationIds, discountType, c, p);

            if (result.Success)
            {
                return Ok("Stations Updated");
            }

            return BadRequest(result.FirstErrorMessage);
        }
    }
}