using AutoMapper;
using ProcessStep_Demo2.Models;
using ProcessStep_Demo2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessStep_Demo2.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<ProcessStep,ProcessStepVM>();
            CreateMap<ProcessStep, ProcessStepVM>();
        }
    }
}
