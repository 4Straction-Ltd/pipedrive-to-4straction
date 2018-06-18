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
    /// AutomatedSourceGeneratedNews
    /// </summary>
    [DataContract]
    public partial class AutomatedSourceGeneratedNews :  IEquatable<AutomatedSourceGeneratedNews>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomatedSourceGeneratedNews" /> class.
        /// </summary>
        /// <param name="AutomatedSourceID">reflection (default to 0).</param>
        /// <param name="Date">reflection.</param>
        /// <param name="Description">reflection (default to &quot;&quot;).</param>
        /// <param name="DrillableUri">reflection (default to &quot;&quot;).</param>
        /// <param name="Title">reflection (default to &quot;&quot;).</param>
        /// <param name="CorporateStructureLink">CorporateStructureLink.</param>
        public AutomatedSourceGeneratedNews(int? AutomatedSourceID = null, DateTime? Date = null, string Description = null, string DrillableUri = null, string Title = null, CorporateStructureLink CorporateStructureLink = null)
        {
            // use default value if no "AutomatedSourceID" provided
            if (AutomatedSourceID == null)
            {
                this.AutomatedSourceID = 0;
            }
            else
            {
                this.AutomatedSourceID = AutomatedSourceID;
            }
            this.Date = Date;
            // use default value if no "Description" provided
            if (Description == null)
            {
                this.Description = "";
            }
            else
            {
                this.Description = Description;
            }
            // use default value if no "DrillableUri" provided
            if (DrillableUri == null)
            {
                this.DrillableUri = "";
            }
            else
            {
                this.DrillableUri = DrillableUri;
            }
            // use default value if no "Title" provided
            if (Title == null)
            {
                this.Title = "";
            }
            else
            {
                this.Title = Title;
            }
            this.CorporateStructureLink = CorporateStructureLink;
        }
        
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="AutomatedSourceID", EmitDefaultValue=false)]
        public int? AutomatedSourceID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }
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
        [DataMember(Name="DrillableUri", EmitDefaultValue=false)]
        public string DrillableUri { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets CorporateStructureLink
        /// </summary>
        [DataMember(Name="CorporateStructureLink", EmitDefaultValue=false)]
        public CorporateStructureLink CorporateStructureLink { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutomatedSourceGeneratedNews {\n");
            sb.Append("  AutomatedSourceID: ").Append(AutomatedSourceID).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DrillableUri: ").Append(DrillableUri).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  CorporateStructureLink: ").Append(CorporateStructureLink).Append("\n");
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
            return this.Equals(obj as AutomatedSourceGeneratedNews);
        }

        /// <summary>
        /// Returns true if AutomatedSourceGeneratedNews instances are equal
        /// </summary>
        /// <param name="other">Instance of AutomatedSourceGeneratedNews to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomatedSourceGeneratedNews other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AutomatedSourceID == other.AutomatedSourceID ||
                    this.AutomatedSourceID != null &&
                    this.AutomatedSourceID.Equals(other.AutomatedSourceID)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.DrillableUri == other.DrillableUri ||
                    this.DrillableUri != null &&
                    this.DrillableUri.Equals(other.DrillableUri)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.CorporateStructureLink == other.CorporateStructureLink ||
                    this.CorporateStructureLink != null &&
                    this.CorporateStructureLink.Equals(other.CorporateStructureLink)
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
                if (this.AutomatedSourceID != null)
                    hash = hash * 59 + this.AutomatedSourceID.GetHashCode();
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.DrillableUri != null)
                    hash = hash * 59 + this.DrillableUri.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.CorporateStructureLink != null)
                    hash = hash * 59 + this.CorporateStructureLink.GetHashCode();
                return hash;
            }
        }
    }

}
