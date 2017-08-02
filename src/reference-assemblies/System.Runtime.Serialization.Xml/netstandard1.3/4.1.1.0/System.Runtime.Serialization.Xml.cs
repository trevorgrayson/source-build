[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Corporation")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Corporation.  All rights reserved.")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Runtime.Serialization.Xml")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Runtime.Serialization.Xml")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("1.0.24212.01")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("1.0.24212.01. Commit Hash: 9688ddbb62c04189cac4c4a06e31e93377dccd41")]
[assembly:System.Reflection.AssemblyMetadataAttribute(".NETFrameworkAssembly", "")]
[assembly:System.Reflection.AssemblyMetadataAttribute("Serviceable", "True")]
[assembly:System.Reflection.AssemblyProductAttribute("Microsoft® .NET Framework")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Runtime.Serialization.Xml")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
namespace System.Runtime.Serialization
{
    public abstract partial class DataContractResolver
    {
        protected DataContractResolver() { }
        public abstract System.Type ResolveName(string typeName, string typeNamespace, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver);
        public abstract bool TryResolveType(System.Type type, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver, out System.Xml.XmlDictionaryString typeName, out System.Xml.XmlDictionaryString typeNamespace);
    }
    public sealed partial class DataContractSerializer : System.Runtime.Serialization.XmlObjectSerializer
    {
        public DataContractSerializer(System.Type type) { }
        public DataContractSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
        public DataContractSerializer(System.Type type, System.Runtime.Serialization.DataContractSerializerSettings settings) { }
        public DataContractSerializer(System.Type type, string rootName, string rootNamespace) { }
        public DataContractSerializer(System.Type type, string rootName, string rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
        public DataContractSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace) { }
        public DataContractSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
        public bool IgnoreExtensionDataObject { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Type> KnownTypes { get { throw null; } }
        public int MaxItemsInObjectGraph { get { throw null; } }
        public bool PreserveObjectReferences { get { throw null; } }
        public bool SerializeReadOnlyTypes { get { throw null; } }
        public override bool IsStartObject(System.Xml.XmlDictionaryReader reader) { throw null; }
        public override bool IsStartObject(System.Xml.XmlReader reader) { throw null; }
        public override object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName) { throw null; }
        public override object ReadObject(System.Xml.XmlReader reader) { throw null; }
        public override object ReadObject(System.Xml.XmlReader reader, bool verifyObjectName) { throw null; }
        public override void WriteEndObject(System.Xml.XmlDictionaryWriter writer) { }
        public override void WriteEndObject(System.Xml.XmlWriter writer) { }
        public override void WriteObject(System.Xml.XmlWriter writer, object graph) { }
        public override void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph) { }
        public override void WriteObjectContent(System.Xml.XmlWriter writer, object graph) { }
        public override void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
        public override void WriteStartObject(System.Xml.XmlWriter writer, object graph) { }
    }
    public static partial class DataContractSerializerExtensions
    {
        public static System.Runtime.Serialization.ISerializationSurrogateProvider GetSerializationSurrogateProvider(this System.Runtime.Serialization.DataContractSerializer serializer) { throw null; }
        public static void SetSerializationSurrogateProvider(this System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.ISerializationSurrogateProvider provider) { }
    }
    public partial class DataContractSerializerSettings
    {
        public DataContractSerializerSettings() { }
        public System.Runtime.Serialization.DataContractResolver DataContractResolver { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<System.Type> KnownTypes { get { throw null; } set { } }
        public int MaxItemsInObjectGraph { get { throw null; } set { } }
        public bool PreserveObjectReferences { get { throw null; } set { } }
        public System.Xml.XmlDictionaryString RootName { get { throw null; } set { } }
        public System.Xml.XmlDictionaryString RootNamespace { get { throw null; } set { } }
        public bool SerializeReadOnlyTypes { get { throw null; } set { } }
    }
    public abstract partial class XmlObjectSerializer
    {
        protected XmlObjectSerializer() { }
        public abstract bool IsStartObject(System.Xml.XmlDictionaryReader reader);
        public virtual bool IsStartObject(System.Xml.XmlReader reader) { throw null; }
        public virtual object ReadObject(System.IO.Stream stream) { throw null; }
        public virtual object ReadObject(System.Xml.XmlDictionaryReader reader) { throw null; }
        public abstract object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName);
        public virtual object ReadObject(System.Xml.XmlReader reader) { throw null; }
        public virtual object ReadObject(System.Xml.XmlReader reader, bool verifyObjectName) { throw null; }
        public abstract void WriteEndObject(System.Xml.XmlDictionaryWriter writer);
        public virtual void WriteEndObject(System.Xml.XmlWriter writer) { }
        public virtual void WriteObject(System.IO.Stream stream, object graph) { }
        public virtual void WriteObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
        public virtual void WriteObject(System.Xml.XmlWriter writer, object graph) { }
        public abstract void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph);
        public virtual void WriteObjectContent(System.Xml.XmlWriter writer, object graph) { }
        public abstract void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph);
        public virtual void WriteStartObject(System.Xml.XmlWriter writer, object graph) { }
    }
}
namespace System.Xml
{
    public partial interface IXmlDictionary
    {
        bool TryLookup(int key, out System.Xml.XmlDictionaryString result);
        bool TryLookup(string value, out System.Xml.XmlDictionaryString result);
        bool TryLookup(System.Xml.XmlDictionaryString value, out System.Xml.XmlDictionaryString result);
    }
    public delegate void OnXmlDictionaryReaderClose(System.Xml.XmlDictionaryReader reader);
    public partial class UniqueId
    {
        public UniqueId() { }
        public UniqueId(byte[] guid) { }
        public UniqueId(byte[] guid, int offset) { }
        public UniqueId(char[] chars, int offset, int count) { }
        public UniqueId(System.Guid guid) { }
        public UniqueId(string value) { }
        public int CharArrayLength { get { throw null; } }
        public bool IsGuid { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Xml.UniqueId id1, System.Xml.UniqueId id2) { throw null; }
        public static bool operator !=(System.Xml.UniqueId id1, System.Xml.UniqueId id2) { throw null; }
        public int ToCharArray(char[] chars, int offset) { throw null; }
        public override string ToString() { throw null; }
        public bool TryGetGuid(byte[] buffer, int offset) { throw null; }
        public bool TryGetGuid(out System.Guid guid) { guid = default(System.Guid); throw null; }
    }
    public partial class XmlBinaryReaderSession : System.Xml.IXmlDictionary
    {
        public XmlBinaryReaderSession() { }
        public System.Xml.XmlDictionaryString Add(int id, string value) { throw null; }
        public void Clear() { }
        public bool TryLookup(int key, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); throw null; }
        public bool TryLookup(string value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); throw null; }
        public bool TryLookup(System.Xml.XmlDictionaryString value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); throw null; }
    }
    public partial class XmlBinaryWriterSession
    {
        public XmlBinaryWriterSession() { }
        public void Reset() { }
        public virtual bool TryAdd(System.Xml.XmlDictionaryString value, out int key) { key = default(int); throw null; }
    }
    public partial class XmlDictionary : System.Xml.IXmlDictionary
    {
        public XmlDictionary() { }
        public XmlDictionary(int capacity) { }
        public static System.Xml.IXmlDictionary Empty { get { throw null; } }
        public virtual System.Xml.XmlDictionaryString Add(string value) { throw null; }
        public virtual bool TryLookup(int key, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); throw null; }
        public virtual bool TryLookup(string value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); throw null; }
        public virtual bool TryLookup(System.Xml.XmlDictionaryString value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); throw null; }
    }
    public abstract partial class XmlDictionaryReader : System.Xml.XmlReader
    {
        protected XmlDictionaryReader() { }
        public virtual bool CanCanonicalize { get { throw null; } }
        public virtual System.Xml.XmlDictionaryReaderQuotas Quotas { get { throw null; } }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateDictionaryReader(System.Xml.XmlReader reader) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public virtual void EndCanonicalization() { }
        public virtual string GetAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual int IndexOfLocalName(string[] localNames, string namespaceUri) { throw null; }
        public virtual int IndexOfLocalName(System.Xml.XmlDictionaryString[] localNames, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual bool IsLocalName(string localName) { throw null; }
        public virtual bool IsLocalName(System.Xml.XmlDictionaryString localName) { throw null; }
        public virtual bool IsNamespaceUri(string namespaceUri) { throw null; }
        public virtual bool IsNamespaceUri(System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual bool IsStartArray(out System.Type type) { type = default(System.Type); throw null; }
        public virtual bool IsStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        protected bool IsTextNode(System.Xml.XmlNodeType nodeType) { throw null; }
        public virtual void MoveToStartElement() { }
        public virtual void MoveToStartElement(string name) { }
        public virtual void MoveToStartElement(string localName, string namespaceUri) { }
        public virtual void MoveToStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual int ReadArray(string localName, string namespaceUri, bool[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, System.DateTime[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, decimal[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, double[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, System.Guid[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, short[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, int[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, long[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, float[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count) { throw null; }
        public virtual bool[] ReadBooleanArray(string localName, string namespaceUri) { throw null; }
        public virtual bool[] ReadBooleanArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public override object ReadContentAs(System.Type type, System.Xml.IXmlNamespaceResolver namespaceResolver) { throw null; }
        public virtual byte[] ReadContentAsBase64() { throw null; }
        public virtual byte[] ReadContentAsBinHex() { throw null; }
        protected byte[] ReadContentAsBinHex(int maxByteArrayContentLength) { throw null; }
        public virtual int ReadContentAsChars(char[] chars, int offset, int count) { throw null; }
        public override decimal ReadContentAsDecimal() { throw null; }
        public override float ReadContentAsFloat() { throw null; }
        public virtual System.Guid ReadContentAsGuid() { throw null; }
        public virtual void ReadContentAsQualifiedName(out string localName, out string namespaceUri) { localName = default(string); namespaceUri = default(string); }
        public override string ReadContentAsString() { throw null; }
        protected string ReadContentAsString(int maxStringContentLength) { throw null; }
        public virtual string ReadContentAsString(string[] strings, out int index) { index = default(int); throw null; }
        public virtual string ReadContentAsString(System.Xml.XmlDictionaryString[] strings, out int index) { index = default(int); throw null; }
        public virtual System.TimeSpan ReadContentAsTimeSpan() { throw null; }
        public virtual System.Xml.UniqueId ReadContentAsUniqueId() { throw null; }
        public virtual System.DateTime[] ReadDateTimeArray(string localName, string namespaceUri) { throw null; }
        public virtual System.DateTime[] ReadDateTimeArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual decimal[] ReadDecimalArray(string localName, string namespaceUri) { throw null; }
        public virtual decimal[] ReadDecimalArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual double[] ReadDoubleArray(string localName, string namespaceUri) { throw null; }
        public virtual double[] ReadDoubleArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual byte[] ReadElementContentAsBase64() { throw null; }
        public virtual byte[] ReadElementContentAsBinHex() { throw null; }
        public override bool ReadElementContentAsBoolean() { throw null; }
        public override decimal ReadElementContentAsDecimal() { throw null; }
        public override double ReadElementContentAsDouble() { throw null; }
        public override float ReadElementContentAsFloat() { throw null; }
        public virtual System.Guid ReadElementContentAsGuid() { throw null; }
        public override int ReadElementContentAsInt() { throw null; }
        public override long ReadElementContentAsLong() { throw null; }
        public override string ReadElementContentAsString() { throw null; }
        public virtual System.TimeSpan ReadElementContentAsTimeSpan() { throw null; }
        public virtual System.Xml.UniqueId ReadElementContentAsUniqueId() { throw null; }
        public virtual void ReadFullStartElement() { }
        public virtual void ReadFullStartElement(string name) { }
        public virtual void ReadFullStartElement(string localName, string namespaceUri) { }
        public virtual void ReadFullStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual System.Guid[] ReadGuidArray(string localName, string namespaceUri) { throw null; }
        public virtual System.Guid[] ReadGuidArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual short[] ReadInt16Array(string localName, string namespaceUri) { throw null; }
        public virtual short[] ReadInt16Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual int[] ReadInt32Array(string localName, string namespaceUri) { throw null; }
        public virtual int[] ReadInt32Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual long[] ReadInt64Array(string localName, string namespaceUri) { throw null; }
        public virtual long[] ReadInt64Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual float[] ReadSingleArray(string localName, string namespaceUri) { throw null; }
        public virtual float[] ReadSingleArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual void ReadStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual System.TimeSpan[] ReadTimeSpanArray(string localName, string namespaceUri) { throw null; }
        public virtual System.TimeSpan[] ReadTimeSpanArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual int ReadValueAsBase64(byte[] buffer, int offset, int count) { throw null; }
        public virtual void StartCanonicalization(System.IO.Stream stream, bool includeComments, string[] inclusivePrefixes) { }
        public virtual bool TryGetArrayLength(out int count) { count = default(int); throw null; }
        public virtual bool TryGetBase64ContentLength(out int length) { length = default(int); throw null; }
        public virtual bool TryGetLocalNameAsDictionaryString(out System.Xml.XmlDictionaryString localName) { localName = default(System.Xml.XmlDictionaryString); throw null; }
        public virtual bool TryGetNamespaceUriAsDictionaryString(out System.Xml.XmlDictionaryString namespaceUri) { namespaceUri = default(System.Xml.XmlDictionaryString); throw null; }
        public virtual bool TryGetValueAsDictionaryString(out System.Xml.XmlDictionaryString value) { value = default(System.Xml.XmlDictionaryString); throw null; }
    }
    public sealed partial class XmlDictionaryReaderQuotas
    {
        public XmlDictionaryReaderQuotas() { }
        public static System.Xml.XmlDictionaryReaderQuotas Max { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(16384)]
        public int MaxArrayLength { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(4096)]
        public int MaxBytesPerRead { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(32)]
        public int MaxDepth { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(16384)]
        public int MaxNameTableCharCount { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(8192)]
        public int MaxStringContentLength { get { throw null; } set { } }
        public System.Xml.XmlDictionaryReaderQuotaTypes ModifiedQuotas { get { throw null; } }
        public void CopyTo(System.Xml.XmlDictionaryReaderQuotas quotas) { }
    }
    [System.FlagsAttribute]
    public enum XmlDictionaryReaderQuotaTypes
    {
        MaxArrayLength = 4,
        MaxBytesPerRead = 8,
        MaxDepth = 1,
        MaxNameTableCharCount = 16,
        MaxStringContentLength = 2,
    }
    public partial class XmlDictionaryString
    {
        public XmlDictionaryString(System.Xml.IXmlDictionary dictionary, string value, int key) { }
        public System.Xml.IXmlDictionary Dictionary { get { throw null; } }
        public static System.Xml.XmlDictionaryString Empty { get { throw null; } }
        public int Key { get { throw null; } }
        public string Value { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public abstract partial class XmlDictionaryWriter : System.Xml.XmlWriter
    {
        protected XmlDictionaryWriter() { }
        public virtual bool CanCanonicalize { get { throw null; } }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryWriterSession session) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryWriterSession session, bool ownsStream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateDictionaryWriter(System.Xml.XmlWriter writer) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream, System.Text.Encoding encoding) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream) { throw null; }
        public virtual void EndCanonicalization() { }
        public virtual void StartCanonicalization(System.IO.Stream stream, bool includeComments, string[] inclusivePrefixes) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, bool[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.DateTime[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, decimal[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, double[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.Guid[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, short[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, int[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, long[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, float[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count) { }
        public void WriteAttributeString(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
        public void WriteAttributeString(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
        public void WriteElementString(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
        public void WriteElementString(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
        public virtual void WriteNode(System.Xml.XmlDictionaryReader reader, bool defattr) { }
        public override void WriteNode(System.Xml.XmlReader reader, bool defattr) { }
        public virtual void WriteQualifiedName(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public void WriteStartAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public void WriteStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual void WriteString(System.Xml.XmlDictionaryString value) { }
        protected virtual void WriteTextNode(System.Xml.XmlDictionaryReader reader, bool isAttribute) { }
        public virtual void WriteValue(System.Guid value) { }
        public virtual void WriteValue(System.TimeSpan value) { }
        public virtual void WriteValue(System.Xml.UniqueId value) { }
        public virtual void WriteValue(System.Xml.XmlDictionaryString value) { }
        public virtual void WriteXmlAttribute(string localName, string value) { }
        public virtual void WriteXmlAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString value) { }
        public virtual void WriteXmlnsAttribute(string prefix, string namespaceUri) { }
        public virtual void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString namespaceUri) { }
    }
}
