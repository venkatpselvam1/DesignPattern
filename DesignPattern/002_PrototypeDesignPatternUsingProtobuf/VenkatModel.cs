// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VenkatModel.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace _002_PrototypeDesignPatternUsingProtobuf {

  /// <summary>Holder for reflection information generated from VenkatModel.proto</summary>
  public static partial class VenkatModelReflection {

    #region Descriptor
    /// <summary>File descriptor for VenkatModel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VenkatModelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFWZW5rYXRNb2RlbC5wcm90bxIjUHJvdG90eXBlRGVzaWduUGF0dGVyblVz",
            "aW5nUHJvdG9idWYiZgoMQ29tcGxleE1vZGVsEgkKAWEYASABKAUSCQoBYhgC",
            "IAEoBRIJCgFjGAMgASgFEgkKAWQYBCABKAUSCQoBdxgFIAEoCRIJCgF4GAYg",
            "ASgJEgkKAXkYByABKAkSCQoBehgIIAEoCUIrqgIoXzAwMl9Qcm90b3R5cGVE",
            "ZXNpZ25QYXR0ZXJuVXNpbmdQcm90b2J1ZmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::_002_PrototypeDesignPatternUsingProtobuf.ComplexModel), global::_002_PrototypeDesignPatternUsingProtobuf.ComplexModel.Parser, new[]{ "A", "B", "C", "D", "W", "X", "Y", "Z" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// [START messages]
  /// </summary>
  public sealed partial class ComplexModel : pb::IMessage<ComplexModel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ComplexModel> _parser = new pb::MessageParser<ComplexModel>(() => new ComplexModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ComplexModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::_002_PrototypeDesignPatternUsingProtobuf.VenkatModelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComplexModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComplexModel(ComplexModel other) : this() {
      a_ = other.a_;
      b_ = other.b_;
      c_ = other.c_;
      d_ = other.d_;
      w_ = other.w_;
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComplexModel Clone() {
      return new ComplexModel(this);
    }

    /// <summary>Field number for the "a" field.</summary>
    public const int AFieldNumber = 1;
    private int a_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int A {
      get { return a_; }
      set {
        a_ = value;
      }
    }

    /// <summary>Field number for the "b" field.</summary>
    public const int BFieldNumber = 2;
    private int b_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int B {
      get { return b_; }
      set {
        b_ = value;
      }
    }

    /// <summary>Field number for the "c" field.</summary>
    public const int CFieldNumber = 3;
    private int c_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int C {
      get { return c_; }
      set {
        c_ = value;
      }
    }

    /// <summary>Field number for the "d" field.</summary>
    public const int DFieldNumber = 4;
    private int d_;
    /// <summary>
    /// Unique ID number for this person.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int D {
      get { return d_; }
      set {
        d_ = value;
      }
    }

    /// <summary>Field number for the "w" field.</summary>
    public const int WFieldNumber = 5;
    private string w_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string W {
      get { return w_; }
      set {
        w_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 6;
    private string x_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string X {
      get { return x_; }
      set {
        x_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 7;
    private string y_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Y {
      get { return y_; }
      set {
        y_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 8;
    private string z_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Z {
      get { return z_; }
      set {
        z_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ComplexModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ComplexModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (A != other.A) return false;
      if (B != other.B) return false;
      if (C != other.C) return false;
      if (D != other.D) return false;
      if (W != other.W) return false;
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      if (Z != other.Z) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (A != 0) hash ^= A.GetHashCode();
      if (B != 0) hash ^= B.GetHashCode();
      if (C != 0) hash ^= C.GetHashCode();
      if (D != 0) hash ^= D.GetHashCode();
      if (W.Length != 0) hash ^= W.GetHashCode();
      if (X.Length != 0) hash ^= X.GetHashCode();
      if (Y.Length != 0) hash ^= Y.GetHashCode();
      if (Z.Length != 0) hash ^= Z.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (A != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(A);
      }
      if (B != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(B);
      }
      if (C != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(C);
      }
      if (D != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(D);
      }
      if (W.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(W);
      }
      if (X.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(X);
      }
      if (Y.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Y);
      }
      if (Z.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Z);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (A != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(A);
      }
      if (B != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(B);
      }
      if (C != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(C);
      }
      if (D != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(D);
      }
      if (W.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(W);
      }
      if (X.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(X);
      }
      if (Y.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Y);
      }
      if (Z.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Z);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (A != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(A);
      }
      if (B != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(B);
      }
      if (C != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(C);
      }
      if (D != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(D);
      }
      if (W.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(W);
      }
      if (X.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(X);
      }
      if (Y.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Y);
      }
      if (Z.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Z);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ComplexModel other) {
      if (other == null) {
        return;
      }
      if (other.A != 0) {
        A = other.A;
      }
      if (other.B != 0) {
        B = other.B;
      }
      if (other.C != 0) {
        C = other.C;
      }
      if (other.D != 0) {
        D = other.D;
      }
      if (other.W.Length != 0) {
        W = other.W;
      }
      if (other.X.Length != 0) {
        X = other.X;
      }
      if (other.Y.Length != 0) {
        Y = other.Y;
      }
      if (other.Z.Length != 0) {
        Z = other.Z;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            A = input.ReadInt32();
            break;
          }
          case 16: {
            B = input.ReadInt32();
            break;
          }
          case 24: {
            C = input.ReadInt32();
            break;
          }
          case 32: {
            D = input.ReadInt32();
            break;
          }
          case 42: {
            W = input.ReadString();
            break;
          }
          case 50: {
            X = input.ReadString();
            break;
          }
          case 58: {
            Y = input.ReadString();
            break;
          }
          case 66: {
            Z = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            A = input.ReadInt32();
            break;
          }
          case 16: {
            B = input.ReadInt32();
            break;
          }
          case 24: {
            C = input.ReadInt32();
            break;
          }
          case 32: {
            D = input.ReadInt32();
            break;
          }
          case 42: {
            W = input.ReadString();
            break;
          }
          case 50: {
            X = input.ReadString();
            break;
          }
          case 58: {
            Y = input.ReadString();
            break;
          }
          case 66: {
            Z = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
