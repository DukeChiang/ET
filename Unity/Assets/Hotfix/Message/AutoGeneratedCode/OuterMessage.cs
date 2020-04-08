//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: OuterMessage.proto

using System;   
using System.Collections.Generic;
using ProtoBuf;
    
namespace DCET
{
  [ProtoContract]
  public partial class C2M_TestRequest
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public long ActorId { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.Default)]
    public string request { get; set; }
    
  }
  
  [ProtoContract]
  public partial class M2C_TestResponse
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int Error { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Message { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
    [ProtoMember(4, IsRequired = true, DataFormat = DataFormat.Default)]
    public string response { get; set; }
    
  }
  
  [ProtoContract]
  public partial class Actor_TransferRequest
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public long ActorId { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int MapIndex { get; set; }
    
  }
  
  [ProtoContract]
  public partial class Actor_TransferResponse
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int Error { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Message { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
  }
  
  [ProtoContract]
  public partial class C2G_EnterMap
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
  }
  
  [ProtoContract]
  public partial class G2C_EnterMap
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int Error { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Message { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
    [ProtoMember(4, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public long UnitId { get; set; }
    
    [ProtoMember(5, DataFormat = DataFormat.Default)]
    public List<DCET.UnitInfo> Units { get; set; } = new List<DCET.UnitInfo>();
  
  }
  
  [ProtoContract]
  public partial class UnitInfo
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public long UnitId { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public DCET.UnitType UnitType { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.FixedSize)]
    public float X { get; set; }
    
    [ProtoMember(4, IsRequired = true, DataFormat = DataFormat.FixedSize)]
    public float Y { get; set; }
    
    [ProtoMember(5, IsRequired = true, DataFormat = DataFormat.FixedSize)]
    public float Z { get; set; }
    
  }
  
  [ProtoContract]
  public partial class M2C_CreateUnits
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public long ActorId { get; set; }
    
    [ProtoMember(2, DataFormat = DataFormat.Default)]
    public List<DCET.UnitInfo> Units { get; set; } = new List<DCET.UnitInfo>();
  
  }
  
  [ProtoContract]
  public partial class Frame_ClickMap
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public long ActorId { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.FixedSize)]
    public float X { get; set; }
    
    [ProtoMember(4, IsRequired = true, DataFormat = DataFormat.FixedSize)]
    public float Y { get; set; }
    
    [ProtoMember(5, IsRequired = true, DataFormat = DataFormat.FixedSize)]
    public float Z { get; set; }
    
  }
  
  [ProtoContract]
  public partial class M2C_PathfindingResult
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public long ActorId { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public long Id { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.FixedSize)]
    public float X { get; set; }
    
    [ProtoMember(4, IsRequired = true, DataFormat = DataFormat.FixedSize)]
    public float Y { get; set; }
    
    [ProtoMember(5, IsRequired = true, DataFormat = DataFormat.FixedSize)]
    public float Z { get; set; }
    
    [ProtoMember(6, DataFormat = DataFormat.FixedSize)]
    public List<float> Xs { get; set; } = new List<float>();
  
    [ProtoMember(7, DataFormat = DataFormat.FixedSize)]
    public List<float> Ys { get; set; } = new List<float>();
  
    [ProtoMember(8, DataFormat = DataFormat.FixedSize)]
    public List<float> Zs { get; set; } = new List<float>();
  
  }
  
  [ProtoContract]
  public partial class C2R_Ping
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
  }
  
  [ProtoContract]
  public partial class R2C_Ping
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int Error { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Message { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
  }
  
  [ProtoContract]
  public partial class G2C_Test
  { 
  }
  
  [ProtoContract]
  public partial class C2M_Reload
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Account { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Password { get; set; }
    
  }
  
  [ProtoContract]
  public partial class M2C_Reload
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int Error { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Message { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
  }
  
  [ProtoContract]
  public partial class C2R_Login
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Account { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Password { get; set; }
    
  }
  
  [ProtoContract]
  public partial class R2C_Login
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int Error { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Message { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
    [ProtoMember(4, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Address { get; set; }
    
    [ProtoMember(5, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public long Key { get; set; }
    
    [ProtoMember(6, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public long GateId { get; set; }
    
  }
  
  [ProtoContract]
  public partial class C2G_LoginGate
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public long Key { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public long GateId { get; set; }
    
  }
  
  [ProtoContract]
  public partial class G2C_LoginGate
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int Error { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Message { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
    [ProtoMember(4, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public long PlayerId { get; set; }
    
  }
  
  [ProtoContract]
  public partial class G2C_TestHotfixMessage
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Info { get; set; }
    
  }
  
  [ProtoContract]
  public partial class C2M_TestActorRequest
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public long ActorId { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Info { get; set; }
    
  }
  
  [ProtoContract]
  public partial class M2C_TestActorResponse
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int Error { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Message { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
    [ProtoMember(4, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Info { get; set; }
    
  }
  
  [ProtoContract]
  public partial class PlayerInfo
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public long RpcId { get; set; }
    
  }
  
  [ProtoContract]
  public partial class C2G_PlayerInfo
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
  }
  
  [ProtoContract]
  public partial class G2C_PlayerInfo
  { 
    [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int Error { get; set; }
    
    [ProtoMember(2, IsRequired = true, DataFormat = DataFormat.Default)]
    public string Message { get; set; }
    
    [ProtoMember(3, IsRequired = true, DataFormat = DataFormat.TwosComplement)]
    public int RpcId { get; set; }
    
    [ProtoMember(4, IsRequired = true, DataFormat = DataFormat.Default)]
    public DCET.PlayerInfo PlayerInfo { get; set; }
    
    [ProtoMember(5, DataFormat = DataFormat.Default)]
    public List<DCET.PlayerInfo> PlayerInfos { get; set; } = new List<DCET.PlayerInfo>();
  
    [ProtoMember(6, DataFormat = DataFormat.Default)]
    public List<string> TestRepeatedString { get; set; } = new List<string>();
  
    [ProtoMember(7, DataFormat = DataFormat.TwosComplement)]
    public List<int> TestRepeatedInt32 { get; set; } = new List<int>();
  
    [ProtoMember(8, DataFormat = DataFormat.TwosComplement)]
    public List<long> TestRepeatedInt64 { get; set; } = new List<long>();
  
  }
  
    [ProtoContract]
    public enum UnitType
    {
            
      [ProtoEnum(Value=0)]
      Hero = 0,
            
      [ProtoEnum(Value=1)]
      Npc = 1
    }
  
}