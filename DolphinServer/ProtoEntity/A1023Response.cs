// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: A1023Response.txt
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace DolphinServer.ProtoEntity {

  namespace Proto {

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class A1023Response {

      #region Extension registration
      public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
      }
      #endregion
      #region Static variables
      internal static pbd::MessageDescriptor internal__static_A1023Response__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::DolphinServer.ProtoEntity.A1023Response, global::DolphinServer.ProtoEntity.A1023Response.Builder> internal__static_A1023Response__FieldAccessorTable;
      #endregion
      #region Descriptor
      public static pbd::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbd::FileDescriptor descriptor;

      static A1023Response() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "ChFBMTAyM1Jlc3BvbnNlLnR4dCI1Cg1BMTAyM1Jlc3BvbnNlEhEKCUVycm9y", 
              "SW5mbxgBIAEoCRIRCglFcnJvckNvZGUYAiABKAVCHKoCGURvbHBoaW5TZXJ2", 
            "ZXIuUHJvdG9FbnRpdHk="));
        pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
          descriptor = root;
          internal__static_A1023Response__Descriptor = Descriptor.MessageTypes[0];
          internal__static_A1023Response__FieldAccessorTable = 
              new pb::FieldAccess.FieldAccessorTable<global::DolphinServer.ProtoEntity.A1023Response, global::DolphinServer.ProtoEntity.A1023Response.Builder>(internal__static_A1023Response__Descriptor,
                  new string[] { "ErrorInfo", "ErrorCode", });
          pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
          RegisterAllExtensions(registry);
          return registry;
        };
        pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
            new pbd::FileDescriptor[] {
            }, assigner);
      }
      #endregion

    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class A1023Response : pb::GeneratedMessage<A1023Response, A1023Response.Builder> {
    private A1023Response() { }
    private static readonly A1023Response defaultInstance = new A1023Response().MakeReadOnly();
    private static readonly string[] _a1023ResponseFieldNames = new string[] { "ErrorCode", "ErrorInfo" };
    private static readonly uint[] _a1023ResponseFieldTags = new uint[] { 16, 10 };
    public static A1023Response DefaultInstance {
      get { return defaultInstance; }
    }

    public override A1023Response DefaultInstanceForType {
      get { return DefaultInstance; }
    }

    protected override A1023Response ThisMessage {
      get { return this; }
    }

    public static pbd::MessageDescriptor Descriptor {
      get { return global::DolphinServer.ProtoEntity.Proto.A1023Response.internal__static_A1023Response__Descriptor; }
    }

    protected override pb::FieldAccess.FieldAccessorTable<A1023Response, A1023Response.Builder> InternalFieldAccessors {
      get { return global::DolphinServer.ProtoEntity.Proto.A1023Response.internal__static_A1023Response__FieldAccessorTable; }
    }

    public const int ErrorInfoFieldNumber = 1;
    private bool hasErrorInfo;
    private string errorInfo_ = "";
    public bool HasErrorInfo {
      get { return hasErrorInfo; }
    }
    public string ErrorInfo {
      get { return errorInfo_; }
    }

    public const int ErrorCodeFieldNumber = 2;
    private bool hasErrorCode;
    private int errorCode_;
    public bool HasErrorCode {
      get { return hasErrorCode; }
    }
    public int ErrorCode {
      get { return errorCode_; }
    }

    public override bool IsInitialized {
      get {
        return true;
      }
    }

    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _a1023ResponseFieldNames;
      if (hasErrorInfo) {
        output.WriteString(1, field_names[1], ErrorInfo);
      }
      if (hasErrorCode) {
        output.WriteInt32(2, field_names[0], ErrorCode);
      }
      UnknownFields.WriteTo(output);
    }

    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        return CalcSerializedSize();
      }
    }

    private int CalcSerializedSize() {
      int size = memoizedSerializedSize;
      if (size != -1) return size;

      size = 0;
      if (hasErrorInfo) {
        size += pb::CodedOutputStream.ComputeStringSize(1, ErrorInfo);
      }
      if (hasErrorCode) {
        size += pb::CodedOutputStream.ComputeInt32Size(2, ErrorCode);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static A1023Response ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static A1023Response ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static A1023Response ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static A1023Response ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static A1023Response ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static A1023Response ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static A1023Response ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static A1023Response ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static A1023Response ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static A1023Response ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private A1023Response MakeReadOnly() {
      return this;
    }

    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(A1023Response prototype) {
      return new Builder(prototype);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<A1023Response, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(A1023Response cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

      private bool resultIsReadOnly;
      private A1023Response result;

      private A1023Response PrepareBuilder() {
        if (resultIsReadOnly) {
          A1023Response original = result;
          result = new A1023Response();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

      protected override A1023Response MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::DolphinServer.ProtoEntity.A1023Response.Descriptor; }
      }

      public override A1023Response DefaultInstanceForType {
        get { return global::DolphinServer.ProtoEntity.A1023Response.DefaultInstance; }
      }

      public override A1023Response BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

      public override Builder MergeFrom(pb::IMessage other) {
        if (other is A1023Response) {
          return MergeFrom((A1023Response) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

      public override Builder MergeFrom(A1023Response other) {
        if (other == global::DolphinServer.ProtoEntity.A1023Response.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasErrorInfo) {
          ErrorInfo = other.ErrorInfo;
        }
        if (other.HasErrorCode) {
          ErrorCode = other.ErrorCode;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_a1023ResponseFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _a1023ResponseFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasErrorInfo = input.ReadString(ref result.errorInfo_);
              break;
            }
            case 16: {
              result.hasErrorCode = input.ReadInt32(ref result.errorCode_);
              break;
            }
          }
        }

        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }


      public bool HasErrorInfo {
        get { return result.hasErrorInfo; }
      }
      public string ErrorInfo {
        get { return result.ErrorInfo; }
        set { SetErrorInfo(value); }
      }
      public Builder SetErrorInfo(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasErrorInfo = true;
        result.errorInfo_ = value;
        return this;
      }
      public Builder ClearErrorInfo() {
        PrepareBuilder();
        result.hasErrorInfo = false;
        result.errorInfo_ = "";
        return this;
      }

      public bool HasErrorCode {
        get { return result.hasErrorCode; }
      }
      public int ErrorCode {
        get { return result.ErrorCode; }
        set { SetErrorCode(value); }
      }
      public Builder SetErrorCode(int value) {
        PrepareBuilder();
        result.hasErrorCode = true;
        result.errorCode_ = value;
        return this;
      }
      public Builder ClearErrorCode() {
        PrepareBuilder();
        result.hasErrorCode = false;
        result.errorCode_ = 0;
        return this;
      }
    }
    static A1023Response() {
      object.ReferenceEquals(global::DolphinServer.ProtoEntity.Proto.A1023Response.Descriptor, null);
    }
  }

  #endregion

}

#endregion Designer generated code