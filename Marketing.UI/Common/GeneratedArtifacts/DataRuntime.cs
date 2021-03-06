
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Data Workspace
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class DataWorkspace : global::Microsoft.LightSwitch.Framework.Base.DataWorkspace<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of a DataWorkspace.  Changes can be made to data sources in the new instance independent of changes made to data sources in the default DataWorkspace.
        /// </summary>
        public DataWorkspace() : base()
        {
        }
    
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// Gets the MarketingDomainServiceData datasource.  This provides members to query and update data in the data source.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.MarketingDomainServiceData MarketingDomainServiceData
        {
            get
            {
                return global::LightSwitchApplication.DataWorkspace.DetailsClass.GetValue(this, global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties.MarketingDomainServiceData);
            }
        }
        
        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.DataWorkspaceDetails<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySet>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties.MarketingDomainServiceData;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.DataWorkspacePropertySet<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.MarketingDomainServiceData> MarketingDomainServiceData
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties.MarketingDomainServiceData) as global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.MarketingDomainServiceData>;
                    }
                }
                
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.MarketingDomainServiceData>.Entry
                    MarketingDomainServiceData = new global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.MarketingDomainServiceData>.Entry(
                        "MarketingDomainServiceData",
                        global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties._MarketingDomainServiceData_Stub);
                private static void _MarketingDomainServiceData_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.DataWorkspace.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.MarketingDomainServiceData>.Data> c, global::LightSwitchApplication.DataWorkspace.DetailsClass d, object sf)
                {
                    c(d, ref d._MarketingDomainServiceData, sf);
                }
                 
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.MarketingDomainServiceData>.Data _MarketingDomainServiceData;
            
        }
    
        #endregion
    }
    
    #endregion
    
    #region Data Services
    
    /// <summary>
    /// Provides members to query and update data in the MarketingDomainServiceData datasource.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MarketingDomainServiceData : global::Microsoft.LightSwitch.Framework.Base.DataService<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass>
    {
        #region Constructors
    
        public MarketingDomainServiceData() : base()
        {
        }
    
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// Gets the CraigslistPosts entity set.  The entity set provides members to access entities of a specific type.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.CraigslistPost> CraigslistPosts
        {
            get
            {
                return global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.GetValue(this, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.PropertySetProperties.CraigslistPosts);
            }
        }
        
        /// <summary>
        /// Gets the CraigsListResponses entity set.  The entity set provides members to access entities of a specific type.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.CraigsListResponse> CraigsListResponses
        {
            get
            {
                return global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.GetValue(this, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.PropertySetProperties.CraigsListResponses);
            }
        }
        
        #endregion
    
        #region Queries
    
        /// <summary>
        /// Returns the entity whose identity is specified by the parameter(s).
        /// </summary>
        /// <param name="Id">
        /// The value of the 'Id' key property of the entity to retrieve.
        /// </param>
        public global::LightSwitchApplication.CraigslistPost CraigslistPosts_Single(global::System.Nullable<global::System.Guid> Id)
        {
            return this.Details.Methods.CraigslistPosts_Single.CreateInvocation(Id).Execute();
        }
        
        /// <summary>
        /// Returns the entity whose identity is specified by the parameter(s) or null if no such entity exists.
        /// </summary>
        /// <param name="Id">
        /// The value of the 'Id' key property of the entity to retrieve.
        /// </param>
        public global::LightSwitchApplication.CraigslistPost CraigslistPosts_SingleOrDefault(global::System.Nullable<global::System.Guid> Id)
        {
            return this.Details.Methods.CraigslistPosts_SingleOrDefault.CreateInvocation(Id).Execute();
        }
        
        /// <summary>
        /// Returns the entity whose identity is specified by the parameter(s).
        /// </summary>
        /// <param name="Id">
        /// The value of the 'Id' key property of the entity to retrieve.
        /// </param>
        public global::LightSwitchApplication.CraigsListResponse CraigsListResponses_Single(global::System.Nullable<global::System.Guid> Id)
        {
            return this.Details.Methods.CraigsListResponses_Single.CreateInvocation(Id).Execute();
        }
        
        /// <summary>
        /// Returns the entity whose identity is specified by the parameter(s) or null if no such entity exists.
        /// </summary>
        /// <param name="Id">
        /// The value of the 'Id' key property of the entity to retrieve.
        /// </param>
        public global::LightSwitchApplication.CraigsListResponse CraigsListResponses_SingleOrDefault(global::System.Nullable<global::System.Guid> Id)
        {
            return this.Details.Methods.CraigsListResponses_SingleOrDefault.CreateInvocation(Id).Execute();
        }
        
        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.DataServiceDetails<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.PropertySet, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.MethodSet>
        {
    
            static DetailsClass()
            {
                var initializeMethodEntry = global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.MethodSetProperties.CraigslistPosts_Single;
                var initializePropertyEntry = global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.PropertySetProperties.CraigslistPosts;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.MethodSet Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class MethodSet : global::Microsoft.LightSwitch.Details.Framework.Base.DataServiceMethodSet<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass>
            {
    
                public MethodSet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost> CraigslistPosts_Single
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.MethodSetProperties.CraigslistPosts_Single) as global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost> CraigslistPosts_SingleOrDefault
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.MethodSetProperties.CraigslistPosts_SingleOrDefault) as global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse> CraigsListResponses_Single
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.MethodSetProperties.CraigsListResponses_Single) as global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse> CraigsListResponses_SingleOrDefault
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.MethodSetProperties.CraigsListResponses_SingleOrDefault) as global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse>;
                    }
                }
                
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.DataServicePropertySet<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost> CraigslistPosts
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.PropertySetProperties.CraigslistPosts) as global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse> CraigsListResponses
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.PropertySetProperties.CraigsListResponses) as global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse>;
                    }
                }
                
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class MethodSetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost>.Entry
                    CraigslistPosts_Single = new global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost>.Entry(
                        "CraigslistPosts_Single",
                        global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.MethodSetProperties._CraigslistPosts_Single_Stub);
                private static void _CraigslistPosts_Single_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost>.Data> c, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass d, object sf)
                {
                    c(d, ref d._CraigslistPosts_Single, sf);
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost>.Entry
                    CraigslistPosts_SingleOrDefault = new global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost>.Entry(
                        "CraigslistPosts_SingleOrDefault",
                        global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.MethodSetProperties._CraigslistPosts_SingleOrDefault_Stub);
                private static void _CraigslistPosts_SingleOrDefault_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost>.Data> c, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass d, object sf)
                {
                    c(d, ref d._CraigslistPosts_SingleOrDefault, sf);
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse>.Entry
                    CraigsListResponses_Single = new global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse>.Entry(
                        "CraigsListResponses_Single",
                        global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.MethodSetProperties._CraigsListResponses_Single_Stub);
                private static void _CraigsListResponses_Single_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse>.Data> c, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass d, object sf)
                {
                    c(d, ref d._CraigsListResponses_Single, sf);
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse>.Entry
                    CraigsListResponses_SingleOrDefault = new global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse>.Entry(
                        "CraigsListResponses_SingleOrDefault",
                        global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.MethodSetProperties._CraigsListResponses_SingleOrDefault_Stub);
                private static void _CraigsListResponses_SingleOrDefault_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse>.Data> c, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass d, object sf)
                {
                    c(d, ref d._CraigsListResponses_SingleOrDefault, sf);
                }
    
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost>.Entry
                    CraigslistPosts = new global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost>.Entry(
                        "CraigslistPosts",
                        global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.PropertySetProperties._CraigslistPosts_Stub);
                private static void _CraigslistPosts_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost>.Data> c, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass d, object sf)
                {
                    c(d, ref d._CraigslistPosts, sf);
                }
     
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse>.Entry
                    CraigsListResponses = new global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse>.Entry(
                        "CraigsListResponses",
                        global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass.PropertySetProperties._CraigsListResponses_Stub);
                private static void _CraigsListResponses_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse>.Data> c, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass d, object sf)
                {
                    c(d, ref d._CraigsListResponses, sf);
                }
     
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost>.Data _CraigslistPosts;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse>.Data _CraigsListResponses;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost>.Data _CraigslistPosts_Single;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigslistPost>.Data _CraigslistPosts_SingleOrDefault;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse>.Data _CraigsListResponses_Single;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.MarketingDomainServiceData, global::LightSwitchApplication.MarketingDomainServiceData.DetailsClass, global::LightSwitchApplication.CraigsListResponse>.Data _CraigsListResponses_SingleOrDefault;
            
        }
    
        #endregion
    }
    
    #endregion
    
}
