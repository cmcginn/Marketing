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
        static void Main(string[] args)
        {
            PostsRefresh();
        }
        static void PostsRefresh()
        {
            List<Guid> userList;
            using (MarketingEntities ctx = new MarketingEntities())
            {
                userList = ctx.aspnet_Membership.Select(n => n.UserId).ToList();

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
