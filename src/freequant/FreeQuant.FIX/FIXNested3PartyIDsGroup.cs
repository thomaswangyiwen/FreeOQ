﻿// Type: SmartQuant.FIX.FIXNested3PartyIDsGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXNested3PartyIDsGroup : FIXGroup
  {
    private ArrayList H2OuMgMoHo;

    [FIXField("949", EFieldOption.Optional)]
    public string Nested3PartyID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(949).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(949, value);
      }
    }

    [FIXField("950", EFieldOption.Optional)]
    public char Nested3PartyIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(950).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(950, value);
      }
    }

    [FIXField("951", EFieldOption.Optional)]
    public int Nested3PartyRole
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(951).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(951, value);
      }
    }

    [FIXField("952", EFieldOption.Optional)]
    public int NoNested3PartySubIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(952).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(952, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNested3PartyIDsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.H2OuMgMoHo = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNested3PartySubIDsGroup GetNested3PartySubIDsGroup(int i)
    {
      if (i < this.NoNested3PartySubIDs)
        return (FIXNested3PartySubIDsGroup) this.H2OuMgMoHo[i];
      else
        return (FIXNested3PartySubIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXNested3PartySubIDsGroup group)
    {
      this.H2OuMgMoHo.Add((object) group);
      ++this.NoNested3PartySubIDs;
    }
  }
}