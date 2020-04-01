using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManagement.Entities;
using NHibernate;

namespace HotelManagement.DataLayer.NhibernateConfiguration
{
   public class NHibernateMapperSession:IMapperSession
    {
        private readonly ISession _session;
        private ITransaction _transaction;

        public NHibernateMapperSession(ISession session)
        {
            _session = session;
        }

        public IQueryable<Hotel> hotel => _session.Query<Hotel>();

        public void BeginTransaction()
        {
            _transaction = _session.BeginTransaction();
        }

        public async System.Threading.Tasks.Task Commit()
        {
            await _transaction.CommitAsync();
        }

        public async System.Threading.Tasks.Task Rollback()
        {
            await _transaction.RollbackAsync();
        }

        public void CloseTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }
        }

        public async System.Threading.Tasks.Task Save(List<Hotel> entity)
        {
            await _session.SaveOrUpdateAsync(entity);
        }

        public async System.Threading.Tasks.Task Delete(Hotel entity)
        {
            await _session.DeleteAsync(entity);
        }
    }
}