using LockersHub.BL.DVM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LockersHub.BL.BusinessLogic.Interfaces
{
    public interface ILockersBL
    {
        Task<int> AddLocker(LockerDVM entity);
        Task<bool> DeleteLocker(object Id);
        Task<List<LockerDVM>> GetAllLockers();
        Task<LockerDVM> GetLockerByID(object Id);
        Task<List<LockerDVM>> GetLockersByStateID(object Id);
        Task<List<LockerDVM>> GetLockersByCityID(object Id);
        Task<List<LockerDVM>> GetLockerByStateName(string key);
        Task<List<LockerDVM>> GetLockersByCityName(string key);
        Task<bool> UpdateLocker(LockerDVM Locker);
    }
}
