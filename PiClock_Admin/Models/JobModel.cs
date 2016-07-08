using Newtonsoft.Json;
using PiClock_Admin.Classes;
using PiClock_Admin.Helpers;
using System.Collections.Generic;

namespace PiClock_Admin.Models
{
    class JobModel : BaseClass
    {
        private string _id;
        [JsonProperty("id")]
        public string Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                    _id = value;
                RaisePropertyChanged("Id");
            }
        }

        private string _description;
        [JsonProperty("description")]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                    _description = value;
                RaisePropertyChanged("Description");
            }
        }

        private string _code;
        [JsonProperty("code")]
        public string Code
        {
            get { return _code; }
            set
            {
                if (_code != value)
                    _code = value;
                RaisePropertyChanged("Code");
            }
        }

        private string _active;
        [JsonProperty("active")]
        public string Active
        {
            get { return _active; }
            set
            {
                if (_active != value)
                    _active = value;
                RaisePropertyChanged("Active");
            }
        }
        
        //private List<JobModel> _jobList;
        //[JsonIgnore]
        //public List<JobModel> JobList
        //{
        //    get
        //    {
        //        GetAllJobs();
        //        return _jobList;
        //    }
        //    set
        //    {
        //        if (_jobList != value)
        //            _jobList = value;
        //        RaisePropertyChanged("JobList");
        //    }
        //}
        
        //private async void GetAllJobs()
        //{
        //    var paramDictionary = new Dictionary<string, string>()
        //    {
        //        { "action", "GetAllJobs" }
        //    };
        //    var httpResponse = await CommonMethods.GetHttpResponseFromRpcServer(paramDictionary);
        //    var httpContent = await httpResponse.Content.ReadAsStringAsync();

        //    _jobList = (List<JobModel>)CommonMethods.Deserialize(typeof(List<JobModel>), httpContent);
        //}
    }
} 
