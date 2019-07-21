using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DvdStore.Data
{
    //where(제네릭 형식 제약 조건)(C# 참조)
    //제네릭 정의의 where 절은 제네릭 형식, 메서드, 대리자 또는
    //로컬 함수의 형식 매개 변수에 대한 인수로 사용되는 형식에 대한 제약 조건을 지정합니다
    //.제약 조건은 인터페이스, 기본 클래스를 지정하거나 제네릭 형식을 참조, 값 또는 관리되지 않는
    //형식으로 요구할 수 있습니다. 형식 인수에서 갖추고 있어야 하는 기능을 선언합니다.
    public class EntityData<T> where T : class
    {
        public List<S> Select<S>(Expression<Func<T, S>> selector)
        {
            using (DvdStoreEntities context = new DvdStoreEntities())
            {
                return context.Set<T>().Select(selector).ToList();
            }
        }

        public List<T> GetAll()
        {
            using (DvdStoreEntities context = new DvdStoreEntities())
            {
                return context.Set<T>().ToList();
            }
        }

        public int GetCount()
        {
            using (DvdStoreEntities context = new DvdStoreEntities())
            {
                return context.Set<T>().Count();
            }
        }

        public int GetCount(Expression<Func<T, bool>> predicate)
        {
            using (DvdStoreEntities context = new DvdStoreEntities())
            {
                return context.Set<T>().Count(predicate);
            }
        }

        public void Insert(T entity)
        {
            using (DvdStoreEntities context = new DvdStoreEntities())
            {
                context.Set<T>().Add(entity);

                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (var context = new DvdStoreEntities())
            {
                context.Entry(entity).State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new DvdStoreEntities())
            {
                context.Entry(entity).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

    }
}
