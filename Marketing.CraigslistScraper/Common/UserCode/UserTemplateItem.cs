using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class UserTemplateItem
    {
        partial void AttachmentName_Compute(ref string result)
        {
            if (this.UserFileId != Guid.Empty)
            {
                var item = this.DataWorkspace.MarketingDomainServiceData.UserFiles.Where(x => x.Id == UserFileId.GetValueOrDefault()).SingleOrDefault();
                if (item != null)
                    result = item.Filename;
            }

        }
    }
}
