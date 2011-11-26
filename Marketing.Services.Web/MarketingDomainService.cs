
namespace Marketing.Services.Web {
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.ComponentModel.DataAnnotations;
  using System.Data;
  using System.Linq;
  using System.ServiceModel.DomainServices.EntityFramework;
  using System.ServiceModel.DomainServices.Hosting;
  using System.ServiceModel.DomainServices.Server;
  using Marketing.Data;


  // Implements application logic using the MarketingDomainModelContainer context.
  // TODO: Add your application logic to these methods or in additional methods.
  // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
  // Also consider adding roles to restrict access as appropriate.
  // [RequiresAuthentication]
  [EnableClientAccess()]
  public class MarketingDomainService : LinqToEntitiesDomainService<MarketingDomainModelContainer> {

    // TODO:
    // Consider constraining the results of your query method.  If you need additional input you can
    // add parameters to this method or create additional query methods with different names.
    // To support paging you will need to add ordering to the 'CraigslistPosts' query.
    [Query( IsDefault = true )]
    public IQueryable<CraigslistPost> GetCraigslistPosts() {
      return this.ObjectContext.CraigslistPosts;
    }

    public void InsertCraigslistPost( CraigslistPost craigslistPost ) {
      if( ( craigslistPost.EntityState != EntityState.Detached ) ) {
        this.ObjectContext.ObjectStateManager.ChangeObjectState( craigslistPost, EntityState.Added );
      } else {
        this.ObjectContext.CraigslistPosts.AddObject( craigslistPost );
      }
    }

    public void UpdateCraigslistPost( CraigslistPost currentCraigslistPost ) {
      this.ObjectContext.CraigslistPosts.AttachAsModified( currentCraigslistPost, this.ChangeSet.GetOriginal( currentCraigslistPost ) );
    }

    public void DeleteCraigslistPost( CraigslistPost craigslistPost ) {
      if( ( craigslistPost.EntityState != EntityState.Detached ) ) {
        this.ObjectContext.ObjectStateManager.ChangeObjectState( craigslistPost, EntityState.Deleted );
      } else {
        this.ObjectContext.CraigslistPosts.Attach( craigslistPost );
        this.ObjectContext.CraigslistPosts.DeleteObject( craigslistPost );
      }
    }
  }
}


