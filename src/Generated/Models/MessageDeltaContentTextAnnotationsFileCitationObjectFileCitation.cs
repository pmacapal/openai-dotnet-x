// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation()
        {
        }

        internal MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation(string fileId, string quote, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileId = fileId;
            Quote = quote;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        public string FileId { get; }
        public string Quote { get; }
    }
}
