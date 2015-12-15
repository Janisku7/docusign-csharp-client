using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DocuSign.eSign.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ServerTemplate : IEquatable<ServerTemplate>
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="sequence", EmitDefaultValue=false)]
        public string Sequence { get; set; }
  
        
        /// <summary>
        /// The unique identifier of the template. If this is not provided, DocuSign will generate a value.
        /// </summary>
        /// <value>The unique identifier of the template. If this is not provided, DocuSign will generate a value.</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerTemplate {\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            
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
            return this.Equals(obj as ServerTemplate);
        }

        /// <summary>
        /// Returns true if ServerTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of ServerTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Sequence == other.Sequence ||
                    this.Sequence != null &&
                    this.Sequence.Equals(other.Sequence)
                ) && 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
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
                
                if (this.Sequence != null)
                    hash = hash * 57 + this.Sequence.GetHashCode();
                
                if (this.TemplateId != null)
                    hash = hash * 57 + this.TemplateId.GetHashCode();
                
                return hash;
            }
        }

    }
}
