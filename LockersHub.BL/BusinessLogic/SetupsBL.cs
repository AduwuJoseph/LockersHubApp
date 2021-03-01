using LockersHub.BL.BusinessLogic.Interfaces;
using LockersHub.BL.DVM;
using LockersHub.DALS.Infrastructure.Interfaces;
using LockersHub.DALS.Entities;
using LockersHub.DALS.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LockersHub.BL.BusinessLogic
{
	public class SetupsBL : ISetupsBL
	{
        private readonly IUnitOfWork unitOfWork;
        private readonly CityRepository cityRepository;
        private readonly CountryRepository countryRepository;
        private readonly StateRepository stateRepository;
        private readonly IMapper mapper;

        /// <summary>
        /// This constructor
        /// </summary>
        /// <param name="_unitOfWork"></param>
        public SetupsBL(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            cityRepository = new CityRepository(_unitOfWork);
            countryRepository = new CountryRepository(_unitOfWork);
            stateRepository = new StateRepository(_unitOfWork);
            mapper = _mapper;
        }

        public async Task<bool> AddCityAsync(CityDVM entity)
        {
            bool id = false;
            if (entity != null)
            {
                City c = mapper.Map<City>(entity);
                try
                {
                    var obj = await cityRepository.InsertAsync(c);
                    id = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return id;
        }

        public async Task<List<CityDVM>> GetAllCitiesAsync()
        {
            List<CityDVM> cdvmList = null;
            var cList = await cityRepository.GetAllAsync();
            if (cList != null)
            {
                cdvmList = new List<CityDVM>();
                try
                {
                    cdvmList = mapper.Map<List<CityDVM>>(cList.ToList());
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return cdvmList;
        }

        public async Task<CityDVM> GetCityByIDAsync(object Id)
        {
            try
            {
                CityDVM cdvm = null;
                if (Id != null)
                {
                    City d = await cityRepository.GetAsync(Id);
                    if (d != null)
                    {
                        cdvm = mapper.Map<CityDVM>(d);
                    }
                }
                return cdvm;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<bool> DeleteCityAsync(object Id)
        {
            bool result = false;
            if (Id != null)
            {
                City d = await cityRepository.GetAsync(Id);
                if (d != null)
                {
                    try
                    {
                        cityRepository.DeleteById(Id);
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

        public async Task<bool> UpdateCityAsync(CityDVM entity)
        {
            bool result = false;
            if (entity != null)
            {
                City d = cityRepository.Get(entity.CityId);
                if (d != null)
                {
                    d.Name = entity.Name;
                    d.StateCode = entity.StateCode;
                    try
                    {
                        await cityRepository.UpdateAsync(d);
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

        public async Task<bool> AddCountry(CountryDVM Country)
        {
            bool id = false;
            if (Country != null)
            {
                Country c = mapper.Map<Country>(Country);
                try
                {
                    var obj = await countryRepository.InsertAsync(c);
                    id = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return id;
        }

        public async Task<bool> DeleteCountry(object Id)
        {
            bool result = false;
            if (Id != null)
            {
                Country c = await countryRepository.GetAsync(Id);
                if (c != null)
                {
                    try
                    {
                        await countryRepository.UpdateAsync(c);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return result;
        }

        public async Task<List<CountryDVM>> GetAllCountries()
        {
            List<CountryDVM> cdvmList = new List<CountryDVM>();
            var cList = await countryRepository.GetAllAsync();
            if (cList != null)
            {
                cdvmList = new List<CountryDVM>();
                try
                {
                    cdvmList = mapper.Map<List<CountryDVM>>(cList);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return cdvmList;
        }

        public async Task<CountryDVM> GetCountryByID(object Id)
        {
            CountryDVM cdvm = new CountryDVM();
            if (Id != null)
            {
                Country c = await countryRepository.GetAsync(Id);
                if (c != null)
                {
                    cdvm = mapper.Map<CountryDVM>(c);
                }
            }
            return cdvm;
        }

        public async Task<bool> UpdateCountry(CountryDVM Country)
        {
            bool result = false;
            if (Country != null)
            {
                Country c = await countryRepository.GetAsync(Country.Code);
                if (c != null)
                {
                    c.Name = Country.Name;
                    try
                    {
                        await countryRepository.UpdateAsync(c);
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
        public async Task<bool> AddState(StateDVM entity)
        {
            bool id = false;
            if (entity != null)
            {
                State c = mapper.Map<State>(entity);
                try
                {
                    var obj = await stateRepository.InsertAsync(c);
                    id = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return id;
        }
        public async Task<bool> DeleteState(object Id)
        {
            bool result = false;
            if (Id != null)
            {
                State c = await stateRepository.GetAsync(Id);
                if (c != null)
                {
                    try
                    {
                        await stateRepository.UpdateAsync(c);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return result;
        }

        public async Task<List<StateDVM>> GetAllStates()
        {
            List<StateDVM> cdvmList = new List<StateDVM>();
            var cList = await stateRepository.GetAllAsync();
            if (cList != null)
            {
                cdvmList = new List<StateDVM>();
                try
                {
                    cdvmList = mapper.Map<List<StateDVM>>(cList);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return cdvmList;
        }

        public async Task<StateDVM> GetStateByID(object Id)
        {
            StateDVM cdvm = new StateDVM();
            if (Id != null)
            {
                State c = await stateRepository.GetAsync(Id);
                if (c != null)
                {
                    cdvm = mapper.Map<StateDVM>(c);
                }
            }
            return cdvm;
        }

        public async Task<List<StateDVM>> GetStatesByCountryID(object Id)
        {
            List<StateDVM> cdvmList = new List<StateDVM>();
            var cList = await stateRepository.GetAllAsync();
            if (cList != null)
            {
                cdvmList = new List<StateDVM>();
                try
                {
                    cdvmList = mapper.Map<List<StateDVM>>(cList.Where(m => m.CountryCode.Equals(Id)));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return cdvmList;
        }

        public async Task<bool> UpdateState(StateDVM entity)
        {
            bool result = false;
            if (entity != null)
            {
                State c = await stateRepository.GetAsync(entity.Code);
                if (c != null)
                {
                    c.Name = entity.Name;
                    c.CountryCode = entity.CountryCode;                    
                    try
                    {
                        await stateRepository.UpdateAsync(c);
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
