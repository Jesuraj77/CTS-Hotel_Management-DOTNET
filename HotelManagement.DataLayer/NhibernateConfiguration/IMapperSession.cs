using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManagement.Entities;

namespace HotelManagement.DataLayer.NhibernateConfiguration
{
   public interface IMapperSession
    {
        void BeginTransaction();
        System.Threading.Tasks.Task Commit();
        System.Threading.Tasks.Task Rollback();
        void CloseTransaction();
        System.Threading.Tasks.Task Save(List<Hotel> entity);
        System.Threading.Tasks.Task Delete(Hotel entity);
        IQueryable<Hotel> hotel { get; }

    }
}
