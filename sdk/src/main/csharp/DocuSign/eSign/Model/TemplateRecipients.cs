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
    public class TemplateRecipients : IEquatable<TemplateRecipients>
    {
        
        /// <summary>
        /// A complex type containing information about the Signer recipient.
        /// </summary>
        /// <value>A complex type containing information about the Signer recipient.</value>
        [DataMember(Name="signers", EmitDefaultValue=false)]
        public List<Signer> Signers { get; set; }
  
        
        /// <summary>
        /// A complex type defining the management and access rights of a recipient assigned assigned as an agent on the document.
        /// </summary>
        /// <value>A complex type defining the management and access rights of a recipient assigned assigned as an agent on the document.</value>
        [DataMember(Name="agents", EmitDefaultValue=false)]
        public List<Agent> Agents { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="editors", EmitDefaultValue=false)]
        public List<Editor> Editors { get; set; }
  
        
        /// <summary>
        /// Identifies a recipient that can, but is not required to, add name and email information for recipients at the same or subsequent level in the routing order (until subsequent Agents, Editors or Intermediaries recipient types are added).
        /// </summary>
        /// <value>Identifies a recipient that can, but is not required to, add name and email information for recipients at the same or subsequent level in the routing order (until subsequent Agents, Editors or Intermediaries recipient types are added).</value>
        [DataMember(Name="intermediaries", EmitDefaultValue=false)]
        public List<Intermediary> Intermediaries { get; set; }
  
        
        /// <summary>
        /// A complex type containing information about recipients who should receive a copy of the envelope, but does not need to sign it.
        /// </summary>
        /// <value>A complex type containing information about recipients who should receive a copy of the envelope, but does not need to sign it.</value>
        [DataMember(Name="carbonCopies", EmitDefaultValue=false)]
        public List<CarbonCopy> CarbonCopies { get; set; }
  
        
        /// <summary>
        /// A complex type containing information on a recipient the must receive the completed documents for the envelope to be completed, but the recipient does not need to sign, initial, date, or add information to any of the documents.
        /// </summary>
        /// <value>A complex type containing information on a recipient the must receive the completed documents for the envelope to be completed, but the recipient does not need to sign, initial, date, or add information to any of the documents.</value>
        [DataMember(Name="certifiedDeliveries", EmitDefaultValue=false)]
        public List<CertifiedDelivery> CertifiedDeliveries { get; set; }
  
        
        /// <summary>
        /// Specifies a signer that is in the same physical location as a DocuSign user who will act as a Signing Host for the transaction. The recipient added is the Signing Host and new separate Signer Name field appears after Sign in person is selected.
        /// </summary>
        /// <value>Specifies a signer that is in the same physical location as a DocuSign user who will act as a Signing Host for the transaction. The recipient added is the Signing Host and new separate Signer Name field appears after Sign in person is selected.</value>
        [DataMember(Name="inPersonSigners", EmitDefaultValue=false)]
        public List<InPersonSigner> InPersonSigners { get; set; }
  
        
        /// <summary>
        /// The list of recipient event statuses that will trigger Connect to send updates to the url. It can be a two-part list with:\n\n* recipientEventStatusCode - The recipient status, this can be Sent, Delivered, Completed, Declined, AuthenticationFailed, and AutoResponded.\n* includeDocuments - When set to **true**, the envelope time zone information is included in the message.
        /// </summary>
        /// <value>The list of recipient event statuses that will trigger Connect to send updates to the url. It can be a two-part list with:\n\n* recipientEventStatusCode - The recipient status, this can be Sent, Delivered, Completed, Declined, AuthenticationFailed, and AutoResponded.\n* includeDocuments - When set to **true**, the envelope time zone information is included in the message.</value>
        [DataMember(Name="recipientCount", EmitDefaultValue=false)]
        public string RecipientCount { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="currentRoutingOrder", EmitDefaultValue=false)]
        public string CurrentRoutingOrder { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateRecipients {\n");
            sb.Append("  Signers: ").Append(Signers).Append("\n");
            sb.Append("  Agents: ").Append(Agents).Append("\n");
            sb.Append("  Editors: ").Append(Editors).Append("\n");
            sb.Append("  Intermediaries: ").Append(Intermediaries).Append("\n");
            sb.Append("  CarbonCopies: ").Append(CarbonCopies).Append("\n");
            sb.Append("  CertifiedDeliveries: ").Append(CertifiedDeliveries).Append("\n");
            sb.Append("  InPersonSigners: ").Append(InPersonSigners).Append("\n");
            sb.Append("  RecipientCount: ").Append(RecipientCount).Append("\n");
            sb.Append("  CurrentRoutingOrder: ").Append(CurrentRoutingOrder).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            
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
            return this.Equals(obj as TemplateRecipients);
        }

        /// <summary>
        /// Returns true if TemplateRecipients instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateRecipients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateRecipients other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Signers == other.Signers ||
                    this.Signers != null &&
                    this.Signers.SequenceEqual(other.Signers)
                ) && 
                (
                    this.Agents == other.Agents ||
                    this.Agents != null &&
                    this.Agents.SequenceEqual(other.Agents)
                ) && 
                (
                    this.Editors == other.Editors ||
                    this.Editors != null &&
                    this.Editors.SequenceEqual(other.Editors)
                ) && 
                (
                    this.Intermediaries == other.Intermediaries ||
                    this.Intermediaries != null &&
                    this.Intermediaries.SequenceEqual(other.Intermediaries)
                ) && 
                (
                    this.CarbonCopies == other.CarbonCopies ||
                    this.CarbonCopies != null &&
                    this.CarbonCopies.SequenceEqual(other.CarbonCopies)
                ) && 
                (
                    this.CertifiedDeliveries == other.CertifiedDeliveries ||
                    this.CertifiedDeliveries != null &&
                    this.CertifiedDeliveries.SequenceEqual(other.CertifiedDeliveries)
                ) && 
                (
                    this.InPersonSigners == other.InPersonSigners ||
                    this.InPersonSigners != null &&
                    this.InPersonSigners.SequenceEqual(other.InPersonSigners)
                ) && 
                (
                    this.RecipientCount == other.RecipientCount ||
                    this.RecipientCount != null &&
                    this.RecipientCount.Equals(other.RecipientCount)
                ) && 
                (
                    this.CurrentRoutingOrder == other.CurrentRoutingOrder ||
                    this.CurrentRoutingOrder != null &&
                    this.CurrentRoutingOrder.Equals(other.CurrentRoutingOrder)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
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
                
                if (this.Signers != null)
                    hash = hash * 57 + this.Signers.GetHashCode();
                
                if (this.Agents != null)
                    hash = hash * 57 + this.Agents.GetHashCode();
                
                if (this.Editors != null)
                    hash = hash * 57 + this.Editors.GetHashCode();
                
                if (this.Intermediaries != null)
                    hash = hash * 57 + this.Intermediaries.GetHashCode();
                
                if (this.CarbonCopies != null)
                    hash = hash * 57 + this.CarbonCopies.GetHashCode();
                
                if (this.CertifiedDeliveries != null)
                    hash = hash * 57 + this.CertifiedDeliveries.GetHashCode();
                
                if (this.InPersonSigners != null)
                    hash = hash * 57 + this.InPersonSigners.GetHashCode();
                
                if (this.RecipientCount != null)
                    hash = hash * 57 + this.RecipientCount.GetHashCode();
                
                if (this.CurrentRoutingOrder != null)
                    hash = hash * 57 + this.CurrentRoutingOrder.GetHashCode();
                
                if (this.ErrorDetails != null)
                    hash = hash * 57 + this.ErrorDetails.GetHashCode();
                
                return hash;
            }
        }

    }
}
