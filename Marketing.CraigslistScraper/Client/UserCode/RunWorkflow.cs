using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class RunWorkflow
    {
        

        void LoadParameters() {          
          if( !String.IsNullOrEmpty( Operation.Parameters ) ) {
            var parameters = Operation.Parameters.Split( ';' ).Select( x => x.Split( '=' ) ).ToDictionary( x => x.ElementAt( 0 ), x => x.ElementAt( 1 ) );
            parameters.ToList().ForEach( x => {
              switch( x.Key ) {
                case "UserId":
                  parameters[x.Key] = this.Application.UserId.ToString();
                  break;
                default:
                  parameters[ x.Key ] = "NULL";
                  break;
              }
            } );
            Operation.Parameters = String.Join( ";", parameters.Select( x => String.Format( "{0}={1}", x.Key, x.Value ) ) );
          }
          
        }
        partial void Operation_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Operation);
        }

        partial void Operation_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Operation);
        }

        partial void RunWorkflow_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Operation);
        }


        partial void RunWorkflow_InitializeDataWorkspace( List<IDataService> saveChangesTo ) {
          // Write your code here.
          Operation.UserId = this.Application.UserId;
        }
    }
}