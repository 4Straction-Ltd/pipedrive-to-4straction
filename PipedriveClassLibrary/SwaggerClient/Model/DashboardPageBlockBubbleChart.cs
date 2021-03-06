/* 
 * ForStraction service API
 *
 * Lead your organisation’s full potential to creating results
 *
 * OpenAPI spec version: 2.0.574845979
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
    /// DashboardPageBlockBubbleChart
    /// </summary>
    [DataContract]
    public partial class DashboardPageBlockBubbleChart :  IEquatable<DashboardPageBlockBubbleChart>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardPageBlockBubbleChart" /> class.
        /// </summary>
        /// <param name="SystemRegisterDataSourceID">reflection (default to 0).</param>
        /// <param name="LimitItems">reflection (default to 0).</param>
        /// <param name="LimitOrderTypeID">reflection (default to 0).</param>
        /// <param name="LimitBasedOnIndicatorID">reflection (default to 0).</param>
        /// <param name="XPositionIndicatorID">reflection (default to 0).</param>
        /// <param name="YPositionIndicatorID">reflection (default to 0).</param>
        /// <param name="SizeIndicatorID">reflection (default to 0).</param>
        /// <param name="ColorIndicatorID">reflection (default to 0).</param>
        /// <param name="BlockID">reflection (default to 0).</param>
        /// <param name="ID">reflection (default to 0).</param>
        public DashboardPageBlockBubbleChart(int? SystemRegisterDataSourceID = null, int? LimitItems = null, int? LimitOrderTypeID = null, int? LimitBasedOnIndicatorID = null, int? XPositionIndicatorID = null, int? YPositionIndicatorID = null, int? SizeIndicatorID = null, int? ColorIndicatorID = null, int? BlockID = null, int? ID = null)
        {
            // use default value if no "SystemRegisterDataSourceID" provided
            if (SystemRegisterDataSourceID == null)
            {
                this.SystemRegisterDataSourceID = 0;
            }
            else
            {
                this.SystemRegisterDataSourceID = SystemRegisterDataSourceID;
            }
            // use default value if no "LimitItems" provided
            if (LimitItems == null)
            {
                this.LimitItems = 0;
            }
            else
            {
                this.LimitItems = LimitItems;
            }
            // use default value if no "LimitOrderTypeID" provided
            if (LimitOrderTypeID == null)
            {
                this.LimitOrderTypeID = 0;
            }
            else
            {
                this.LimitOrderTypeID = LimitOrderTypeID;
            }
            // use default value if no "LimitBasedOnIndicatorID" provided
            if (LimitBasedOnIndicatorID == null)
            {
                this.LimitBasedOnIndicatorID = 0;
            }
            else
            {
                this.LimitBasedOnIndicatorID = LimitBasedOnIndicatorID;
            }
            // use default value if no "XPositionIndicatorID" provided
            if (XPositionIndicatorID == null)
            {
                this.XPositionIndicatorID = 0;
            }
            else
            {
                this.XPositionIndicatorID = XPositionIndicatorID;
            }
            // use default value if no "YPositionIndicatorID" provided
            if (YPositionIndicatorID == null)
            {
                this.YPositionIndicatorID = 0;
            }
            else
            {
                this.YPositionIndicatorID = YPositionIndicatorID;
            }
            // use default value if no "SizeIndicatorID" provided
            if (SizeIndicatorID == null)
            {
                this.SizeIndicatorID = 0;
            }
            else
            {
                this.SizeIndicatorID = SizeIndicatorID;
            }
            // use default value if no "ColorIndicatorID" provided
            if (ColorIndicatorID == null)
            {
                this.ColorIndicatorID = 0;
            }
            else
            {
                this.ColorIndicatorID = ColorIndicatorID;
            }
            // use default value if no "BlockID" provided
            if (BlockID == null)
            {
                this.BlockID = 0;
            }
            else
            {
                this.BlockID = BlockID;
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
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="SystemRegisterDataSourceID", EmitDefaultValue=false)]
        public int? SystemRegisterDataSourceID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="LimitItems", EmitDefaultValue=false)]
        public int? LimitItems { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="LimitOrderTypeID", EmitDefaultValue=false)]
        public int? LimitOrderTypeID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="LimitBasedOnIndicatorID", EmitDefaultValue=false)]
        public int? LimitBasedOnIndicatorID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="XPositionIndicatorID", EmitDefaultValue=false)]
        public int? XPositionIndicatorID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="YPositionIndicatorID", EmitDefaultValue=false)]
        public int? YPositionIndicatorID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="SizeIndicatorID", EmitDefaultValue=false)]
        public int? SizeIndicatorID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ColorIndicatorID", EmitDefaultValue=false)]
        public int? ColorIndicatorID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="BlockID", EmitDefaultValue=false)]
        public int? BlockID { get; set; }
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
            sb.Append("class DashboardPageBlockBubbleChart {\n");
            sb.Append("  SystemRegisterDataSourceID: ").Append(SystemRegisterDataSourceID).Append("\n");
            sb.Append("  LimitItems: ").Append(LimitItems).Append("\n");
            sb.Append("  LimitOrderTypeID: ").Append(LimitOrderTypeID).Append("\n");
            sb.Append("  LimitBasedOnIndicatorID: ").Append(LimitBasedOnIndicatorID).Append("\n");
            sb.Append("  XPositionIndicatorID: ").Append(XPositionIndicatorID).Append("\n");
            sb.Append("  YPositionIndicatorID: ").Append(YPositionIndicatorID).Append("\n");
            sb.Append("  SizeIndicatorID: ").Append(SizeIndicatorID).Append("\n");
            sb.Append("  ColorIndicatorID: ").Append(ColorIndicatorID).Append("\n");
            sb.Append("  BlockID: ").Append(BlockID).Append("\n");
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
            return this.Equals(obj as DashboardPageBlockBubbleChart);
        }

        /// <summary>
        /// Returns true if DashboardPageBlockBubbleChart instances are equal
        /// </summary>
        /// <param name="other">Instance of DashboardPageBlockBubbleChart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardPageBlockBubbleChart other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SystemRegisterDataSourceID == other.SystemRegisterDataSourceID ||
                    this.SystemRegisterDataSourceID != null &&
                    this.SystemRegisterDataSourceID.Equals(other.SystemRegisterDataSourceID)
                ) && 
                (
                    this.LimitItems == other.LimitItems ||
                    this.LimitItems != null &&
                    this.LimitItems.Equals(other.LimitItems)
                ) && 
                (
                    this.LimitOrderTypeID == other.LimitOrderTypeID ||
                    this.LimitOrderTypeID != null &&
                    this.LimitOrderTypeID.Equals(other.LimitOrderTypeID)
                ) && 
                (
                    this.LimitBasedOnIndicatorID == other.LimitBasedOnIndicatorID ||
                    this.LimitBasedOnIndicatorID != null &&
                    this.LimitBasedOnIndicatorID.Equals(other.LimitBasedOnIndicatorID)
                ) && 
                (
                    this.XPositionIndicatorID == other.XPositionIndicatorID ||
                    this.XPositionIndicatorID != null &&
                    this.XPositionIndicatorID.Equals(other.XPositionIndicatorID)
                ) && 
                (
                    this.YPositionIndicatorID == other.YPositionIndicatorID ||
                    this.YPositionIndicatorID != null &&
                    this.YPositionIndicatorID.Equals(other.YPositionIndicatorID)
                ) && 
                (
                    this.SizeIndicatorID == other.SizeIndicatorID ||
                    this.SizeIndicatorID != null &&
                    this.SizeIndicatorID.Equals(other.SizeIndicatorID)
                ) && 
                (
                    this.ColorIndicatorID == other.ColorIndicatorID ||
                    this.ColorIndicatorID != null &&
                    this.ColorIndicatorID.Equals(other.ColorIndicatorID)
                ) && 
                (
                    this.BlockID == other.BlockID ||
                    this.BlockID != null &&
                    this.BlockID.Equals(other.BlockID)
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
                if (this.SystemRegisterDataSourceID != null)
                    hash = hash * 59 + this.SystemRegisterDataSourceID.GetHashCode();
                if (this.LimitItems != null)
                    hash = hash * 59 + this.LimitItems.GetHashCode();
                if (this.LimitOrderTypeID != null)
                    hash = hash * 59 + this.LimitOrderTypeID.GetHashCode();
                if (this.LimitBasedOnIndicatorID != null)
                    hash = hash * 59 + this.LimitBasedOnIndicatorID.GetHashCode();
                if (this.XPositionIndicatorID != null)
                    hash = hash * 59 + this.XPositionIndicatorID.GetHashCode();
                if (this.YPositionIndicatorID != null)
                    hash = hash * 59 + this.YPositionIndicatorID.GetHashCode();
                if (this.SizeIndicatorID != null)
                    hash = hash * 59 + this.SizeIndicatorID.GetHashCode();
                if (this.ColorIndicatorID != null)
                    hash = hash * 59 + this.ColorIndicatorID.GetHashCode();
                if (this.BlockID != null)
                    hash = hash * 59 + this.BlockID.GetHashCode();
                if (this.ID != null)
                    hash = hash * 59 + this.ID.GetHashCode();
                return hash;
            }
        }
    }

}
