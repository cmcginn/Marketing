using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.Practices.EnterpriseLibrary.Logging;
namespace Marketing.Services {
 
  public class User {
    [Key]
    public Guid Id { get; set; }
    public string Username { get; set; }
  }
  public class UserCitySelection {
   
    public Guid Id { get; set; }
    public bool? Selected { get; set; }
     [Key]
    public Guid CityId { get; set; }
    public Guid UserId { get; set; }

    public string CityName { get; set; }
    public string RegionName { get; set; }
    public string StateProvince { get; set; }
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
    public string SMTPUsername { get; set; }
    public string SMTPPassword { get; set; }
    public string SMTPServer { get; set; }
    public int SMTPPort { get; set; }
    public bool RequiresSSL { get; set; }
    public int MinimumKeywordScore { get; set; }
  }
  public class UserListingItem {
    [Key]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string CategoryName { get; set; }
    public string GroupName { get; set; }
    public string RegionName { get; set;}
    public string CityName { get; set; }
    public string StateProvince { get; set; }
    public DateTime Created { get; set; }
    public String PostElement { get; set; }
    public String PostHtml { get; set; }
    public Guid UserId { get; set; }
    public DateTime? Responded { get; set; }
    public DateTime? ResponseSent { get; set; }
    public Guid? ResponseId { get; set; }
    public string Response { get; set; }
    public string ResponseText { get; set; }
    public bool CityActive { get; set; }
    public bool UserCityActive { get; set; }
    public bool ListingCategoryActive { get; set; }
    public int? KeywordScore { get; set; }
    public string KeywordDisplay { get; set; }
    public bool UseDefaultResponse { get; set; }
    public DateTime PostDate { get; set; }
    public string PostText { get; set; }
    public bool IsHidden { get; set; }
  }
  public class UserListingResponseItem {
    [Key]
    public Guid Id { get; set; }
    public Guid UserListingUrlId { get; set; }
    public Guid UserId { get; set; }
    public DateTime Created { get; set; }
    public string Response { get; set; }
    
  }
  public class Operation {

    [Key]
    public int Id { get; set; }
    public bool Visible { get; set; }
    public DateTime Created { get; set; }
    public string OperationName { get; set; }
    public String Parameters { get; set; }
    public Guid UserId { get; set; }
  }
  public class UserTemplateItem {
    [Key]
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public DateTime Created { get; set; }
    public DateTime? LastUpdated { get; set; }
    public bool IsDefault { get; set; }
    public string TemplateHtml { get; set; }
    public string TemplateText { get; set; }
    public string TemplateName { get; set; }
  }
  public class UserPostListFilterItem
  {
      // Fields...
      [Key]
      public Guid Id { get; set; }
      public Guid UserId { get; set; }
      public DateTime? PostStartDate { get; set; }
      public DateTime? PostEndDate { get; set; }
      public DateTime? ResponseStartDate { get; set; }
      public DateTime? ResponseEndDate { get; set; }
      public string FilteredKeywords { get; set; }
      public string FilteredCities { get; set; }
      public string FilteredStates { get; set; }
      public string FilteredCountries { get; set; }
      public bool ShowResponded { get; set; }
      public bool ShowNotResponded { get; set; }
      public bool FiltersEnabled { get; set; }      
      
  }
  public class BugReportItem
  {
      [Key]
      public Guid Id { get; set; }
      public string Description { get; set; }
      public string Resolution { get; set; }
      public string ReproductionSteps { get; set; }
      public DateTime? Resolved { get; set; }
      public DateTime Reported { get; set; }
  }
  public class Error
  {
      [Key]
      public Guid Id { get; set; }
      public string OriginatingClassName { get; set; }
      public string MethodName { get; set; }
      public string ExceptionTypeName { get; set; }
      public string ExceptionMessage { get; set; }
      public string ErrorMessage { get; set; }
      public string ErrorData { get; set; }
  }
  public class ErrorDisplay
  {
      [Key]
      public string Id { get; set; }
      public DateTime Timestamp { get; set; }
      public string Title { get; set; }
      public string Message { get; set; }
      
  }
}
