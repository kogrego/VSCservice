using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSservice 
{
    class GithubService : IVCSService
    {
        private static GithubService service;
        private User user;
        private Commit commit;
        private Repo repo;

        private GithubService()
        {
            
        }
        public static GithubService Service
        {
            get
            {
                if (service == null)
                {
                    service = new GithubService();
                }
                return service;
            }
        }
        public string GetCommitInfo()
        {
            return "OK";
        }
        public string GetUserInfo()
        {
            return "OK";
        }
        public string GetRepoInfo()
        {
            return "OK";
        }
    }
}
