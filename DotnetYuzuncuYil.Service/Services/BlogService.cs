﻿using DotnetYuzuncuYil.Core.Models;
using DotnetYuzuncuYil.Core.Repositories;
using DotnetYuzuncuYil.Core.Services;
using DotnetYuzuncuYil.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Service.Services
{
    public class BlogService : Service<Blog>, IBlogService
    {
        public BlogService(IGenericRepository<Blog> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
