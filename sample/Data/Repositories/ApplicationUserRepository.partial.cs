//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Data.Entities;

namespace Data.Repositories
{
    public partial class ApplicationUserRepository : IDbSet<ApplicationUser>
    {
        private readonly DbSet<ApplicationUser> _dbSet;
    
        internal ApplicationUserRepository(DbSet<ApplicationUser> dbSet)
        {
    		_dbSet = dbSet;
        }
        
    	public ApplicationUser Add(ApplicationUser entity)
    	{
     		return _dbSet.Add(entity);
    	}
    
    	public ApplicationUser Attach(ApplicationUser entity)
    	{
     		return _dbSet.Attach(entity);
    	}
    
    	public ApplicationUser Create()
    	{
     		return _dbSet.Create();
    	}
    
        TDerivedEntity IDbSet<ApplicationUser>.Create<TDerivedEntity>()
        {
            return _dbSet.Create<TDerivedEntity>();
        }
    
    	public ApplicationUser Find(params object[] keyValues)
    	{
     		return _dbSet.Find(keyValues);
    	}
    
    	public System.Collections.ObjectModel.ObservableCollection<ApplicationUser> Local
    	{
    		get { return _dbSet.Local; }
    	}
    
    	public ApplicationUser Remove(ApplicationUser entity)
    	{
    		return _dbSet.Remove(entity);
    	}
    
        public Type ElementType
        {
            get { return ((IQueryable)_dbSet).ElementType; }
        }
    
        public System.Linq.Expressions.Expression Expression
        {
            get { return ((IQueryable)_dbSet).Expression; }
        }
    
        public System.Linq.IQueryProvider Provider
        {
            get { return ((IQueryable)_dbSet).Provider; }
        }
    
        public IEnumerator<ApplicationUser> GetEnumerator()
        {
            return ((IEnumerable<ApplicationUser>) _dbSet).GetEnumerator();
        }
    
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) _dbSet).GetEnumerator();
        }
    }
    
}
