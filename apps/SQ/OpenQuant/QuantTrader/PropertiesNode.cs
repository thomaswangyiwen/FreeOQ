﻿// Type: OpenQuant.QuantTrader.PropertiesNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

namespace OpenQuant.QuantTrader
{
  internal class PropertiesNode : ExportItemNode
  {
    public override bool AutoCheckFromParent
    {
      get
      {
        return false;
      }
    }

    public override bool AutoUncheckParent
    {
      get
      {
        return false;
      }
    }

    public PropertiesNode()
      : base("Properties", 6)
    {
    }
  }
}
