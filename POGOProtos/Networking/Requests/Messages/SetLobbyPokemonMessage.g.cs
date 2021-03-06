// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Requests/Messages/SetLobbyPokemonMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/SetLobbyPokemonMessage.proto</summary>
  public static partial class SetLobbyPokemonMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/SetLobbyPokemonMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetLobbyPokemonMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvU2V0",
            "TG9iYnlQb2tlbW9uTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3Jr",
            "aW5nLlJlcXVlc3RzLk1lc3NhZ2VzImEKFlNldExvYmJ5UG9rZW1vbk1lc3Nh",
            "Z2USEQoJcmFpZF9zZWVkGAEgASgDEg4KBmd5bV9pZBgCIAEoCRIQCghsb2Ji",
            "eV9pZBgDIAMoBRISCgpwb2tlbW9uX2lkGAQgAygGYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.SetLobbyPokemonMessage), global::POGOProtos.Networking.Requests.Messages.SetLobbyPokemonMessage.Parser, new[]{ "RaidSeed", "GymId", "LobbyId", "PokemonId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SetLobbyPokemonMessage : pb::IMessage<SetLobbyPokemonMessage> {
    private static readonly pb::MessageParser<SetLobbyPokemonMessage> _parser = new pb::MessageParser<SetLobbyPokemonMessage>(() => new SetLobbyPokemonMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetLobbyPokemonMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.SetLobbyPokemonMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetLobbyPokemonMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetLobbyPokemonMessage(SetLobbyPokemonMessage other) : this() {
      raidSeed_ = other.raidSeed_;
      gymId_ = other.gymId_;
      lobbyId_ = other.lobbyId_.Clone();
      pokemonId_ = other.pokemonId_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetLobbyPokemonMessage Clone() {
      return new SetLobbyPokemonMessage(this);
    }

    /// <summary>Field number for the "raid_seed" field.</summary>
    public const int RaidSeedFieldNumber = 1;
    private long raidSeed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RaidSeed {
      get { return raidSeed_; }
      set {
        raidSeed_ = value;
      }
    }

    /// <summary>Field number for the "gym_id" field.</summary>
    public const int GymIdFieldNumber = 2;
    private string gymId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GymId {
      get { return gymId_; }
      set {
        gymId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lobby_id" field.</summary>
    public const int LobbyIdFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_lobbyId_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> lobbyId_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> LobbyId {
      get { return lobbyId_; }
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 4;
    private static readonly pb::FieldCodec<ulong> _repeated_pokemonId_codec
        = pb::FieldCodec.ForFixed64(34);
    private readonly pbc::RepeatedField<ulong> pokemonId_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<ulong> PokemonId {
      get { return pokemonId_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetLobbyPokemonMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetLobbyPokemonMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RaidSeed != other.RaidSeed) return false;
      if (GymId != other.GymId) return false;
      if(!lobbyId_.Equals(other.lobbyId_)) return false;
      if(!pokemonId_.Equals(other.pokemonId_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RaidSeed != 0L) hash ^= RaidSeed.GetHashCode();
      if (GymId.Length != 0) hash ^= GymId.GetHashCode();
      hash ^= lobbyId_.GetHashCode();
      hash ^= pokemonId_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RaidSeed != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RaidSeed);
      }
      if (GymId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(GymId);
      }
      lobbyId_.WriteTo(output, _repeated_lobbyId_codec);
      pokemonId_.WriteTo(output, _repeated_pokemonId_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RaidSeed != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RaidSeed);
      }
      if (GymId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GymId);
      }
      size += lobbyId_.CalculateSize(_repeated_lobbyId_codec);
      size += pokemonId_.CalculateSize(_repeated_pokemonId_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetLobbyPokemonMessage other) {
      if (other == null) {
        return;
      }
      if (other.RaidSeed != 0L) {
        RaidSeed = other.RaidSeed;
      }
      if (other.GymId.Length != 0) {
        GymId = other.GymId;
      }
      lobbyId_.Add(other.lobbyId_);
      pokemonId_.Add(other.pokemonId_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            RaidSeed = input.ReadInt64();
            break;
          }
          case 18: {
            GymId = input.ReadString();
            break;
          }
          case 26:
          case 24: {
            lobbyId_.AddEntriesFrom(input, _repeated_lobbyId_codec);
            break;
          }
          case 34:
          case 33: {
            pokemonId_.AddEntriesFrom(input, _repeated_pokemonId_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
