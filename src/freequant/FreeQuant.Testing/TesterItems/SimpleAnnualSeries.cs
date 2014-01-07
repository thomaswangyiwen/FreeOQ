﻿// Type: SmartQuant.Testing.TesterItems.SimpleAnnualSeries
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using ASQMKC8WePBGJ83PL4;
using Byqm85MNrFBe6JPJlI;
using SmartQuant.Series;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.TesterItems
{
  public class SimpleAnnualSeries : SeriesTesterItem
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleAnnualSeries(string name, SeriesTesterItem parentSeriesItem)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, parentSeriesItem, s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2732) + parentSeriesItem.Series.Title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleAnnualSeries(string name)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      if (firstIndex > lastIndex)
        return;
      DateTime dateTime1 = this.parentSeries.GetDateTime(firstIndex);
      DateTime dateTime2 = this.parentSeries.GetDateTime(lastIndex);
      for (DateTime DateTime = new DateTime(dateTime1.Year, 1, 1); DateTime <= dateTime2; DateTime = DateTime.AddYears(1))
        this.series.Add(DateTime, this.parentSeries[DateTime.AddYears(1).AddTicks(-1L), EIndexOption.Prev]);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(DateTime date)
    {
      return this.parentSeries[new DateTime(date.Year, 1, 1).AddYears(1), EIndexOption.Prev];
    }
  }
}