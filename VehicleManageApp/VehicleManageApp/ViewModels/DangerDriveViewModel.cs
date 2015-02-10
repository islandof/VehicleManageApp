using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManageApp.Async;
using VehicleManageApp.Services;
using VehicleManageApp.Model;

namespace VehicleManageApp.ViewModels
{
    public class DangerDriveViewModel : BaseViewModel
    {
        private static int count = 0;
        public DangerDriveViewModel()
        {
            //var _dangerDriveService = new DanDriveService();
            //var result = await _dangerDriveService.GetDangerDriveList();
            DangerDriveList = new NotifyTaskCompletion<List<DangerDrive>>(GetDangerDriveList());
        }

        private async Task<List<DangerDrive>> GetDangerDriveList()
        {
            var _dangerDriveService = new DanDriveService();
            var result = await _dangerDriveService.GetDangerDriveList();
            return result;
        }
        public NotifyTaskCompletion<List<DangerDrive>> DangerDriveList { get; private set; }
        }
}
