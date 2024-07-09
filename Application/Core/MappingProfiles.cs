using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<ActivityRequestDTO, ActivityRequestDTO>();
            //TOdo:這裡 是暫時用 requestDTO  實際上 是應該 CreateMap<ActivityRequestDTO, ActivityResponseDTO>();
        }

    }
}