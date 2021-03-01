using LockersHub.BL.DVM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LockersHub.BL.BusinessLogic.Interfaces
{
    public interface ISetupsBL
    {
        /// <summary>
        /// This method adds a new City
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> AddCityAsync(CityDVM entity);
        /// <summary>
        /// This method gets all City
        /// </summary>
        /// <returns></returns>
        Task<List<CityDVM>> GetAllCitiesAsync();
        /// <summary>
		/// This metho gets an City by id
		/// </summary>
		/// <param name="Id"></param>
		/// <returns></returns>
		Task<CityDVM> GetCityByIDAsync(object Id);
        /// <summary>
        /// This method deletes a City
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<bool> DeleteCityAsync(object Id);
        /// <summary>
        /// This method updates a Bank
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> UpdateCityAsync(CityDVM entity);

        Task<bool> AddCountry(CountryDVM Country);
        Task<bool> DeleteCountry(object Id);
        Task<List<CountryDVM>> GetAllCountries();
        Task<CountryDVM> GetCountryByID(object Id);
        Task<bool> UpdateCountry(CountryDVM Country);

        Task<bool> AddState(StateDVM entity);
        Task<bool> DeleteState(object Id);
        Task<List<StateDVM>> GetAllStates();
        Task<StateDVM> GetStateByID(object Id);
        Task<List<StateDVM>> GetStatesByCountryID(object Id);
        Task<bool> UpdateState(StateDVM entity);

    }
}
