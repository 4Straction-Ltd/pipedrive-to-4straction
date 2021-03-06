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
    /// PartnerComment
    /// </summary>
    [DataContract]
    public partial class PartnerComment :  IEquatable<PartnerComment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerComment" /> class.
        /// </summary>
        /// <param name="PartnerID">reflection (default to 0).</param>
        /// <param name="UserID">reflection (default to 0).</param>
        /// <param name="DateAdded">reflection.</param>
        /// <param name="Comment">reflection (default to &quot;&quot;).</param>
        /// <param name="ReplyToCommentID">reflection.</param>
        /// <param name="ID">reflection (default to 0).</param>
        public PartnerComment(int? PartnerID = null, int? UserID = null, DateTime? DateAdded = null, string Comment = null, int? ReplyToCommentID = null, int? ID = null)
        {
            // use default value if no "PartnerID" provided
            if (PartnerID == null)
            {
                this.PartnerID = 0;
            }
            else
            {
                this.PartnerID = PartnerID;
            }
            // use default value if no "UserID" provided
            if (UserID == null)
            {
                this.UserID = 0;
            }
            else
            {
                this.UserID = UserID;
            }
            this.DateAdded = DateAdded;
            // use default value if no "Comment" provided
            if (Comment == null)
            {
                this.Comment = "";
            }
            else
            {
                this.Comment = Comment;
            }
            this.ReplyToCommentID = ReplyToCommentID;
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
        [DataMember(Name="PartnerID", EmitDefaultValue=false)]
        public int? PartnerID { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="UserID", EmitDefaultValue=false)]
        public int? UserID { get; set; }
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
        [DataMember(Name="Comment", EmitDefaultValue=false)]
        public string Comment { get; set; }
        /// <summary>
        /// reflection
        /// </summary>
        /// <value>reflection</value>
        [DataMember(Name="ReplyToCommentID", EmitDefaultValue=false)]
        public int? ReplyToCommentID { get; set; }
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
            sb.Append("class PartnerComment {\n");
            sb.Append("  PartnerID: ").Append(PartnerID).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  DateAdded: ").Append(DateAdded).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  ReplyToCommentID: ").Append(ReplyToCommentID).Append("\n");
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
            return this.Equals(obj as PartnerComment);
        }

        /// <summary>
        /// Returns true if PartnerComment instances are equal
        /// </summary>
        /// <param name="other">Instance of PartnerComment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartnerComment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PartnerID == other.PartnerID ||
                    this.PartnerID != null &&
                    this.PartnerID.Equals(other.PartnerID)
                ) && 
                (
                    this.UserID == other.UserID ||
                    this.UserID != null &&
                    this.UserID.Equals(other.UserID)
                ) && 
                (
                    this.DateAdded == other.DateAdded ||
                    this.DateAdded != null &&
                    this.DateAdded.Equals(other.DateAdded)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.ReplyToCommentID == other.ReplyToCommentID ||
                    this.ReplyToCommentID != null &&
                    this.ReplyToCommentID.Equals(other.ReplyToCommentID)
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
                if (this.PartnerID != null)
                    hash = hash * 59 + this.PartnerID.GetHashCode();
                if (this.UserID != null)
                    hash = hash * 59 + this.UserID.GetHashCode();
                if (this.DateAdded != null)
                    hash = hash * 59 + this.DateAdded.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.ReplyToCommentID != null)
                    hash = hash * 59 + this.ReplyToCommentID.GetHashCode();
                if (this.ID != null)
                    hash = hash * 59 + this.ID.GetHashCode();
                return hash;
            }
        }
    }

}
