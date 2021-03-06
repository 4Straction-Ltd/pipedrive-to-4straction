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
    /// PerformanceIndicatorDataReport
    /// </summary>
    [DataContract]
    public partial class PerformanceIndicatorDataReport :  IEquatable<PerformanceIndicatorDataReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceIndicatorDataReport" /> class.
        /// </summary>
        /// <param name="Date">reflection.</param>
        /// <param name="Actual">reflection (default to 0.0).</param>
        /// <param name="Budget">reflection (default to 0.0).</param>
        /// <param name="Forecast">reflection (default to 0.0).</param>
        /// <param name="Goal">reflection (default to 0.0).</param>
        /// <param name="Comment">reflection (default to &quot;&quot;).</param>
        /// <param name="ActualSourceID">reflection (default to 0).</param>
        /// <param name="BudgetSourceID">reflection (default to 0).</param>
        public PerformanceIndicatorDataReport(DateTime? Date = null, double? Actual = null, double? Budget = null, double? Forecast = null, double? Goal = null, string Comment = null, int? ActualSourceID = null, int? BudgetSourceID = null)
        {
            this.Date = Date;
            // use default value if no "Actual" provided
            if (Actual == null)
            {
                this.Actual = 0.0;
            }
            else
            {
                this.Actual = Actual;
            }
            // use default value if no "Budget" provided
            if (Budget == null)
            {
                this.Budget = 0.0;
            }
            else
            {
                this.Budget = Budget;
            }
            // use default value if no "Forecast" provided
            if (Forecast == null)
            {
                this.Forecast = 0.0;
            }
            else
            {
                this.Forecast = Forecast;
            }
            // use default value if no "Goal" provided
            if (Goal == null)
            {
                this.Goal = 0.0;
            }
            else
            {
                this.Goal = Goal;
            }
            // use default value if no "Comment" provided
            if (Comment == null)
            {
                this.Comment = "";
            }
            else
            {
                this.Comment = Comment;
            }
            // use default value if no "ActualSourceID" provided
            if (ActualSourceID == null)
            {
                this.ActualSourceID = 0;
            }
            else
            {
                this.ActualSourceID = ActualSourceID;
            }
            // use default value if no "BudgetSourceID" provided
            if (BudgetSourceID == null)
            {
                this.BudgetSourceID = 0;
            }
            else
            {
                this.BudgetSourceID = BudgetSourceID;
            }
        }
        
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
        [DataMember(Name="Actual", EmitDefaultValue=false)]
        public double? Actual { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="Budget", EmitDefaultValue=false)]
        public double? Budget { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="Forecast", EmitDefaultValue=false)]
        public double? Forecast { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="Goal", EmitDefaultValue=false)]
        public double? Goal { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="Comment", EmitDefaultValue=false)]
        public string Comment { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ActualSourceID", EmitDefaultValue=false)]
        public int? ActualSourceID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="BudgetSourceID", EmitDefaultValue=false)]
        public int? BudgetSourceID { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PerformanceIndicatorDataReport {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Actual: ").Append(Actual).Append("\n");
            sb.Append("  Budget: ").Append(Budget).Append("\n");
            sb.Append("  Forecast: ").Append(Forecast).Append("\n");
            sb.Append("  Goal: ").Append(Goal).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  ActualSourceID: ").Append(ActualSourceID).Append("\n");
            sb.Append("  BudgetSourceID: ").Append(BudgetSourceID).Append("\n");
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
            return this.Equals(obj as PerformanceIndicatorDataReport);
        }

        /// <summary>
        /// Returns true if PerformanceIndicatorDataReport instances are equal
        /// </summary>
        /// <param name="other">Instance of PerformanceIndicatorDataReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformanceIndicatorDataReport other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.Actual == other.Actual ||
                    this.Actual != null &&
                    this.Actual.Equals(other.Actual)
                ) && 
                (
                    this.Budget == other.Budget ||
                    this.Budget != null &&
                    this.Budget.Equals(other.Budget)
                ) && 
                (
                    this.Forecast == other.Forecast ||
                    this.Forecast != null &&
                    this.Forecast.Equals(other.Forecast)
                ) && 
                (
                    this.Goal == other.Goal ||
                    this.Goal != null &&
                    this.Goal.Equals(other.Goal)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.ActualSourceID == other.ActualSourceID ||
                    this.ActualSourceID != null &&
                    this.ActualSourceID.Equals(other.ActualSourceID)
                ) && 
                (
                    this.BudgetSourceID == other.BudgetSourceID ||
                    this.BudgetSourceID != null &&
                    this.BudgetSourceID.Equals(other.BudgetSourceID)
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
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.Actual != null)
                    hash = hash * 59 + this.Actual.GetHashCode();
                if (this.Budget != null)
                    hash = hash * 59 + this.Budget.GetHashCode();
                if (this.Forecast != null)
                    hash = hash * 59 + this.Forecast.GetHashCode();
                if (this.Goal != null)
                    hash = hash * 59 + this.Goal.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.ActualSourceID != null)
                    hash = hash * 59 + this.ActualSourceID.GetHashCode();
                if (this.BudgetSourceID != null)
                    hash = hash * 59 + this.BudgetSourceID.GetHashCode();
                return hash;
            }
        }
    }

}
