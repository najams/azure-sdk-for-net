// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Content
    {
        /// <summary>
        /// Initializes a new instance of the Content class.
        /// </summary>
        public Content()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Content class.
        /// </summary>
        /// <param name="contentValue">Content to evaluate for a job.</param>
        public Content(string contentValue)
        {
            ContentValue = contentValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets content to evaluate for a job.
        /// </summary>
        [JsonProperty(PropertyName = "ContentValue")]
        public string ContentValue { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContentValue == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContentValue");
            }
        }
    }
}