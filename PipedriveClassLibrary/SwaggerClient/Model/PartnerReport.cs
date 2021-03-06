/* 
 * ForStraction service API
 *
 * Lead your organisation’s full potential to creating results
 *
 * OpenAPI spec version: 2.0.575447164
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// PartnerReport
    /// </summary>
    [DataContract]
    public partial class PartnerReport :  IEquatable<PartnerReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerReport" /> class.
        /// </summary>
        /// <param name="Comments">Comments.</param>
        /// <param name="TypeID">reflection (default to 0).</param>
        /// <param name="BusinessID">reflection (default to &quot;&quot;).</param>
        /// <param name="HumanReadableBusinessID">reflection (default to &quot;&quot;).</param>
        /// <param name="DomainURI">reflection (default to &quot;&quot;).</param>
        /// <param name="CreatorID">reflection (default to 0).</param>
        /// <param name="DateAdded">reflection.</param>
        /// <param name="DateRemoved">reflection.</param>
        /// <param name="LocationLatitude">reflection.</param>
        /// <param name="LocationLongitude">reflection.</param>
        /// <param name="MarketScopeTypeID">reflection.</param>
        /// <param name="MarketScopeEntityID">reflection (default to &quot;&quot;).</param>
        /// <param name="CountryID">reflection.</param>
        /// <param name="Description">reflection (default to &quot;&quot;).</param>
        /// <param name="Importance">reflection.</param>
        /// <param name="AddressLine">reflection (default to &quot;&quot;).</param>
        /// <param name="BrandNames">reflection (default to &quot;&quot;).</param>
        /// <param name="NewsWatchOn">reflection (default to 0).</param>
        /// <param name="NewsWatchFilterLevelID">reflection.</param>
        /// <param name="NewsWatchInitialRunDone">reflection (default to 0).</param>
        /// <param name="AdditionalMarketID">reflection.</param>
        /// <param name="NewsModeratorID">reflection.</param>
        /// <param name="WebWatchOn">reflection (default to false).</param>
        /// <param name="Name">reflection (default to &quot;&quot;).</param>
        /// <param name="FatherID">reflection.</param>
        /// <param name="Sort">reflection (default to 0).</param>
        /// <param name="ScopeEndSort">reflection (default to 0).</param>
        /// <param name="DepthLevel">reflection (default to 0).</param>
        /// <param name="IsGroup">reflection (default to 0).</param>
        /// <param name="ID">reflection (default to 0).</param>
        public PartnerReport(PartnerCommentPaginationSlice Comments = null, int? TypeID = null, string BusinessID = null, string HumanReadableBusinessID = null, string DomainURI = null, int? CreatorID = null, DateTime? DateAdded = null, DateTime? DateRemoved = null, double? LocationLatitude = null, double? LocationLongitude = null, int? MarketScopeTypeID = null, string MarketScopeEntityID = null, int? CountryID = null, string Description = null, int? Importance = null, string AddressLine = null, string BrandNames = null, int? NewsWatchOn = null, int? NewsWatchFilterLevelID = null, int? NewsWatchInitialRunDone = null, int? AdditionalMarketID = null, int? NewsModeratorID = null, bool? WebWatchOn = null, string Name = null, int? FatherID = null, int? Sort = null, int? ScopeEndSort = null, int? DepthLevel = null, int? IsGroup = null, int? ID = null)
        {
            this.Comments = Comments;
            // use default value if no "TypeID" provided
            if (TypeID == null)
            {
                this.TypeID = 0;
            }
            else
            {
                this.TypeID = TypeID;
            }
            // use default value if no "BusinessID" provided
            if (BusinessID == null)
            {
                this.BusinessID = "";
            }
            else
            {
                this.BusinessID = BusinessID;
            }
            // use default value if no "HumanReadableBusinessID" provided
            if (HumanReadableBusinessID == null)
            {
                this.HumanReadableBusinessID = "";
            }
            else
            {
                this.HumanReadableBusinessID = HumanReadableBusinessID;
            }
            // use default value if no "DomainURI" provided
            if (DomainURI == null)
            {
                this.DomainURI = "";
            }
            else
            {
                this.DomainURI = DomainURI;
            }
            // use default value if no "CreatorID" provided
            if (CreatorID == null)
            {
                this.CreatorID = 0;
            }
            else
            {
                this.CreatorID = CreatorID;
            }
            this.DateAdded = DateAdded;
            this.DateRemoved = DateRemoved;
            this.LocationLatitude = LocationLatitude;
            this.LocationLongitude = LocationLongitude;
            this.MarketScopeTypeID = MarketScopeTypeID;
            // use default value if no "MarketScopeEntityID" provided
            if (MarketScopeEntityID == null)
            {
                this.MarketScopeEntityID = "";
            }
            else
            {
                this.MarketScopeEntityID = MarketScopeEntityID;
            }
            this.CountryID = CountryID;
            // use default value if no "Description" provided
            if (Description == null)
            {
                this.Description = "";
            }
            else
            {
                this.Description = Description;
            }
            this.Importance = Importance;
            // use default value if no "AddressLine" provided
            if (AddressLine == null)
            {
                this.AddressLine = "";
            }
            else
            {
                this.AddressLine = AddressLine;
            }
            // use default value if no "BrandNames" provided
            if (BrandNames == null)
            {
                this.BrandNames = "";
            }
            else
            {
                this.BrandNames = BrandNames;
            }
            // use default value if no "NewsWatchOn" provided
            if (NewsWatchOn == null)
            {
                this.NewsWatchOn = 0;
            }
            else
            {
                this.NewsWatchOn = NewsWatchOn;
            }
            this.NewsWatchFilterLevelID = NewsWatchFilterLevelID;
            // use default value if no "NewsWatchInitialRunDone" provided
            if (NewsWatchInitialRunDone == null)
            {
                this.NewsWatchInitialRunDone = 0;
            }
            else
            {
                this.NewsWatchInitialRunDone = NewsWatchInitialRunDone;
            }
            this.AdditionalMarketID = AdditionalMarketID;
            this.NewsModeratorID = NewsModeratorID;
            // use default value if no "WebWatchOn" provided
            if (WebWatchOn == null)
            {
                this.WebWatchOn = false;
            }
            else
            {
                this.WebWatchOn = WebWatchOn;
            }
            // use default value if no "Name" provided
            if (Name == null)
            {
                this.Name = "";
            }
            else
            {
                this.Name = Name;
            }
            this.FatherID = FatherID;
            // use default value if no "Sort" provided
            if (Sort == null)
            {
                this.Sort = 0;
            }
            else
            {
                this.Sort = Sort;
            }
            // use default value if no "ScopeEndSort" provided
            if (ScopeEndSort == null)
            {
                this.ScopeEndSort = 0;
            }
            else
            {
                this.ScopeEndSort = ScopeEndSort;
            }
            // use default value if no "DepthLevel" provided
            if (DepthLevel == null)
            {
                this.DepthLevel = 0;
            }
            else
            {
                this.DepthLevel = DepthLevel;
            }
            // use default value if no "IsGroup" provided
            if (IsGroup == null)
            {
                this.IsGroup = 0;
            }
            else
            {
                this.IsGroup = IsGroup;
            }
            // use default value if no "ID" provided
            if (ID == null)
            {
                this.ID = 0;
            }
            else
            {
                this.ID = ID;
            }
        }
        
        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public PartnerCommentPaginationSlice Comments { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="TypeID", EmitDefaultValue=false)]
        public int? TypeID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="BusinessID", EmitDefaultValue=false)]
        public string BusinessID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="HumanReadableBusinessID", EmitDefaultValue=false)]
        public string HumanReadableBusinessID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="DomainURI", EmitDefaultValue=false)]
        public string DomainURI { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="CreatorID", EmitDefaultValue=false)]
        public int? CreatorID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="DateAdded", EmitDefaultValue=false)]
        public DateTime? DateAdded { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="DateRemoved", EmitDefaultValue=false)]
        public DateTime? DateRemoved { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="LocationLatitude", EmitDefaultValue=false)]
        public double? LocationLatitude { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="LocationLongitude", EmitDefaultValue=false)]
        public double? LocationLongitude { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="MarketScopeTypeID", EmitDefaultValue=false)]
        public int? MarketScopeTypeID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="MarketScopeEntityID", EmitDefaultValue=false)]
        public string MarketScopeEntityID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="CountryID", EmitDefaultValue=false)]
        public int? CountryID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="Importance", EmitDefaultValue=false)]
        public int? Importance { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="AddressLine", EmitDefaultValue=false)]
        public string AddressLine { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="BrandNames", EmitDefaultValue=false)]
        public string BrandNames { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="NewsWatchOn", EmitDefaultValue=false)]
        public int? NewsWatchOn { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="NewsWatchFilterLevelID", EmitDefaultValue=false)]
        public int? NewsWatchFilterLevelID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="NewsWatchInitialRunDone", EmitDefaultValue=false)]
        public int? NewsWatchInitialRunDone { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="AdditionalMarketID", EmitDefaultValue=false)]
        public int? AdditionalMarketID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="NewsModeratorID", EmitDefaultValue=false)]
        public int? NewsModeratorID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="WebWatchOn", EmitDefaultValue=false)]
        public bool? WebWatchOn { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="FatherID", EmitDefaultValue=false)]
        public int? FatherID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="Sort", EmitDefaultValue=false)]
        public int? Sort { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ScopeEndSort", EmitDefaultValue=false)]
        public int? ScopeEndSort { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="DepthLevel", EmitDefaultValue=false)]
        public int? DepthLevel { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="IsGroup", EmitDefaultValue=false)]
        public int? IsGroup { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public int? ID { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartnerReport {\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  TypeID: ").Append(TypeID).Append("\n");
            sb.Append("  BusinessID: ").Append(BusinessID).Append("\n");
            sb.Append("  HumanReadableBusinessID: ").Append(HumanReadableBusinessID).Append("\n");
            sb.Append("  DomainURI: ").Append(DomainURI).Append("\n");
            sb.Append("  CreatorID: ").Append(CreatorID).Append("\n");
            sb.Append("  DateAdded: ").Append(DateAdded).Append("\n");
            sb.Append("  DateRemoved: ").Append(DateRemoved).Append("\n");
            sb.Append("  LocationLatitude: ").Append(LocationLatitude).Append("\n");
            sb.Append("  LocationLongitude: ").Append(LocationLongitude).Append("\n");
            sb.Append("  MarketScopeTypeID: ").Append(MarketScopeTypeID).Append("\n");
            sb.Append("  MarketScopeEntityID: ").Append(MarketScopeEntityID).Append("\n");
            sb.Append("  CountryID: ").Append(CountryID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Importance: ").Append(Importance).Append("\n");
            sb.Append("  AddressLine: ").Append(AddressLine).Append("\n");
            sb.Append("  BrandNames: ").Append(BrandNames).Append("\n");
            sb.Append("  NewsWatchOn: ").Append(NewsWatchOn).Append("\n");
            sb.Append("  NewsWatchFilterLevelID: ").Append(NewsWatchFilterLevelID).Append("\n");
            sb.Append("  NewsWatchInitialRunDone: ").Append(NewsWatchInitialRunDone).Append("\n");
            sb.Append("  AdditionalMarketID: ").Append(AdditionalMarketID).Append("\n");
            sb.Append("  NewsModeratorID: ").Append(NewsModeratorID).Append("\n");
            sb.Append("  WebWatchOn: ").Append(WebWatchOn).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FatherID: ").Append(FatherID).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  ScopeEndSort: ").Append(ScopeEndSort).Append("\n");
            sb.Append("  DepthLevel: ").Append(DepthLevel).Append("\n");
            sb.Append("  IsGroup: ").Append(IsGroup).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PartnerReport);
        }

        /// <summary>
        /// Returns true if PartnerReport instances are equal
        /// </summary>
        /// <param name="other">Instance of PartnerReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartnerReport other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.Equals(other.Comments)
                ) && 
                (
                    this.TypeID == other.TypeID ||
                    this.TypeID != null &&
                    this.TypeID.Equals(other.TypeID)
                ) && 
                (
                    this.BusinessID == other.BusinessID ||
                    this.BusinessID != null &&
                    this.BusinessID.Equals(other.BusinessID)
                ) && 
                (
                    this.HumanReadableBusinessID == other.HumanReadableBusinessID ||
                    this.HumanReadableBusinessID != null &&
                    this.HumanReadableBusinessID.Equals(other.HumanReadableBusinessID)
                ) && 
                (
                    this.DomainURI == other.DomainURI ||
                    this.DomainURI != null &&
                    this.DomainURI.Equals(other.DomainURI)
                ) && 
                (
                    this.CreatorID == other.CreatorID ||
                    this.CreatorID != null &&
                    this.CreatorID.Equals(other.CreatorID)
                ) && 
                (
                    this.DateAdded == other.DateAdded ||
                    this.DateAdded != null &&
                    this.DateAdded.Equals(other.DateAdded)
                ) && 
                (
                    this.DateRemoved == other.DateRemoved ||
                    this.DateRemoved != null &&
                    this.DateRemoved.Equals(other.DateRemoved)
                ) && 
                (
                    this.LocationLatitude == other.LocationLatitude ||
                    this.LocationLatitude != null &&
                    this.LocationLatitude.Equals(other.LocationLatitude)
                ) && 
                (
                    this.LocationLongitude == other.LocationLongitude ||
                    this.LocationLongitude != null &&
                    this.LocationLongitude.Equals(other.LocationLongitude)
                ) && 
                (
                    this.MarketScopeTypeID == other.MarketScopeTypeID ||
                    this.MarketScopeTypeID != null &&
                    this.MarketScopeTypeID.Equals(other.MarketScopeTypeID)
                ) && 
                (
                    this.MarketScopeEntityID == other.MarketScopeEntityID ||
                    this.MarketScopeEntityID != null &&
                    this.MarketScopeEntityID.Equals(other.MarketScopeEntityID)
                ) && 
                (
                    this.CountryID == other.CountryID ||
                    this.CountryID != null &&
                    this.CountryID.Equals(other.CountryID)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Importance == other.Importance ||
                    this.Importance != null &&
                    this.Importance.Equals(other.Importance)
                ) && 
                (
                    this.AddressLine == other.AddressLine ||
                    this.AddressLine != null &&
                    this.AddressLine.Equals(other.AddressLine)
                ) && 
                (
                    this.BrandNames == other.BrandNames ||
                    this.BrandNames != null &&
                    this.BrandNames.Equals(other.BrandNames)
                ) && 
                (
                    this.NewsWatchOn == other.NewsWatchOn ||
                    this.NewsWatchOn != null &&
                    this.NewsWatchOn.Equals(other.NewsWatchOn)
                ) && 
                (
                    this.NewsWatchFilterLevelID == other.NewsWatchFilterLevelID ||
                    this.NewsWatchFilterLevelID != null &&
                    this.NewsWatchFilterLevelID.Equals(other.NewsWatchFilterLevelID)
                ) && 
                (
                    this.NewsWatchInitialRunDone == other.NewsWatchInitialRunDone ||
                    this.NewsWatchInitialRunDone != null &&
                    this.NewsWatchInitialRunDone.Equals(other.NewsWatchInitialRunDone)
                ) && 
                (
                    this.AdditionalMarketID == other.AdditionalMarketID ||
                    this.AdditionalMarketID != null &&
                    this.AdditionalMarketID.Equals(other.AdditionalMarketID)
                ) && 
                (
                    this.NewsModeratorID == other.NewsModeratorID ||
                    this.NewsModeratorID != null &&
                    this.NewsModeratorID.Equals(other.NewsModeratorID)
                ) && 
                (
                    this.WebWatchOn == other.WebWatchOn ||
                    this.WebWatchOn != null &&
                    this.WebWatchOn.Equals(other.WebWatchOn)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.FatherID == other.FatherID ||
                    this.FatherID != null &&
                    this.FatherID.Equals(other.FatherID)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.Equals(other.Sort)
                ) && 
                (
                    this.ScopeEndSort == other.ScopeEndSort ||
                    this.ScopeEndSort != null &&
                    this.ScopeEndSort.Equals(other.ScopeEndSort)
                ) && 
                (
                    this.DepthLevel == other.DepthLevel ||
                    this.DepthLevel != null &&
                    this.DepthLevel.Equals(other.DepthLevel)
                ) && 
                (
                    this.IsGroup == other.IsGroup ||
                    this.IsGroup != null &&
                    this.IsGroup.Equals(other.IsGroup)
                ) && 
                (
                    this.ID == other.ID ||
                    this.ID != null &&
                    this.ID.Equals(other.ID)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();
                if (this.TypeID != null)
                    hash = hash * 59 + this.TypeID.GetHashCode();
                if (this.BusinessID != null)
                    hash = hash * 59 + this.BusinessID.GetHashCode();
                if (this.HumanReadableBusinessID != null)
                    hash = hash * 59 + this.HumanReadableBusinessID.GetHashCode();
                if (this.DomainURI != null)
                    hash = hash * 59 + this.DomainURI.GetHashCode();
                if (this.CreatorID != null)
                    hash = hash * 59 + this.CreatorID.GetHashCode();
                if (this.DateAdded != null)
                    hash = hash * 59 + this.DateAdded.GetHashCode();
                if (this.DateRemoved != null)
                    hash = hash * 59 + this.DateRemoved.GetHashCode();
                if (this.LocationLatitude != null)
                    hash = hash * 59 + this.LocationLatitude.GetHashCode();
                if (this.LocationLongitude != null)
                    hash = hash * 59 + this.LocationLongitude.GetHashCode();
                if (this.MarketScopeTypeID != null)
                    hash = hash * 59 + this.MarketScopeTypeID.GetHashCode();
                if (this.MarketScopeEntityID != null)
                    hash = hash * 59 + this.MarketScopeEntityID.GetHashCode();
                if (this.CountryID != null)
                    hash = hash * 59 + this.CountryID.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Importance != null)
                    hash = hash * 59 + this.Importance.GetHashCode();
                if (this.AddressLine != null)
                    hash = hash * 59 + this.AddressLine.GetHashCode();
                if (this.BrandNames != null)
                    hash = hash * 59 + this.BrandNames.GetHashCode();
                if (this.NewsWatchOn != null)
                    hash = hash * 59 + this.NewsWatchOn.GetHashCode();
                if (this.NewsWatchFilterLevelID != null)
                    hash = hash * 59 + this.NewsWatchFilterLevelID.GetHashCode();
                if (this.NewsWatchInitialRunDone != null)
                    hash = hash * 59 + this.NewsWatchInitialRunDone.GetHashCode();
                if (this.AdditionalMarketID != null)
                    hash = hash * 59 + this.AdditionalMarketID.GetHashCode();
                if (this.NewsModeratorID != null)
                    hash = hash * 59 + this.NewsModeratorID.GetHashCode();
                if (this.WebWatchOn != null)
                    hash = hash * 59 + this.WebWatchOn.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.FatherID != null)
                    hash = hash * 59 + this.FatherID.GetHashCode();
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                if (this.ScopeEndSort != null)
                    hash = hash * 59 + this.ScopeEndSort.GetHashCode();
                if (this.DepthLevel != null)
                    hash = hash * 59 + this.DepthLevel.GetHashCode();
                if (this.IsGroup != null)
                    hash = hash * 59 + this.IsGroup.GetHashCode();
                if (this.ID != null)
                    hash = hash * 59 + this.ID.GetHashCode();
                return hash;
            }
        }
    }

}
