using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Money :  IEquatable<Money>
    { 
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrencyEnum {
            
            [EnumMember(Value = "AED")]
            Aed,
            
            [EnumMember(Value = "AFN")]
            Afn,
            
            [EnumMember(Value = "ALL")]
            All,
            
            [EnumMember(Value = "AMD")]
            Amd,
            
            [EnumMember(Value = "ANG")]
            Ang,
            
            [EnumMember(Value = "AOA")]
            Aoa,
            
            [EnumMember(Value = "ARS")]
            Ars,
            
            [EnumMember(Value = "AUD")]
            Aud,
            
            [EnumMember(Value = "AWG")]
            Awg,
            
            [EnumMember(Value = "AZN")]
            Azn,
            
            [EnumMember(Value = "BAM")]
            Bam,
            
            [EnumMember(Value = "BBD")]
            Bbd,
            
            [EnumMember(Value = "BDT")]
            Bdt,
            
            [EnumMember(Value = "BGN")]
            Bgn,
            
            [EnumMember(Value = "BHD")]
            Bhd,
            
            [EnumMember(Value = "BIF")]
            Bif,
            
            [EnumMember(Value = "BMD")]
            Bmd,
            
            [EnumMember(Value = "BND")]
            Bnd,
            
            [EnumMember(Value = "BOB")]
            Bob,
            
            [EnumMember(Value = "BOV")]
            Bov,
            
            [EnumMember(Value = "BRL")]
            Brl,
            
            [EnumMember(Value = "BSD")]
            Bsd,
            
            [EnumMember(Value = "BTN")]
            Btn,
            
            [EnumMember(Value = "BWP")]
            Bwp,
            
            [EnumMember(Value = "BYR")]
            Byr,
            
            [EnumMember(Value = "BZD")]
            Bzd,
            
            [EnumMember(Value = "CAD")]
            Cad,
            
            [EnumMember(Value = "CDF")]
            Cdf,
            
            [EnumMember(Value = "CHE")]
            Che,
            
            [EnumMember(Value = "CHF")]
            Chf,
            
            [EnumMember(Value = "CHW")]
            Chw,
            
            [EnumMember(Value = "CLF")]
            Clf,
            
            [EnumMember(Value = "CLP")]
            Clp,
            
            [EnumMember(Value = "CNY")]
            Cny,
            
            [EnumMember(Value = "COP")]
            Cop,
            
            [EnumMember(Value = "COU")]
            Cou,
            
            [EnumMember(Value = "CRC")]
            Crc,
            
            [EnumMember(Value = "CUC")]
            Cuc,
            
            [EnumMember(Value = "CUP")]
            Cup,
            
            [EnumMember(Value = "CVE")]
            Cve,
            
            [EnumMember(Value = "CZK")]
            Czk,
            
            [EnumMember(Value = "DJF")]
            Djf,
            
            [EnumMember(Value = "DKK")]
            Dkk,
            
            [EnumMember(Value = "DOP")]
            Dop,
            
            [EnumMember(Value = "DZD")]
            Dzd,
            
            [EnumMember(Value = "EGP")]
            Egp,
            
            [EnumMember(Value = "ERN")]
            Ern,
            
            [EnumMember(Value = "ETB")]
            Etb,
            
            [EnumMember(Value = "EUR")]
            Eur,
            
            [EnumMember(Value = "FJD")]
            Fjd,
            
            [EnumMember(Value = "FKP")]
            Fkp,
            
            [EnumMember(Value = "GBP")]
            Gbp,
            
            [EnumMember(Value = "GEL")]
            Gel,
            
            [EnumMember(Value = "GHS")]
            Ghs,
            
            [EnumMember(Value = "GIP")]
            Gip,
            
            [EnumMember(Value = "GMD")]
            Gmd,
            
            [EnumMember(Value = "GNF")]
            Gnf,
            
            [EnumMember(Value = "GTQ")]
            Gtq,
            
            [EnumMember(Value = "GYD")]
            Gyd,
            
            [EnumMember(Value = "HKD")]
            Hkd,
            
            [EnumMember(Value = "HNL")]
            Hnl,
            
            [EnumMember(Value = "HRK")]
            Hrk,
            
            [EnumMember(Value = "HTG")]
            Htg,
            
            [EnumMember(Value = "HUF")]
            Huf,
            
            [EnumMember(Value = "IDR")]
            Idr,
            
            [EnumMember(Value = "ILS")]
            Ils,
            
            [EnumMember(Value = "INR")]
            Inr,
            
            [EnumMember(Value = "IQD")]
            Iqd,
            
            [EnumMember(Value = "IRR")]
            Irr,
            
            [EnumMember(Value = "ISK")]
            Isk,
            
            [EnumMember(Value = "JMD")]
            Jmd,
            
            [EnumMember(Value = "JOD")]
            Jod,
            
            [EnumMember(Value = "JPY")]
            Jpy,
            
            [EnumMember(Value = "KES")]
            Kes,
            
            [EnumMember(Value = "KGS")]
            Kgs,
            
            [EnumMember(Value = "KHR")]
            Khr,
            
            [EnumMember(Value = "KMF")]
            Kmf,
            
            [EnumMember(Value = "KPW")]
            Kpw,
            
            [EnumMember(Value = "KRW")]
            Krw,
            
            [EnumMember(Value = "KWD")]
            Kwd,
            
            [EnumMember(Value = "KYD")]
            Kyd,
            
            [EnumMember(Value = "KZT")]
            Kzt,
            
            [EnumMember(Value = "LAK")]
            Lak,
            
            [EnumMember(Value = "LBP")]
            Lbp,
            
            [EnumMember(Value = "LKR")]
            Lkr,
            
            [EnumMember(Value = "LRD")]
            Lrd,
            
            [EnumMember(Value = "LSL")]
            Lsl,
            
            [EnumMember(Value = "LTL")]
            Ltl,
            
            [EnumMember(Value = "LVL")]
            Lvl,
            
            [EnumMember(Value = "LYD")]
            Lyd,
            
            [EnumMember(Value = "MAD")]
            Mad,
            
            [EnumMember(Value = "MDL")]
            Mdl,
            
            [EnumMember(Value = "MGA")]
            Mga,
            
            [EnumMember(Value = "MKD")]
            Mkd,
            
            [EnumMember(Value = "MMK")]
            Mmk,
            
            [EnumMember(Value = "MNT")]
            Mnt,
            
            [EnumMember(Value = "MOP")]
            Mop,
            
            [EnumMember(Value = "MRO")]
            Mro,
            
            [EnumMember(Value = "MUR")]
            Mur,
            
            [EnumMember(Value = "MVR")]
            Mvr,
            
            [EnumMember(Value = "MWK")]
            Mwk,
            
            [EnumMember(Value = "MXN")]
            Mxn,
            
            [EnumMember(Value = "MXV")]
            Mxv,
            
            [EnumMember(Value = "MYR")]
            Myr,
            
            [EnumMember(Value = "MZN")]
            Mzn,
            
            [EnumMember(Value = "NAD")]
            Nad,
            
            [EnumMember(Value = "NGN")]
            Ngn,
            
            [EnumMember(Value = "NIO")]
            Nio,
            
            [EnumMember(Value = "NOK")]
            Nok,
            
            [EnumMember(Value = "NPR")]
            Npr,
            
            [EnumMember(Value = "NZD")]
            Nzd,
            
            [EnumMember(Value = "OMR")]
            Omr,
            
            [EnumMember(Value = "PAB")]
            Pab,
            
            [EnumMember(Value = "PEN")]
            Pen,
            
            [EnumMember(Value = "PGK")]
            Pgk,
            
            [EnumMember(Value = "PHP")]
            Php,
            
            [EnumMember(Value = "PKR")]
            Pkr,
            
            [EnumMember(Value = "PLN")]
            Pln,
            
            [EnumMember(Value = "PYG")]
            Pyg,
            
            [EnumMember(Value = "QAR")]
            Qar,
            
            [EnumMember(Value = "RON")]
            Ron,
            
            [EnumMember(Value = "RSD")]
            Rsd,
            
            [EnumMember(Value = "RUB")]
            Rub,
            
            [EnumMember(Value = "RWF")]
            Rwf,
            
            [EnumMember(Value = "SAR")]
            Sar,
            
            [EnumMember(Value = "SBD")]
            Sbd,
            
            [EnumMember(Value = "SCR")]
            Scr,
            
            [EnumMember(Value = "SDG")]
            Sdg,
            
            [EnumMember(Value = "SEK")]
            Sek,
            
            [EnumMember(Value = "SGD")]
            Sgd,
            
            [EnumMember(Value = "SHP")]
            Shp,
            
            [EnumMember(Value = "SLL")]
            Sll,
            
            [EnumMember(Value = "SOS")]
            Sos,
            
            [EnumMember(Value = "SRD")]
            Srd,
            
            [EnumMember(Value = "SSP")]
            Ssp,
            
            [EnumMember(Value = "STD")]
            Std,
            
            [EnumMember(Value = "SVC")]
            Svc,
            
            [EnumMember(Value = "SYP")]
            Syp,
            
            [EnumMember(Value = "SZL")]
            Szl,
            
            [EnumMember(Value = "THB")]
            Thb,
            
            [EnumMember(Value = "TJS")]
            Tjs,
            
            [EnumMember(Value = "TMT")]
            Tmt,
            
            [EnumMember(Value = "TND")]
            Tnd,
            
            [EnumMember(Value = "TOP")]
            Top,
            
            [EnumMember(Value = "TRY")]
            Try,
            
            [EnumMember(Value = "TTD")]
            Ttd,
            
            [EnumMember(Value = "TWD")]
            Twd,
            
            [EnumMember(Value = "TZS")]
            Tzs,
            
            [EnumMember(Value = "UAH")]
            Uah,
            
            [EnumMember(Value = "UGX")]
            Ugx,
            
            [EnumMember(Value = "USD")]
            Usd,
            
            [EnumMember(Value = "USN")]
            Usn,
            
            [EnumMember(Value = "USS")]
            Uss,
            
            [EnumMember(Value = "UYI")]
            Uyi,
            
            [EnumMember(Value = "UYU")]
            Uyu,
            
            [EnumMember(Value = "UZS")]
            Uzs,
            
            [EnumMember(Value = "VEF")]
            Vef,
            
            [EnumMember(Value = "VND")]
            Vnd,
            
            [EnumMember(Value = "VUV")]
            Vuv,
            
            [EnumMember(Value = "WST")]
            Wst,
            
            [EnumMember(Value = "XAF")]
            Xaf,
            
            [EnumMember(Value = "XAG")]
            Xag,
            
            [EnumMember(Value = "XAU")]
            Xau,
            
            [EnumMember(Value = "XBA")]
            Xba,
            
            [EnumMember(Value = "XBB")]
            Xbb,
            
            [EnumMember(Value = "XBC")]
            Xbc,
            
            [EnumMember(Value = "XBD")]
            Xbd,
            
            [EnumMember(Value = "XCD")]
            Xcd,
            
            [EnumMember(Value = "XDR")]
            Xdr,
            
            [EnumMember(Value = "XOF")]
            Xof,
            
            [EnumMember(Value = "XPD")]
            Xpd,
            
            [EnumMember(Value = "XPF")]
            Xpf,
            
            [EnumMember(Value = "XPT")]
            Xpt,
            
            [EnumMember(Value = "XTS")]
            Xts,
            
            [EnumMember(Value = "XXX")]
            Xxx,
            
            [EnumMember(Value = "YER")]
            Yer,
            
            [EnumMember(Value = "ZAR")]
            Zar,
            
            [EnumMember(Value = "ZMK")]
            Zmk,
            
            [EnumMember(Value = "ZMW")]
            Zmw,
            
            [EnumMember(Value = "BTC")]
            Btc
        }

    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public CurrencyEnum? Currency { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Money" /> class.
        /// Initializes a new instance of the <see cref="Money" />class.
        /// </summary>
        /// <param name="Amount">Amount in the lowest denominated value of this Currency. E.g. in USD\nthese are cents, in JPY they are Yen (which do not have a &#39;cent&#39; concept)..</param>
        /// <param name="Currency">.</param>

        public Money(int? Amount = null, CurrencyEnum? Currency = null)
        {
            this.Amount = Amount;
            this.Currency = Currency;
            
        }
        
    
        /// <summary>
        /// Amount in the lowest denominated value of this Currency. E.g. in USD\nthese are cents, in JPY they are Yen (which do not have a &#39;cent&#39; concept).
        /// </summary>
        /// <value>Amount in the lowest denominated value of this Currency. E.g. in USD\nthese are cents, in JPY they are Yen (which do not have a &#39;cent&#39; concept).</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Money {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Money);
        }

        /// <summary>
        /// Returns true if Money instances are equal
        /// </summary>
        /// <param name="other">Instance of Money to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Money other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                
                return hash;
            }
        }

    }
}
