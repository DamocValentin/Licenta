﻿using Data.Core.Domain;
using Data.Core.Interfaces;
using Data.Persistance;

namespace Business.Repository
{
    public class ActivityRepository : GenericRepository<Activity>, IActivityRepository
    {
        public ActivityRepository(DatabaseContext context) : base(context)
        {
        }

        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }
    }
}