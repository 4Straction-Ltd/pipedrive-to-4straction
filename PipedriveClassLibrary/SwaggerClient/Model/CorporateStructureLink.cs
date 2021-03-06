/* 
 * ForStraction service API
 *
 * Lead your organisation�s full potential to creating results
 *
 * OpenAPI spec version: 2.0.573622193
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
    /// CorporateStructureLink
    /// </summary>
    [DataContract]
    public partial class CorporateStructureLink :  IEquatable<CorporateStructureLink>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorporateStructureLink" /> class.
        /// </summary>
        /// <param name="ProductID">reflection (default to 0).</param>
        /// <param name="GeoAreaID">reflection (default to 0).</param>
        /// <param name="CustomerID">reflection (default to 0).</param>
        /// <param name="CompetitorID">reflection (default to 0).</param>
        /// <param name="SupplierID">reflection (default to 0).</param>
        /// <param name="PartnerID">reflection (default to 0).</param>
        /// <param name="OtherPlayerID">reflection (default to 0).</param>
        /// <param name="CompanyLegalEntityID">reflection (default to 0).</param>
        /// <param name="CompanyFunctionID">reflection (default to 0).</param>
        public CorporateStructureLink(int? ProductID = null, int? GeoAreaID = null, int? CustomerID = null, int? CompetitorID = null, int? SupplierID = null, int? PartnerID = null, int? OtherPlayerID = null, int? CompanyLegalEntityID = null, int? CompanyFunctionID = null)
        {
            // use default value if no "ProductID" provided
            if (ProductID == null)
            {
                this.ProductID = 0;
            }
            else
            {
                this.ProductID = ProductID;
            }
            // use default value if no "GeoAreaID" provided
            if (GeoAreaID == null)
            {
                this.GeoAreaID = 0;
            }
            else
            {
                this.GeoAreaID = GeoAreaID;
            }
            // use default value if no "CustomerID" provided
            if (CustomerID == null)
            {
                this.CustomerID = 0;
            }
            else
            {
                this.CustomerID = CustomerID;
            }
            // use default value if no "CompetitorID" provided
            if (CompetitorID == null)
            {
                this.CompetitorID = 0;
            }
            else
            {
                this.CompetitorID = CompetitorID;
            }
            // use default value if no "SupplierID" provided
            if (SupplierID == null)
            {
                this.SupplierID = 0;
            }
            else
            {
                this.SupplierID = SupplierID;
            }
            // use default value if no "PartnerID" provided
            if (PartnerID == null)
            {
                this.PartnerID = 0;
            }
            else
            {
                this.PartnerID = PartnerID;
            }
            // use default value if no "OtherPlayerID" provided
            if (OtherPlayerID == null)
            {
                this.OtherPlayerID = 0;
            }
            else
            {
                this.OtherPlayerID = OtherPlayerID;
            }
            // use default value if no "CompanyLegalEntityID" provided
            if (CompanyLegalEntityID == null)
            {
                this.CompanyLegalEntityID = 0;
            }
            else
            {
                this.CompanyLegalEntityID = CompanyLegalEntityID;
            }
            // use default value if no "CompanyFunctionID" provided
            if (CompanyFunctionID == null)
            {
                this.CompanyFunctionID = 0;
            }
            else
            {
                this.CompanyFunctionID = CompanyFunctionID;
            }
        }
        
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ProductID", EmitDefaultValue=false)]
        public int? ProductID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="GeoAreaID", EmitDefaultValue=false)]
        public int? GeoAreaID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="CustomerID", EmitDefaultValue=false)]
        public int? CustomerID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="CompetitorID", EmitDefaultValue=false)]
        public int? CompetitorID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="SupplierID", EmitDefaultValue=false)]
        public int? SupplierID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="PartnerID", EmitDefaultValue=false)]
        public int? PartnerID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="OtherPlayerID", EmitDefaultValue=false)]
        public int? OtherPlayerID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="CompanyLegalEntityID", EmitDefaultValue=false)]
        public int? CompanyLegalEntityID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="CompanyFunctionID", EmitDefaultValue=false)]
        public int? CompanyFunctionID { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorporateStructureLink {\n");
            sb.Append("  ProductID: ").Append(ProductID).Append("\n");
            sb.Append("  GeoAreaID: ").Append(GeoAreaID).Append("\n");
            sb.Append("  CustomerID: ").Append(CustomerID).Append("\n");
            sb.Append("  CompetitorID: ").Append(CompetitorID).Append("\n");
            sb.Append("  SupplierID: ").Append(SupplierID).Append("\n");
            sb.Append("  PartnerID: ").Append(PartnerID).Append("\n");
            sb.Append("  OtherPlayerID: ").Append(OtherPlayerID).Append("\n");
            sb.Append("  CompanyLegalEntityID: ").Append(CompanyLegalEntityID).Append("\n");
            sb.Append("  CompanyFunctionID: ").Append(CompanyFunctionID).Append("\n");
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
            return this.Equals(obj as CorporateStructureLink);
        }

        /// <summary>
        /// Returns true if CorporateStructureLink instances are equal
        /// </summary>
        /// <param name="other">Instance of CorporateStructureLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorporateStructureLink other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProductID == other.ProductID ||
                    this.ProductID != null &&
                    this.ProductID.Equals(other.ProductID)
                ) && 
                (
                    this.GeoAreaID == other.GeoAreaID ||
                    this.GeoAreaID != null &&
                    this.GeoAreaID.Equals(other.GeoAreaID)
                ) && 
                (
                    this.CustomerID == other.CustomerID ||
                    this.CustomerID != null &&
                    this.CustomerID.Equals(other.CustomerID)
                ) && 
                (
                    this.CompetitorID == other.CompetitorID ||
                    this.CompetitorID != null &&
                    this.CompetitorID.Equals(other.CompetitorID)
                ) && 
                (
                    this.SupplierID == other.SupplierID ||
                    this.SupplierID != null &&
                    this.SupplierID.Equals(other.SupplierID)
                ) && 
                (
                    this.PartnerID == other.PartnerID ||
                    this.PartnerID != null &&
                    this.PartnerID.Equals(other.PartnerID)
                ) && 
                (
                    this.OtherPlayerID == other.OtherPlayerID ||
                    this.OtherPlayerID != null &&
                    this.OtherPlayerID.Equals(other.OtherPlayerID)
                ) && 
                (
                    this.CompanyLegalEntityID == other.CompanyLegalEntityID ||
                    this.CompanyLegalEntityID != null &&
                    this.CompanyLegalEntityID.Equals(other.CompanyLegalEntityID)
                ) && 
                (
                    this.CompanyFunctionID == other.CompanyFunctionID ||
                    this.CompanyFunctionID != null &&
                    this.CompanyFunctionID.Equals(other.CompanyFunctionID)
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
                if (this.ProductID != null)
                    hash = hash * 59 + this.ProductID.GetHashCode();
                if (this.GeoAreaID != null)
                    hash = hash * 59 + this.GeoAreaID.GetHashCode();
                if (this.CustomerID != null)
                    hash = hash * 59 + this.CustomerID.GetHashCode();
                if (this.CompetitorID != null)
                    hash = hash * 59 + this.CompetitorID.GetHashCode();
                if (this.SupplierID != null)
                    hash = hash * 59 + this.SupplierID.GetHashCode();
                if (this.PartnerID != null)
                    hash = hash * 59 + this.PartnerID.GetHashCode();
                if (this.OtherPlayerID != null)
                    hash = hash * 59 + this.OtherPlayerID.GetHashCode();
                if (this.CompanyLegalEntityID != null)
                    hash = hash * 59 + this.CompanyLegalEntityID.GetHashCode();
                if (this.CompanyFunctionID != null)
                    hash = hash * 59 + this.CompanyFunctionID.GetHashCode();
                return hash;
            }
        }
    }

}
