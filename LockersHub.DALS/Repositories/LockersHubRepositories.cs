using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LockersHub.DALS.Entities;
using LockersHub.DALS.Infrastructure;
using LockersHub.DALS.Infrastructure.Interfaces;

namespace LockersHub.DALS.Repositories
{
    
    /// <summary>
    /// AspNetRole Repository class
    /// </summary>
    public class AspNetRoleRepository : GenericRepository<AspNetRole>
    {
        public AspNetRoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }

    /// <summary>
    /// AspNetRoleClaim Repository class
    /// </summary>
    public class AspNetRoleClaimRepository : GenericRepository<AspNetRoleClaim>
    {
        public AspNetRoleClaimRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }

    /// <summary>
    /// AspNetUser Repository class
    /// </summary>
    public class AspNetUserRepository : GenericRepository<AspNetUser>
    {
        public AspNetUserRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }

    /// <summary>
    /// AspNetUserClaim Repository class
    /// </summary>
    public class AspNetUserClaimRepository : GenericRepository<AspNetUserClaim>
    {
        public AspNetUserClaimRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }

    /// <summary>
    /// AspNetUserLogin Repository class
    /// </summary>
    public class AspNetUserLoginRepository : GenericRepository<AspNetUserLogin>
    {
        public AspNetUserLoginRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }

    /// <summary>
    /// AspNetUserRole Repository class
    /// </summary>
    public class AspNetUserRoleRepository : GenericRepository<AspNetUserRole>
    {
        public AspNetUserRoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }

    /// <summary>
    /// AspNetUserToken Repository class
    /// </summary>
    public class AspNetUserTokenRepository : GenericRepository<AspNetUserToken>
    {
        public AspNetUserTokenRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }

    /// <summary>
    ///  City Repository class
    /// </summary>
    public class CityRepository : GenericRepository<City>
    {
        public CityRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
    /// <summary>
    ///  Country Repository class
    /// </summary>
    public class CountryRepository : GenericRepository<Country>
    {
        public CountryRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
    /// <summary>
    ///  Locker Repository class
    /// </summary>
    public class LockerRepository : GenericRepository<Locker>
    {
        public LockerRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
    /// <summary>
    ///  State Repository class
    /// </summary>
    public class StateRepository : GenericRepository<State>
    {
        public StateRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
    
}