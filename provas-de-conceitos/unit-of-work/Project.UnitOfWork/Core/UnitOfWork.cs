﻿using Project.UnitOfWorkProject.Core;
using Project.UnitOfWorkProjectProject.Entities;
using Project.UnitOfWorkProjectProject.Repositories;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Project.UnitOfWorkProjectProject.Core
{
    public class UnitOfWork : IUnitOfWorkContextAware
    {
        private bool _disposed;
        private readonly DbContext context;
        private readonly IResolver resolver;

        public UnitOfWork(DbContext context, IResolver resolver)
        {
            this.context = context;
            this.resolver = resolver;
        }

        public TRepository GetRepository<TRepository>() where TRepository : IRepository
        {
            return resolver.Resolve<TRepository>(typeof(TRepository));
        }

        public IDbSet<TEntity> GetDbSet<TEntity>() where TEntity : Entity
        {
            return context.Set<TEntity>();
        }

        public int Commit()
        {
            return context.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            _disposed = true;
        }


    }
}
