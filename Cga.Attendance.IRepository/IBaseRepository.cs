using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cga.Attendance.IRepository
{
    public interface IBaseRepository<T> where T : class, new()
    {
        int AddEntity(T entity);
        int DeleteEntity(T entity);
        int DeleteEntity(Expression<Func<T, bool>> whereLambda);
        int UpdateEntity(T entity);


    }
}
