using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeadScraper.Utils.Extensions {
  public static class StringExtensions {
    public static string ConvertToString( this byte[] raw ) {
      String result = new String( raw.Select( n => ( char )n ).ToArray() ).Replace( "ï¿½", "" );
      return result;
    }
  }
}
