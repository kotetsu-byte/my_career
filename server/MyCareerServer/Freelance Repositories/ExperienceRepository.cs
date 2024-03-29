﻿using Microsoft.EntityFrameworkCore;
using MyCareerServer.Data;
using MyCareerServer.Freelance_Interfaces;
using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Freelance_Repositories
{
    public class ExperienceRepository : IExperienceRepository
    {
        private readonly ResumeDBContext _dbContext;

        public ExperienceRepository(ResumeDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<IEnumerable<Experience>> GetExperiences(int id)
        {
            return await _dbContext.Experiences.Where(e => e.ResumeId == id).ToListAsync();
        }

        public bool Create(Experience experience)
        {
            _dbContext.Experiences.Add(experience);

            return Save();
        }

        public bool Update(Experience experience)
        {
            _dbContext.Experiences.Update(experience);

            return Save();
        }

        public bool Delete(int id)
        {
            var experience = _dbContext.Experiences.Where(e => e.Id == id).FirstOrDefault();
            _dbContext.Experiences.Remove(experience);

            return Save();
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();

            return saved > 0 ? true : false;
        }
    }
}
