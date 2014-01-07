﻿// Type: SmartQuant.QuantRouterLib.Messages.MsgProviderError
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using NI8YCE6tH4BIeIEcEy;
using SmartQuant.QuantRouterLib.Data;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.QuantRouterLib.Messages
{
  public class MsgProviderError : Message
  {
    public ProviderError Data { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MsgProviderError()
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector(12);
      this.Data = new ProviderError();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnGetData(BinaryWriter writer)
    {
      writer.Write(this.Data.Code);
      writer.Write(this.Data.DateTime.Ticks);
      writer.Write(this.Data.Description);
      writer.Write((byte) this.Data.ErrorType);
      writer.Write(this.Data.Id);
      writer.Write(this.Data.ProviderId);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSetData(BinaryReader reader)
    {
      this.Data.Code = reader.ReadInt32();
      this.Data.DateTime = new DateTime(reader.ReadInt64());
      this.Data.Description = reader.ReadString();
      this.Data.ErrorType = (ProviderErrorType) reader.ReadByte();
      this.Data.Id = reader.ReadInt32();
      this.Data.ProviderId = reader.ReadByte();
    }
  }
}
