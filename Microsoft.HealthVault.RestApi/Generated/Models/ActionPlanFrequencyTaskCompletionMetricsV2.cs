// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.HealthVault.RestApi.Generated.Models
{
    using Microsoft.HealthVault;
    using Microsoft.HealthVault.RestApi;
    using Microsoft.HealthVault.RestApi.Generated;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Completion Metrics for frequency based tasks
    /// </summary>
    public partial class ActionPlanFrequencyTaskCompletionMetricsV2
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ActionPlanFrequencyTaskCompletionMetricsV2 class.
        /// </summary>
        public ActionPlanFrequencyTaskCompletionMetricsV2()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ActionPlanFrequencyTaskCompletionMetricsV2 class.
        /// </summary>
        /// <param name="windowType">The window in which the occurrences must
        /// be completed. Possible values include: 'Unknown', 'None', 'Daily',
        /// 'Weekly'</param>
        /// <param name="occurrenceCount">The number of times the Task has to
        /// be completed</param>
        public ActionPlanFrequencyTaskCompletionMetricsV2(string windowType = default(string), int? occurrenceCount = default(int?))
        {
            WindowType = windowType;
            OccurrenceCount = occurrenceCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the window in which the occurrences must be completed.
        /// Possible values include: 'Unknown', 'None', 'Daily', 'Weekly'
        /// </summary>
        [JsonProperty(PropertyName = "windowType")]
        public string WindowType { get; set; }

        /// <summary>
        /// Gets or sets the number of times the Task has to be completed
        /// </summary>
        [JsonProperty(PropertyName = "occurrenceCount")]
        public int? OccurrenceCount { get; set; }

    }
}
