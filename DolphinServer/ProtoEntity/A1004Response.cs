// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: A1004Response.txt
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace DolphinServer.ProtoEntity {

  namespace Proto {

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class A1004Response {

      #region Extension registration
      public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
      }
      #endregion
      #region Static variables
      internal static pbd::MessageDescriptor internal__static_A1004Response__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::DolphinServer.ProtoEntity.A1004Response, global::DolphinServer.ProtoEntity.A1004Response.Builder> internal__static_A1004Response__FieldAccessorTable;
      internal static pbd::MessageDescriptor internal__static_A1004User__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::DolphinServer.ProtoEntity.A1004User, global::DolphinServer.ProtoEntity.A1004User.Builder> internal__static_A1004User__FieldAccessorTable;
      #endregion
      #region Descriptor
      public static pbd::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbd::FileDescriptor descriptor;

      static A1004Response() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "ChFBMTAwNFJlc3BvbnNlLnR4dCKGAQoNQTEwMDRSZXNwb25zZRIRCglFcnJv", 
              "ckluZm8YASABKAkSEQoJRXJyb3JDb2RlGAIgASgFEg4KBlJvb21JRBgEIAEo", 
              "BRIQCghSb29tVHlwZRgFIAEoBRIZCgVVc2VycxgGIAMoCzIKLkExMDA0VXNl", 
              "chISCgpDYW5jZWxUeXBlGAcgASgFIjgKCUExMDA0VXNlchILCgNVaWQYASAB", 
              "KAkSEAoISXNDYW5jZWwYAiABKAUSDAoETmFtZRgDIAEoCUIcqgIZRG9scGhp", 
            "blNlcnZlci5Qcm90b0VudGl0eQ=="));
        pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
          descriptor = root;
          internal__static_A1004Response__Descriptor = Descriptor.MessageTypes[0];
          internal__static_A1004Response__FieldAccessorTable = 
              new pb::FieldAccess.FieldAccessorTable<global::DolphinServer.ProtoEntity.A1004Response, global::DolphinServer.ProtoEntity.A1004Response.Builder>(internal__static_A1004Response__Descriptor,
                  new string[] { "ErrorInfo", "ErrorCode", "RoomID", "RoomType", "Users", "CancelType", });
          internal__static_A1004User__Descriptor = Descriptor.MessageTypes[1];
          internal__static_A1004User__FieldAccessorTable = 
              new pb::FieldAccess.FieldAccessorTable<global::DolphinServer.ProtoEntity.A1004User, global::DolphinServer.ProtoEntity.A1004User.Builder>(internal__static_A1004User__Descriptor,
                  new string[] { "Uid", "IsCancel", "Name", });
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
  public sealed partial class A1004Response : pb::GeneratedMessage<A1004Response, A1004Response.Builder> {
    private A1004Response() { }
    private static readonly A1004Response defaultInstance = new A1004Response().MakeReadOnly();
    private static readonly string[] _a1004ResponseFieldNames = new string[] { "CancelType", "ErrorCode", "ErrorInfo", "RoomID", "RoomType", "Users" };
    private static readonly uint[] _a1004ResponseFieldTags = new uint[] { 56, 16, 10, 32, 40, 50 };
    public static A1004Response DefaultInstance {
      get { return defaultInstance; }
    }

    public override A1004Response DefaultInstanceForType {
      get { return DefaultInstance; }
    }

    protected override A1004Response ThisMessage {
      get { return this; }
    }

    public static pbd::MessageDescriptor Descriptor {
      get { return global::DolphinServer.ProtoEntity.Proto.A1004Response.internal__static_A1004Response__Descriptor; }
    }

    protected override pb::FieldAccess.FieldAccessorTable<A1004Response, A1004Response.Builder> InternalFieldAccessors {
      get { return global::DolphinServer.ProtoEntity.Proto.A1004Response.internal__static_A1004Response__FieldAccessorTable; }
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

    public const int RoomIDFieldNumber = 4;
    private bool hasRoomID;
    private int roomID_;
    public bool HasRoomID {
      get { return hasRoomID; }
    }
    public int RoomID {
      get { return roomID_; }
    }

    public const int RoomTypeFieldNumber = 5;
    private bool hasRoomType;
    private int roomType_;
    public bool HasRoomType {
      get { return hasRoomType; }
    }
    public int RoomType {
      get { return roomType_; }
    }

    public const int UsersFieldNumber = 6;
    private pbc::PopsicleList<global::DolphinServer.ProtoEntity.A1004User> users_ = new pbc::PopsicleList<global::DolphinServer.ProtoEntity.A1004User>();
    public scg::IList<global::DolphinServer.ProtoEntity.A1004User> UsersList {
      get { return users_; }
    }
    public int UsersCount {
      get { return users_.Count; }
    }
    public global::DolphinServer.ProtoEntity.A1004User GetUsers(int index) {
      return users_[index];
    }

    public const int CancelTypeFieldNumber = 7;
    private bool hasCancelType;
    private int cancelType_;
    public bool HasCancelType {
      get { return hasCancelType; }
    }
    public int CancelType {
      get { return cancelType_; }
    }

    public override bool IsInitialized {
      get {
        return true;
      }
    }

    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _a1004ResponseFieldNames;
      if (hasErrorInfo) {
        output.WriteString(1, field_names[2], ErrorInfo);
      }
      if (hasErrorCode) {
        output.WriteInt32(2, field_names[1], ErrorCode);
      }
      if (hasRoomID) {
        output.WriteInt32(4, field_names[3], RoomID);
      }
      if (hasRoomType) {
        output.WriteInt32(5, field_names[4], RoomType);
      }
      if (users_.Count > 0) {
        output.WriteMessageArray(6, field_names[5], users_);
      }
      if (hasCancelType) {
        output.WriteInt32(7, field_names[0], CancelType);
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
      if (hasRoomID) {
        size += pb::CodedOutputStream.ComputeInt32Size(4, RoomID);
      }
      if (hasRoomType) {
        size += pb::CodedOutputStream.ComputeInt32Size(5, RoomType);
      }
      foreach (global::DolphinServer.ProtoEntity.A1004User element in UsersList) {
        size += pb::CodedOutputStream.ComputeMessageSize(6, element);
      }
      if (hasCancelType) {
        size += pb::CodedOutputStream.ComputeInt32Size(7, CancelType);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static A1004Response ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static A1004Response ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static A1004Response ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static A1004Response ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static A1004Response ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static A1004Response ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static A1004Response ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static A1004Response ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static A1004Response ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static A1004Response ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private A1004Response MakeReadOnly() {
      users_.MakeReadOnly();
      return this;
    }

    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(A1004Response prototype) {
      return new Builder(prototype);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<A1004Response, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(A1004Response cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

      private bool resultIsReadOnly;
      private A1004Response result;

      private A1004Response PrepareBuilder() {
        if (resultIsReadOnly) {
          A1004Response original = result;
          result = new A1004Response();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

      protected override A1004Response MessageBeingBuilt {
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
        get { return global::DolphinServer.ProtoEntity.A1004Response.Descriptor; }
      }

      public override A1004Response DefaultInstanceForType {
        get { return global::DolphinServer.ProtoEntity.A1004Response.DefaultInstance; }
      }

      public override A1004Response BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

      public override Builder MergeFrom(pb::IMessage other) {
        if (other is A1004Response) {
          return MergeFrom((A1004Response) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

      public override Builder MergeFrom(A1004Response other) {
        if (other == global::DolphinServer.ProtoEntity.A1004Response.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasErrorInfo) {
          ErrorInfo = other.ErrorInfo;
        }
        if (other.HasErrorCode) {
          ErrorCode = other.ErrorCode;
        }
        if (other.HasRoomID) {
          RoomID = other.RoomID;
        }
        if (other.HasRoomType) {
          RoomType = other.RoomType;
        }
        if (other.users_.Count != 0) {
          result.users_.Add(other.users_);
        }
        if (other.HasCancelType) {
          CancelType = other.CancelType;
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
            int field_ordinal = global::System.Array.BinarySearch(_a1004ResponseFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _a1004ResponseFieldTags[field_ordinal];
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
            case 32: {
              result.hasRoomID = input.ReadInt32(ref result.roomID_);
              break;
            }
            case 40: {
              result.hasRoomType = input.ReadInt32(ref result.roomType_);
              break;
            }
            case 50: {
              input.ReadMessageArray(tag, field_name, result.users_, global::DolphinServer.ProtoEntity.A1004User.DefaultInstance, extensionRegistry);
              break;
            }
            case 56: {
              result.hasCancelType = input.ReadInt32(ref result.cancelType_);
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

      public bool HasRoomID {
        get { return result.hasRoomID; }
      }
      public int RoomID {
        get { return result.RoomID; }
        set { SetRoomID(value); }
      }
      public Builder SetRoomID(int value) {
        PrepareBuilder();
        result.hasRoomID = true;
        result.roomID_ = value;
        return this;
      }
      public Builder ClearRoomID() {
        PrepareBuilder();
        result.hasRoomID = false;
        result.roomID_ = 0;
        return this;
      }

      public bool HasRoomType {
        get { return result.hasRoomType; }
      }
      public int RoomType {
        get { return result.RoomType; }
        set { SetRoomType(value); }
      }
      public Builder SetRoomType(int value) {
        PrepareBuilder();
        result.hasRoomType = true;
        result.roomType_ = value;
        return this;
      }
      public Builder ClearRoomType() {
        PrepareBuilder();
        result.hasRoomType = false;
        result.roomType_ = 0;
        return this;
      }

      public pbc::IPopsicleList<global::DolphinServer.ProtoEntity.A1004User> UsersList {
        get { return PrepareBuilder().users_; }
      }
      public int UsersCount {
        get { return result.UsersCount; }
      }
      public global::DolphinServer.ProtoEntity.A1004User GetUsers(int index) {
        return result.GetUsers(index);
      }
      public Builder SetUsers(int index, global::DolphinServer.ProtoEntity.A1004User value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.users_[index] = value;
        return this;
      }
      public Builder SetUsers(int index, global::DolphinServer.ProtoEntity.A1004User.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.users_[index] = builderForValue.Build();
        return this;
      }
      public Builder AddUsers(global::DolphinServer.ProtoEntity.A1004User value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.users_.Add(value);
        return this;
      }
      public Builder AddUsers(global::DolphinServer.ProtoEntity.A1004User.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.users_.Add(builderForValue.Build());
        return this;
      }
      public Builder AddRangeUsers(scg::IEnumerable<global::DolphinServer.ProtoEntity.A1004User> values) {
        PrepareBuilder();
        result.users_.Add(values);
        return this;
      }
      public Builder ClearUsers() {
        PrepareBuilder();
        result.users_.Clear();
        return this;
      }

      public bool HasCancelType {
        get { return result.hasCancelType; }
      }
      public int CancelType {
        get { return result.CancelType; }
        set { SetCancelType(value); }
      }
      public Builder SetCancelType(int value) {
        PrepareBuilder();
        result.hasCancelType = true;
        result.cancelType_ = value;
        return this;
      }
      public Builder ClearCancelType() {
        PrepareBuilder();
        result.hasCancelType = false;
        result.cancelType_ = 0;
        return this;
      }
    }
    static A1004Response() {
      object.ReferenceEquals(global::DolphinServer.ProtoEntity.Proto.A1004Response.Descriptor, null);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class A1004User : pb::GeneratedMessage<A1004User, A1004User.Builder> {
    private A1004User() { }
    private static readonly A1004User defaultInstance = new A1004User().MakeReadOnly();
    private static readonly string[] _a1004UserFieldNames = new string[] { "IsCancel", "Name", "Uid" };
    private static readonly uint[] _a1004UserFieldTags = new uint[] { 16, 26, 10 };
    public static A1004User DefaultInstance {
      get { return defaultInstance; }
    }

    public override A1004User DefaultInstanceForType {
      get { return DefaultInstance; }
    }

    protected override A1004User ThisMessage {
      get { return this; }
    }

    public static pbd::MessageDescriptor Descriptor {
      get { return global::DolphinServer.ProtoEntity.Proto.A1004Response.internal__static_A1004User__Descriptor; }
    }

    protected override pb::FieldAccess.FieldAccessorTable<A1004User, A1004User.Builder> InternalFieldAccessors {
      get { return global::DolphinServer.ProtoEntity.Proto.A1004Response.internal__static_A1004User__FieldAccessorTable; }
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

    public const int IsCancelFieldNumber = 2;
    private bool hasIsCancel;
    private int isCancel_;
    public bool HasIsCancel {
      get { return hasIsCancel; }
    }
    public int IsCancel {
      get { return isCancel_; }
    }

    public const int NameFieldNumber = 3;
    private bool hasName;
    private string name_ = "";
    public bool HasName {
      get { return hasName; }
    }
    public string Name {
      get { return name_; }
    }

    public override bool IsInitialized {
      get {
        return true;
      }
    }

    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _a1004UserFieldNames;
      if (hasUid) {
        output.WriteString(1, field_names[2], Uid);
      }
      if (hasIsCancel) {
        output.WriteInt32(2, field_names[0], IsCancel);
      }
      if (hasName) {
        output.WriteString(3, field_names[1], Name);
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
      if (hasIsCancel) {
        size += pb::CodedOutputStream.ComputeInt32Size(2, IsCancel);
      }
      if (hasName) {
        size += pb::CodedOutputStream.ComputeStringSize(3, Name);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static A1004User ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static A1004User ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static A1004User ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static A1004User ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static A1004User ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static A1004User ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static A1004User ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static A1004User ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static A1004User ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static A1004User ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private A1004User MakeReadOnly() {
      return this;
    }

    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(A1004User prototype) {
      return new Builder(prototype);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<A1004User, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(A1004User cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

      private bool resultIsReadOnly;
      private A1004User result;

      private A1004User PrepareBuilder() {
        if (resultIsReadOnly) {
          A1004User original = result;
          result = new A1004User();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

      protected override A1004User MessageBeingBuilt {
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
        get { return global::DolphinServer.ProtoEntity.A1004User.Descriptor; }
      }

      public override A1004User DefaultInstanceForType {
        get { return global::DolphinServer.ProtoEntity.A1004User.DefaultInstance; }
      }

      public override A1004User BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

      public override Builder MergeFrom(pb::IMessage other) {
        if (other is A1004User) {
          return MergeFrom((A1004User) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

      public override Builder MergeFrom(A1004User other) {
        if (other == global::DolphinServer.ProtoEntity.A1004User.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasUid) {
          Uid = other.Uid;
        }
        if (other.HasIsCancel) {
          IsCancel = other.IsCancel;
        }
        if (other.HasName) {
          Name = other.Name;
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
            int field_ordinal = global::System.Array.BinarySearch(_a1004UserFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _a1004UserFieldTags[field_ordinal];
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
              result.hasIsCancel = input.ReadInt32(ref result.isCancel_);
              break;
            }
            case 26: {
              result.hasName = input.ReadString(ref result.name_);
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

      public bool HasIsCancel {
        get { return result.hasIsCancel; }
      }
      public int IsCancel {
        get { return result.IsCancel; }
        set { SetIsCancel(value); }
      }
      public Builder SetIsCancel(int value) {
        PrepareBuilder();
        result.hasIsCancel = true;
        result.isCancel_ = value;
        return this;
      }
      public Builder ClearIsCancel() {
        PrepareBuilder();
        result.hasIsCancel = false;
        result.isCancel_ = 0;
        return this;
      }

      public bool HasName {
        get { return result.hasName; }
      }
      public string Name {
        get { return result.Name; }
        set { SetName(value); }
      }
      public Builder SetName(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasName = true;
        result.name_ = value;
        return this;
      }
      public Builder ClearName() {
        PrepareBuilder();
        result.hasName = false;
        result.name_ = "";
        return this;
      }
    }
    static A1004User() {
      object.ReferenceEquals(global::DolphinServer.ProtoEntity.Proto.A1004Response.Descriptor, null);
    }
  }

  #endregion

}

#endregion Designer generated code
