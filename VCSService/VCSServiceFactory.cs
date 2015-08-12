using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSservice
{
    class VCSServiceFactory
    {
        public static GithubService GetGithubService()
        {
            return GithubService.Service;
        }
    }
}
