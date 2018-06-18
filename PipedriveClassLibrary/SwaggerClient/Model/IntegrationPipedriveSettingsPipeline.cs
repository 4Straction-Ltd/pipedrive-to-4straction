/* 
 * ForStraction service API
 *
 * Lead your organisation’s full potential to creating results
 *
 * OpenAPI spec version: 2.0.582609432
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
    /// IntegrationPipedriveSettingsPipeline
    /// </summary>
    [DataContract]
    public partial class IntegrationPipedriveSettingsPipeline :  IEquatable<IntegrationPipedriveSettingsPipeline>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationPipedriveSettingsPipeline" /> class.
        /// </summary>
        /// <param name="SettingsID">reflection (default to 0).</param>
        /// <param name="Name">reflection (default to &quot;&quot;).</param>
        /// <param name="ExternalPipelineID">reflection.</param>
        /// <param name="ImportLossDealCount">reflection (default to false).</param>
        /// <param name="ImportLossDealCountIndicatorID">reflection.</param>
        /// <param name="ImportLossDealSum">reflection (default to false).</param>
        /// <param name="ImportLossDealSumIndicatorID">reflection.</param>
        /// <param name="ImportWinDealCount">reflection (default to false).</param>
        /// <param name="ImportWinDealCountIndicatorID">reflection.</param>
        /// <param name="ImportWinDealSum">reflection (default to false).</param>
        /// <param name="ImportWinDealSumIndicatorID">reflection.</param>
        /// <param name="CorporateStructureLink">CorporateStructureLink.</param>
        /// <param name="ID">reflection (default to 0).</param>
        public IntegrationPipedriveSettingsPipeline(int? SettingsID = null, string Name = null, int? ExternalPipelineID = null, bool? ImportLossDealCount = null, int? ImportLossDealCountIndicatorID = null, bool? ImportLossDealSum = null, int? ImportLossDealSumIndicatorID = null, bool? ImportWinDealCount = null, int? ImportWinDealCountIndicatorID = null, bool? ImportWinDealSum = null, int? ImportWinDealSumIndicatorID = null, CorporateStructureLink CorporateStructureLink = null, int? ID = null)
        {
            // use default value if no "SettingsID" provided
            if (SettingsID == null)
            {
                this.SettingsID = 0;
            }
            else
            {
                this.SettingsID = SettingsID;
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
            this.ExternalPipelineID = ExternalPipelineID;
            // use default value if no "ImportLossDealCount" provided
            if (ImportLossDealCount == null)
            {
                this.ImportLossDealCount = false;
            }
            else
            {
                this.ImportLossDealCount = ImportLossDealCount;
            }
            this.ImportLossDealCountIndicatorID = ImportLossDealCountIndicatorID;
            // use default value if no "ImportLossDealSum" provided
            if (ImportLossDealSum == null)
            {
                this.ImportLossDealSum = false;
            }
            else
            {
                this.ImportLossDealSum = ImportLossDealSum;
            }
            this.ImportLossDealSumIndicatorID = ImportLossDealSumIndicatorID;
            // use default value if no "ImportWinDealCount" provided
            if (ImportWinDealCount == null)
            {
                this.ImportWinDealCount = false;
            }
            else
            {
                this.ImportWinDealCount = ImportWinDealCount;
            }
            this.ImportWinDealCountIndicatorID = ImportWinDealCountIndicatorID;
            // use default value if no "ImportWinDealSum" provided
            if (ImportWinDealSum == null)
            {
                this.ImportWinDealSum = false;
            }
            else
            {
                this.ImportWinDealSum = ImportWinDealSum;
            }
            this.ImportWinDealSumIndicatorID = ImportWinDealSumIndicatorID;
            this.CorporateStructureLink = CorporateStructureLink;
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
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="SettingsID", EmitDefaultValue=false)]
        public int? SettingsID { get; set; }
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
        [DataMember(Name="ExternalPipelineID", EmitDefaultValue=false)]
        public int? ExternalPipelineID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ImportLossDealCount", EmitDefaultValue=false)]
        public bool? ImportLossDealCount { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ImportLossDealCountIndicatorID", EmitDefaultValue=false)]
        public int? ImportLossDealCountIndicatorID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ImportLossDealSum", EmitDefaultValue=false)]
        public bool? ImportLossDealSum { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ImportLossDealSumIndicatorID", EmitDefaultValue=false)]
        public int? ImportLossDealSumIndicatorID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ImportWinDealCount", EmitDefaultValue=false)]
        public bool? ImportWinDealCount { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ImportWinDealCountIndicatorID", EmitDefaultValue=false)]
        public int? ImportWinDealCountIndicatorID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ImportWinDealSum", EmitDefaultValue=false)]
        public bool? ImportWinDealSum { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ImportWinDealSumIndicatorID", EmitDefaultValue=false)]
        public int? ImportWinDealSumIndicatorID { get; set; }
        /// <summary>
        /// Gets or Sets CorporateStructureLink
        /// </summary>
        [DataMember(Name="CorporateStructureLink", EmitDefaultValue=false)]
        public CorporateStructureLink CorporateStructureLink { get; set; }
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
            sb.Append("class IntegrationPipedriveSettingsPipeline {\n");
            sb.Append("  SettingsID: ").Append(SettingsID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExternalPipelineID: ").Append(ExternalPipelineID).Append("\n");
            sb.Append("  ImportLossDealCount: ").Append(ImportLossDealCount).Append("\n");
            sb.Append("  ImportLossDealCountIndicatorID: ").Append(ImportLossDealCountIndicatorID).Append("\n");
            sb.Append("  ImportLossDealSum: ").Append(ImportLossDealSum).Append("\n");
            sb.Append("  ImportLossDealSumIndicatorID: ").Append(ImportLossDealSumIndicatorID).Append("\n");
            sb.Append("  ImportWinDealCount: ").Append(ImportWinDealCount).Append("\n");
            sb.Append("  ImportWinDealCountIndicatorID: ").Append(ImportWinDealCountIndicatorID).Append("\n");
            sb.Append("  ImportWinDealSum: ").Append(ImportWinDealSum).Append("\n");
            sb.Append("  ImportWinDealSumIndicatorID: ").Append(ImportWinDealSumIndicatorID).Append("\n");
            sb.Append("  CorporateStructureLink: ").Append(CorporateStructureLink).Append("\n");
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
            return this.Equals(obj as IntegrationPipedriveSettingsPipeline);
        }

        /// <summary>
        /// Returns true if IntegrationPipedriveSettingsPipeline instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegrationPipedriveSettingsPipeline to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationPipedriveSettingsPipeline other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SettingsID == other.SettingsID ||
                    this.SettingsID != null &&
                    this.SettingsID.Equals(other.SettingsID)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ExternalPipelineID == other.ExternalPipelineID ||
                    this.ExternalPipelineID != null &&
                    this.ExternalPipelineID.Equals(other.ExternalPipelineID)
                ) && 
                (
                    this.ImportLossDealCount == other.ImportLossDealCount ||
                    this.ImportLossDealCount != null &&
                    this.ImportLossDealCount.Equals(other.ImportLossDealCount)
                ) && 
                (
                    this.ImportLossDealCountIndicatorID == other.ImportLossDealCountIndicatorID ||
                    this.ImportLossDealCountIndicatorID != null &&
                    this.ImportLossDealCountIndicatorID.Equals(other.ImportLossDealCountIndicatorID)
                ) && 
                (
                    this.ImportLossDealSum == other.ImportLossDealSum ||
                    this.ImportLossDealSum != null &&
                    this.ImportLossDealSum.Equals(other.ImportLossDealSum)
                ) && 
                (
                    this.ImportLossDealSumIndicatorID == other.ImportLossDealSumIndicatorID ||
                    this.ImportLossDealSumIndicatorID != null &&
                    this.ImportLossDealSumIndicatorID.Equals(other.ImportLossDealSumIndicatorID)
                ) && 
                (
                    this.ImportWinDealCount == other.ImportWinDealCount ||
                    this.ImportWinDealCount != null &&
                    this.ImportWinDealCount.Equals(other.ImportWinDealCount)
                ) && 
                (
                    this.ImportWinDealCountIndicatorID == other.ImportWinDealCountIndicatorID ||
                    this.ImportWinDealCountIndicatorID != null &&
                    this.ImportWinDealCountIndicatorID.Equals(other.ImportWinDealCountIndicatorID)
                ) && 
                (
                    this.ImportWinDealSum == other.ImportWinDealSum ||
                    this.ImportWinDealSum != null &&
                    this.ImportWinDealSum.Equals(other.ImportWinDealSum)
                ) && 
                (
                    this.ImportWinDealSumIndicatorID == other.ImportWinDealSumIndicatorID ||
                    this.ImportWinDealSumIndicatorID != null &&
                    this.ImportWinDealSumIndicatorID.Equals(other.ImportWinDealSumIndicatorID)
                ) && 
                (
                    this.CorporateStructureLink == other.CorporateStructureLink ||
                    this.CorporateStructureLink != null &&
                    this.CorporateStructureLink.Equals(other.CorporateStructureLink)
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
                if (this.SettingsID != null)
                    hash = hash * 59 + this.SettingsID.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ExternalPipelineID != null)
                    hash = hash * 59 + this.ExternalPipelineID.GetHashCode();
                if (this.ImportLossDealCount != null)
                    hash = hash * 59 + this.ImportLossDealCount.GetHashCode();
                if (this.ImportLossDealCountIndicatorID != null)
                    hash = hash * 59 + this.ImportLossDealCountIndicatorID.GetHashCode();
                if (this.ImportLossDealSum != null)
                    hash = hash * 59 + this.ImportLossDealSum.GetHashCode();
                if (this.ImportLossDealSumIndicatorID != null)
                    hash = hash * 59 + this.ImportLossDealSumIndicatorID.GetHashCode();
                if (this.ImportWinDealCount != null)
                    hash = hash * 59 + this.ImportWinDealCount.GetHashCode();
                if (this.ImportWinDealCountIndicatorID != null)
                    hash = hash * 59 + this.ImportWinDealCountIndicatorID.GetHashCode();
                if (this.ImportWinDealSum != null)
                    hash = hash * 59 + this.ImportWinDealSum.GetHashCode();
                if (this.ImportWinDealSumIndicatorID != null)
                    hash = hash * 59 + this.ImportWinDealSumIndicatorID.GetHashCode();
                if (this.CorporateStructureLink != null)
                    hash = hash * 59 + this.CorporateStructureLink.GetHashCode();
                if (this.ID != null)
                    hash = hash * 59 + this.ID.GetHashCode();
                return hash;
            }
        }
    }

}
