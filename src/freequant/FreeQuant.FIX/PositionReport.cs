﻿// Type: SmartQuant.FIX.PositionReport
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class PositionReport : FIXPositionReport
  {
    public PosReqType PosReqType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXPosReqType.FromFIX(base.PosReqType);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.PosReqType = FIXPosReqType.ToFIX(value);
      }
    }

    public PosReqResult PosReqResult
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXPosReqResult.FromFIX(base.PosReqResult);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.PosReqResult = FIXPosReqResult.ToFIX(value);
      }
    }

    public PutOrCall PutOrCall
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXPutOrCall.FromFIX(base.PutOrCall);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.PutOrCall = FIXPutOrCall.ToFIX(value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PositionReport()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}