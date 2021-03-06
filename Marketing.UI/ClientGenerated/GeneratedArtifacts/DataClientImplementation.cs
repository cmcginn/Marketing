//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication.Implementation
{
    
    #region CraigslistPost
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/MarketingDomainServiceData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class CraigslistPost :
        global::System.ServiceModel.DomainServices.Client.Entity,
        global::LightSwitchApplication.CraigslistPost.DetailsClass.IImplementation
    {
        public override object GetIdentity()
        {
            if (this.__host != null && this.__host.IsNewlyAdded)
            {
                return null;
            }
    
            return this._Id;
        }
        [global::System.ComponentModel.DataAnnotations.Key()]
        [global::System.ComponentModel.DataAnnotations.Editable(false, AllowInitialValue = true)]
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public global::System.Guid Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (this._Id != value)
                {
                    this.ValidateProperty("Id", value);
                    this._Id = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        private global::System.Guid _Id;
        
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public global::System.DateTime PostDate
        {
            get
            {
                return this._PostDate;
            }
            set
            {
                if (this._PostDate != value)
                {
                    this.RaiseDataMemberChanging("PostDate");
                    this.ValidateProperty("PostDate", value);
                    this._PostDate = value;
                    this.RaiseDataMemberChanged("PostDate");
                }
            }
        }
        private global::System.DateTime _PostDate;
        
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public string PostsElement
        {
            get
            {
                return this._PostsElement;
            }
            set
            {
                if (this._PostsElement != value)
                {
                    this.RaiseDataMemberChanging("PostsElement");
                    this.ValidateProperty("PostsElement", value);
                    this._PostsElement = value;
                    this.RaiseDataMemberChanged("PostsElement");
                }
            }
        }
        private string _PostsElement;
        
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public long PostId
        {
            get
            {
                return this._PostId;
            }
            set
            {
                if (this._PostId != value)
                {
                    this.RaiseDataMemberChanging("PostId");
                    this.ValidateProperty("PostId", value);
                    this._PostId = value;
                    this.RaiseDataMemberChanged("PostId");
                }
            }
        }
        private long _PostId;
        
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                if (this._Title != value)
                {
                    this.RaiseDataMemberChanging("Title");
                    this.ValidateProperty("Title", value);
                    this._Title = value;
                    this.RaiseDataMemberChanged("Title");
                }
            }
        }
        private string _Title;
        
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public string EmailAddress
        {
            get
            {
                return this._EmailAddress;
            }
            set
            {
                if (this._EmailAddress != value)
                {
                    this.RaiseDataMemberChanging("EmailAddress");
                    this.ValidateProperty("EmailAddress", value);
                    this._EmailAddress = value;
                    this.RaiseDataMemberChanged("EmailAddress");
                }
            }
        }
        private string _EmailAddress;
        
        [global::System.ComponentModel.DataAnnotations.Association("CraigslistPost_CraigsListResponse", "Id", "CraigslitPostsId")]
        [global::System.Xml.Serialization.XmlIgnore()]
        public global::System.ServiceModel.DomainServices.Client.EntityCollection<CraigsListResponse> CraigsListResponses
        {
            get
            {
                if (this._CraigsListResponses == null)
                {
                    this._CraigsListResponses = new global::System.ServiceModel.DomainServices.Client.EntityCollection<global::LightSwitchApplication.Implementation.CraigsListResponse>(this, "CraigsListResponses", this.FilterCraigsListResponses, this.AttachCraigsListResponses, this.DetachCraigsListResponses);
                }
                return this._CraigsListResponses;
            }
        }
        private global::System.ServiceModel.DomainServices.Client.EntityCollection<global::LightSwitchApplication.Implementation.CraigsListResponse> _CraigsListResponses;
        private void AttachCraigsListResponses(global::LightSwitchApplication.Implementation.CraigsListResponse entity)
        {
            entity.CraigslistPost = this;
        }
        private void DetachCraigsListResponses(global::LightSwitchApplication.Implementation.CraigsListResponse entity)
        {
            entity.CraigslistPost = null;
        }
        private bool FilterCraigsListResponses(global::LightSwitchApplication.Implementation.CraigsListResponse entity)
        {
            return global::System.Object.Equals(entity.CraigslitPostsId, this.Id);
        }
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
        
        protected override void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(e.PropertyName);
            }
        }
        #endregion
    }
    #endregion
    
    #region CraigsListResponse
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/MarketingDomainServiceData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class CraigsListResponse :
        global::System.ServiceModel.DomainServices.Client.Entity,
        global::LightSwitchApplication.CraigsListResponse.DetailsClass.IImplementation
    {
        public override object GetIdentity()
        {
            if (this.__host != null && this.__host.IsNewlyAdded)
            {
                return null;
            }
    
            return this._Id;
        }
        [global::System.ComponentModel.DataAnnotations.Key()]
        [global::System.ComponentModel.DataAnnotations.Editable(false, AllowInitialValue = true)]
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public global::System.Guid Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (this._Id != value)
                {
                    this.ValidateProperty("Id", value);
                    this._Id = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        private global::System.Guid _Id;
        
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public string ResponseContent
        {
            get
            {
                return this._ResponseContent;
            }
            set
            {
                if (this._ResponseContent != value)
                {
                    this.RaiseDataMemberChanging("ResponseContent");
                    this.ValidateProperty("ResponseContent", value);
                    this._ResponseContent = value;
                    this.RaiseDataMemberChanged("ResponseContent");
                }
            }
        }
        private string _ResponseContent;
        
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public global::System.DateTime Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                if (this._Created != value)
                {
                    this.RaiseDataMemberChanging("Created");
                    this.ValidateProperty("Created", value);
                    this._Created = value;
                    this.RaiseDataMemberChanged("Created");
                }
            }
        }
        private global::System.DateTime _Created;
        
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public string ResponseHtmlContent
        {
            get
            {
                return this._ResponseHtmlContent;
            }
            set
            {
                if (this._ResponseHtmlContent != value)
                {
                    this.RaiseDataMemberChanging("ResponseHtmlContent");
                    this.ValidateProperty("ResponseHtmlContent", value);
                    this._ResponseHtmlContent = value;
                    this.RaiseDataMemberChanged("ResponseHtmlContent");
                }
            }
        }
        private string _ResponseHtmlContent;
        
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public global::System.Guid CraigslitPostsId
        {
            get
            {
                return this._CraigslitPostsId;
            }
            set
            {
                if (this._CraigslitPostsId != value)
                {
                    this.RaiseDataMemberChanging("CraigslitPostsId");
                    this.ValidateProperty("CraigslitPostsId", value);
                    this._CraigslitPostsId = value;
                    this.RaiseDataMemberChanged("CraigslitPostsId");
                }
            }
        }
        private global::System.Guid _CraigslitPostsId;
        
        [global::System.ComponentModel.DataAnnotations.Association("CraigslistPost_CraigsListResponse", "CraigslitPostsId", "Id", IsForeignKey = true)]
        [global::System.Xml.Serialization.XmlIgnore()]
        public global::LightSwitchApplication.Implementation.CraigslistPost CraigslistPost
        {
            get
            {
                if (this._CraigslistPost == null)
                {
                    this._CraigslistPost = new global::System.ServiceModel.DomainServices.Client.EntityRef<global::LightSwitchApplication.Implementation.CraigslistPost>(this, "CraigslistPost", this.FilterCraigslistPost);
                }
                return this._CraigslistPost.Entity;
            }
            set
            {
                CraigslistPost previous = this.CraigslistPost;
                if (previous != value)
                {
                    this.ValidateProperty("CraigslistPost", value);
                    if (previous != null)
                    {
                        this._CraigslistPost.Entity = null;
                        previous.CraigsListResponses.Remove(this);
                    }
                    if (value != null)
                    {
                        this.CraigslitPostsId = value.Id;
                    }
                    else
                    {
                        this.CraigslitPostsId = default(global::System.Guid);
                    }
                    this._CraigslistPost.Entity = value;
                    if (value != null)
                    {
                        value.CraigsListResponses.Add(this);
                    }
                    this.RaisePropertyChanged("CraigslistPost");
                }
            }
        }
        private global::System.ServiceModel.DomainServices.Client.EntityRef<global::LightSwitchApplication.Implementation.CraigslistPost> _CraigslistPost;
        private bool FilterCraigslistPost(global::LightSwitchApplication.Implementation.CraigslistPost entity)
        {
            return global::System.Object.Equals(entity.Id, this.CraigslitPostsId);
        }
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.CraigsListResponse.DetailsClass.IImplementation.CraigslistPost
        {
            get
            {
                return this.CraigslistPost;
            }
            set
            {
                this.CraigslistPost = (global::LightSwitchApplication.Implementation.CraigslistPost)value;
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
        
        protected override void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(e.PropertyName);
            }
        }
        #endregion
    }
    #endregion
    
    #region MarketingDomainServiceData
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MarketingDomainServiceData
        : global::Microsoft.LightSwitch.ClientGenerated.Implementation.DomainContext
    {
        public MarketingDomainServiceData(global::Microsoft.LightSwitch.IDataService dataService)
            : base(dataService, global::Microsoft.LightSwitch.ClientGenerated.Implementation.DomainContext.CreateWcfDomainClient<IMarketingDomainServiceDataContract>(new global::System.Uri("LightSwitchApplication-Implementation-MarketingDomainServiceDataDomainService.svc", global::System.UriKind.Relative)))
        {
        }
    
        public global::System.ServiceModel.DomainServices.Client.EntitySet<global::LightSwitchApplication.Implementation.CraigslistPost> CraigslistPostEntityList
        {
            get
            {
                return base.EntityContainer.GetEntitySet<global::LightSwitchApplication.Implementation.CraigslistPost>();
            }
        }
        public global::System.ServiceModel.DomainServices.Client.EntitySet<global::LightSwitchApplication.Implementation.CraigsListResponse> CraigsListResponseEntityList
        {
            get
            {
                return base.EntityContainer.GetEntitySet<global::LightSwitchApplication.Implementation.CraigsListResponse>();
            }
        }
        protected override global::System.ServiceModel.DomainServices.Client.EntityContainer CreateEntityContainer()
        {
            return new MarketingDomainServiceDataEntityContainer();
        }
    
        internal sealed class MarketingDomainServiceDataEntityContainer : global::System.ServiceModel.DomainServices.Client.EntityContainer
        {
            public MarketingDomainServiceDataEntityContainer()
            {
                this.CreateEntitySet<global::LightSwitchApplication.Implementation.CraigslistPost>(global::System.ServiceModel.DomainServices.Client.EntitySetOperations.All);
                this.CreateEntitySet<global::LightSwitchApplication.Implementation.CraigsListResponse>(global::System.ServiceModel.DomainServices.Client.EntitySetOperations.All);
            }
        }
    
        #region Service Contract Interface
    
        [global::System.ServiceModel.ServiceContract]
        public interface IMarketingDomainServiceDataContract
        {
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigslistPosts_Single", ReplyAction = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigslistPosts_SingleResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigslistPosts_SingleDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginCraigslistPosts_Single(string frameworkOperators, global::System.Nullable<global::System.Guid> Id, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.CraigslistPost> EndCraigslistPosts_Single(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigslistPosts_SingleOrDefault", ReplyAction = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigslistPosts_SingleOrDefaultResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigslistPosts_SingleOrDefaultDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginCraigslistPosts_SingleOrDefault(string frameworkOperators, global::System.Nullable<global::System.Guid> Id, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.CraigslistPost> EndCraigslistPosts_SingleOrDefault(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigslistPosts_All", ReplyAction = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigslistPosts_AllResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigslistPosts_AllDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginCraigslistPosts_All(string frameworkOperators, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.CraigslistPost> EndCraigslistPosts_All(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigsListResponses_Single", ReplyAction = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigsListResponses_SingleResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigsListResponses_SingleDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginCraigsListResponses_Single(string frameworkOperators, global::System.Nullable<global::System.Guid> Id, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.CraigsListResponse> EndCraigsListResponses_Single(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigsListResponses_SingleOrDefault", ReplyAction = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigsListResponses_SingleOrDefaultResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigsListResponses_SingleOrDefaultDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginCraigsListResponses_SingleOrDefault(string frameworkOperators, global::System.Nullable<global::System.Guid> Id, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.CraigsListResponse> EndCraigsListResponses_SingleOrDefault(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigsListResponses_All", ReplyAction = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigsListResponses_AllResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/CraigsListResponses_AllDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginCraigsListResponses_All(string frameworkOperators, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.CraigsListResponse> EndCraigsListResponses_All(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/SubmitChanges", ReplyAction = "http://tempuri.org/MarketingDomainServiceDataDomainService/SubmitChangesResponse"),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/SubmitChangesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginSubmitChanges(global::System.Collections.Generic.IEnumerable<global::System.ServiceModel.DomainServices.Client.ChangeSetEntry> changeSet, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.Collections.Generic.IEnumerable<global::System.ServiceModel.DomainServices.Client.ChangeSetEntry> EndSubmitChanges(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/__GetEntitySetCanInformation", ReplyAction = "http://tempuri.org/MarketingDomainServiceDataDomainService/__GetEntitySetCanInformationResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/__GetEntitySetCanInformationDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult Begin__GetEntitySetCanInformation(string entitySetName, global::System.AsyncCallback callback, global::System.Object asyncState);
            int End__GetEntitySetCanInformation(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/__CanExecuteOperation", ReplyAction = "http://tempuri.org/MarketingDomainServiceDataDomainService/__CanExecuteOperationResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/MarketingDomainServiceDataDomainService/__CanExecuteOperationDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult Begin__CanExecuteOperation(string operationName, global::System.AsyncCallback callback, global::System.Object asyncState);
            bool End__CanExecuteOperation(global::System.IAsyncResult result);
            
        }
    
        #endregion
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.CraigslistPost))
            {
                return new global::LightSwitchApplication.Implementation.CraigslistPost();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.CraigsListResponse))
            {
                return new global::LightSwitchApplication.Implementation.CraigsListResponse();
            }
            return null;
        }
    }
    #endregion
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DataServiceFactory :
        global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.MarketingDomainServiceData))
            {
                return new global::LightSwitchApplication.MarketingDomainServiceData();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.MarketingDomainServiceData))
            {
                return new global::LightSwitchApplication.Implementation.MarketingDomainServiceData(dataService);
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
                return typeof(global::LightSwitchApplication.Implementation.CraigslistPost);
            }
            if (typeof(global::LightSwitchApplication.CraigsListResponse) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.CraigsListResponse);
            }
            return null;
        }
    }
}
