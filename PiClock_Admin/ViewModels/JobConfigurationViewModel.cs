using PiClock_Admin.Helpers;
using PiClock_Admin.Models;
using System.Collections.Generic;

namespace PiClock_Admin.ViewModels
{
    class JobConfigurationViewModel : BaseViewModel
    {
        private List<JobModel> _jobList;
        public List<JobModel> JobList
        {
            get
            {
                if (_jobList == null)
                    GetAllJobs();
                return _jobList;
            }
            set
            {
                if (_jobList != value)
                    _jobList = value;
                RaisePropertyChanged("JobList");
            }
        }

        private async void GetAllJobs()
        {
            var paramDictionary = new Dictionary<string, string>()
            {
                { "action", "GetAllJobs" }
            };
            var httpResponse = await CommonMethods.GetHttpResponseFromRpcServer(paramDictionary);
            var httpContent = await httpResponse.Content.ReadAsStringAsync();

            JobList = (List<JobModel>)CommonMethods.Deserialize(typeof(List<JobModel>), httpContent);
        }
    }
}
