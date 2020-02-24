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
            "ChNQcm90b3MvYmFza2V0LnByb3RvEglCYXNrZXRBcGkiJwoHRGVjaW1hbBIN",
            "CgV1bml0cxgBIAEoAxINCgVuYW5vcxgCIAEoD0ITqgIQQmFza2V0LkFQSS5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Basket.API.Proto.Decimal), global::Basket.API.Proto.Decimal.Parser, new[]{ "Units", "Nanos" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Decimal : pb::IMessage<Decimal> {
    private static readonly pb::MessageParser<Decimal> _parser = new pb::MessageParser<Decimal>(() => new Decimal());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Decimal> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Basket.API.Proto.BasketReflection.Descriptor.MessageTypes[0]; }
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

  #endregion

}

#endregion Designer generated code
