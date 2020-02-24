// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/basket.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Basket.API.Proto {

  /// <summary>Holder for reflection information generated from Protos/basket.proto</summary>
  public static partial class BasketReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/basket.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BasketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQcm90b3MvYmFza2V0LnByb3RvEglCYXNrZXRBcGkiGwoNQmFza2V0UmVx",
            "dWVzdBIKCgJpZBgBIAEoCSInCgdEZWNpbWFsEg0KBXVuaXRzGAEgASgDEg0K",
            "BW5hbm9zGAIgASgPIlYKFUN1c3RvbWVyQmFza2V0UmVxdWVzdBIPCgdidXll",
            "cmlkGAEgASgJEiwKBWl0ZW1zGAIgAygLMh0uQmFza2V0QXBpLkJhc2tldEl0",
            "ZW1SZXNwb25zZSJXChZDdXN0b21lckJhc2tldFJlc3BvbnNlEg8KB2J1eWVy",
            "aWQYASABKAkSLAoFaXRlbXMYAiADKAsyHS5CYXNrZXRBcGkuQmFza2V0SXRl",
            "bVJlc3BvbnNlIr8BChJCYXNrZXRJdGVtUmVzcG9uc2USCgoCaWQYASABKAkS",
            "EQoJcHJvZHVjdGlkGAIgASgFEhMKC3Byb2R1Y3RuYW1lGAMgASgJEiUKCXVu",
            "aXRwcmljZRgEIAEoCzISLkJhc2tldEFwaS5EZWNpbWFsEigKDG9sZHVuaXRw",
            "cmljZRgFIAEoCzISLkJhc2tldEFwaS5EZWNpbWFsEhAKCHF1YW50aXR5GAYg",
            "ASgFEhIKCnBpY3R1cmV1cmwYByABKAkyrwEKBkJhc2tldBJOCg1HZXRCYXNr",
            "ZXRCeUlkEhguQmFza2V0QXBpLkJhc2tldFJlcXVlc3QaIS5CYXNrZXRBcGku",
            "Q3VzdG9tZXJCYXNrZXRSZXNwb25zZSIAElUKDFVwZGF0ZUJhc2tldBIgLkJh",
            "c2tldEFwaS5DdXN0b21lckJhc2tldFJlcXVlc3QaIS5CYXNrZXRBcGkuQ3Vz",
            "dG9tZXJCYXNrZXRSZXNwb25zZSIAQhOqAhBCYXNrZXQuQVBJLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Basket.API.Proto.BasketRequest), global::Basket.API.Proto.BasketRequest.Parser, new[]{ "Id" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Basket.API.Proto.Decimal), global::Basket.API.Proto.Decimal.Parser, new[]{ "Units", "Nanos" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Basket.API.Proto.CustomerBasketRequest), global::Basket.API.Proto.CustomerBasketRequest.Parser, new[]{ "Buyerid", "Items" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Basket.API.Proto.CustomerBasketResponse), global::Basket.API.Proto.CustomerBasketResponse.Parser, new[]{ "Buyerid", "Items" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Basket.API.Proto.BasketItemResponse), global::Basket.API.Proto.BasketItemResponse.Parser, new[]{ "Id", "Productid", "Productname", "Unitprice", "Oldunitprice", "Quantity", "Pictureurl" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BasketRequest : pb::IMessage<BasketRequest> {
    private static readonly pb::MessageParser<BasketRequest> _parser = new pb::MessageParser<BasketRequest>(() => new BasketRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BasketRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Basket.API.Proto.BasketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BasketRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BasketRequest(BasketRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BasketRequest Clone() {
      return new BasketRequest(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BasketRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BasketRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BasketRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Decimal : pb::IMessage<Decimal> {
    private static readonly pb::MessageParser<Decimal> _parser = new pb::MessageParser<Decimal>(() => new Decimal());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Decimal> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Basket.API.Proto.BasketReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Decimal() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Decimal(Decimal other) : this() {
      units_ = other.units_;
      nanos_ = other.nanos_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Decimal Clone() {
      return new Decimal(this);
    }

    /// <summary>Field number for the "units" field.</summary>
    public const int UnitsFieldNumber = 1;
    private long units_;
    /// <summary>
    /// Whole units part of the amount
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Units {
      get { return units_; }
      set {
        units_ = value;
      }
    }

    /// <summary>Field number for the "nanos" field.</summary>
    public const int NanosFieldNumber = 2;
    private int nanos_;
    /// <summary>
    /// Nano units of the amount (10^-9)
    /// Must be same sign as units
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Nanos {
      get { return nanos_; }
      set {
        nanos_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Decimal);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Decimal other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Units != other.Units) return false;
      if (Nanos != other.Nanos) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Units != 0L) hash ^= Units.GetHashCode();
      if (Nanos != 0) hash ^= Nanos.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Units != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Units);
      }
      if (Nanos != 0) {
        output.WriteRawTag(21);
        output.WriteSFixed32(Nanos);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Units != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Units);
      }
      if (Nanos != 0) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Decimal other) {
      if (other == null) {
        return;
      }
      if (other.Units != 0L) {
        Units = other.Units;
      }
      if (other.Nanos != 0) {
        Nanos = other.Nanos;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Units = input.ReadInt64();
            break;
          }
          case 21: {
            Nanos = input.ReadSFixed32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CustomerBasketRequest : pb::IMessage<CustomerBasketRequest> {
    private static readonly pb::MessageParser<CustomerBasketRequest> _parser = new pb::MessageParser<CustomerBasketRequest>(() => new CustomerBasketRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerBasketRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Basket.API.Proto.BasketReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerBasketRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerBasketRequest(CustomerBasketRequest other) : this() {
      buyerid_ = other.buyerid_;
      items_ = other.items_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerBasketRequest Clone() {
      return new CustomerBasketRequest(this);
    }

    /// <summary>Field number for the "buyerid" field.</summary>
    public const int BuyeridFieldNumber = 1;
    private string buyerid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Buyerid {
      get { return buyerid_; }
      set {
        buyerid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Basket.API.Proto.BasketItemResponse> _repeated_items_codec
        = pb::FieldCodec.ForMessage(18, global::Basket.API.Proto.BasketItemResponse.Parser);
    private readonly pbc::RepeatedField<global::Basket.API.Proto.BasketItemResponse> items_ = new pbc::RepeatedField<global::Basket.API.Proto.BasketItemResponse>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Basket.API.Proto.BasketItemResponse> Items {
      get { return items_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerBasketRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerBasketRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Buyerid != other.Buyerid) return false;
      if(!items_.Equals(other.items_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Buyerid.Length != 0) hash ^= Buyerid.GetHashCode();
      hash ^= items_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Buyerid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Buyerid);
      }
      items_.WriteTo(output, _repeated_items_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Buyerid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Buyerid);
      }
      size += items_.CalculateSize(_repeated_items_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerBasketRequest other) {
      if (other == null) {
        return;
      }
      if (other.Buyerid.Length != 0) {
        Buyerid = other.Buyerid;
      }
      items_.Add(other.items_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Buyerid = input.ReadString();
            break;
          }
          case 18: {
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class CustomerBasketResponse : pb::IMessage<CustomerBasketResponse> {
    private static readonly pb::MessageParser<CustomerBasketResponse> _parser = new pb::MessageParser<CustomerBasketResponse>(() => new CustomerBasketResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerBasketResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Basket.API.Proto.BasketReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerBasketResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerBasketResponse(CustomerBasketResponse other) : this() {
      buyerid_ = other.buyerid_;
      items_ = other.items_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerBasketResponse Clone() {
      return new CustomerBasketResponse(this);
    }

    /// <summary>Field number for the "buyerid" field.</summary>
    public const int BuyeridFieldNumber = 1;
    private string buyerid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Buyerid {
      get { return buyerid_; }
      set {
        buyerid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Basket.API.Proto.BasketItemResponse> _repeated_items_codec
        = pb::FieldCodec.ForMessage(18, global::Basket.API.Proto.BasketItemResponse.Parser);
    private readonly pbc::RepeatedField<global::Basket.API.Proto.BasketItemResponse> items_ = new pbc::RepeatedField<global::Basket.API.Proto.BasketItemResponse>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Basket.API.Proto.BasketItemResponse> Items {
      get { return items_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerBasketResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerBasketResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Buyerid != other.Buyerid) return false;
      if(!items_.Equals(other.items_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Buyerid.Length != 0) hash ^= Buyerid.GetHashCode();
      hash ^= items_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Buyerid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Buyerid);
      }
      items_.WriteTo(output, _repeated_items_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Buyerid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Buyerid);
      }
      size += items_.CalculateSize(_repeated_items_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerBasketResponse other) {
      if (other == null) {
        return;
      }
      if (other.Buyerid.Length != 0) {
        Buyerid = other.Buyerid;
      }
      items_.Add(other.items_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Buyerid = input.ReadString();
            break;
          }
          case 18: {
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class BasketItemResponse : pb::IMessage<BasketItemResponse> {
    private static readonly pb::MessageParser<BasketItemResponse> _parser = new pb::MessageParser<BasketItemResponse>(() => new BasketItemResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BasketItemResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Basket.API.Proto.BasketReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BasketItemResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BasketItemResponse(BasketItemResponse other) : this() {
      id_ = other.id_;
      productid_ = other.productid_;
      productname_ = other.productname_;
      unitprice_ = other.unitprice_ != null ? other.unitprice_.Clone() : null;
      oldunitprice_ = other.oldunitprice_ != null ? other.oldunitprice_.Clone() : null;
      quantity_ = other.quantity_;
      pictureurl_ = other.pictureurl_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BasketItemResponse Clone() {
      return new BasketItemResponse(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "productid" field.</summary>
    public const int ProductidFieldNumber = 2;
    private int productid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Productid {
      get { return productid_; }
      set {
        productid_ = value;
      }
    }

    /// <summary>Field number for the "productname" field.</summary>
    public const int ProductnameFieldNumber = 3;
    private string productname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Productname {
      get { return productname_; }
      set {
        productname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "unitprice" field.</summary>
    public const int UnitpriceFieldNumber = 4;
    private global::Basket.API.Proto.Decimal unitprice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Basket.API.Proto.Decimal Unitprice {
      get { return unitprice_; }
      set {
        unitprice_ = value;
      }
    }

    /// <summary>Field number for the "oldunitprice" field.</summary>
    public const int OldunitpriceFieldNumber = 5;
    private global::Basket.API.Proto.Decimal oldunitprice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Basket.API.Proto.Decimal Oldunitprice {
      get { return oldunitprice_; }
      set {
        oldunitprice_ = value;
      }
    }

    /// <summary>Field number for the "quantity" field.</summary>
    public const int QuantityFieldNumber = 6;
    private int quantity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Quantity {
      get { return quantity_; }
      set {
        quantity_ = value;
      }
    }

    /// <summary>Field number for the "pictureurl" field.</summary>
    public const int PictureurlFieldNumber = 7;
    private string pictureurl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Pictureurl {
      get { return pictureurl_; }
      set {
        pictureurl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BasketItemResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BasketItemResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Productid != other.Productid) return false;
      if (Productname != other.Productname) return false;
      if (!object.Equals(Unitprice, other.Unitprice)) return false;
      if (!object.Equals(Oldunitprice, other.Oldunitprice)) return false;
      if (Quantity != other.Quantity) return false;
      if (Pictureurl != other.Pictureurl) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Productid != 0) hash ^= Productid.GetHashCode();
      if (Productname.Length != 0) hash ^= Productname.GetHashCode();
      if (unitprice_ != null) hash ^= Unitprice.GetHashCode();
      if (oldunitprice_ != null) hash ^= Oldunitprice.GetHashCode();
      if (Quantity != 0) hash ^= Quantity.GetHashCode();
      if (Pictureurl.Length != 0) hash ^= Pictureurl.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Productid != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Productid);
      }
      if (Productname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Productname);
      }
      if (unitprice_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Unitprice);
      }
      if (oldunitprice_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Oldunitprice);
      }
      if (Quantity != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Quantity);
      }
      if (Pictureurl.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Pictureurl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Productid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Productid);
      }
      if (Productname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Productname);
      }
      if (unitprice_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unitprice);
      }
      if (oldunitprice_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Oldunitprice);
      }
      if (Quantity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Quantity);
      }
      if (Pictureurl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Pictureurl);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BasketItemResponse other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Productid != 0) {
        Productid = other.Productid;
      }
      if (other.Productname.Length != 0) {
        Productname = other.Productname;
      }
      if (other.unitprice_ != null) {
        if (unitprice_ == null) {
          Unitprice = new global::Basket.API.Proto.Decimal();
        }
        Unitprice.MergeFrom(other.Unitprice);
      }
      if (other.oldunitprice_ != null) {
        if (oldunitprice_ == null) {
          Oldunitprice = new global::Basket.API.Proto.Decimal();
        }
        Oldunitprice.MergeFrom(other.Oldunitprice);
      }
      if (other.Quantity != 0) {
        Quantity = other.Quantity;
      }
      if (other.Pictureurl.Length != 0) {
        Pictureurl = other.Pictureurl;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 16: {
            Productid = input.ReadInt32();
            break;
          }
          case 26: {
            Productname = input.ReadString();
            break;
          }
          case 34: {
            if (unitprice_ == null) {
              Unitprice = new global::Basket.API.Proto.Decimal();
            }
            input.ReadMessage(Unitprice);
            break;
          }
          case 42: {
            if (oldunitprice_ == null) {
              Oldunitprice = new global::Basket.API.Proto.Decimal();
            }
            input.ReadMessage(Oldunitprice);
            break;
          }
          case 48: {
            Quantity = input.ReadInt32();
            break;
          }
          case 58: {
            Pictureurl = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code