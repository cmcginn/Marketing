using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Marketing.Data;
using System.Collections.Specialized;
namespace Marketing.Services.Extensions {
  public static class DomainExtensions {
    public static IQueryable<UserCitySelection> GetUserCitySelectionFromContext( this MarketingEntities context, Guid userId ) {
      var query = from city in context.Cities
                  join uc in context.UserCities
                  on city.Id equals uc.CityId into usc
                  from item in usc.DefaultIfEmpty()
                  select new UserCitySelection { Id = item.Id != Guid.Empty ? item.Id : Guid.NewGuid(), Active = item.Active != null ? item.Active : true, CityId = city.Id, CityName = city.CityName, RegionName = city.RegionName, UserId = item.UserId != Guid.Empty ? item.UserId : userId, Selected = item != null };

      return query.AsQueryable();
    }
    
    public static IQueryable<UserCitySelection> GetUserCitySelectionFromContext( this MarketingEntities context ) {
      return context.GetUserCitySelectionFromContext( Guid.Empty );
    }
  }
}
