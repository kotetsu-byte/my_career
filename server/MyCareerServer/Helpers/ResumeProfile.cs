﻿using AutoMapper;
using MyCareerServer.CompanyModels;
using MyCareerServer.Dtos;
using MyCareerServer.FreelanceModels;
using MyCareerServer.User_Model;

namespace MyCareerServer.Helpers
{
    public class ResumeProfile : Profile
    {
        public ResumeProfile()
        {
            CreateMap<Resume, ResumeDto>();
            CreateMap<ResumeDto, Resume>();
            CreateMap<Language, LanguageDto>();
            CreateMap<LanguageDto, Language>();
            CreateMap<Education, EducationDto>();
            CreateMap<EducationDto,  Education>();
            CreateMap<Experience, ExperienceDto>();
            CreateMap<ExperienceDto, Experience>();
            CreateMap<CompanyResume, CompanyResumeDto>();
            CreateMap<CompanyResumeDto, CompanyResume>();
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
