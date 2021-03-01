﻿using Microsoft.EntityFrameworkCore;
using System;

namespace LockersHub.DALS.Infrastructure.Interfaces
{

    public interface IUnitOfWork : IDisposable
	{
		/// <summary>
		/// Return the database reference for this Unit Of Work
		/// </summary>
		DbContext Db { get; }
	}
}