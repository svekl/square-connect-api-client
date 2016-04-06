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
    public partial class Address :  IEquatable<Address>
    { 
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CountryEnum {
            
            [EnumMember(Value = "ZZ")]
            Zz,
            
            [EnumMember(Value = "AD")]
            Ad,
            
            [EnumMember(Value = "AE")]
            Ae,
            
            [EnumMember(Value = "AF")]
            Af,
            
            [EnumMember(Value = "AG")]
            Ag,
            
            [EnumMember(Value = "AI")]
            Ai,
            
            [EnumMember(Value = "AL")]
            Al,
            
            [EnumMember(Value = "AM")]
            Am,
            
            [EnumMember(Value = "AO")]
            Ao,
            
            [EnumMember(Value = "AQ")]
            Aq,
            
            [EnumMember(Value = "AR")]
            Ar,
            
            [EnumMember(Value = "AS")]
            As,
            
            [EnumMember(Value = "AT")]
            At,
            
            [EnumMember(Value = "AU")]
            Au,
            
            [EnumMember(Value = "AW")]
            Aw,
            
            [EnumMember(Value = "AX")]
            Ax,
            
            [EnumMember(Value = "AZ")]
            Az,
            
            [EnumMember(Value = "BA")]
            Ba,
            
            [EnumMember(Value = "BB")]
            Bb,
            
            [EnumMember(Value = "BD")]
            Bd,
            
            [EnumMember(Value = "BE")]
            Be,
            
            [EnumMember(Value = "BF")]
            Bf,
            
            [EnumMember(Value = "BG")]
            Bg,
            
            [EnumMember(Value = "BH")]
            Bh,
            
            [EnumMember(Value = "BI")]
            Bi,
            
            [EnumMember(Value = "BJ")]
            Bj,
            
            [EnumMember(Value = "BL")]
            Bl,
            
            [EnumMember(Value = "BM")]
            Bm,
            
            [EnumMember(Value = "BN")]
            Bn,
            
            [EnumMember(Value = "BO")]
            Bo,
            
            [EnumMember(Value = "BQ")]
            Bq,
            
            [EnumMember(Value = "BR")]
            Br,
            
            [EnumMember(Value = "BS")]
            Bs,
            
            [EnumMember(Value = "BT")]
            Bt,
            
            [EnumMember(Value = "BV")]
            Bv,
            
            [EnumMember(Value = "BW")]
            Bw,
            
            [EnumMember(Value = "BY")]
            By,
            
            [EnumMember(Value = "BZ")]
            Bz,
            
            [EnumMember(Value = "CA")]
            Ca,
            
            [EnumMember(Value = "CC")]
            Cc,
            
            [EnumMember(Value = "CD")]
            Cd,
            
            [EnumMember(Value = "CF")]
            Cf,
            
            [EnumMember(Value = "CG")]
            Cg,
            
            [EnumMember(Value = "CH")]
            Ch,
            
            [EnumMember(Value = "CI")]
            Ci,
            
            [EnumMember(Value = "CK")]
            Ck,
            
            [EnumMember(Value = "CL")]
            Cl,
            
            [EnumMember(Value = "CM")]
            Cm,
            
            [EnumMember(Value = "CN")]
            Cn,
            
            [EnumMember(Value = "CO")]
            Co,
            
            [EnumMember(Value = "CR")]
            Cr,
            
            [EnumMember(Value = "CU")]
            Cu,
            
            [EnumMember(Value = "CV")]
            Cv,
            
            [EnumMember(Value = "CW")]
            Cw,
            
            [EnumMember(Value = "CX")]
            Cx,
            
            [EnumMember(Value = "CY")]
            Cy,
            
            [EnumMember(Value = "CZ")]
            Cz,
            
            [EnumMember(Value = "DE")]
            De,
            
            [EnumMember(Value = "DJ")]
            Dj,
            
            [EnumMember(Value = "DK")]
            Dk,
            
            [EnumMember(Value = "DM")]
            Dm,
            
            [EnumMember(Value = "DO")]
            Do,
            
            [EnumMember(Value = "DZ")]
            Dz,
            
            [EnumMember(Value = "EC")]
            Ec,
            
            [EnumMember(Value = "EE")]
            Ee,
            
            [EnumMember(Value = "EG")]
            Eg,
            
            [EnumMember(Value = "EH")]
            Eh,
            
            [EnumMember(Value = "ER")]
            Er,
            
            [EnumMember(Value = "ES")]
            Es,
            
            [EnumMember(Value = "ET")]
            Et,
            
            [EnumMember(Value = "FI")]
            Fi,
            
            [EnumMember(Value = "FJ")]
            Fj,
            
            [EnumMember(Value = "FK")]
            Fk,
            
            [EnumMember(Value = "FM")]
            Fm,
            
            [EnumMember(Value = "FO")]
            Fo,
            
            [EnumMember(Value = "FR")]
            Fr,
            
            [EnumMember(Value = "GA")]
            Ga,
            
            [EnumMember(Value = "GB")]
            Gb,
            
            [EnumMember(Value = "GD")]
            Gd,
            
            [EnumMember(Value = "GE")]
            Ge,
            
            [EnumMember(Value = "GF")]
            Gf,
            
            [EnumMember(Value = "GG")]
            Gg,
            
            [EnumMember(Value = "GH")]
            Gh,
            
            [EnumMember(Value = "GI")]
            Gi,
            
            [EnumMember(Value = "GL")]
            Gl,
            
            [EnumMember(Value = "GM")]
            Gm,
            
            [EnumMember(Value = "GN")]
            Gn,
            
            [EnumMember(Value = "GP")]
            Gp,
            
            [EnumMember(Value = "GQ")]
            Gq,
            
            [EnumMember(Value = "GR")]
            Gr,
            
            [EnumMember(Value = "GS")]
            Gs,
            
            [EnumMember(Value = "GT")]
            Gt,
            
            [EnumMember(Value = "GU")]
            Gu,
            
            [EnumMember(Value = "GW")]
            Gw,
            
            [EnumMember(Value = "GY")]
            Gy,
            
            [EnumMember(Value = "HK")]
            Hk,
            
            [EnumMember(Value = "HM")]
            Hm,
            
            [EnumMember(Value = "HN")]
            Hn,
            
            [EnumMember(Value = "HR")]
            Hr,
            
            [EnumMember(Value = "HT")]
            Ht,
            
            [EnumMember(Value = "HU")]
            Hu,
            
            [EnumMember(Value = "ID")]
            Id,
            
            [EnumMember(Value = "IE")]
            Ie,
            
            [EnumMember(Value = "IL")]
            Il,
            
            [EnumMember(Value = "IM")]
            Im,
            
            [EnumMember(Value = "IN")]
            In,
            
            [EnumMember(Value = "IO")]
            Io,
            
            [EnumMember(Value = "IQ")]
            Iq,
            
            [EnumMember(Value = "IR")]
            Ir,
            
            [EnumMember(Value = "IS")]
            Is,
            
            [EnumMember(Value = "IT")]
            It,
            
            [EnumMember(Value = "JE")]
            Je,
            
            [EnumMember(Value = "JM")]
            Jm,
            
            [EnumMember(Value = "JO")]
            Jo,
            
            [EnumMember(Value = "JP")]
            Jp,
            
            [EnumMember(Value = "KE")]
            Ke,
            
            [EnumMember(Value = "KG")]
            Kg,
            
            [EnumMember(Value = "KH")]
            Kh,
            
            [EnumMember(Value = "KI")]
            Ki,
            
            [EnumMember(Value = "KM")]
            Km,
            
            [EnumMember(Value = "KN")]
            Kn,
            
            [EnumMember(Value = "KP")]
            Kp,
            
            [EnumMember(Value = "KR")]
            Kr,
            
            [EnumMember(Value = "KW")]
            Kw,
            
            [EnumMember(Value = "KY")]
            Ky,
            
            [EnumMember(Value = "KZ")]
            Kz,
            
            [EnumMember(Value = "LA")]
            La,
            
            [EnumMember(Value = "LB")]
            Lb,
            
            [EnumMember(Value = "LC")]
            Lc,
            
            [EnumMember(Value = "LI")]
            Li,
            
            [EnumMember(Value = "LK")]
            Lk,
            
            [EnumMember(Value = "LR")]
            Lr,
            
            [EnumMember(Value = "LS")]
            Ls,
            
            [EnumMember(Value = "LT")]
            Lt,
            
            [EnumMember(Value = "LU")]
            Lu,
            
            [EnumMember(Value = "LV")]
            Lv,
            
            [EnumMember(Value = "LY")]
            Ly,
            
            [EnumMember(Value = "MA")]
            Ma,
            
            [EnumMember(Value = "MC")]
            Mc,
            
            [EnumMember(Value = "MD")]
            Md,
            
            [EnumMember(Value = "ME")]
            Me,
            
            [EnumMember(Value = "MF")]
            Mf,
            
            [EnumMember(Value = "MG")]
            Mg,
            
            [EnumMember(Value = "MH")]
            Mh,
            
            [EnumMember(Value = "MK")]
            Mk,
            
            [EnumMember(Value = "ML")]
            Ml,
            
            [EnumMember(Value = "MM")]
            Mm,
            
            [EnumMember(Value = "MN")]
            Mn,
            
            [EnumMember(Value = "MO")]
            Mo,
            
            [EnumMember(Value = "MP")]
            Mp,
            
            [EnumMember(Value = "MQ")]
            Mq,
            
            [EnumMember(Value = "MR")]
            Mr,
            
            [EnumMember(Value = "MS")]
            Ms,
            
            [EnumMember(Value = "MT")]
            Mt,
            
            [EnumMember(Value = "MU")]
            Mu,
            
            [EnumMember(Value = "MV")]
            Mv,
            
            [EnumMember(Value = "MW")]
            Mw,
            
            [EnumMember(Value = "MX")]
            Mx,
            
            [EnumMember(Value = "MY")]
            My,
            
            [EnumMember(Value = "MZ")]
            Mz,
            
            [EnumMember(Value = "NA")]
            Na,
            
            [EnumMember(Value = "NC")]
            Nc,
            
            [EnumMember(Value = "NE")]
            Ne,
            
            [EnumMember(Value = "NF")]
            Nf,
            
            [EnumMember(Value = "NG")]
            Ng,
            
            [EnumMember(Value = "NI")]
            Ni,
            
            [EnumMember(Value = "NL")]
            Nl,
            
            [EnumMember(Value = "NO")]
            No,
            
            [EnumMember(Value = "NP")]
            Np,
            
            [EnumMember(Value = "NR")]
            Nr,
            
            [EnumMember(Value = "NU")]
            Nu,
            
            [EnumMember(Value = "NZ")]
            Nz,
            
            [EnumMember(Value = "OM")]
            Om,
            
            [EnumMember(Value = "PA")]
            Pa,
            
            [EnumMember(Value = "PE")]
            Pe,
            
            [EnumMember(Value = "PF")]
            Pf,
            
            [EnumMember(Value = "PG")]
            Pg,
            
            [EnumMember(Value = "PH")]
            Ph,
            
            [EnumMember(Value = "PK")]
            Pk,
            
            [EnumMember(Value = "PL")]
            Pl,
            
            [EnumMember(Value = "PM")]
            Pm,
            
            [EnumMember(Value = "PN")]
            Pn,
            
            [EnumMember(Value = "PR")]
            Pr,
            
            [EnumMember(Value = "PS")]
            Ps,
            
            [EnumMember(Value = "PT")]
            Pt,
            
            [EnumMember(Value = "PW")]
            Pw,
            
            [EnumMember(Value = "PY")]
            Py,
            
            [EnumMember(Value = "QA")]
            Qa,
            
            [EnumMember(Value = "RE")]
            Re,
            
            [EnumMember(Value = "RO")]
            Ro,
            
            [EnumMember(Value = "RS")]
            Rs,
            
            [EnumMember(Value = "RU")]
            Ru,
            
            [EnumMember(Value = "RW")]
            Rw,
            
            [EnumMember(Value = "SA")]
            Sa,
            
            [EnumMember(Value = "SB")]
            Sb,
            
            [EnumMember(Value = "SC")]
            Sc,
            
            [EnumMember(Value = "SD")]
            Sd,
            
            [EnumMember(Value = "SE")]
            Se,
            
            [EnumMember(Value = "SG")]
            Sg,
            
            [EnumMember(Value = "SH")]
            Sh,
            
            [EnumMember(Value = "SI")]
            Si,
            
            [EnumMember(Value = "SJ")]
            Sj,
            
            [EnumMember(Value = "SK")]
            Sk,
            
            [EnumMember(Value = "SL")]
            Sl,
            
            [EnumMember(Value = "SM")]
            Sm,
            
            [EnumMember(Value = "SN")]
            Sn,
            
            [EnumMember(Value = "SO")]
            So,
            
            [EnumMember(Value = "SR")]
            Sr,
            
            [EnumMember(Value = "SS")]
            Ss,
            
            [EnumMember(Value = "ST")]
            St,
            
            [EnumMember(Value = "SV")]
            Sv,
            
            [EnumMember(Value = "SX")]
            Sx,
            
            [EnumMember(Value = "SY")]
            Sy,
            
            [EnumMember(Value = "SZ")]
            Sz,
            
            [EnumMember(Value = "TC")]
            Tc,
            
            [EnumMember(Value = "TD")]
            Td,
            
            [EnumMember(Value = "TF")]
            Tf,
            
            [EnumMember(Value = "TG")]
            Tg,
            
            [EnumMember(Value = "TH")]
            Th,
            
            [EnumMember(Value = "TJ")]
            Tj,
            
            [EnumMember(Value = "TK")]
            Tk,
            
            [EnumMember(Value = "TL")]
            Tl,
            
            [EnumMember(Value = "TM")]
            Tm,
            
            [EnumMember(Value = "TN")]
            Tn,
            
            [EnumMember(Value = "TO")]
            To,
            
            [EnumMember(Value = "TR")]
            Tr,
            
            [EnumMember(Value = "TT")]
            Tt,
            
            [EnumMember(Value = "TV")]
            Tv,
            
            [EnumMember(Value = "TW")]
            Tw,
            
            [EnumMember(Value = "TZ")]
            Tz,
            
            [EnumMember(Value = "UA")]
            Ua,
            
            [EnumMember(Value = "UG")]
            Ug,
            
            [EnumMember(Value = "UM")]
            Um,
            
            [EnumMember(Value = "US")]
            Us,
            
            [EnumMember(Value = "UY")]
            Uy,
            
            [EnumMember(Value = "UZ")]
            Uz,
            
            [EnumMember(Value = "VA")]
            Va,
            
            [EnumMember(Value = "VC")]
            Vc,
            
            [EnumMember(Value = "VE")]
            Ve,
            
            [EnumMember(Value = "VG")]
            Vg,
            
            [EnumMember(Value = "VI")]
            Vi,
            
            [EnumMember(Value = "VN")]
            Vn,
            
            [EnumMember(Value = "VU")]
            Vu,
            
            [EnumMember(Value = "WF")]
            Wf,
            
            [EnumMember(Value = "WS")]
            Ws,
            
            [EnumMember(Value = "YE")]
            Ye,
            
            [EnumMember(Value = "YT")]
            Yt,
            
            [EnumMember(Value = "ZA")]
            Za,
            
            [EnumMember(Value = "ZM")]
            Zm,
            
            [EnumMember(Value = "ZW")]
            Zw
        }

    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public CountryEnum? Country { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// Initializes a new instance of the <see cref="Address" />class.
        /// </summary>
        /// <param name="AddressLine1">.</param>
        /// <param name="AddressLine2">.</param>
        /// <param name="AddressLine3">.</param>
        /// <param name="Locality">.</param>
        /// <param name="Sublocality">.</param>
        /// <param name="Sublocality2">.</param>
        /// <param name="Sublocality3">.</param>
        /// <param name="AdministrativeDistrictLevel1">.</param>
        /// <param name="AdministrativeDistrictLevel2">.</param>
        /// <param name="AdministrativeDistrictLevel3">.</param>
        /// <param name="PostalCode">.</param>
        /// <param name="Country">.</param>

        public Address(string AddressLine1 = null, string AddressLine2 = null, string AddressLine3 = null, string Locality = null, string Sublocality = null, string Sublocality2 = null, string Sublocality3 = null, string AdministrativeDistrictLevel1 = null, string AdministrativeDistrictLevel2 = null, string AdministrativeDistrictLevel3 = null, string PostalCode = null, CountryEnum? Country = null)
        {
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.AddressLine3 = AddressLine3;
            this.Locality = Locality;
            this.Sublocality = Sublocality;
            this.Sublocality2 = Sublocality2;
            this.Sublocality3 = Sublocality3;
            this.AdministrativeDistrictLevel1 = AdministrativeDistrictLevel1;
            this.AdministrativeDistrictLevel2 = AdministrativeDistrictLevel2;
            this.AdministrativeDistrictLevel3 = AdministrativeDistrictLevel3;
            this.PostalCode = PostalCode;
            this.Country = Country;
            
        }
        
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="address_line_1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="address_line_2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="address_line_3", EmitDefaultValue=false)]
        public string AddressLine3 { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="sublocality", EmitDefaultValue=false)]
        public string Sublocality { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="sublocality_2", EmitDefaultValue=false)]
        public string Sublocality2 { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="sublocality_3", EmitDefaultValue=false)]
        public string Sublocality3 { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="administrative_district_level_1", EmitDefaultValue=false)]
        public string AdministrativeDistrictLevel1 { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="administrative_district_level_2", EmitDefaultValue=false)]
        public string AdministrativeDistrictLevel2 { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="administrative_district_level_3", EmitDefaultValue=false)]
        public string AdministrativeDistrictLevel3 { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  Sublocality: ").Append(Sublocality).Append("\n");
            sb.Append("  Sublocality2: ").Append(Sublocality2).Append("\n");
            sb.Append("  Sublocality3: ").Append(Sublocality3).Append("\n");
            sb.Append("  AdministrativeDistrictLevel1: ").Append(AdministrativeDistrictLevel1).Append("\n");
            sb.Append("  AdministrativeDistrictLevel2: ").Append(AdministrativeDistrictLevel2).Append("\n");
            sb.Append("  AdministrativeDistrictLevel3: ").Append(AdministrativeDistrictLevel3).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            
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
            return this.Equals(obj as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="other">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddressLine1 == other.AddressLine1 ||
                    this.AddressLine1 != null &&
                    this.AddressLine1.Equals(other.AddressLine1)
                ) && 
                (
                    this.AddressLine2 == other.AddressLine2 ||
                    this.AddressLine2 != null &&
                    this.AddressLine2.Equals(other.AddressLine2)
                ) && 
                (
                    this.AddressLine3 == other.AddressLine3 ||
                    this.AddressLine3 != null &&
                    this.AddressLine3.Equals(other.AddressLine3)
                ) && 
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
                ) && 
                (
                    this.Sublocality == other.Sublocality ||
                    this.Sublocality != null &&
                    this.Sublocality.Equals(other.Sublocality)
                ) && 
                (
                    this.Sublocality2 == other.Sublocality2 ||
                    this.Sublocality2 != null &&
                    this.Sublocality2.Equals(other.Sublocality2)
                ) && 
                (
                    this.Sublocality3 == other.Sublocality3 ||
                    this.Sublocality3 != null &&
                    this.Sublocality3.Equals(other.Sublocality3)
                ) && 
                (
                    this.AdministrativeDistrictLevel1 == other.AdministrativeDistrictLevel1 ||
                    this.AdministrativeDistrictLevel1 != null &&
                    this.AdministrativeDistrictLevel1.Equals(other.AdministrativeDistrictLevel1)
                ) && 
                (
                    this.AdministrativeDistrictLevel2 == other.AdministrativeDistrictLevel2 ||
                    this.AdministrativeDistrictLevel2 != null &&
                    this.AdministrativeDistrictLevel2.Equals(other.AdministrativeDistrictLevel2)
                ) && 
                (
                    this.AdministrativeDistrictLevel3 == other.AdministrativeDistrictLevel3 ||
                    this.AdministrativeDistrictLevel3 != null &&
                    this.AdministrativeDistrictLevel3.Equals(other.AdministrativeDistrictLevel3)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                
                if (this.AddressLine1 != null)
                    hash = hash * 59 + this.AddressLine1.GetHashCode();
                
                if (this.AddressLine2 != null)
                    hash = hash * 59 + this.AddressLine2.GetHashCode();
                
                if (this.AddressLine3 != null)
                    hash = hash * 59 + this.AddressLine3.GetHashCode();
                
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
                
                if (this.Sublocality != null)
                    hash = hash * 59 + this.Sublocality.GetHashCode();
                
                if (this.Sublocality2 != null)
                    hash = hash * 59 + this.Sublocality2.GetHashCode();
                
                if (this.Sublocality3 != null)
                    hash = hash * 59 + this.Sublocality3.GetHashCode();
                
                if (this.AdministrativeDistrictLevel1 != null)
                    hash = hash * 59 + this.AdministrativeDistrictLevel1.GetHashCode();
                
                if (this.AdministrativeDistrictLevel2 != null)
                    hash = hash * 59 + this.AdministrativeDistrictLevel2.GetHashCode();
                
                if (this.AdministrativeDistrictLevel3 != null)
                    hash = hash * 59 + this.AdministrativeDistrictLevel3.GetHashCode();
                
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                return hash;
            }
        }

    }
}
