// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionResponseMessageFunctionCall
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal InternalChatCompletionResponseMessageFunctionCall(string arguments, string name)
        {
            Argument.AssertNotNull(arguments, nameof(arguments));
            Argument.AssertNotNull(name, nameof(name));

            Arguments = arguments;
            Name = name;
        }

        internal InternalChatCompletionResponseMessageFunctionCall(string arguments, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Arguments = arguments;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalChatCompletionResponseMessageFunctionCall()
        {
        }

        public string Arguments { get; }
        public string Name { get; }
    }
}
