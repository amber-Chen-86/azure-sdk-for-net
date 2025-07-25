// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.OpenAI;

namespace Azure.AI.OpenAI.Chat
{
    /// <summary> The DataSourceFieldMappings. </summary>
    public partial class DataSourceFieldMappings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        /// <summary> Initializes a new instance of <see cref="DataSourceFieldMappings"/>. </summary>
        public DataSourceFieldMappings() : this(null, null, null, null, null, null, null, null)
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataSourceFieldMappings"/>. </summary>
        /// <param name="titleFieldName"> The name of the index field to use as a title. </param>
        /// <param name="urlFieldName"> The name of the index field to use as a URL. </param>
        /// <param name="filePathFieldName"> The name of the index field to use as a filepath. </param>
        /// <param name="contentFieldNames"> The names of index fields that should be treated as content. </param>
        /// <param name="contentFieldSeparator"> The separator pattern that content fields should use. </param>
        /// <param name="vectorFieldNames"> The names of fields that represent vector data. </param>
        /// <param name="imageVectorFieldNames"> The names of fields that represent image vector data. </param>
        /// <param name="additionalBinaryDataProperties"> Keeps track of any properties unknown to the library. </param>
        internal DataSourceFieldMappings(string titleFieldName, string urlFieldName, string filePathFieldName, IList<string> contentFieldNames, string contentFieldSeparator, IList<string> vectorFieldNames, IList<string> imageVectorFieldNames, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            TitleFieldName = titleFieldName;
            UrlFieldName = urlFieldName;
            FilePathFieldName = filePathFieldName;
            ContentFieldNames = contentFieldNames ?? new ChangeTrackingList<string>();
            ContentFieldSeparator = contentFieldSeparator;
            VectorFieldNames = vectorFieldNames ?? new ChangeTrackingList<string>();
            ImageVectorFieldNames = imageVectorFieldNames ?? new ChangeTrackingList<string>();
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary></summary>
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
