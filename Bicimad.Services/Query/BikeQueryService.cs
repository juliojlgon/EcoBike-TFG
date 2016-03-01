﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Bicimad.Core;
using Bicimad.Core.DomainObjects;
using Bicimad.Services.Query.Dto.Bike;
using Bicimad.Services.Query.Interfaces;

namespace Bicimad.Services.Query
{
    public class BikeQueryService: IBikeQueryService
    {

        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public BikeQueryService(IMapper mapper, IRepository repostory)
        {
            _mapper = mapper;
            _repository = repostory;
        }

        public List<BikeDto> GetBikes()
        {
            var bikes = _repository.Bikes.ToList();
            return bikes.Select(bike => _mapper.Map<Bike, BikeDto>(bike)).ToList();
        }

        public List<BikeDto> GetBikesByStationId(string id)
        {
            return _repository.Bikes.Where(b => b.StationId == id).Select(bike => _mapper.Map<Bike, BikeDto>(bike)).ToList();
        }

        public List<BikeDto> GetBikesByStationNameList(string name)
        {
            return _repository.Bikes.Where(b => b.Station.StationName == name).Select(bike => _mapper.Map<Bike, BikeDto>(bike)).ToList(); 
        }
    }
}
