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
    public sealed partial class Application
        : global::Microsoft.LightSwitch.Framework.Client.ClientApplication<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass, global::LightSwitchApplication.DataWorkspace>
    {
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Application(global::Microsoft.LightSwitch.Model.IApplicationDefinition applicationDefinition) : base(applicationDefinition)
        {
            global::LightSwitchApplication.Application.DetailsClass.Initialize(this);
        }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Application_Initialize();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Application_LoggedIn();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static new global::LightSwitchApplication.Application Current
        {
            get
            {
                return (global::LightSwitchApplication.Application)global::Microsoft.LightSwitch.Framework.Client.ClientApplication<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Current;
            }
        }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CraigslistDetail_CanRun(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CraigslistDetail_Run(ref bool handled);
    
        /// <summary>
        /// Opens the ShowCraigslistDetail screen.  If the screen is already opened, it is activated and shown.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void ShowCraigslistDetail()
        {
            ((global::Microsoft.LightSwitch.Details.Client.IClientApplicationDetails)this.Details).InvokeMethod(this.Details.Methods.ShowCraigslistDetail);
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CreateNewCraigsListResponse_CanRun(ref bool result, global::System.Guid SelectedCraigslistPostId);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CreateNewCraigsListResponse_Run(ref bool handled, global::System.Guid SelectedCraigslistPostId);
    
        /// <summary>
        /// Opens a new instance of the ShowCreateNewCraigsListResponse screen.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void ShowCreateNewCraigsListResponse(global::System.Guid SelectedCraigslistPostId)
        {
            ((global::Microsoft.LightSwitch.Details.Client.IClientApplicationDetails)this.Details).InvokeMethod(this.Details.Methods.ShowCreateNewCraigsListResponse, SelectedCraigslistPostId);
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass
            : global::Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationDetails<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass, global::LightSwitchApplication.Application.DetailsClass.PropertySet, global::LightSwitchApplication.Application.DetailsClass.CommandSet, global::LightSwitchApplication.Application.DetailsClass.MethodSet>
        {

            static DetailsClass()
            {
                var initializeCommandEntry = global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties.ShowCraigslistDetail;
                var initializeMethodEntry = global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowCraigslistDetail;
            }

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationDetails<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                __ApplicationEntry = new global::Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationDetails<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                    global::LightSwitchApplication.Application.DetailsClass.__Application_Initialized,
                    global::LightSwitchApplication.Application.DetailsClass.__Application_LoggedIn);
            private static void __Application_Initialized(global::LightSwitchApplication.Application a)
            {
                a.Application_Initialize();
            }
            private static void __Application_LoggedIn(global::LightSwitchApplication.Application a)
            {
                a.Application_LoggedIn();
            }

            public DetailsClass() : base()
            {
            }

            public new global::LightSwitchApplication.Application.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }

            public new global::LightSwitchApplication.Application.DetailsClass.CommandSet Commands
            {
                get
                {
                    return base.Commands;
                }
            }

            public new global::LightSwitchApplication.Application.DetailsClass.MethodSet Methods
            {
                get
                {
                    return base.Methods;
                }
            }

            protected override global::Microsoft.LightSwitch.Client.IScreenObject CreateScreen(string screenName, params object[] args)
            {
                switch (screenName)
                {
                    case "CraigslistDetail":
                        return global::LightSwitchApplication.CraigslistDetail.CreateInstance();
                    case "CreateNewCraigsListResponse":
                        return global::LightSwitchApplication.CreateNewCraigsListResponse.CreateInstance((global::System.Guid)args[0]);
                }
            
                return base.CreateScreen(screenName, args);
            }
            
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationPropertySet<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>
            {

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class CommandSet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationCommandSet<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>
            {

                public global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowCraigslistDetail
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties.ShowCraigslistDetail);
                    }
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class MethodSet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationMethodSet<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>
            {

                public global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowCraigslistDetail
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowCraigslistDetail);
                    }
                }

                public global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowCreateNewCraigsListResponse
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowCreateNewCraigsListResponse);
                    }
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class PropertySetProperties
            {

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class CommandSetProperties
            {

                public static readonly global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowCraigslistDetail = new global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowCraigslistDetail",
                        global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowCraigslistDetail_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowCraigslistDetail_CreateExecutableObject);
                private static void _ShowCraigslistDetail_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowCraigslistDetailCommand, sf);
                }
                private static global::Microsoft.LightSwitch.IExecutable _ShowCraigslistDetail_CreateExecutableObject(global::LightSwitchApplication.Application.DetailsClass d)
                {
                    return ((global::LightSwitchApplication.Application.DetailsClass)d).Methods.ShowCraigslistDetail.CreateInvocation(new object[0]);
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class MethodSetProperties
            {

                public static readonly global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowCraigslistDetail = new global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowCraigslistDetail",
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowCraigslistDetail_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowCraigslistDetail_CanInvoke,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowCraigslistDetail_InvokeMethod);
                private static void _ShowCraigslistDetail_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowCraigslistDetailMethod, sf);
                }
                private static global::System.Exception _ShowCraigslistDetail_CanInvoke(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args, global::System.Exception ex)
                {
                    bool result = true;
                    d.Application.CraigslistDetail_CanRun(ref result);
                    return result ? null : ex;
                }
                private static void _ShowCraigslistDetail_InvokeMethod(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args)
                {
                    bool handled = false;
                    d.Application.CraigslistDetail_Run(ref handled);
                    if (!handled)
                    {
                        d.ShowScreen("LightSwitchApplication:CraigslistDetail", () => global::LightSwitchApplication.CraigslistDetail.CreateInstance(), args);
                    }
                }
 
                public static readonly global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowCreateNewCraigsListResponse = new global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowCreateNewCraigsListResponse",
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowCreateNewCraigsListResponse_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowCreateNewCraigsListResponse_CanInvoke,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowCreateNewCraigsListResponse_InvokeMethod);
                private static void _ShowCreateNewCraigsListResponse_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowCreateNewCraigsListResponseMethod, sf);
                }
                private static global::System.Exception _ShowCreateNewCraigsListResponse_CanInvoke(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args, global::System.Exception ex)
                {
                    bool result = true;
                    d.Application.CreateNewCraigsListResponse_CanRun(ref result, (global::System.Guid)args[0]);
                    return result ? null : ex;
                }
                private static void _ShowCreateNewCraigsListResponse_InvokeMethod(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args)
                {
                    bool handled = false;
                    d.Application.CreateNewCraigsListResponse_Run(ref handled, (global::System.Guid)args[0]);
                    if (!handled)
                    {
                        d.ShowScreen("LightSwitchApplication:CreateNewCraigsListResponse", () => global::LightSwitchApplication.CreateNewCraigsListResponse.CreateInstance((global::System.Guid)args[0]), args);
                    }
                }
 
            }

            private global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowCraigslistDetailMethod;

            private global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowCreateNewCraigsListResponseMethod;

            private global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowCraigslistDetailCommand;

        }
    }
}
