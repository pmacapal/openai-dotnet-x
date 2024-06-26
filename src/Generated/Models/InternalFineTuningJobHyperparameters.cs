// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.FineTuning
{
    internal partial class InternalFineTuningJobHyperparameters
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal InternalFineTuningJobHyperparameters(BinaryData nEpochs)
        {
            Argument.AssertNotNull(nEpochs, nameof(nEpochs));

            NEpochs = nEpochs;
        }

        internal InternalFineTuningJobHyperparameters(BinaryData nEpochs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NEpochs = nEpochs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalFineTuningJobHyperparameters()
        {
        }

        public BinaryData NEpochs { get; }
    }
}
