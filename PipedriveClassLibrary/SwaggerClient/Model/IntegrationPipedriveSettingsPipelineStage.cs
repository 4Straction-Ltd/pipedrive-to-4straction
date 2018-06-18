/* 
 * ForStraction service API
 *
 * Lead your organisation’s full potential to creating results
 *
 * OpenAPI spec version: 2.0.578381728
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
    /// IntegrationPipedriveSettingsPipelineStage
    /// </summary>
    [DataContract]
    public partial class IntegrationPipedriveSettingsPipelineStage :  IEquatable<IntegrationPipedriveSettingsPipelineStage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationPipedriveSettingsPipelineStage" /> class.
        /// </summary>
        /// <param name="PipeLineID">reflection (default to 0).</param>
        /// <param name="ExternalStageID">reflection (default to 0).</param>
        /// <param name="Name">reflection (default to &quot;&quot;).</param>
        /// <param name="ImportDealNames">reflection.</param>
        /// <param name="ImportDealCount">reflection.</param>
        /// <param name="ImportDealCountIndicatorID">reflection.</param>
        /// <param name="ImportDealSum">reflection.</param>
        /// <param name="ImportDealSumIndicatorID">reflection.</param>
        /// <param name="ID">reflection (default to 0).</param>
        public IntegrationPipedriveSettingsPipelineStage(int? PipeLineID = null, int? ExternalStageID = null, string Name = null, bool? ImportDealNames = null, bool? ImportDealCount = null, int? ImportDealCountIndicatorID = null, bool? ImportDealSum = null, int? ImportDealSumIndicatorID = null, int? ID = null)
        {
            // use default value if no "PipeLineID" provided
            if (PipeLineID == null)
            {
                this.PipeLineID = 0;
            }
            else
            {
                this.PipeLineID = PipeLineID;
            }
            // use default value if no "ExternalStageID" provided
            if (ExternalStageID == null)
            {
                this.ExternalStageID = 0;
            }
            else
            {
                this.ExternalStageID = ExternalStageID;
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
            this.ImportDealNames = ImportDealNames;
            this.ImportDealCount = ImportDealCount;
            this.ImportDealCountIndicatorID = ImportDealCountIndicatorID;
            this.ImportDealSum = ImportDealSum;
            this.ImportDealSumIndicatorID = ImportDealSumIndicatorID;
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
        [DataMember(Name="PipeLineID", EmitDefaultValue=false)]
        public int? PipeLineID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ExternalStageID", EmitDefaultValue=false)]
        public int? ExternalStageID { get; set; }
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
        [DataMember(Name="ImportDealNames", EmitDefaultValue=false)]
        public bool? ImportDealNames { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ImportDealCount", EmitDefaultValue=false)]
        public bool? ImportDealCount { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ImportDealCountIndicatorID", EmitDefaultValue=false)]
        public int? ImportDealCountIndicatorID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ImportDealSum", EmitDefaultValue=false)]
        public bool? ImportDealSum { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ImportDealSumIndicatorID", EmitDefaultValue=false)]
        public int? ImportDealSumIndicatorID { get; set; }
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
            sb.Append("class IntegrationPipedriveSettingsPipelineStage {\n");
            sb.Append("  PipeLineID: ").Append(PipeLineID).Append("\n");
            sb.Append("  ExternalStageID: ").Append(ExternalStageID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ImportDealNames: ").Append(ImportDealNames).Append("\n");
            sb.Append("  ImportDealCount: ").Append(ImportDealCount).Append("\n");
            sb.Append("  ImportDealCountIndicatorID: ").Append(ImportDealCountIndicatorID).Append("\n");
            sb.Append("  ImportDealSum: ").Append(ImportDealSum).Append("\n");
            sb.Append("  ImportDealSumIndicatorID: ").Append(ImportDealSumIndicatorID).Append("\n");
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
            return this.Equals(obj as IntegrationPipedriveSettingsPipelineStage);
        }

        /// <summary>
        /// Returns true if IntegrationPipedriveSettingsPipelineStage instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegrationPipedriveSettingsPipelineStage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationPipedriveSettingsPipelineStage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PipeLineID == other.PipeLineID ||
                    this.PipeLineID != null &&
                    this.PipeLineID.Equals(other.PipeLineID)
                ) && 
                (
                    this.ExternalStageID == other.ExternalStageID ||
                    this.ExternalStageID != null &&
                    this.ExternalStageID.Equals(other.ExternalStageID)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ImportDealNames == other.ImportDealNames ||
                    this.ImportDealNames != null &&
                    this.ImportDealNames.Equals(other.ImportDealNames)
                ) && 
                (
                    this.ImportDealCount == other.ImportDealCount ||
                    this.ImportDealCount != null &&
                    this.ImportDealCount.Equals(other.ImportDealCount)
                ) && 
                (
                    this.ImportDealCountIndicatorID == other.ImportDealCountIndicatorID ||
                    this.ImportDealCountIndicatorID != null &&
                    this.ImportDealCountIndicatorID.Equals(other.ImportDealCountIndicatorID)
                ) && 
                (
                    this.ImportDealSum == other.ImportDealSum ||
                    this.ImportDealSum != null &&
                    this.ImportDealSum.Equals(other.ImportDealSum)
                ) && 
                (
                    this.ImportDealSumIndicatorID == other.ImportDealSumIndicatorID ||
                    this.ImportDealSumIndicatorID != null &&
                    this.ImportDealSumIndicatorID.Equals(other.ImportDealSumIndicatorID)
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
                if (this.PipeLineID != null)
                    hash = hash * 59 + this.PipeLineID.GetHashCode();
                if (this.ExternalStageID != null)
                    hash = hash * 59 + this.ExternalStageID.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ImportDealNames != null)
                    hash = hash * 59 + this.ImportDealNames.GetHashCode();
                if (this.ImportDealCount != null)
                    hash = hash * 59 + this.ImportDealCount.GetHashCode();
                if (this.ImportDealCountIndicatorID != null)
                    hash = hash * 59 + this.ImportDealCountIndicatorID.GetHashCode();
                if (this.ImportDealSum != null)
                    hash = hash * 59 + this.ImportDealSum.GetHashCode();
                if (this.ImportDealSumIndicatorID != null)
                    hash = hash * 59 + this.ImportDealSumIndicatorID.GetHashCode();
                if (this.ID != null)
                    hash = hash * 59 + this.ID.GetHashCode();
                return hash;
            }
        }
    }

}
