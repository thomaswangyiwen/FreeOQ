﻿// Type: OpenQuant.Options.Xml.ProviderXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;

namespace OpenQuant.Options.Xml
{
  internal abstract class ProviderXmlNode : XmlNodeBase
  {
    public byte ProviderId
    {
      get
      {
        return this.GetByteValue();
      }
      set
      {
        this.SetValue(value);
      }
    }
  }
}
