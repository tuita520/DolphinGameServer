// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: A1001Response.txt
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace DolphinServer.ProtoEntity {

  namespace Proto {

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class A1001Response {

      #region Extension registration
      public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
      }
      #endregion
      #region Static variables
      internal static pbd::MessageDescriptor internal__static_A1001Response__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::DolphinServer.ProtoEntity.A1001Response, global::DolphinServer.ProtoEntity.A1001Response.Builder> internal__static_A1001Response__FieldAccessorTable;
      #endregion
      #region Descriptor
      public static pbd::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbd::FileDescriptor descriptor;

      static A1001Response() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "ChFBMTAwMVJlc3BvbnNlLnR4dCJCCg1BMTAwMVJlc3BvbnNlEhEKCUVycm9y", 
              "SW5mbxgCIAEoCRIRCglFcnJvckNvZGUYAyABKAUSCwoDVWlkGAQgASgJQhyq", 
            "AhlEb2xwaGluU2VydmVyLlByb3RvRW50aXR5"));
        pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
          descriptor = root;
          internal__static_A1001Response__Descriptor = Descriptor.MessageTypes[0];
          internal__static_A1001Response__FieldAccessorTable = 
              new pb::FieldAccess.FieldAccessorTable<global::DolphinServer.ProtoEntity.A1001Response, global::DolphinServer.ProtoEntity.A1001Response.Builder>(internal__static_A1001Response__Descriptor,
                  new string[] { "ErrorInfo", "ErrorCode", "Uid", });
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
  public sealed partial class A1001Response : pb::GeneratedMessage<A1001Response, A1001Response.Builder> {
    private A1001Response() { }
    private static readonly A1001Response defaultInstance = new A1001Response().MakeReadOnly();
    private static readonly string[] _a1001ResponseFieldNames = new string[] { "ErrorCode", "ErrorInfo", "Uid" };
    private static readonly uint[] _a1001ResponseFieldTags = new uint[] { 24, 18, 34 };
    public static A1001Response DefaultInstance {
      get { return defaultInstance; }
    }

    public override A1001Response DefaultInstanceForType {
      get { return DefaultInstance; }
    }

    protected override A1001Response ThisMessage {
      get { return this; }
    }

    public static pbd::MessageDescriptor Descriptor {
      get { return global::DolphinServer.ProtoEntity.Proto.A1001Response.internal__static_A1001Response__Descriptor; }
    }

    protected override pb::FieldAccess.FieldAccessorTable<A1001Response, A1001Response.Builder> InternalFieldAccessors {
      get { return global::DolphinServer.ProtoEntity.Proto.A1001Response.internal__static_A1001Response__FieldAccessorTable; }
    }

    public const int ErrorInfoFieldNumber = 2;
    private bool hasErrorInfo;
    private string errorInfo_ = "";
    public bool HasErrorInfo {
      get { return hasErrorInfo; }
    }
    public string ErrorInfo {
      get { return errorInfo_; }
    }

    public const int ErrorCodeFieldNumber = 3;
    private bool hasErrorCode;
    private int errorCode_;
    public bool HasErrorCode {
      get { return hasErrorCode; }
    }
    public int ErrorCode {
      get { return errorCode_; }
    }

    public const int UidFieldNumber = 4;
    private bool hasUid;
    private string uid_ = "";
    public bool HasUid {
      get { return hasUid; }
    }
    public string Uid {
      get { return uid_; }
    }

    public override bool IsInitialized {
      get {
        return true;
      }
    }

    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _a1001ResponseFieldNames;
      if (hasErrorInfo) {
        output.WriteString(2, field_names[1], ErrorInfo);
      }
      if (hasErrorCode) {
        output.WriteInt32(3, field_names[0], ErrorCode);
      }
      if (hasUid) {
        output.WriteString(4, field_names[2], Uid);
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
        size += pb::CodedOutputStream.ComputeStringSize(2, ErrorInfo);
      }
      if (hasErrorCode) {
        size += pb::CodedOutputStream.ComputeInt32Size(3, ErrorCode);
      }
      if (hasUid) {
        size += pb::CodedOutputStream.ComputeStringSize(4, Uid);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static A1001Response ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static A1001Response ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static A1001Response ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static A1001Response ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static A1001Response ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static A1001Response ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static A1001Response ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static A1001Response ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static A1001Response ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static A1001Response ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private A1001Response MakeReadOnly() {
      return this;
    }

    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(A1001Response prototype) {
      return new Builder(prototype);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<A1001Response, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(A1001Response cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

      private bool resultIsReadOnly;
      private A1001Response result;

      private A1001Response PrepareBuilder() {
        if (resultIsReadOnly) {
          A1001Response original = result;
          result = new A1001Response();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

      protected override A1001Response MessageBeingBuilt {
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
        get { return global::DolphinServer.ProtoEntity.A1001Response.Descriptor; }
      }

      public override A1001Response DefaultInstanceForType {
        get { return global::DolphinServer.ProtoEntity.A1001Response.DefaultInstance; }
      }

      public override A1001Response BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

      public override Builder MergeFrom(pb::IMessage other) {
        if (other is A1001Response) {
          return MergeFrom((A1001Response) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

      public override Builder MergeFrom(A1001Response other) {
        if (other == global::DolphinServer.ProtoEntity.A1001Response.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasErrorInfo) {
          ErrorInfo = other.ErrorInfo;
        }
        if (other.HasErrorCode) {
          ErrorCode = other.ErrorCode;
        }
        if (other.HasUid) {
          Uid = other.Uid;
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
            int field_ordinal = global::System.Array.BinarySearch(_a1001ResponseFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _a1001ResponseFieldTags[field_ordinal];
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
            case 18: {
              result.hasErrorInfo = input.ReadString(ref result.errorInfo_);
              break;
            }
            case 24: {
              result.hasErrorCode = input.ReadInt32(ref result.errorCode_);
              break;
            }
            case 34: {
              result.hasUid = input.ReadString(ref result.uid_);
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

      public bool HasUid {
        get { return result.hasUid; }
      }
      public string Uid {
        get { return result.Uid; }
        set { SetUid(value); }
      }
      public Builder SetUid(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasUid = true;
        result.uid_ = value;
        return this;
      }
      public Builder ClearUid() {
        PrepareBuilder();
        result.hasUid = false;
        result.uid_ = "";
        return this;
      }
    }
    static A1001Response() {
      object.ReferenceEquals(global::DolphinServer.ProtoEntity.Proto.A1001Response.Descriptor, null);
    }
  }

  #endregion

}

#endregion Designer generated code