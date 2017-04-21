﻿using Project.UnitOfWorkProjectProject.Contexts;

namespace Project.UnitOfWorkProjectProject.Core
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        public readonly IResolver resolver;

        public UnitOfWorkFactory(IResolver resolver)
        {
            this.resolver = resolver;
        }

        public IUnitOfWork Create()
        {
            // TODO: Remover acoplamento
            return new UnitOfWork(new UsuarioDbContext(), resolver);
        }
    }
}
