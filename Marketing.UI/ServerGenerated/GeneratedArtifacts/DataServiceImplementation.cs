//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    
    [global::System.ServiceModel.DomainServices.Hosting.EnableClientAccess()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MarketingDomainServiceDataDomainService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DomainService<global::MarketingDomainServiceData.Implementation.MarketingDomainServiceDataObjectContext>
    {
    
        public MarketingDomainServiceDataDomainService() : base()
        {
        }
    
    #region Public Methods
    
    #region CraigslistPost
    
        public void InsertCraigslistPost(global::MarketingDomainServiceData.Implementation.CraigslistPost entity)
        {
            if (entity.EntityState != global::System.Data.EntityState.Detached)
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(entity, global::System.Data.EntityState.Added);
            }
            else
            {
                this.ObjectContext.CraigslistPosts.AddObject(entity);
            }
        }
    
        public void UpdateCraigslistPost(global::MarketingDomainServiceData.Implementation.CraigslistPost currentEntity)
        {
            global::System.ServiceModel.DomainServices.EntityFramework.ObjectContextExtensions.AttachAsModified(this.ObjectContext.CraigslistPosts, currentEntity, this.ChangeSet.GetOriginal(currentEntity));
        }
    
        public void DeleteCraigslistPost(global::MarketingDomainServiceData.Implementation.CraigslistPost entity)
        {
            if (entity.EntityState == global::System.Data.EntityState.Detached)
            {
                this.ObjectContext.CraigslistPosts.Attach(entity);
            }
    
            this.DeleteEntity(entity);
        }
    #endregion
    
    #region CraigsListResponse
    
        public void InsertCraigsListResponse(global::MarketingDomainServiceData.Implementation.CraigsListResponse entity)
        {
            if (entity.EntityState != global::System.Data.EntityState.Detached)
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(entity, global::System.Data.EntityState.Added);
            }
            else
            {
                this.ObjectContext.CraigsListResponses.AddObject(entity);
            }
        }
    
        public void UpdateCraigsListResponse(global::MarketingDomainServiceData.Implementation.CraigsListResponse currentEntity)
        {
            global::System.ServiceModel.DomainServices.EntityFramework.ObjectContextExtensions.AttachAsModified(this.ObjectContext.CraigsListResponses, currentEntity, this.ChangeSet.GetOriginal(currentEntity));
        }
    
        public void DeleteCraigsListResponse(global::MarketingDomainServiceData.Implementation.CraigsListResponse entity)
        {
            if (entity.EntityState == global::System.Data.EntityState.Detached)
            {
                this.ObjectContext.CraigsListResponses.Attach(entity);
            }
    
            this.DeleteEntity(entity);
        }
    #endregion
    
    #region Queries
        public global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigslistPost> CraigslistPosts_Single(string frameworkOperators, global::System.Nullable<global::System.Guid> Id)
        {
            return this.GetQuery<global::MarketingDomainServiceData.Implementation.CraigslistPost>("CraigslistPosts_Single", frameworkOperators, Id);
        }
    
        public global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigslistPost> CraigslistPosts_SingleOrDefault(string frameworkOperators, global::System.Nullable<global::System.Guid> Id)
        {
            return this.GetQuery<global::MarketingDomainServiceData.Implementation.CraigslistPost>("CraigslistPosts_SingleOrDefault", frameworkOperators, Id);
        }
    
        public global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigslistPost> CraigslistPosts_All(string frameworkOperators)
        {
            return this.GetQuery<global::MarketingDomainServiceData.Implementation.CraigslistPost>("CraigslistPosts_All", frameworkOperators);
        }
    
        public global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigsListResponse> CraigsListResponses_Single(string frameworkOperators, global::System.Nullable<global::System.Guid> Id)
        {
            return this.GetQuery<global::MarketingDomainServiceData.Implementation.CraigsListResponse>("CraigsListResponses_Single", frameworkOperators, Id);
        }
    
        public global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigsListResponse> CraigsListResponses_SingleOrDefault(string frameworkOperators, global::System.Nullable<global::System.Guid> Id)
        {
            return this.GetQuery<global::MarketingDomainServiceData.Implementation.CraigsListResponse>("CraigsListResponses_SingleOrDefault", frameworkOperators, Id);
        }
    
        public global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigsListResponse> CraigsListResponses_All(string frameworkOperators)
        {
            return this.GetQuery<global::MarketingDomainServiceData.Implementation.CraigsListResponse>("CraigsListResponses_All", frameworkOperators);
        }
    
    #endregion
    
        [global::System.ServiceModel.DomainServices.Server.Invoke(HasSideEffects=false)]
        public int __GetEntitySetCanInformation(string entitySetName)
        {
            return base.GetEntitySetCanInformation(entitySetName);
        }
    
        [global::System.ServiceModel.DomainServices.Server.Invoke(HasSideEffects=false)]
        public bool __CanExecuteOperation(string operationName)
        {
            return base.CanExecuteOperation(operationName);
        }
    
    #endregion
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService()
        {
            return new global::LightSwitchApplication.DataWorkspace().MarketingDomainServiceData;
        }
    
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MarketingDomainServiceDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.RiaDataServiceImplementation<global::MarketingDomainServiceData.Implementation.MarketingDomainServiceDataObjectContext, global::Marketing.Services.Web.MarketingDomainService>
    {
        public MarketingDomainServiceDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
        public global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigslistPost> CraigslistPosts_Single(global::System.Nullable<global::System.Guid> Id)
        {
            global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigslistPost> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::MarketingDomainServiceData.Implementation.CraigslistPost>("CraigslistPosts_All"),
                (c) => (Id.HasValue && (c.Id == Id)));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigslistPost> CraigslistPosts_SingleOrDefault(global::System.Nullable<global::System.Guid> Id)
        {
            global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigslistPost> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::MarketingDomainServiceData.Implementation.CraigslistPost>("CraigslistPosts_All"),
                (c) => (Id.HasValue && (c.Id == Id)));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigslistPost> CraigslistPosts_All()
        {
            global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigslistPost> query;
            query = base.CreateQuery<global::MarketingDomainServiceData.Implementation.CraigslistPost>("GetCraigslistPosts").AsQueryable();
            return query;
        }
    
        public global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigsListResponse> CraigsListResponses_Single(global::System.Nullable<global::System.Guid> Id)
        {
            global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigsListResponse> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::MarketingDomainServiceData.Implementation.CraigsListResponse>("CraigsListResponses_All"),
                (c) => (Id.HasValue && (c.Id == Id)));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigsListResponse> CraigsListResponses_SingleOrDefault(global::System.Nullable<global::System.Guid> Id)
        {
            global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigsListResponse> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::MarketingDomainServiceData.Implementation.CraigsListResponse>("CraigsListResponses_All"),
                (c) => (Id.HasValue && (c.Id == Id)));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigsListResponse> CraigsListResponses_All()
        {
            global::System.Linq.IQueryable<global::MarketingDomainServiceData.Implementation.CraigsListResponse> query;
            query = base.CreateQuery<global::MarketingDomainServiceData.Implementation.CraigsListResponse>("GetCraigsListResponses").AsQueryable();
            return query;
        }
    
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::MarketingDomainServiceData.Implementation.CraigslistPost))
            {
                return new global::MarketingDomainServiceData.Implementation.CraigslistPost();
            }
            if (type == typeof(global::MarketingDomainServiceData.Implementation.CraigsListResponse))
            {
                return new global::MarketingDomainServiceData.Implementation.CraigsListResponse();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::MarketingDomainServiceData.Implementation.MarketingDomainServiceDataObjectContext CreateObjectContext()
        {
            return new global::MarketingDomainServiceData.Implementation.MarketingDomainServiceDataObjectContext(base.GetEntityConnectionString(
                "MarketingDomainServiceData", 
                "res://*/MarketingDomainServiceData.csdl|res://*/MarketingDomainServiceData.ssdl|res://*/MarketingDomainServiceData.msl",
                "System.Data.SqlClient"));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.CraigslistPost))
            {
                return new global::MarketingDomainServiceData.Implementation.CraigslistPost();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.CraigsListResponse))
            {
                return new global::MarketingDomainServiceData.Implementation.CraigsListResponse();
            }
            return null;
        }
        protected override global::System.Type ConvertType(global::System.Type outerType)
        {
            if (outerType == typeof(global::MarketingDomainServiceData.Implementation.CraigslistPost))
            {
                return typeof(global::Marketing.Data.CraigslistPost);
            }
            if (outerType == typeof(global::MarketingDomainServiceData.Implementation.CraigsListResponse))
            {
                return typeof(global::Marketing.Data.CraigsListResponse);
            }
            return base.ConvertType(outerType);
        }
        protected override object ConvertEntity(object outerEntity)
        {
            global::MarketingDomainServiceData.Implementation.CraigslistPost craigslistPost = outerEntity as global::MarketingDomainServiceData.Implementation.CraigslistPost;
            if (craigslistPost != null)
            {
                global::Marketing.Data.CraigslistPost result = new global::Marketing.Data.CraigslistPost();
                result.Id = craigslistPost.Id;
                result.PostDate = craigslistPost.PostDate;
                result.PostsElement = craigslistPost.PostsElement;
                result.PostId = craigslistPost.PostId;
                result.Title = craigslistPost.Title;
                result.EmailAddress = craigslistPost.EmailAddress;
                return result;
            }
            global::MarketingDomainServiceData.Implementation.CraigsListResponse craigsListResponse = outerEntity as global::MarketingDomainServiceData.Implementation.CraigsListResponse;
            if (craigsListResponse != null)
            {
                global::Marketing.Data.CraigsListResponse result = new global::Marketing.Data.CraigsListResponse();
                result.Id = craigsListResponse.Id;
                result.ResponseContent = craigsListResponse.ResponseContent;
                result.Created = craigsListResponse.Created;
                result.CraigslitPostsId = craigsListResponse.CraigslitPostsId;
                return result;
            }
            return null;
        }
       
    
        protected override void UpdateResult(object outerEntity, object innerResult)
        {
            global::MarketingDomainServiceData.Implementation.CraigslistPost outerCraigslistPost = outerEntity as global::MarketingDomainServiceData.Implementation.CraigslistPost;
            global::Marketing.Data.CraigslistPost innerCraigslistPost = innerResult as global::Marketing.Data.CraigslistPost;
            if ((outerCraigslistPost != null) && (innerCraigslistPost != null))
            {
                outerCraigslistPost.Id = innerCraigslistPost.Id;
                outerCraigslistPost.PostDate = innerCraigslistPost.PostDate;
                outerCraigslistPost.PostsElement = innerCraigslistPost.PostsElement;
                outerCraigslistPost.PostId = innerCraigslistPost.PostId;
                outerCraigslistPost.Title = innerCraigslistPost.Title;
                outerCraigslistPost.EmailAddress = innerCraigslistPost.EmailAddress;
                return;
            }
            global::MarketingDomainServiceData.Implementation.CraigsListResponse outerCraigsListResponse = outerEntity as global::MarketingDomainServiceData.Implementation.CraigsListResponse;
            global::Marketing.Data.CraigsListResponse innerCraigsListResponse = innerResult as global::Marketing.Data.CraigsListResponse;
            if ((outerCraigsListResponse != null) && (innerCraigsListResponse != null))
            {
                outerCraigsListResponse.Id = innerCraigsListResponse.Id;
                outerCraigsListResponse.ResponseContent = innerCraigsListResponse.ResponseContent;
                outerCraigsListResponse.Created = innerCraigsListResponse.Created;
                outerCraigsListResponse.CraigslitPostsId = innerCraigsListResponse.CraigslitPostsId;
                return;
            }
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.MarketingDomainServiceData))
            {
                return new global::LightSwitchApplication.MarketingDomainServiceDataService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.MarketingDomainServiceData))
            {
                return new global::LightSwitchApplication.Implementation.MarketingDomainServiceDataServiceImplementation(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.CraigslistPost) == definitionType)
            {
                return typeof(global::MarketingDomainServiceData.Implementation.CraigslistPost);
            }
            if (typeof(global::LightSwitchApplication.CraigsListResponse) == definitionType)
            {
                return typeof(global::MarketingDomainServiceData.Implementation.CraigsListResponse);
            }
            return null;
        }
    }
}

namespace MarketingDomainServiceData.Implementation
{

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class CraigslistPost :
        global::LightSwitchApplication.CraigslistPost.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.CraigslistPost.DetailsClass.IImplementation.CraigsListResponses
        {
            get
            {
                return this.CraigsListResponses;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.DataAnnotations.MetadataType(typeof(global::MarketingDomainServiceData.Implementation.CraigsListResponse.Metadata))]
    public partial class CraigsListResponse :
        global::LightSwitchApplication.CraigsListResponse.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.CraigsListResponse.DetailsClass.IImplementation.CraigslistPost
        {
            get
            {
                return this.CraigslistPost;
            }
            set
            {
                this.CraigslistPost = (global::MarketingDomainServiceData.Implementation.CraigslistPost)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("CraigslistPost");
                }
            }
        }
        
        partial void OnCraigslitPostsIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("CraigslistPost");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
        
        internal class Metadata
        {
            [global::System.ServiceModel.DomainServices.Server.Include]
            public global::MarketingDomainServiceData.Implementation.CraigslistPost CraigslistPost { get; set; }
        
        }
    }
    
}

