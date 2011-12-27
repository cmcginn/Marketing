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
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    public sealed partial class Preferences
        : global::Microsoft.LightSwitch.Framework.Client.ScreenObject<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass>
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private Preferences(global::System.Nullable<global::System.Guid> UserId) : base("LightSwitchApplication:Preferences")
        {
                this.UserId = UserId;
            global::LightSwitchApplication.Preferences.DetailsClass.Initialize(this);
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static Preferences CreateInstance(global::System.Nullable<global::System.Guid> UserId)
        {
            return new global::LightSwitchApplication.Preferences(
                        UserId
            );
        }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Preferences_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Preferences_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Preferences_Activated();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Preferences_Saving(ref bool handled);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Preferences_Saved();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Preferences_Closing(ref bool cancel);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Preferences_SaveError(global::System.Exception exception, ref bool handled);
     
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.Application Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)((global::Microsoft.LightSwitch.Details.Client.IScreenDetails)this.Details).DataWorkspace;
            }
        }
        
        #endregion
 
        partial void UserCitySelections_SelectionChanged();

        partial void UserCitySelections_Changed(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e);

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void UserCitySelections_Loaded(bool succeeded);

        partial void GetUserCitySelections_SelectionChanged();

        partial void GetUserCitySelections_Changed(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e);

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void GetUserCitySelections_Loaded(bool succeeded);

        partial void UserId_Changed();

        partial void GetUserCategorySelections_SelectionChanged();

        partial void GetUserCategorySelections_Changed(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e);

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void GetUserCategorySelections_Loaded(bool succeeded);

        /// <summary>
        /// Gets the UserCitySelections visual collection. The collection contains all records currently shown on the respective list or grid control.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.Client.VisualCollection<global::LightSwitchApplication.UserCitySelection> UserCitySelections
        {
            get
            {
                return global::LightSwitchApplication.Preferences.DetailsClass.GetValue(this, global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties.UserCitySelections);
            }
        }
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void UserCitySelections_Validate(global::Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder results);
 
        /// <summary>
        /// Gets the GetUserCitySelections visual collection. The collection contains all records currently shown on the respective list or grid control.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.Client.VisualCollection<global::LightSwitchApplication.UserCitySelection> GetUserCitySelections
        {
            get
            {
                return global::LightSwitchApplication.Preferences.DetailsClass.GetValue(this, global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties.GetUserCitySelections);
            }
        }
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void GetUserCitySelections_Validate(global::Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder results);
 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Nullable<global::System.Guid> UserId
        {
            get 
            {
                return global::LightSwitchApplication.Preferences.DetailsClass.GetValue(this, global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties.UserId);
            }
            set
            {
                global::LightSwitchApplication.Preferences.DetailsClass.SetValue(this, global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties.UserId, value);
            }
        }
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void UserId_Validate(global::Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder results);
 
        /// <summary>
        /// Gets the GetUserCategorySelections visual collection. The collection contains all records currently shown on the respective list or grid control.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.Client.VisualCollection<global::LightSwitchApplication.UserListingCategorySelection> GetUserCategorySelections
        {
            get
            {
                return global::LightSwitchApplication.Preferences.DetailsClass.GetValue(this, global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties.GetUserCategorySelections);
            }
        }
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void GetUserCategorySelections_Validate(global::Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder results);
 
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass
            : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenDetails<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.Preferences.DetailsClass.PropertySet, global::LightSwitchApplication.Preferences.DetailsClass.CommandSet, global::LightSwitchApplication.Preferences.DetailsClass.MethodSet>
        {

            static DetailsClass()
            {
                var initializePropertyEntry = global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties.UserCitySelections;
            }

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static global::Microsoft.LightSwitch.Details.Framework.Client.ScreenDetails<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass>.Entry
                __PreferencesEntry = new global::Microsoft.LightSwitch.Details.Framework.Client.ScreenDetails<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass>.Entry(
                    global::LightSwitchApplication.Preferences.DetailsClass.__Preferences_InvokeInitializeDataWorkspace,
                    global::LightSwitchApplication.Preferences.DetailsClass.__Preferences_InvokeSavingEvent,
                    global::LightSwitchApplication.Preferences.DetailsClass.__Preferences_InvokeSavedEvent,
                    global::LightSwitchApplication.Preferences.DetailsClass.__Preferences_InvokeClosingEvent,
                    global::LightSwitchApplication.Preferences.DetailsClass.__Preferences_InvokeCreated,
                    global::LightSwitchApplication.Preferences.DetailsClass.__Preferences_InvokeActivated,
                    global::LightSwitchApplication.Preferences.DetailsClass.__Preferences_InvokeSaveErrorEvent);
            private static void __Preferences_InvokeInitializeDataWorkspace(global::LightSwitchApplication.Preferences s, global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
            {
                s.Preferences_InitializeDataWorkspace(saveChangesTo);
            }
            private static bool __Preferences_InvokeSavingEvent(global::LightSwitchApplication.Preferences s)
            {
                bool handled = false;
                s.Preferences_Saving(ref handled);
                return handled;
            }
            private static void __Preferences_InvokeSavedEvent(global::LightSwitchApplication.Preferences s)
            {
                s.Preferences_Saved();
            }
            private static bool __Preferences_InvokeClosingEvent(global::LightSwitchApplication.Preferences s)
            {
                bool cancel = false;
                s.Preferences_Closing(ref cancel);
                return cancel;
            }
            private static void __Preferences_InvokeCreated(global::LightSwitchApplication.Preferences s)
            {
                s.Preferences_Created();
            }
            private static void __Preferences_InvokeActivated(global::LightSwitchApplication.Preferences s)
            {
                s.Preferences_Activated();
            }
            private static bool __Preferences_InvokeSaveErrorEvent(global::LightSwitchApplication.Preferences s, global::System.Exception ex)
            {
                bool handled = false;
                s.Preferences_SaveError(ex, ref handled);
                return handled;
            }

            public DetailsClass() : base()
            {
            }

            public new global::LightSwitchApplication.Preferences.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }

            public new global::LightSwitchApplication.Preferences.DetailsClass.CommandSet Commands
            {
                get
                {
                    return base.Commands;
                }
            }

            public new global::LightSwitchApplication.Preferences.DetailsClass.MethodSet Methods
            {
                get
                {
                    return base.Methods;
                }
            }

            private global::Microsoft.LightSwitch.IDataServiceQueryable UserCitySelectionsQuery()
            {
                return this.Screen.DataWorkspace.MarketingDomainServiceData.UserCitySelections;
            }

            private global::Microsoft.LightSwitch.IDataServiceQueryable GetUserCitySelectionsQuery(global::System.Nullable<global::System.Guid> userId)
            {
                return this.Screen.DataWorkspace.MarketingDomainServiceData.GetUserCitySelections(userId);
            }

            private global::Microsoft.LightSwitch.IDataServiceQueryable GetUserCategorySelectionsQuery(global::System.Nullable<global::System.Guid> userId)
            {
                return this.Screen.DataWorkspace.MarketingDomainServiceData.GetUserCategorySelections(userId);
            }

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserCitySelection>.Data _UserCitySelections;

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserCitySelection>.Data _GetUserCitySelections;

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.Client.ScreenLocalProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::System.Nullable<global::System.Guid>>.Data _UserId;

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserListingCategorySelection>.Data _GetUserCategorySelections;

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenPropertySet<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass>
            {

                public global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserCitySelection> UserCitySelections
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserCitySelection>)base.GetItem(global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties.UserCitySelections);
                    }
                }

                public global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserCitySelection> GetUserCitySelections
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserCitySelection>)base.GetItem(global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties.GetUserCitySelections);
                    }
                }

                public global::Microsoft.LightSwitch.Details.Framework.Client.ScreenLocalProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::System.Nullable<global::System.Guid>> UserId
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.Client.ScreenLocalProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::System.Nullable<global::System.Guid>>)base.GetItem(global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties.UserId);
                    }
                }

                public global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserListingCategorySelection> GetUserCategorySelections
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserListingCategorySelection>)base.GetItem(global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties.GetUserCategorySelections);
                    }
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class CommandSet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCommandSet<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass>
            {
            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class MethodSet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenMethodSet<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass>
            {
            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class PropertySetProperties
            {

                public static readonly global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserCitySelection>.Entry
                    UserCitySelections = new global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserCitySelection>.Entry(
                        "UserCitySelections",
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._UserCitySelections_Stub,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._UserCitySelections_Validate,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._UserCitySelections_CreateQuery,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._UserCitySelections_SelectionChanged,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._UserCitySelections_OnCollectionChanged,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._UserCitySelections_OnLoaded);
                private static void _UserCitySelections_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Preferences.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserCitySelection>.Data> c, global::LightSwitchApplication.Preferences.DetailsClass d, object sf)
                {
                    c(d, ref d._UserCitySelections, sf);
                }
                private static void _UserCitySelections_Validate(global::LightSwitchApplication.Preferences s, global::Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder r)
                {
                    s.UserCitySelections_Validate(r);
                }
                private static global::Microsoft.LightSwitch.IDataServiceQueryable _UserCitySelections_CreateQuery(global::LightSwitchApplication.Preferences.DetailsClass d, object[] args)
                {
                    return d.UserCitySelectionsQuery();
                }
                private static void _UserCitySelections_SelectionChanged(global::LightSwitchApplication.Preferences s)
                {
                    s.UserCitySelections_SelectionChanged();
                }
                private static void _UserCitySelections_OnCollectionChanged(global::LightSwitchApplication.Preferences s, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    s.UserCitySelections_Changed(e);
                }
                private static void _UserCitySelections_OnLoaded(global::LightSwitchApplication.Preferences s, bool succeeded)
                {
                    s.UserCitySelections_Loaded(succeeded);
                }

                public static readonly global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserCitySelection>.Entry
                    GetUserCitySelections = new global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserCitySelection>.Entry(
                        "GetUserCitySelections",
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._GetUserCitySelections_Stub,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._GetUserCitySelections_Validate,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._GetUserCitySelections_CreateQuery,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._GetUserCitySelections_SelectionChanged,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._GetUserCitySelections_OnCollectionChanged,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._GetUserCitySelections_OnLoaded);
                private static void _GetUserCitySelections_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Preferences.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserCitySelection>.Data> c, global::LightSwitchApplication.Preferences.DetailsClass d, object sf)
                {
                    c(d, ref d._GetUserCitySelections, sf);
                }
                private static void _GetUserCitySelections_Validate(global::LightSwitchApplication.Preferences s, global::Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder r)
                {
                    s.GetUserCitySelections_Validate(r);
                }
                private static global::Microsoft.LightSwitch.IDataServiceQueryable _GetUserCitySelections_CreateQuery(global::LightSwitchApplication.Preferences.DetailsClass d, object[] args)
                {
                    return d.GetUserCitySelectionsQuery((global::System.Nullable<global::System.Guid>)args[0]);
                }
                private static void _GetUserCitySelections_SelectionChanged(global::LightSwitchApplication.Preferences s)
                {
                    s.GetUserCitySelections_SelectionChanged();
                }
                private static void _GetUserCitySelections_OnCollectionChanged(global::LightSwitchApplication.Preferences s, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    s.GetUserCitySelections_Changed(e);
                }
                private static void _GetUserCitySelections_OnLoaded(global::LightSwitchApplication.Preferences s, bool succeeded)
                {
                    s.GetUserCitySelections_Loaded(succeeded);
                }

                public static readonly global::Microsoft.LightSwitch.Details.Framework.Client.ScreenLocalProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::System.Nullable<global::System.Guid>>.Entry
                    UserId = new global::Microsoft.LightSwitch.Details.Framework.Client.ScreenLocalProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::System.Nullable<global::System.Guid>>.Entry(
                        "UserId",
                        false,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._UserId_Stub,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._UserId_Validate,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._UserId_OnValueChanged);
                private static void _UserId_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Preferences.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.Client.ScreenLocalProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::System.Nullable<global::System.Guid>>.Data> c, global::LightSwitchApplication.Preferences.DetailsClass d, object sf)
                {
                    c(d, ref d._UserId, sf);
                }
                private static void _UserId_Validate(global::LightSwitchApplication.Preferences s, global::Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder r)
                {
                    s.UserId_Validate(r);
                }
                private static void _UserId_OnValueChanged(global::LightSwitchApplication.Preferences s)
                {
                    s.UserId_Changed();
                }

                public static readonly global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserListingCategorySelection>.Entry
                    GetUserCategorySelections = new global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserListingCategorySelection>.Entry(
                        "GetUserCategorySelections",
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._GetUserCategorySelections_Stub,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._GetUserCategorySelections_Validate,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._GetUserCategorySelections_CreateQuery,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._GetUserCategorySelections_SelectionChanged,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._GetUserCategorySelections_OnCollectionChanged,
                        global::LightSwitchApplication.Preferences.DetailsClass.PropertySetProperties._GetUserCategorySelections_OnLoaded);
                private static void _GetUserCategorySelections_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Preferences.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.Preferences, global::LightSwitchApplication.Preferences.DetailsClass, global::LightSwitchApplication.UserListingCategorySelection>.Data> c, global::LightSwitchApplication.Preferences.DetailsClass d, object sf)
                {
                    c(d, ref d._GetUserCategorySelections, sf);
                }
                private static void _GetUserCategorySelections_Validate(global::LightSwitchApplication.Preferences s, global::Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder r)
                {
                    s.GetUserCategorySelections_Validate(r);
                }
                private static global::Microsoft.LightSwitch.IDataServiceQueryable _GetUserCategorySelections_CreateQuery(global::LightSwitchApplication.Preferences.DetailsClass d, object[] args)
                {
                    return d.GetUserCategorySelectionsQuery((global::System.Nullable<global::System.Guid>)args[0]);
                }
                private static void _GetUserCategorySelections_SelectionChanged(global::LightSwitchApplication.Preferences s)
                {
                    s.GetUserCategorySelections_SelectionChanged();
                }
                private static void _GetUserCategorySelections_OnCollectionChanged(global::LightSwitchApplication.Preferences s, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    s.GetUserCategorySelections_Changed(e);
                }
                private static void _GetUserCategorySelections_OnLoaded(global::LightSwitchApplication.Preferences s, bool succeeded)
                {
                    s.GetUserCategorySelections_Loaded(succeeded);
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class CommandSetProperties
            {
            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class MethodSetProperties
            {
            }
        }
    }
}
