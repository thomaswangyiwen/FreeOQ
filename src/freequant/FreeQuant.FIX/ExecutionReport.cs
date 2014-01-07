﻿// Type: SmartQuant.FIX.ExecutionReport
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class ExecutionReport : FIXExecutionReport
  {
    [Category("Attributes")]
    public Side Side
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXSide.FromFIX(base.Side);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.Side = FIXSide.ToFIX(value);
      }
    }

    [Category("Attributes")]
    public OrdType OrdType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXOrdType.FromFIX(base.OrdType);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.OrdType = FIXOrdType.ToFIX(value);
      }
    }

    [Category("Attributes")]
    public OrdStatus OrdStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXOrdStatus.FromFIX(base.OrdStatus);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.OrdStatus = FIXOrdStatus.ToFIX(value);
      }
    }

    [Category("Attributes")]
    public TimeInForce TimeInForce
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXTimeInForce.FromFIX(base.TimeInForce);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.TimeInForce = FIXTimeInForce.ToFIX(value);
      }
    }

    [Category("Attributes")]
    public ExecTransType ExecTransType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXExecTransType.FromFIX(base.ExecTransType);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.ExecTransType = FIXExecTransType.ToFIX(value);
      }
    }

    [Category("Attributes")]
    public ExecType ExecType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXExecType.FromFIX(base.ExecType);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.ExecType = FIXExecType.ToFIX(value);
      }
    }

    [Category("Commission")]
    public CommType CommType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXCommType.FromFIX(base.CommType);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.CommType = FIXCommType.ToFIX(value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExecutionReport()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}