using Microsoft.EntityFrameworkCore;
using System;
using LockersHub.DALS.Entities;
using LockersHub.DALS.Infrastructure.Interfaces;

namespace LockersHub.DALS.Infrastructure
{
	public class UnitOfWork : IUnitOfWork
	{
		/// <summary>
		/// This readonly variable creates the context of the database
		/// </summary>
		private readonly LockersDBContext _dbContext;

		/// <summary>
		/// This constructor initializes the database
		/// </summary>
		public UnitOfWork(LockersDBContext context)
		{
			_dbContext = context;
		}

		/// <summary>
		/// This method Returns the db context created from the constructor
		/// </summary>
		public DbContext Db
		{
			get { return _dbContext; }
		}

		private bool disposed = false;
		/// <summary>
		/// This method disposes the database
		/// </summary>
		public virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					_dbContext.Dispose();
				}
			}

			this.disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}