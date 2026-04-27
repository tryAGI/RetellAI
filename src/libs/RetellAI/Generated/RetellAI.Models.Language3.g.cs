
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Specifies what language (and dialect) the agent will operate in. For instance, selecting `en-GB` optimizes speech recognition for British English and indexes knowledge bases with English. If unset, will use default value `en-US`. This enum does not include the legacy scalar value `multi`.<br/>
    /// Example: en-US
    /// </summary>
    public enum Language3
    {
        /// <summary>
        /// 
        /// </summary>
        AfZa,
        /// <summary>
        /// 
        /// </summary>
        ArSa,
        /// <summary>
        /// 
        /// </summary>
        AzAz,
        /// <summary>
        /// 
        /// </summary>
        BgBg,
        /// <summary>
        /// 
        /// </summary>
        BsBa,
        /// <summary>
        /// 
        /// </summary>
        CaEs,
        /// <summary>
        /// 
        /// </summary>
        CsCz,
        /// <summary>
        /// 
        /// </summary>
        CyGb,
        /// <summary>
        /// 
        /// </summary>
        DaDk,
        /// <summary>
        /// 
        /// </summary>
        DeDe,
        /// <summary>
        /// 
        /// </summary>
        ElGr,
        /// <summary>
        /// 
        /// </summary>
        EnAu,
        /// <summary>
        /// 
        /// </summary>
        EnGb,
        /// <summary>
        /// 
        /// </summary>
        EnIn,
        /// <summary>
        /// 
        /// </summary>
        EnNz,
        /// <summary>
        /// 
        /// </summary>
        EnUs,
        /// <summary>
        /// 
        /// </summary>
        Es419,
        /// <summary>
        /// 
        /// </summary>
        EsEs,
        /// <summary>
        /// 
        /// </summary>
        FaIr,
        /// <summary>
        /// 
        /// </summary>
        FiFi,
        /// <summary>
        /// 
        /// </summary>
        FilPh,
        /// <summary>
        /// 
        /// </summary>
        FrCa,
        /// <summary>
        /// 
        /// </summary>
        FrFr,
        /// <summary>
        /// 
        /// </summary>
        GlEs,
        /// <summary>
        /// 
        /// </summary>
        HeIl,
        /// <summary>
        /// 
        /// </summary>
        HiIn,
        /// <summary>
        /// 
        /// </summary>
        HrHr,
        /// <summary>
        /// 
        /// </summary>
        HuHu,
        /// <summary>
        /// 
        /// </summary>
        HyAm,
        /// <summary>
        /// 
        /// </summary>
        IdId,
        /// <summary>
        /// 
        /// </summary>
        IsIs,
        /// <summary>
        /// 
        /// </summary>
        ItIt,
        /// <summary>
        /// 
        /// </summary>
        JaJp,
        /// <summary>
        /// 
        /// </summary>
        KkKz,
        /// <summary>
        /// 
        /// </summary>
        KnIn,
        /// <summary>
        /// 
        /// </summary>
        KoKr,
        /// <summary>
        /// 
        /// </summary>
        LtLt,
        /// <summary>
        /// 
        /// </summary>
        LvLv,
        /// <summary>
        /// 
        /// </summary>
        MkMk,
        /// <summary>
        /// 
        /// </summary>
        MrIn,
        /// <summary>
        /// 
        /// </summary>
        MsMy,
        /// <summary>
        /// 
        /// </summary>
        NeNp,
        /// <summary>
        /// 
        /// </summary>
        NlBe,
        /// <summary>
        /// 
        /// </summary>
        NlNl,
        /// <summary>
        /// 
        /// </summary>
        NoNo,
        /// <summary>
        /// 
        /// </summary>
        PlPl,
        /// <summary>
        /// 
        /// </summary>
        PtBr,
        /// <summary>
        /// 
        /// </summary>
        PtPt,
        /// <summary>
        /// 
        /// </summary>
        RoRo,
        /// <summary>
        /// 
        /// </summary>
        RuRu,
        /// <summary>
        /// 
        /// </summary>
        SkSk,
        /// <summary>
        /// 
        /// </summary>
        SlSi,
        /// <summary>
        /// 
        /// </summary>
        SrRs,
        /// <summary>
        /// 
        /// </summary>
        SvSe,
        /// <summary>
        /// 
        /// </summary>
        SwKe,
        /// <summary>
        /// 
        /// </summary>
        TaIn,
        /// <summary>
        /// 
        /// </summary>
        ThTh,
        /// <summary>
        /// 
        /// </summary>
        TrTr,
        /// <summary>
        /// 
        /// </summary>
        UkUa,
        /// <summary>
        /// 
        /// </summary>
        UrIn,
        /// <summary>
        /// 
        /// </summary>
        ViVn,
        /// <summary>
        /// 
        /// </summary>
        YueCn,
        /// <summary>
        /// 
        /// </summary>
        ZhCn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Language3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Language3 value)
        {
            return value switch
            {
                Language3.AfZa => "af-ZA",
                Language3.ArSa => "ar-SA",
                Language3.AzAz => "az-AZ",
                Language3.BgBg => "bg-BG",
                Language3.BsBa => "bs-BA",
                Language3.CaEs => "ca-ES",
                Language3.CsCz => "cs-CZ",
                Language3.CyGb => "cy-GB",
                Language3.DaDk => "da-DK",
                Language3.DeDe => "de-DE",
                Language3.ElGr => "el-GR",
                Language3.EnAu => "en-AU",
                Language3.EnGb => "en-GB",
                Language3.EnIn => "en-IN",
                Language3.EnNz => "en-NZ",
                Language3.EnUs => "en-US",
                Language3.Es419 => "es-419",
                Language3.EsEs => "es-ES",
                Language3.FaIr => "fa-IR",
                Language3.FiFi => "fi-FI",
                Language3.FilPh => "fil-PH",
                Language3.FrCa => "fr-CA",
                Language3.FrFr => "fr-FR",
                Language3.GlEs => "gl-ES",
                Language3.HeIl => "he-IL",
                Language3.HiIn => "hi-IN",
                Language3.HrHr => "hr-HR",
                Language3.HuHu => "hu-HU",
                Language3.HyAm => "hy-AM",
                Language3.IdId => "id-ID",
                Language3.IsIs => "is-IS",
                Language3.ItIt => "it-IT",
                Language3.JaJp => "ja-JP",
                Language3.KkKz => "kk-KZ",
                Language3.KnIn => "kn-IN",
                Language3.KoKr => "ko-KR",
                Language3.LtLt => "lt-LT",
                Language3.LvLv => "lv-LV",
                Language3.MkMk => "mk-MK",
                Language3.MrIn => "mr-IN",
                Language3.MsMy => "ms-MY",
                Language3.NeNp => "ne-NP",
                Language3.NlBe => "nl-BE",
                Language3.NlNl => "nl-NL",
                Language3.NoNo => "no-NO",
                Language3.PlPl => "pl-PL",
                Language3.PtBr => "pt-BR",
                Language3.PtPt => "pt-PT",
                Language3.RoRo => "ro-RO",
                Language3.RuRu => "ru-RU",
                Language3.SkSk => "sk-SK",
                Language3.SlSi => "sl-SI",
                Language3.SrRs => "sr-RS",
                Language3.SvSe => "sv-SE",
                Language3.SwKe => "sw-KE",
                Language3.TaIn => "ta-IN",
                Language3.ThTh => "th-TH",
                Language3.TrTr => "tr-TR",
                Language3.UkUa => "uk-UA",
                Language3.UrIn => "ur-IN",
                Language3.ViVn => "vi-VN",
                Language3.YueCn => "yue-CN",
                Language3.ZhCn => "zh-CN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Language3? ToEnum(string value)
        {
            return value switch
            {
                "af-ZA" => Language3.AfZa,
                "ar-SA" => Language3.ArSa,
                "az-AZ" => Language3.AzAz,
                "bg-BG" => Language3.BgBg,
                "bs-BA" => Language3.BsBa,
                "ca-ES" => Language3.CaEs,
                "cs-CZ" => Language3.CsCz,
                "cy-GB" => Language3.CyGb,
                "da-DK" => Language3.DaDk,
                "de-DE" => Language3.DeDe,
                "el-GR" => Language3.ElGr,
                "en-AU" => Language3.EnAu,
                "en-GB" => Language3.EnGb,
                "en-IN" => Language3.EnIn,
                "en-NZ" => Language3.EnNz,
                "en-US" => Language3.EnUs,
                "es-419" => Language3.Es419,
                "es-ES" => Language3.EsEs,
                "fa-IR" => Language3.FaIr,
                "fi-FI" => Language3.FiFi,
                "fil-PH" => Language3.FilPh,
                "fr-CA" => Language3.FrCa,
                "fr-FR" => Language3.FrFr,
                "gl-ES" => Language3.GlEs,
                "he-IL" => Language3.HeIl,
                "hi-IN" => Language3.HiIn,
                "hr-HR" => Language3.HrHr,
                "hu-HU" => Language3.HuHu,
                "hy-AM" => Language3.HyAm,
                "id-ID" => Language3.IdId,
                "is-IS" => Language3.IsIs,
                "it-IT" => Language3.ItIt,
                "ja-JP" => Language3.JaJp,
                "kk-KZ" => Language3.KkKz,
                "kn-IN" => Language3.KnIn,
                "ko-KR" => Language3.KoKr,
                "lt-LT" => Language3.LtLt,
                "lv-LV" => Language3.LvLv,
                "mk-MK" => Language3.MkMk,
                "mr-IN" => Language3.MrIn,
                "ms-MY" => Language3.MsMy,
                "ne-NP" => Language3.NeNp,
                "nl-BE" => Language3.NlBe,
                "nl-NL" => Language3.NlNl,
                "no-NO" => Language3.NoNo,
                "pl-PL" => Language3.PlPl,
                "pt-BR" => Language3.PtBr,
                "pt-PT" => Language3.PtPt,
                "ro-RO" => Language3.RoRo,
                "ru-RU" => Language3.RuRu,
                "sk-SK" => Language3.SkSk,
                "sl-SI" => Language3.SlSi,
                "sr-RS" => Language3.SrRs,
                "sv-SE" => Language3.SvSe,
                "sw-KE" => Language3.SwKe,
                "ta-IN" => Language3.TaIn,
                "th-TH" => Language3.ThTh,
                "tr-TR" => Language3.TrTr,
                "uk-UA" => Language3.UkUa,
                "ur-IN" => Language3.UrIn,
                "vi-VN" => Language3.ViVn,
                "yue-CN" => Language3.YueCn,
                "zh-CN" => Language3.ZhCn,
                _ => null,
            };
        }
    }
}