//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Marketing.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel.DomainServices;
    using System.ServiceModel.DomainServices.Client;
    using System.ServiceModel.DomainServices.Client.ApplicationServices;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// The 'CraigslistPost' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/Marketing.Data")]
    public sealed partial class CraigslistPost : Entity
    {
        
        private EntityCollection<CraigsListResponse> _craigsListResponses;
        
        private string _emailAddress;
        
        private Guid _id;
        
        private DateTime _postDate;
        
        private long _postId;
        
        private string _postsElement;
        
        private string _title;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnEmailAddressChanging(string value);
        partial void OnEmailAddressChanged();
        partial void OnIdChanging(Guid value);
        partial void OnIdChanged();
        partial void OnPostDateChanging(DateTime value);
        partial void OnPostDateChanged();
        partial void OnPostIdChanging(long value);
        partial void OnPostIdChanged();
        partial void OnPostsElementChanging(string value);
        partial void OnPostsElementChanged();
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="CraigslistPost"/> class.
        /// </summary>
        public CraigslistPost()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the collection of associated <see cref="CraigsListResponse"/> entity instances.
        /// </summary>
        [Association("CraigslistPost_CraigsListResponse", "Id", "CraigslitPostsId")]
        [XmlIgnore()]
        public EntityCollection<CraigsListResponse> CraigsListResponses
        {
            get
            {
                if ((this._craigsListResponses == null))
                {
                    this._craigsListResponses = new EntityCollection<CraigsListResponse>(this, "CraigsListResponses", this.FilterCraigsListResponses, this.AttachCraigsListResponses, this.DetachCraigsListResponses);
                }
                return this._craigsListResponses;
            }
        }
        
        /// <summary>
        /// Gets or sets the 'EmailAddress' value.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(255)]
        public string EmailAddress
        {
            get
            {
                return this._emailAddress;
            }
            set
            {
                if ((this._emailAddress != value))
                {
                    this.OnEmailAddressChanging(value);
                    this.RaiseDataMemberChanging("EmailAddress");
                    this.ValidateProperty("EmailAddress", value);
                    this._emailAddress = value;
                    this.RaiseDataMemberChanged("EmailAddress");
                    this.OnEmailAddressChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Id' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public Guid Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnIdChanging(value);
                    this.ValidateProperty("Id", value);
                    this._id = value;
                    this.RaisePropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'PostDate' value.
        /// </summary>
        [DataMember()]
        public DateTime PostDate
        {
            get
            {
                return this._postDate;
            }
            set
            {
                if ((this._postDate != value))
                {
                    this.OnPostDateChanging(value);
                    this.RaiseDataMemberChanging("PostDate");
                    this.ValidateProperty("PostDate", value);
                    this._postDate = value;
                    this.RaiseDataMemberChanged("PostDate");
                    this.OnPostDateChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'PostId' value.
        /// </summary>
        [DataMember()]
        public long PostId
        {
            get
            {
                return this._postId;
            }
            set
            {
                if ((this._postId != value))
                {
                    this.OnPostIdChanging(value);
                    this.RaiseDataMemberChanging("PostId");
                    this.ValidateProperty("PostId", value);
                    this._postId = value;
                    this.RaiseDataMemberChanged("PostId");
                    this.OnPostIdChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'PostsElement' value.
        /// </summary>
        [DataMember()]
        [Required()]
        public string PostsElement
        {
            get
            {
                return this._postsElement;
            }
            set
            {
                if ((this._postsElement != value))
                {
                    this.OnPostsElementChanging(value);
                    this.RaiseDataMemberChanging("PostsElement");
                    this.ValidateProperty("PostsElement", value);
                    this._postsElement = value;
                    this.RaiseDataMemberChanged("PostsElement");
                    this.OnPostsElementChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Title' value.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(255)]
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                if ((this._title != value))
                {
                    this.OnTitleChanging(value);
                    this.RaiseDataMemberChanging("Title");
                    this.ValidateProperty("Title", value);
                    this._title = value;
                    this.RaiseDataMemberChanged("Title");
                    this.OnTitleChanged();
                }
            }
        }
        
        private void AttachCraigsListResponses(CraigsListResponse entity)
        {
            entity.CraigslistPost = this;
        }
        
        private void DetachCraigsListResponses(CraigsListResponse entity)
        {
            entity.CraigslistPost = null;
        }
        
        private bool FilterCraigsListResponses(CraigsListResponse entity)
        {
            return (entity.CraigslitPostsId == this.Id);
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._id;
        }
    }
    
    /// <summary>
    /// The 'CraigsListResponse' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/Marketing.Data")]
    public sealed partial class CraigsListResponse : Entity
    {
        
        private EntityRef<CraigslistPost> _craigslistPost;
        
        private Guid _craigslitPostsId;
        
        private DateTime _created;
        
        private Guid _id;
        
        private string _responseContent;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnCraigslitPostsIdChanging(Guid value);
        partial void OnCraigslitPostsIdChanged();
        partial void OnCreatedChanging(DateTime value);
        partial void OnCreatedChanged();
        partial void OnIdChanging(Guid value);
        partial void OnIdChanged();
        partial void OnResponseContentChanging(string value);
        partial void OnResponseContentChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="CraigsListResponse"/> class.
        /// </summary>
        public CraigsListResponse()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the associated <see cref="CraigslistPost"/> entity.
        /// </summary>
        [Association("CraigslistPost_CraigsListResponse", "CraigslitPostsId", "Id", IsForeignKey=true)]
        [XmlIgnore()]
        public CraigslistPost CraigslistPost
        {
            get
            {
                if ((this._craigslistPost == null))
                {
                    this._craigslistPost = new EntityRef<CraigslistPost>(this, "CraigslistPost", this.FilterCraigslistPost);
                }
                return this._craigslistPost.Entity;
            }
            set
            {
                CraigslistPost previous = this.CraigslistPost;
                if ((previous != value))
                {
                    this.ValidateProperty("CraigslistPost", value);
                    if ((previous != null))
                    {
                        this._craigslistPost.Entity = null;
                        previous.CraigsListResponses.Remove(this);
                    }
                    if ((value != null))
                    {
                        this.CraigslitPostsId = value.Id;
                    }
                    else
                    {
                        this.CraigslitPostsId = default(Guid);
                    }
                    this._craigslistPost.Entity = value;
                    if ((value != null))
                    {
                        value.CraigsListResponses.Add(this);
                    }
                    this.RaisePropertyChanged("CraigslistPost");
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'CraigslitPostsId' value.
        /// </summary>
        [DataMember()]
        [RoundtripOriginal()]
        public Guid CraigslitPostsId
        {
            get
            {
                return this._craigslitPostsId;
            }
            set
            {
                if ((this._craigslitPostsId != value))
                {
                    this.OnCraigslitPostsIdChanging(value);
                    this.RaiseDataMemberChanging("CraigslitPostsId");
                    this.ValidateProperty("CraigslitPostsId", value);
                    this._craigslitPostsId = value;
                    this.RaiseDataMemberChanged("CraigslitPostsId");
                    this.OnCraigslitPostsIdChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Created' value.
        /// </summary>
        [DataMember()]
        public DateTime Created
        {
            get
            {
                return this._created;
            }
            set
            {
                if ((this._created != value))
                {
                    this.OnCreatedChanging(value);
                    this.RaiseDataMemberChanging("Created");
                    this.ValidateProperty("Created", value);
                    this._created = value;
                    this.RaiseDataMemberChanged("Created");
                    this.OnCreatedChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Id' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public Guid Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnIdChanging(value);
                    this.ValidateProperty("Id", value);
                    this._id = value;
                    this.RaisePropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'ResponseContent' value.
        /// </summary>
        [DataMember()]
        [Required()]
        public string ResponseContent
        {
            get
            {
                return this._responseContent;
            }
            set
            {
                if ((this._responseContent != value))
                {
                    this.OnResponseContentChanging(value);
                    this.RaiseDataMemberChanging("ResponseContent");
                    this.ValidateProperty("ResponseContent", value);
                    this._responseContent = value;
                    this.RaiseDataMemberChanged("ResponseContent");
                    this.OnResponseContentChanged();
                }
            }
        }
        
        private bool FilterCraigslistPost(CraigslistPost entity)
        {
            return (entity.Id == this.CraigslitPostsId);
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._id;
        }
    }
    
    /// <summary>
    /// The 'Dumbell' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/Marketing.Data")]
    public sealed partial class Dumbell : Entity
    {
        
        private string _dumbellName;
        
        private Guid _id;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnDumbellNameChanging(string value);
        partial void OnDumbellNameChanged();
        partial void OnIdChanging(Guid value);
        partial void OnIdChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Dumbell"/> class.
        /// </summary>
        public Dumbell()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'DumbellName' value.
        /// </summary>
        [DataMember()]
        [Required()]
        public string DumbellName
        {
            get
            {
                return this._dumbellName;
            }
            set
            {
                if ((this._dumbellName != value))
                {
                    this.OnDumbellNameChanging(value);
                    this.RaiseDataMemberChanging("DumbellName");
                    this.ValidateProperty("DumbellName", value);
                    this._dumbellName = value;
                    this.RaiseDataMemberChanged("DumbellName");
                    this.OnDumbellNameChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Id' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public Guid Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnIdChanging(value);
                    this.ValidateProperty("Id", value);
                    this._id = value;
                    this.RaisePropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._id;
        }
    }
}
namespace Marketing.Services.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel;
    using System.ServiceModel.DomainServices;
    using System.ServiceModel.DomainServices.Client;
    using System.ServiceModel.DomainServices.Client.ApplicationServices;
    using System.ServiceModel.Web;
    using Marketing.Data;
    
    
    /// <summary>
    /// The DomainContext corresponding to the 'MarketingDomainService' DomainService.
    /// </summary>
    public sealed partial class MarketingDomainContext : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketingDomainContext"/> class.
        /// </summary>
        public MarketingDomainContext() : 
                this(new WebDomainClient<IMarketingDomainServiceContract>(new Uri("Marketing-Services-Web-MarketingDomainService.svc", UriKind.Relative)))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketingDomainContext"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The MarketingDomainService service URI.</param>
        public MarketingDomainContext(Uri serviceUri) : 
                this(new WebDomainClient<IMarketingDomainServiceContract>(serviceUri))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketingDomainContext"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public MarketingDomainContext(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="CraigslistPost"/> entity instances that have been loaded into this <see cref="MarketingDomainContext"/> instance.
        /// </summary>
        public EntitySet<CraigslistPost> CraigslistPosts
        {
            get
            {
                return base.EntityContainer.GetEntitySet<CraigslistPost>();
            }
        }
        
        /// <summary>
        /// Gets the set of <see cref="CraigsListResponse"/> entity instances that have been loaded into this <see cref="MarketingDomainContext"/> instance.
        /// </summary>
        public EntitySet<CraigsListResponse> CraigsListResponses
        {
            get
            {
                return base.EntityContainer.GetEntitySet<CraigsListResponse>();
            }
        }
        
        /// <summary>
        /// Gets the set of <see cref="Dumbell"/> entity instances that have been loaded into this <see cref="MarketingDomainContext"/> instance.
        /// </summary>
        public EntitySet<Dumbell> Dumbells
        {
            get
            {
                return base.EntityContainer.GetEntitySet<Dumbell>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="CraigslistPost"/> entity instances using the 'GetCraigslistPosts' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="CraigslistPost"/> entity instances.</returns>
        public EntityQuery<CraigslistPost> GetCraigslistPostsQuery()
        {
            this.ValidateMethod("GetCraigslistPostsQuery", null);
            return base.CreateQuery<CraigslistPost>("GetCraigslistPosts", null, false, true);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="CraigsListResponse"/> entity instances using the 'GetCraigsListResponses' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="CraigsListResponse"/> entity instances.</returns>
        public EntityQuery<CraigsListResponse> GetCraigsListResponsesQuery()
        {
            this.ValidateMethod("GetCraigsListResponsesQuery", null);
            return base.CreateQuery<CraigsListResponse>("GetCraigsListResponses", null, false, true);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="Dumbell"/> entity instances using the 'GetDumbells' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="Dumbell"/> entity instances.</returns>
        public EntityQuery<Dumbell> GetDumbellsQuery()
        {
            this.ValidateMethod("GetDumbellsQuery", null);
            return base.CreateQuery<Dumbell>("GetDumbells", null, false, true);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new MarketingDomainContextEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'MarketingDomainService' DomainService.
        /// </summary>
        [ServiceContract()]
        public interface IMarketingDomainServiceContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetCraigslistPosts' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/MarketingDomainService/GetCraigslistPostsDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/MarketingDomainService/GetCraigslistPosts", ReplyAction="http://tempuri.org/MarketingDomainService/GetCraigslistPostsResponse")]
            [WebGet()]
            IAsyncResult BeginGetCraigslistPosts(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetCraigslistPosts'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetCraigslistPosts'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetCraigslistPosts' operation.</returns>
            QueryResult<CraigslistPost> EndGetCraigslistPosts(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'GetCraigsListResponses' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/MarketingDomainService/GetCraigsListResponsesDomainServiceFaul" +
                "t", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/MarketingDomainService/GetCraigsListResponses", ReplyAction="http://tempuri.org/MarketingDomainService/GetCraigsListResponsesResponse")]
            [WebGet()]
            IAsyncResult BeginGetCraigsListResponses(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetCraigsListResponses'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetCraigsListResponses'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetCraigsListResponses' operation.</returns>
            QueryResult<CraigsListResponse> EndGetCraigsListResponses(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'GetDumbells' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/MarketingDomainService/GetDumbellsDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/MarketingDomainService/GetDumbells", ReplyAction="http://tempuri.org/MarketingDomainService/GetDumbellsResponse")]
            [WebGet()]
            IAsyncResult BeginGetDumbells(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetDumbells'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetDumbells'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetDumbells' operation.</returns>
            QueryResult<Dumbell> EndGetDumbells(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'SubmitChanges' operation.
            /// </summary>
            /// <param name="changeSet">The change-set to submit.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/MarketingDomainService/SubmitChangesDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/MarketingDomainService/SubmitChanges", ReplyAction="http://tempuri.org/MarketingDomainService/SubmitChangesResponse")]
            IAsyncResult BeginSubmitChanges(IEnumerable<ChangeSetEntry> changeSet, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            /// <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            IEnumerable<ChangeSetEntry> EndSubmitChanges(IAsyncResult result);
        }
        
        internal sealed class MarketingDomainContextEntityContainer : EntityContainer
        {
            
            public MarketingDomainContextEntityContainer()
            {
                this.CreateEntitySet<CraigslistPost>(EntitySetOperations.All);
                this.CreateEntitySet<CraigsListResponse>(EntitySetOperations.All);
                this.CreateEntitySet<Dumbell>(EntitySetOperations.All);
            }
        }
    }
}
