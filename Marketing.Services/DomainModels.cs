using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Marketing.Services {
  public class UserCitySelection {
    [Key]
    public Guid Id { get; set; }
    public bool Selected { get; set; }
    public Guid CityId { get; set; }
    public Guid UserId { get; set; }
    public string CityName { get; set; }
    public string RegionName { get; set; }
    public bool Active { get; set; }
  }
  public class UserListingCategorySelection {
    [Key]
    public Guid Id { get; set; }
    public bool Selected { get; set; }
    public string CategoryName { get; set; }
    public Guid CategoryId { get; set; }
    public Guid UserId { get; set; }
    public string GroupName { get; set; }
    public bool Active { get; set; }
  }
}
