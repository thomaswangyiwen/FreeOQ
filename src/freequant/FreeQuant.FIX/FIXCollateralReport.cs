using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCollateralReport : FIXMessage
  {
    private ArrayList WsAUcTvobS;
    private ArrayList M2ZUzm9ml0;
    private ArrayList qLvAS54bAn;
    private ArrayList NNdAUno2MQ;
    private ArrayList fZKAANLvux;
    private ArrayList u3xA8vrFby;
    private ArrayList eThAZtaAhL;
    private ArrayList f4YAujQJ39;
    private ArrayList jItAtRPbmA;
    private ArrayList rv2AQcn4T3;
    private ArrayList cp6A7hgCjU;
    private ArrayList uJBAYycAMI;
    private ArrayList INtAyDr2fY;

    [FIXField("144", EFieldOption.Optional)]
    public string OnBehalfOfLocationID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(144).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(144, value);
      }
    }

    [FIXField("9", EFieldOption.Required)]
    public int BodyLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(9).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(9, value);
      }
    }

    [FIXField("35", EFieldOption.Required)]
    public string MsgType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(35).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(35, value);
      }
    }

    [FIXField("49", EFieldOption.Required)]
    public string SenderCompID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(49).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(49, value);
      }
    }

    [FIXField("56", EFieldOption.Required)]
    public string TargetCompID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(56).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(56, value);
      }
    }

    [FIXField("115", EFieldOption.Optional)]
    public string OnBehalfOfCompID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(115).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(115, value);
      }
    }

    [FIXField("128", EFieldOption.Optional)]
    public string DeliverToCompID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(128).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(128, value);
      }
    }

    [FIXField("90", EFieldOption.Optional)]
    public int SecureDataLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(90).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(90, value);
      }
    }

    [FIXField("91", EFieldOption.Optional)]
    public string SecureData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(91).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(91, value);
      }
    }

    [FIXField("34", EFieldOption.Required)]
    public int MsgSeqNum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(34).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(34, value);
      }
    }

    [FIXField("50", EFieldOption.Optional)]
    public string SenderSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(50).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(50, value);
      }
    }

    [FIXField("142", EFieldOption.Optional)]
    public string SenderLocationID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(142).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(142, value);
      }
    }

    [FIXField("57", EFieldOption.Optional)]
    public string TargetSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(57).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(57, value);
      }
    }

    [FIXField("8", EFieldOption.Required)]
    public string BeginString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(8).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(8, value);
      }
    }

    [FIXField("116", EFieldOption.Optional)]
    public string OnBehalfOfSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(116).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(116, value);
      }
    }

    [FIXField("129", EFieldOption.Optional)]
    public string DeliverToSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(129).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(129, value);
      }
    }

    [FIXField("145", EFieldOption.Optional)]
    public string DeliverToLocationID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(145).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(145, value);
      }
    }

    [FIXField("43", EFieldOption.Optional)]
    public bool PossDupFlag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolField(43).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddBoolField(43, value);
      }
    }

    [FIXField("97", EFieldOption.Optional)]
    public bool PossResend
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolField(97).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddBoolField(97, value);
      }
    }

    [FIXField("52", EFieldOption.Optional)]
    public DateTime SendingTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(52).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(52, value);
      }
    }

    [FIXField("122", EFieldOption.Optional)]
    public DateTime OrigSendingTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(122).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(122, value);
      }
    }

    [FIXField("212", EFieldOption.Optional)]
    public int XmlDataLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(212).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(212, value);
      }
    }

    [FIXField("213", EFieldOption.Optional)]
    public string XmlData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(213).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(213, value);
      }
    }

    [FIXField("347", EFieldOption.Optional)]
    public string MessageEncoding
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(347).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(347, value);
      }
    }

    [FIXField("369", EFieldOption.Optional)]
    public int LastMsgSeqNumProcessed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(369).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(369, value);
      }
    }

    [FIXField("627", EFieldOption.Optional)]
    public int NoHops
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(627).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(627, value);
      }
    }

    [FIXField("143", EFieldOption.Optional)]
    public string TargetLocationID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(143).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(143, value);
      }
    }

    [FIXField("908", EFieldOption.Required)]
    public string CollRptID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(908).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(908, value);
      }
    }

    [FIXField("909", EFieldOption.Optional)]
    public string CollInquiryID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(909).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(909, value);
      }
    }

    [FIXField("910", EFieldOption.Required)]
    public int CollStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(910).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(910, value);
      }
    }

    [FIXField("911", EFieldOption.Optional)]
    public int TotNumReports
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(911).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(911, value);
      }
    }

    [FIXField("912", EFieldOption.Optional)]
    public bool LastRptRequested
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolField(912).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddBoolField(912, value);
      }
    }

    [FIXField("453", EFieldOption.Optional)]
    public int NoPartyIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(453).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(453, value);
      }
    }

    [FIXField("1", EFieldOption.Optional)]
    public string Account
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(1).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(1, value);
      }
    }

    [FIXField("581", EFieldOption.Optional)]
    public int AccountType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(581).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(581, value);
      }
    }

    [FIXField("11", EFieldOption.Optional)]
    public string ClOrdID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(11).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(11, value);
      }
    }

    [FIXField("37", EFieldOption.Optional)]
    public string OrderID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(37).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(37, value);
      }
    }

    [FIXField("198", EFieldOption.Optional)]
    public string SecondaryOrderID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(198).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(198, value);
      }
    }

    [FIXField("526", EFieldOption.Optional)]
    public string SecondaryClOrdID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(526).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(526, value);
      }
    }

    [FIXField("124", EFieldOption.Optional)]
    public int NoExecs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(124).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(124, value);
      }
    }

    [FIXField("897", EFieldOption.Optional)]
    public int NoTrades
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(897).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(897, value);
      }
    }

    [FIXField("55", EFieldOption.Optional)]
    public string Symbol
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(55).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(55, value);
      }
    }

    [FIXField("65", EFieldOption.Optional)]
    public string SymbolSfx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(65).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(65, value);
      }
    }

    [FIXField("48", EFieldOption.Optional)]
    public string SecurityID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(48).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(48, value);
      }
    }

    [FIXField("22", EFieldOption.Optional)]
    public string SecurityIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(22).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(22, value);
      }
    }

    [FIXField("454", EFieldOption.Optional)]
    public int NoSecurityAltID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(454).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(454, value);
      }
    }

    [FIXField("460", EFieldOption.Optional)]
    public int Product
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(460).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(460, value);
      }
    }

    [FIXField("461", EFieldOption.Optional)]
    public string CFICode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(461).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(461, value);
      }
    }

    [FIXField("167", EFieldOption.Optional)]
    public string SecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(167).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(167, value);
      }
    }

    [FIXField("762", EFieldOption.Optional)]
    public string SecuritySubType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(762).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(762, value);
      }
    }

    [FIXField("200", EFieldOption.Optional)]
    public string MaturityMonthYear
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(200).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(200, value);
      }
    }

    [FIXField("541", EFieldOption.Optional)]
    public DateTime MaturityDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(541).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(541, value);
      }
    }

    [FIXField("224", EFieldOption.Optional)]
    public DateTime CouponPaymentDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(224).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(224, value);
      }
    }

    [FIXField("225", EFieldOption.Optional)]
    public DateTime IssueDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(225).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(225, value);
      }
    }

    [FIXField("239", EFieldOption.Optional)]
    public int RepoCollateralSecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(239).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(239, value);
      }
    }

    [FIXField("226", EFieldOption.Optional)]
    public int RepurchaseTerm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(226).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(226, value);
      }
    }

    [FIXField("227", EFieldOption.Optional)]
    public double RepurchaseRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(227).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(227, value);
      }
    }

    [FIXField("228", EFieldOption.Optional)]
    public double Factor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(228).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(228, value);
      }
    }

    [FIXField("255", EFieldOption.Optional)]
    public string CreditRating
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField((int) byte.MaxValue).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField((int) byte.MaxValue, value);
      }
    }

    [FIXField("543", EFieldOption.Optional)]
    public string InstrRegistry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(543).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(543, value);
      }
    }

    [FIXField("470", EFieldOption.Optional)]
    public string CountryOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(470).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(470, value);
      }
    }

    [FIXField("471", EFieldOption.Optional)]
    public string StateOrProvinceOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(471).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(471, value);
      }
    }

    [FIXField("472", EFieldOption.Optional)]
    public string LocaleOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(472).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(472, value);
      }
    }

    [FIXField("240", EFieldOption.Optional)]
    public DateTime RedemptionDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(240).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(240, value);
      }
    }

    [FIXField("202", EFieldOption.Optional)]
    public double StrikePrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(202).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(202, value);
      }
    }

    [FIXField("947", EFieldOption.Optional)]
    public double StrikeCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(947).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(947, value);
      }
    }

    [FIXField("206", EFieldOption.Optional)]
    public char OptAttribute
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(206).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(206, value);
      }
    }

    [FIXField("231", EFieldOption.Optional)]
    public double ContractMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(231).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(231, value);
      }
    }

    [FIXField("223", EFieldOption.Optional)]
    public double CouponRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(223).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(223, value);
      }
    }

    [FIXField("207", EFieldOption.Optional)]
    public string SecurityExchange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(207).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(207, value);
      }
    }

    [FIXField("106", EFieldOption.Optional)]
    public string Issuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(106).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(106, value);
      }
    }

    [FIXField("348", EFieldOption.Optional)]
    public int EncodedIssuerLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(348).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(348, value);
      }
    }

    [FIXField("349", EFieldOption.Optional)]
    public string EncodedIssuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(349).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(349, value);
      }
    }

    [FIXField("107", EFieldOption.Optional)]
    public string SecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(107).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(107, value);
      }
    }

    [FIXField("350", EFieldOption.Optional)]
    public int EncodedSecurityDescLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(350).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(350, value);
      }
    }

    [FIXField("351", EFieldOption.Optional)]
    public string EncodedSecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(351).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(351, value);
      }
    }

    [FIXField("691", EFieldOption.Optional)]
    public string Pool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(691).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(691, value);
      }
    }

    [FIXField("667", EFieldOption.Optional)]
    public string ContractSettlMonth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(667).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(667, value);
      }
    }

    [FIXField("875", EFieldOption.Optional)]
    public int CPProgram
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(875).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(875, value);
      }
    }

    [FIXField("876", EFieldOption.Optional)]
    public string CPRegType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(876).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(876, value);
      }
    }

    [FIXField("864", EFieldOption.Optional)]
    public int NoEvents
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(864).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(864, value);
      }
    }

    [FIXField("873", EFieldOption.Optional)]
    public DateTime DatedDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(873).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(873, value);
      }
    }

    [FIXField("874", EFieldOption.Optional)]
    public DateTime InterestAccrualDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(874).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(874, value);
      }
    }

    [FIXField("913", EFieldOption.Optional)]
    public string AgreementDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(913).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(913, value);
      }
    }

    [FIXField("914", EFieldOption.Optional)]
    public string AgreementID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(914).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(914, value);
      }
    }

    [FIXField("915", EFieldOption.Optional)]
    public DateTime AgreementDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(915).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(915, value);
      }
    }

    [FIXField("918", EFieldOption.Optional)]
    public double AgreementCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(918).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(918, value);
      }
    }

    [FIXField("788", EFieldOption.Optional)]
    public int TerminationType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(788).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(788, value);
      }
    }

    [FIXField("916", EFieldOption.Optional)]
    public DateTime StartDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(916).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(916, value);
      }
    }

    [FIXField("917", EFieldOption.Optional)]
    public DateTime EndDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(917).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(917, value);
      }
    }

    [FIXField("919", EFieldOption.Optional)]
    public int DeliveryType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(919).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(919, value);
      }
    }

    [FIXField("898", EFieldOption.Optional)]
    public double MarginRatio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(898).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(898, value);
      }
    }

    [FIXField("64", EFieldOption.Optional)]
    public DateTime SettlDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(64).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(64, value);
      }
    }

    [FIXField("53", EFieldOption.Optional)]
    public double Quantity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(53).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(53, value);
      }
    }

    [FIXField("854", EFieldOption.Optional)]
    public int QtyType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(854).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(854, value);
      }
    }

    [FIXField("15", EFieldOption.Optional)]
    public double Currency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(15).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(15, value);
      }
    }

    [FIXField("555", EFieldOption.Optional)]
    public int NoLegs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(555).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(555, value);
      }
    }

    [FIXField("711", EFieldOption.Optional)]
    public int NoUnderlyings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(711).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(711, value);
      }
    }

    [FIXField("899", EFieldOption.Optional)]
    public double MarginExcess
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(899).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(899, value);
      }
    }

    [FIXField("900", EFieldOption.Optional)]
    public double TotalNetValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(900).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(900, value);
      }
    }

    [FIXField("901", EFieldOption.Optional)]
    public double CashOutstanding
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(901).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(901, value);
      }
    }

    [FIXField("768", EFieldOption.Optional)]
    public int NoTrdRegTimestamps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(768).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(768, value);
      }
    }

    [FIXField("54", EFieldOption.Optional)]
    public char Side
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(54).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(54, value);
      }
    }

    [FIXField("136", EFieldOption.Optional)]
    public int NoMiscFees
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(136).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(136, value);
      }
    }

    [FIXField("44", EFieldOption.Optional)]
    public double Price
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(44).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(44, value);
      }
    }

    [FIXField("423", EFieldOption.Optional)]
    public int PriceType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(423).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(423, value);
      }
    }

    [FIXField("159", EFieldOption.Optional)]
    public double AccruedInterestAmt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(159).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(159, value);
      }
    }

    [FIXField("920", EFieldOption.Optional)]
    public double EndAccruedInterestAmt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(920).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(920, value);
      }
    }

    [FIXField("921", EFieldOption.Optional)]
    public double StartCash
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(921).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(921, value);
      }
    }

    [FIXField("922", EFieldOption.Optional)]
    public double EndCash
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(922).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(922, value);
      }
    }

    [FIXField("218", EFieldOption.Optional)]
    public double Spread
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(218).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(218, value);
      }
    }

    [FIXField("220", EFieldOption.Optional)]
    public double BenchmarkCurveCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(220).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(220, value);
      }
    }

    [FIXField("221", EFieldOption.Optional)]
    public string BenchmarkCurveName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(221).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(221, value);
      }
    }

    [FIXField("222", EFieldOption.Optional)]
    public string BenchmarkCurvePoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(222).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(222, value);
      }
    }

    [FIXField("662", EFieldOption.Optional)]
    public double BenchmarkPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(662).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(662, value);
      }
    }

    [FIXField("663", EFieldOption.Optional)]
    public int BenchmarkPriceType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(663).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(663, value);
      }
    }

    [FIXField("699", EFieldOption.Optional)]
    public string BenchmarkSecurityID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(699).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(699, value);
      }
    }

    [FIXField("761", EFieldOption.Optional)]
    public string BenchmarkSecurityIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(761).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(761, value);
      }
    }

    [FIXField("232", EFieldOption.Optional)]
    public int NoStipulations
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(232).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(232, value);
      }
    }

    [FIXField("172", EFieldOption.Optional)]
    public int SettlDeliveryType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(172).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(172, value);
      }
    }

    [FIXField("169", EFieldOption.Optional)]
    public int StandInstDbType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(169).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(169, value);
      }
    }

    [FIXField("170", EFieldOption.Optional)]
    public string StandInstDbName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(170).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(170, value);
      }
    }

    [FIXField("171", EFieldOption.Optional)]
    public string StandInstDbID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(171).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(171, value);
      }
    }

    [FIXField("85", EFieldOption.Optional)]
    public int NoDlvyInst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(85).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(85, value);
      }
    }

    [FIXField("336", EFieldOption.Optional)]
    public string TradingSessionID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(336).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(336, value);
      }
    }

    [FIXField("625", EFieldOption.Optional)]
    public string TradingSessionSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(625).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(625, value);
      }
    }

    [FIXField("716", EFieldOption.Optional)]
    public string SettlSessID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(716).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(716, value);
      }
    }

    [FIXField("717", EFieldOption.Optional)]
    public string SettlSessSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(717).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(717, value);
      }
    }

    [FIXField("715", EFieldOption.Optional)]
    public DateTime ClearingBusinessDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(715).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(715, value);
      }
    }

    [FIXField("58", EFieldOption.Optional)]
    public string Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(58).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(58, value);
      }
    }

    [FIXField("354", EFieldOption.Optional)]
    public int EncodedTextLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(354).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(354, value);
      }
    }

    [FIXField("355", EFieldOption.Optional)]
    public string EncodedText
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(355).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(355, value);
      }
    }

    [FIXField("10", EFieldOption.Required)]
    public string CheckSum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(10).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(10, value);
      }
    }

    [FIXField("89", EFieldOption.Optional)]
    public string Signature
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(89).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(89, value);
      }
    }

    [FIXField("93", EFieldOption.Optional)]
    public int SignatureLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(93).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(93, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXCollateralReport() :base()
    {
        this.WsAUcTvobS = new ArrayList();
      this.M2ZUzm9ml0 = new ArrayList();
      this.qLvAS54bAn = new ArrayList();
      this.NNdAUno2MQ = new ArrayList();
      this.fZKAANLvux = new ArrayList();
      this.u3xA8vrFby = new ArrayList();
      this.eThAZtaAhL = new ArrayList();
      this.f4YAujQJ39 = new ArrayList();
      this.jItAtRPbmA = new ArrayList();
      this.rv2AQcn4T3 = new ArrayList();
      this.cp6A7hgCjU = new ArrayList();
      this.uJBAYycAMI = new ArrayList();
      this.INtAyDr2fY = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXCollateralReport(string CollRptID, int CollStatus):base()
    {
      this.WsAUcTvobS = new ArrayList();
      this.M2ZUzm9ml0 = new ArrayList();
      this.qLvAS54bAn = new ArrayList();
      this.NNdAUno2MQ = new ArrayList();
      this.fZKAANLvux = new ArrayList();
      this.u3xA8vrFby = new ArrayList();
      this.eThAZtaAhL = new ArrayList();
      this.f4YAujQJ39 = new ArrayList();
      this.jItAtRPbmA = new ArrayList();
      this.rv2AQcn4T3 = new ArrayList();
      this.cp6A7hgCjU = new ArrayList();
      this.uJBAYycAMI = new ArrayList();
      this.INtAyDr2fY = new ArrayList();
      this.CollRptID = CollRptID;
      this.CollStatus = CollStatus;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXHopRefIDGroup GetHopRefIDGroup(int i)
    {
      return (FIXHopRefIDGroup) this.WsAUcTvobS[i];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXHopRefIDGroup group)
    {
      this.WsAUcTvobS.Add((object) group);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXHopsGroup GetHopsGroup(int i)
    {
      if (i < this.NoHops)
        return (FIXHopsGroup) this.M2ZUzm9ml0[i];
      else
        return (FIXHopsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXHopsGroup group)
    {
      this.M2ZUzm9ml0.Add((object) group);
      ++this.NoHops;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPartyIDsGroup GetPartyIDsGroup(int i)
    {
      if (i < this.NoPartyIDs)
        return (FIXPartyIDsGroup) this.qLvAS54bAn[i];
      else
        return (FIXPartyIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXPartyIDsGroup group)
    {
      this.qLvAS54bAn.Add((object) group);
      ++this.NoPartyIDs;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXExecsGroup GetExecsGroup(int i)
    {
      if (i < this.NoExecs)
        return (FIXExecsGroup) this.NNdAUno2MQ[i];
      else
        return (FIXExecsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXExecsGroup group)
    {
      this.NNdAUno2MQ.Add((object) group);
      ++this.NoExecs;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTradesGroup GetTradesGroup(int i)
    {
      if (i < this.NoTrades)
        return (FIXTradesGroup) this.fZKAANLvux[i];
      else
        return (FIXTradesGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXTradesGroup group)
    {
      this.fZKAANLvux.Add((object) group);
      ++this.NoTrades;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
    {
      if (i < this.NoSecurityAltID)
        return (FIXSecurityAltIDGroup) this.u3xA8vrFby[i];
      else
        return (FIXSecurityAltIDGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXSecurityAltIDGroup group)
    {
      this.u3xA8vrFby.Add((object) group);
      ++this.NoSecurityAltID;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXEventsGroup GetEventsGroup(int i)
    {
      if (i < this.NoEvents)
        return (FIXEventsGroup) this.eThAZtaAhL[i];
      else
        return (FIXEventsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXEventsGroup group)
    {
      this.eThAZtaAhL.Add((object) group);
      ++this.NoEvents;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXLegsGroup GetLegsGroup(int i)
    {
      if (i < this.NoLegs)
        return (FIXLegsGroup) this.f4YAujQJ39[i];
      else
        return (FIXLegsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXLegsGroup group)
    {
      this.f4YAujQJ39.Add((object) group);
      ++this.NoLegs;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
    {
      if (i < this.NoUnderlyings)
        return (FIXUnderlyingsGroup) this.jItAtRPbmA[i];
      else
        return (FIXUnderlyingsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXUnderlyingsGroup group)
    {
      this.jItAtRPbmA.Add((object) group);
      ++this.NoUnderlyings;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTrdRegTimestampsGroup GetTrdRegTimestampsGroup(int i)
    {
      if (i < this.NoTrdRegTimestamps)
        return (FIXTrdRegTimestampsGroup) this.rv2AQcn4T3[i];
      else
        return (FIXTrdRegTimestampsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXTrdRegTimestampsGroup group)
    {
      this.rv2AQcn4T3.Add((object) group);
      ++this.NoTrdRegTimestamps;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXMiscFeesGroup GetMiscFeesGroup(int i)
    {
      if (i < this.NoMiscFees)
        return (FIXMiscFeesGroup) this.cp6A7hgCjU[i];
      else
        return (FIXMiscFeesGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXMiscFeesGroup group)
    {
      this.cp6A7hgCjU.Add((object) group);
      ++this.NoMiscFees;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXStipulationsGroup GetStipulationsGroup(int i)
    {
      if (i < this.NoStipulations)
        return (FIXStipulationsGroup) this.uJBAYycAMI[i];
      else
        return (FIXStipulationsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXStipulationsGroup group)
    {
      this.uJBAYycAMI.Add((object) group);
      ++this.NoStipulations;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXDlvyInstGroup GetDlvyInstGroup(int i)
    {
      if (i < this.NoDlvyInst)
        return (FIXDlvyInstGroup) this.INtAyDr2fY[i];
      else
        return (FIXDlvyInstGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXDlvyInstGroup group)
    {
      this.INtAyDr2fY.Add((object) group);
      ++this.NoDlvyInst;
    }
  }
}
