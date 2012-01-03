using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
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
  public class UserKeywordSelection {
    [Key]
    public Guid Id { get; set; }
    public string Keyword { get; set; }
    public int WeightedScore { get; set; }
    public Guid UserId { get; set; }
  }
  public class UserPreferenceSelection {
    [Key]
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public bool LiveMode { get; set; }
    public string BCCEmailAddress { get; set; }
  }
  public class UserListingItem {
    [Key]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string CategoryName { get; set; }
    public string GroupName { get; set; }
    public string RegionName { get; set;}
    public string CityName { get; set; }
    public DateTime Created { get; set; }
    public String PostElement { get; set; }
    public Guid UserId { get; set; }
    public DateTime? Responded { get; set; }
    public Guid? ResponseId { get; set; }
    public string Response { get; set; }
    public string ResponseText { get; set; }
  }
  public class UserListingResponseItem {
    [Key]
    public Guid Id { get; set; }
    public Guid UserListingUrlId { get; set; }
    public Guid UserId { get; set; }
    public DateTime Created { get; set; }
    public string Response { get; set; }
  }
}
