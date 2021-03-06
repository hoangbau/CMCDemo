﻿using ElectricWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElectricWebApp.Services.Interfaces
{
    public interface IElectricService
    {
        Task<ResponseDataModel<string>> Create(DeviceViewModel electricModel);
        Task<object> Edit(DeviceViewModel electricModel);
        Task<ResponseDataModel<string>> Delete(string id);
        Task<DeviceViewModel> GetDetail(string id);
        Task<IEnumerable<DeviceViewModel>> GetAll();
    }
}
