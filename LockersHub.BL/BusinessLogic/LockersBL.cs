using AutoMapper;
using LockersHub.BL.BusinessLogic.Interfaces;
using LockersHub.BL.DVM;
using LockersHub.DALS.Entities;
using LockersHub.DALS.Infrastructure.Interfaces;
using LockersHub.DALS.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockersHub.BL.BusinessLogic
{
    public class LockersBL : ILockersBL
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly LockerRepository lockerRepository;
		private readonly CityRepository cityRepository;
		private readonly StateRepository stateRepository;
		private readonly IMapper mapper;

        /// <summary>
        /// This constructor
        /// </summary>
        /// <param name="_unitOfWork"></param>
        public LockersBL(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            lockerRepository = new LockerRepository(_unitOfWork);
			cityRepository = new CityRepository(_unitOfWork);
			stateRepository = new StateRepository(_unitOfWork);
			mapper = _mapper;
        }

		/// <summary>
		/// This method Adds a new Locker and returns the id
		/// </summary>
		/// <param name="Locker"></param>
		/// <returns></returns>
		public async Task<int> AddLocker(LockerDVM Locker)
		{
			int id = 0;
			if (Locker != null)
			{
				Locker c = mapper.Map<Locker>(Locker);
				try
				{
					var obj = await lockerRepository.InsertAsync(c);
					id = obj.LockerId;
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
			return id;
		}

		/// <summary>
		/// This method deletes a Locker details
		/// </summary>
		/// <param name="Id"></param>
		/// <returns></returns>
		public async Task<bool> DeleteLocker(object Id)
		{
			bool result = false;
			if (Id != null)
			{
				Locker c = await lockerRepository.GetAsync(Id);
				if (c != null)
				{
					try
					{
						await lockerRepository.UpdateAsync(c);
					}
					catch (Exception ex)
					{
						throw ex;
					}
				}
			}
			return result;
		}

		/// <summary>
		/// This method returns all Lockers
		/// </summary>
		/// <returns></returns>
		public async Task<List<LockerDVM>> GetAllLockers()
		{
			List<LockerDVM> cdvmList = new List<LockerDVM>();
			var cList = await lockerRepository.GetAllAsync();
			if (cList != null)
			{
				cdvmList = new List<LockerDVM>();
				try
				{
					cdvmList = mapper.Map<List<LockerDVM>>(cList);
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}

			return cdvmList;
		}

		/// <summary>
		/// This method gets Locker by id
		/// </summary>
		/// <param name="Id"></param>
		/// <returns></returns>
		public async Task<LockerDVM> GetLockerByID(object Id)
		{
			LockerDVM cdvm = null;
			if (Id != null)
			{
				Locker c = await lockerRepository.GetAsync(Id);
				if (c != null)
				{
					cdvm = mapper.Map<LockerDVM>(c);
				}
			}
			return cdvm;
		}

		/// <summary>
		/// This method returns all Lockers
		/// </summary>
		/// <returns></returns>
		public async Task<List<LockerDVM>> GetLockersByCityID(object Id)
		{
			List<LockerDVM> cdvmList = new List<LockerDVM>();
			var cList = await lockerRepository.GetAllAsync();
			if (cList != null)
			{
				cdvmList = new List<LockerDVM>();
				try
				{
					cdvmList = mapper.Map<List<LockerDVM>>(cList.Where(m => m.CityId.Equals(Id)));
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}

			return cdvmList;
		}

		/// <summary>
		/// This method returns all Lockers
		/// </summary>
		/// <returns></returns>
		public async Task<List<LockerDVM>> GetLockersByStateID(object Id)
		{
			List<LockerDVM> cdvmList = new List<LockerDVM>();
			var cList = await lockerRepository.GetAllAsync();
			if (cList != null)
			{
				cdvmList = new List<LockerDVM>();
				try
				{
					cdvmList = mapper.Map<List<LockerDVM>>(cList.Where(m => m.StateCode.Equals(Id)));
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}

			return cdvmList;
		}

		/// <summary>
		/// This method returns all Lockers by City
		/// </summary>
		/// <returns></returns>
		public async Task<List<LockerDVM>> GetLockersByCityName(string key)
		{
			List<LockerDVM> cdvmList = null;
			var cList = await lockerRepository.GetAllAsync();
			var searchRes = new List<Locker>();
			if (cList.Count() > 0)
			{
				var cities = await cityRepository.GetAllAsync();
				var sc = cities.Where(m => m.Name.ToLower().StartsWith(key.ToLower()) || m.Name.Contains(key.ToLower()) || m.Name.ToLower() == key.ToLower());
				foreach(var city in sc)
                {
					var sList = cList.Where(m => m.CityId == city.CityId);
					searchRes.AddRange(sList);
                }
				try
				{
					cdvmList = mapper.Map<List<LockerDVM>>(searchRes);
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
			return cdvmList;
		}

		/// <summary>
		/// This method returns all Lockers by State
		/// </summary>
		/// <returns></returns>
		public async Task<List<LockerDVM>> GetLockerByStateName(string key)
		{
			List<LockerDVM> cdvmList = null;
			var cList = await lockerRepository.GetAllAsync();
			var searchRes = new List<Locker>();
			if (cList.Count() > 0)
			{
				var states = await stateRepository.GetAllAsync();
				var sc = states.Where(m => m.Name.ToLower().StartsWith(key.ToLower()) || m.Name.Contains(key.ToLower()) || m.Name.ToLower() == key.ToLower());
				foreach (var city in sc)
				{
					var sList = cList.Where(m => m.StateCode == city.Code);
					searchRes.AddRange(sList);
				}
				try
				{
					cdvmList = mapper.Map<List<LockerDVM>>(searchRes);
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}

			return cdvmList;
		}

		/// <summary>
		/// This method updates a Locker and returns true if successful
		/// </summary>
		/// <param name="Locker"></param>
		/// <returns></returns>
		public async Task<bool> UpdateLocker(LockerDVM Locker)
		{
			bool result = false;
			if (Locker != null)
			{
				Locker c = await lockerRepository.GetAsync(Locker.LockerId);
				if (c != null)
				{
					c.Name = Locker.Name;
					c.CityId = Locker.CityId;
					c.Description = Locker.Description;
					c.Price = Locker.Price;
					c.QuantityAvailable = Locker.QuantityAvailable;
					c.StateCode = Locker.StateCode;
					c.DateCreated = Locker.DateCreated;
					c.DateModified = Locker.DateModified;
					c.ModifiedBy = Locker.ModifiedBy;
					c.DateModified = Locker.DateModified;
					c.Status = Locker.Status;
					c.Size = Locker.Size;
					c.ImageUrl = Locker.ImageUrl;
					try
					{
						await lockerRepository.UpdateAsync(c);
						result = true;
					}
					catch (Exception ex)
					{
						throw ex;
					}
				}
			}
			return result;
		}
	}
}
