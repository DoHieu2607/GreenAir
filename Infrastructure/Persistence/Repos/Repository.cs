using System;
using System.Linq;
using System.Linq.Expressions;
using ApplicationCore.Interfaces;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repos
{
    public class Repository<T> : IRepository<T> where T : class, IAggregateRoot
    {
        protected GreenairContext Context { get; private set; }

        public Repository(GreenairContext context)
        {
            Context = context;
        }

        public void Add(T entity)
        {
            try
            {
                Context.Add(entity);
            }
            catch (Exception e)
            {
                Console.WriteLine("Add() Unexpected: " + e);
            }
        }

        public void AddRange(IEnumerable<T> entities)
        {

            try
            {
                Context.AddRange(entities);
            }
            catch (Exception e)
            {
                Console.WriteLine("AddRange() Unexpected: " + e);
            }
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {

            try
            {
                return Context.Set<T>().Where(predicate);
            }
            catch (Exception e)
            {
                Console.WriteLine("Find() Unexpected: " + e);
                return null;
            }
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return Context.Set<T>().ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("GetAll() Unexpected: " + e);
                return null;
            }
        }

        public T GetBy(string id)
        {
            try
            {
                return Context.Set<T>().Find(id);
            }
            catch (Exception e)
            {
                Console.WriteLine("GetBy() Unexpected: " + e);
                return null;
            }
        }

        public void Remove(T entity)
        {

            try
            {
                Context.Set<T>().Remove(entity);
            }
            catch (Exception e)
            {
                Console.WriteLine("Remove() Unexpected: " + e);
            }
        }

        public void RemoveById(string id)
        {

            try
            {
                T temp = this.GetBy(id);
                Context.Set<T>().Remove(temp);
            }
            catch (Exception e)
            {
                Console.WriteLine("RemoveById() Unexpected: " + e);
            }
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            try
            {
                Context.Set<T>().RemoveRange(entities);
            }
            catch (Exception e)
            {
                Console.WriteLine("RemoveRange() Unexpected: " + e);
            }
        }
    }
}