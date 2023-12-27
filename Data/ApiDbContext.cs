﻿using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}