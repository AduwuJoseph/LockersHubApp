using LockersHub.BL.DVM;
using LockersHub.DALS.Entities;
using Microsoft.AspNetCore.Identity;

namespace LockersHub.BL.Infrastructure
{
	public class AutoMapperWebProfile : AutoMapper.Profile
	{
		public AutoMapperWebProfile()
        {

            CreateMap<AspNetRoleClaim, AspNetRoleClaimDVM>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<AspNetRoleClaimDVM, AspNetRoleClaim>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<AspNetRole, AspNetRoleDVM>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<AspNetRoleDVM, AspNetRole>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<AspNetUserClaim, AspNetUserClaimDVM>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<AspNetUserClaimDVM, AspNetUserClaim>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<AspNetUser, AspNetUserDVM>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<AspNetUserDVM, AspNetUser>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<AspNetUserLogin, AspNetUserLoginDVM>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<AspNetUserLoginDVM, AspNetUserLogin>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<AspNetUserRole, AspNetUserRoleDVM>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<AspNetUserRoleDVM, AspNetUserRole>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<AspNetUserToken, AspNetUserTokenDVM>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<AspNetUserTokenDVM, AspNetUserToken>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<City, CityDVM>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<CityDVM, City>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Country, CountryDVM>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<CountryDVM, Country>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Locker, LockerDVM>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<LockerDVM, Locker>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<State, StateDVM>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<StateDVM, State>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

        }
    }
}