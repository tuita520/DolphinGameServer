// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: A1013Response.txt
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace DolphinServer.ProtoEntity {

  namespace Proto {

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class A1013Response {

      #region Extension registration
      public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
      }
      #endregion
      #region Static variables
      internal static pbd::MessageDescriptor internal__static_A1013Response__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::DolphinServer.ProtoEntity.A1013Response, global::DolphinServer.ProtoEntity.A1013Response.Builder> internal__static_A1013Response__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_A1013User__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::DolphinServer.ProtoEntity.A1013User, global::DolphinServer.ProtoEntity.A1013User.Builder> internal__static_A1013User__FieldAccessorTable;
      #endregion
      #region Descriptor
      public static pbd::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbd::FileDescriptor descriptor;

      static A1013Response() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "ChFBMTAxM1Jlc3BvbnNlLnR4dCJ8Cg1BMTAxM1Jlc3BvbnNlEhEKCUVycm9y", 
              "SW5mbxgBIAEoCRIRCglFcnJvckNvZGUYAiABKAUSCwoDVWlkGAMgASgJEg4K", 
              "Bkh1VHlwZRgEIAEoBRINCgVTY29yZRgFIAEoBRIZCgVVc2VycxgGIAMoCzIK", 
              "LkExMDEzVXNlciImCglBMTAxM1VzZXISCwoDVWlkGAEgASgJEgwKBFNvcmUY", 
            "AiABKAVCHKoCGURvbHBoaW5TZXJ2ZXIuUHJvdG9FbnRpdHk="));
        pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
          descriptor = root;
          internal__static_A1013Response__Descriptor = Descriptor.MessageTypes[0];
          internal__static_A1013Response__FieldAccessorTable = 
              new pb::FieldAccess.FieldAccessorTable<global::DolphinServer.ProtoEntity.A1013Response, global::DolphinServer.ProtoEntity.A1013Response.Builder>(internal__static_A1013Response__Descriptor,
                  new string[] { "ErrorInfo", "ErrorCode", "Uid", "HuType", "Score", "Users", });
          internal__static_A1013User__Descriptor = Descriptor.MessageTypes[1];
          internal__static_A1013User__FieldAccessorTable = 
              new pb::FieldAccess.FieldAccessorTable<global::DolphinServer.ProtoEntity.A1013User, global::DolphinServer.ProtoEntity.A1013User.Builder>(internal__static_A1013User__Descriptor,
                  new string[] { "Uid", "Sore", });
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
  public sealed partial class A1013Response : pb::GeneratedMessage<A1013Response, A1013Response.Builder> {
    private A1013Response() { }
    private static readonly A1013Response defaultInstance = new A1013Response().MakeReadOnly();
    private static readonly string[] _a1013ResponseFieldNames = new string[] { "ErrorCode", "ErrorInfo", "HuType", "Score", "Uid", "Users" };
    private static readonly uint[] _a1013ResponseFieldTags = new uint[] { 16, 10, 32, 40, 26, 50 };
    public static A1013Response DefaultInstance {
      get { return defaultInstance; }
    }

    public override A1013Response DefaultInstanceForType {
      get { return DefaultInstance; }
    }

    protected override A1013Response ThisMessage {
      get { return this; }
    }

    public static pbd::MessageDescriptor Descriptor {
      get { return global::DolphinServer.ProtoEntity.Proto.A1013Response.internal__static_A1013Response__Descriptor; }
    }

    protected override pb::FieldAccess.FieldAccessorTable<A1013Response, A1013Response.Builder> InternalFieldAccessors {
      get { return global::DolphinServer.ProtoEntity.Proto.A1013Response.internal__static_A1013Response__FieldAccessorTable; }
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

    public const int UidFieldNumber = 3;
    private bool hasUid;
    private string uid_ = "";
    public bool HasUid {
      get { return hasUid; }
    }
    public string Uid {
      get { return uid_; }
    }

    public const int HuTypeFieldNumber = 4;
    private bool hasHuType;
    private int huType_;
    public bool HasHuType {
      get { return hasHuType; }
    }
    public int HuType {
      get { return huType_; }
    }

    public const int ScoreFieldNumber = 5;
    private bool hasScore;
    private int score_;
    public bool HasScore {
      get { return hasScore; }
    }
    public int Score {
      get { return score_; }
    }

    public const int UsersFieldNumber = 6;
    private pbc::PopsicleList<global::DolphinServer.ProtoEntity.A1013User> users_ = new pbc::PopsicleList<global::DolphinServer.ProtoEntity.A1013User>();
    public scg::IList<global::DolphinServer.ProtoEntity.A1013User> UsersList {
      get { return users_; }
    }
    public int UsersCount {
      get { return users_.Count; }
    }
    public global::DolphinServer.ProtoEntity.A1013User GetUsers(int index) {
      return users_[index];
    }

    public override bool IsInitialized {
      get {
        return true;
      }
    }

    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _a1013ResponseFieldNames;
      if (hasErrorInfo) {
        output.WriteString(1, field_names[1], ErrorInfo);
      }
      if (hasErrorCode) {
        output.WriteInt32(2, field_names[0], ErrorCode);
      }
      if (hasUid) {
        output.WriteString(3, field_names[4], Uid);
      }
      if (hasHuType) {
        output.WriteInt32(4, field_names[2], HuType);
      }
      if (hasScore) {
        output.WriteInt32(5, field_names[3], Score);
      }
      if (users_.Count > 0) {
        output.WriteMessageArray(6, field_names[5], users_);
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
      if (hasUid) {
        size += pb::CodedOutputStream.ComputeStringSize(3, Uid);
      }
      if (hasHuType) {
        size += pb::CodedOutputStream.ComputeInt32Size(4, HuType);
      }
      if (hasScore) {
        size += pb::CodedOutputStream.ComputeInt32Size(5, Score);
      }
      foreach (global::DolphinServer.ProtoEntity.A1013User element in UsersList) {
        size += pb::CodedOutputStream.ComputeMessageSize(6, element);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static A1013Response ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static A1013Response ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static A1013Response ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static A1013Response ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static A1013Response ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static A1013Response ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static A1013Response ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static A1013Response ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static A1013Response ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static A1013Response ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private A1013Response MakeReadOnly() {
      users_.MakeReadOnly();
      return this;
    }

    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(A1013Response prototype) {
      return new Builder(prototype);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<A1013Response, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(A1013Response cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

      private bool resultIsReadOnly;
      private A1013Response result;

      private A1013Response PrepareBuilder() {
        if (resultIsReadOnly) {
          A1013Response original = result;
          result = new A1013Response();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

      protected override A1013Response MessageBeingBuilt {
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
        get { return global::DolphinServer.ProtoEntity.A1013Response.Descriptor; }
      }

      public override A1013Response DefaultInstanceForType {
        get { return global::DolphinServer.ProtoEntity.A1013Response.DefaultInstance; }
      }

      public override A1013Response BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

      public override Builder MergeFrom(pb::IMessage other) {
        if (other is A1013Response) {
          return MergeFrom((A1013Response) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

      public override Builder MergeFrom(A1013Response other) {
        if (other == global::DolphinServer.ProtoEntity.A1013Response.DefaultInstance) return this;
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
        if (other.HasHuType) {
          HuType = other.HuType;
        }
        if (other.HasScore) {
          Score = other.Score;
        }
        if (other.users_.Count != 0) {
          result.users_.Add(other.users_);
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
            int field_ordinal = global::System.Array.BinarySearch(_a1013ResponseFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _a1013ResponseFieldTags[field_ordinal];
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
            case 26: {
              result.hasUid = input.ReadString(ref result.uid_);
              break;
            }
            case 32: {
              result.hasHuType = input.ReadInt32(ref result.huType_);
              break;
            }
            case 40: {
              result.hasScore = input.ReadInt32(ref result.score_);
              break;
            }
            case 50: {
              input.ReadMessageArray(tag, field_name, result.users_, global::DolphinServer.ProtoEntity.A1013User.DefaultInstance, extensionRegistry);
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

      public bool HasHuType {
        get { return result.hasHuType; }
      }
      public int HuType {
        get { return result.HuType; }
        set { SetHuType(value); }
      }
      public Builder SetHuType(int value) {
        PrepareBuilder();
        result.hasHuType = true;
        result.huType_ = value;
        return this;
      }
      public Builder ClearHuType() {
        PrepareBuilder();
        result.hasHuType = false;
        result.huType_ = 0;
        return this;
      }

      public bool HasScore {
        get { return result.hasScore; }
      }
      public int Score {
        get { return result.Score; }
        set { SetScore(value); }
      }
      public Builder SetScore(int value) {
        PrepareBuilder();
        result.hasScore = true;
        result.score_ = value;
        return this;
      }
      public Builder ClearScore() {
        PrepareBuilder();
        result.hasScore = false;
        result.score_ = 0;
        return this;
      }

      public pbc::IPopsicleList<global::DolphinServer.ProtoEntity.A1013User> UsersList {
        get { return PrepareBuilder().users_; }
      }
      public int UsersCount {
        get { return result.UsersCount; }
      }
      public global::DolphinServer.ProtoEntity.A1013User GetUsers(int index) {
        return result.GetUsers(index);
      }
      public Builder SetUsers(int index, global::DolphinServer.ProtoEntity.A1013User value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.users_[index] = value;
        return this;
      }
      public Builder SetUsers(int index, global::DolphinServer.ProtoEntity.A1013User.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.users_[index] = builderForValue.Build();
        return this;
      }
      public Builder AddUsers(global::DolphinServer.ProtoEntity.A1013User value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.users_.Add(value);
        return this;
      }
      public Builder AddUsers(global::DolphinServer.ProtoEntity.A1013User.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.users_.Add(builderForValue.Build());
        return this;
      }
      public Builder AddRangeUsers(scg::IEnumerable<global::DolphinServer.ProtoEntity.A1013User> values) {
        PrepareBuilder();
        result.users_.Add(values);
        return this;
      }
      public Builder ClearUsers() {
        PrepareBuilder();
        result.users_.Clear();
        return this;
      }
    }
    static A1013Response() {
      object.ReferenceEquals(global::DolphinServer.ProtoEntity.Proto.A1013Response.Descriptor, null);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class A1013User : pb::GeneratedMessage<A1013User, A1013User.Builder> {
    private A1013User() { }
    private static readonly A1013User defaultInstance = new A1013User().MakeReadOnly();
    private static readonly string[] _a1013UserFieldNames = new string[] { "Sore", "Uid" };
    private static readonly uint[] _a1013UserFieldTags = new uint[] { 16, 10 };
    public static A1013User DefaultInstance {
      get { return defaultInstance; }
    }

    public override A1013User DefaultInstanceForType {
      get { return DefaultInstance; }
    }

    protected override A1013User ThisMessage {
      get { return this; }
    }

    public static pbd::MessageDescriptor Descriptor {
      get { return global::DolphinServer.ProtoEntity.Proto.A1013Response.internal__static_A1013User__Descriptor; }
    }

    protected override pb::FieldAccess.FieldAccessorTable<A1013User, A1013User.Builder> InternalFieldAccessors {
      get { return global::DolphinServer.ProtoEntity.Proto.A1013Response.internal__static_A1013User__FieldAccessorTable; }
    }

    public const int UidFieldNumber = 1;
    private bool hasUid;
    private string uid_ = "";
    public bool HasUid {
      get { return hasUid; }
    }
    public string Uid {
      get { return uid_; }
    }

    public const int SoreFieldNumber = 2;
    private bool hasSore;
    private int sore_;
    public bool HasSore {
      get { return hasSore; }
    }
    public int Sore {
      get { return sore_; }
    }

    public override bool IsInitialized {
      get {
        return true;
      }
    }

    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _a1013UserFieldNames;
      if (hasUid) {
        output.WriteString(1, field_names[1], Uid);
      }
      if (hasSore) {
        output.WriteInt32(2, field_names[0], Sore);
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
      if (hasUid) {
        size += pb::CodedOutputStream.ComputeStringSize(1, Uid);
      }
      if (hasSore) {
        size += pb::CodedOutputStream.ComputeInt32Size(2, Sore);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static A1013User ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static A1013User ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static A1013User ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static A1013User ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static A1013User ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static A1013User ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static A1013User ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static A1013User ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static A1013User ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static A1013User ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private A1013User MakeReadOnly() {
      return this;
    }

    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(A1013User prototype) {
      return new Builder(prototype);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<A1013User, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(A1013User cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

      private bool resultIsReadOnly;
      private A1013User result;

      private A1013User PrepareBuilder() {
        if (resultIsReadOnly) {
          A1013User original = result;
          result = new A1013User();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

      protected override A1013User MessageBeingBuilt {
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
        get { return global::DolphinServer.ProtoEntity.A1013User.Descriptor; }
      }

      public override A1013User DefaultInstanceForType {
        get { return global::DolphinServer.ProtoEntity.A1013User.DefaultInstance; }
      }

      public override A1013User BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

      public override Builder MergeFrom(pb::IMessage other) {
        if (other is A1013User) {
          return MergeFrom((A1013User) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

      public override Builder MergeFrom(A1013User other) {
        if (other == global::DolphinServer.ProtoEntity.A1013User.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasUid) {
          Uid = other.Uid;
        }
        if (other.HasSore) {
          Sore = other.Sore;
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
            int field_ordinal = global::System.Array.BinarySearch(_a1013UserFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _a1013UserFieldTags[field_ordinal];
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
              result.hasUid = input.ReadString(ref result.uid_);
              break;
            }
            case 16: {
              result.hasSore = input.ReadInt32(ref result.sore_);
              break;
            }
          }
        }

        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
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

      public bool HasSore {
        get { return result.hasSore; }
      }
      public int Sore {
        get { return result.Sore; }
        set { SetSore(value); }
      }
      public Builder SetSore(int value) {
        PrepareBuilder();
        result.hasSore = true;
        result.sore_ = value;
        return this;
      }
      public Builder ClearSore() {
        PrepareBuilder();
        result.hasSore = false;
        result.sore_ = 0;
        return this;
      }
    }
    static A1013User() {
      object.ReferenceEquals(global::DolphinServer.ProtoEntity.Proto.A1013Response.Descriptor, null);
    }
  }

  #endregion

}

#endregion Designer generated code
