using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSservice
{
    interface IVCSService
    {
        public Commit GetCommitInfo();
        public User GetUserInfo();
        public Repo GetRepoInfo();
    }
}
