using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Workflow;
using System.Workflow.Runtime;
using Marketing.Data;
using Marketing.WorkflowActivities;
namespace Marketing.Batch
{
    class Program
    {
        static string[] _Args;
        static void Main(string[] args)
        {
            _Args = args;
            PostsRefresh();

        }
        static void PostsRefresh()
        {
            var users = _Args.Where(n => n.Contains("users=")).FirstOrDefault();
            var userNameList = new List<string>();
            if (users!=null)
            {
                var arguments = users.Replace("users=", "").Split(' ');
                userNameList = arguments.Select(n => n).ToList();

            }
            List<Guid> userList = new List<Guid>();
            using (MarketingEntities ctx = new MarketingEntities())
            {
                ctx.vw_aspnet_MembershipUsers.ToList().ForEach(n =>
                    {
                        if (userNameList.Contains(n.UserName))
                            userList.Add(n.UserId);
                    });

            }
            
            var purge = new WorkflowInvoker(new PurgePostsActivity());
            purge.Invoke();
            userList.ForEach(n =>
                {
                    
                    var inputs = new Dictionary<string, object>();
                    var userId = n;
                    inputs.Add("UserId", userId);
                    var host = new WorkflowInvoker(new RefreshUserDataActivity());
                    host.Invoke(inputs);
                });

        }
    }
}
