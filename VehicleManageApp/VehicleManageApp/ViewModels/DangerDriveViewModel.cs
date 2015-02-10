using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManageApp.Async;
using VehicleManageApp.Services;

namespace VehicleManageApp.ViewModels
{
    public class DangerDriveViewModel : BaseViewModel
    {
        private static int count = 0;
        public DangerDriveViewModel()
        {
            //var _dangerDriveService = new DanDriveService();
            //var result = await _dangerDriveService.GetDangerDriveList();
            //DangerDriveList = new NotifyTaskCompletion<List<DangerDriveViewModel>>(GetDangerDriveList());
            //Debug.WriteLine(count++.ToString());
        }

        private async Task<List<DangerDriveViewModel>> GetDangerDriveList()
        {
            var _dangerDriveService = new DanDriveService();
            var result = await _dangerDriveService.GetDangerDriveList();
            DangerDriveList = result;
            return result;
        }

        public List<DangerDriveViewModel> DangerDriveList { get; private set; }

        public string ownercompanyname { get; set; }

        public string chepaino { get; set; }

        public string Ala10 { get; set; }

        public string Ala11 { get; set; }

        public string Ala12 { get; set; }

        public string Ala13 { get; set; }

        public string Ala14 { get; set; }

        public string Ala15 { get; set; }

        public string Ala16 { get; set; }

        public string Ala17 { get; set; }

        public string Ala18 { get; set; }

        public string Ala19 { get; set; }

        public string Ala20 { get; set; }

        public string Ala21 { get; set; }

        public string Ala30 { get; set; }

        public string Ala31 { get; set; }

        public string Ala32 { get; set; }

        public string Ala33 { get; set; }

        public string Ala34 { get; set; }

        public string Ala35 { get; set; }


    }
}
