
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Specifies what language (and dialect) the agent will operate in. For instance, selecting `en-GB` optimizes speech recognition for British English and indexes knowledge bases with English. If unset, will use default value `en-US`.<br/>
    /// Example: en-US
    /// </summary>
    public enum Language
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
    public static class LanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Language value)
        {
            return value switch
            {
                Language.AfZa => "af-ZA",
                Language.ArSa => "ar-SA",
                Language.AzAz => "az-AZ",
                Language.BgBg => "bg-BG",
                Language.BsBa => "bs-BA",
                Language.CaEs => "ca-ES",
                Language.CsCz => "cs-CZ",
                Language.CyGb => "cy-GB",
                Language.DaDk => "da-DK",
                Language.DeDe => "de-DE",
                Language.ElGr => "el-GR",
                Language.EnAu => "en-AU",
                Language.EnGb => "en-GB",
                Language.EnIn => "en-IN",
                Language.EnNz => "en-NZ",
                Language.EnUs => "en-US",
                Language.Es419 => "es-419",
                Language.EsEs => "es-ES",
                Language.FaIr => "fa-IR",
                Language.FiFi => "fi-FI",
                Language.FilPh => "fil-PH",
                Language.FrCa => "fr-CA",
                Language.FrFr => "fr-FR",
                Language.GlEs => "gl-ES",
                Language.HeIl => "he-IL",
                Language.HiIn => "hi-IN",
                Language.HrHr => "hr-HR",
                Language.HuHu => "hu-HU",
                Language.HyAm => "hy-AM",
                Language.IdId => "id-ID",
                Language.IsIs => "is-IS",
                Language.ItIt => "it-IT",
                Language.JaJp => "ja-JP",
                Language.KkKz => "kk-KZ",
                Language.KnIn => "kn-IN",
                Language.KoKr => "ko-KR",
                Language.LtLt => "lt-LT",
                Language.LvLv => "lv-LV",
                Language.MkMk => "mk-MK",
                Language.MrIn => "mr-IN",
                Language.MsMy => "ms-MY",
                Language.NeNp => "ne-NP",
                Language.NlBe => "nl-BE",
                Language.NlNl => "nl-NL",
                Language.NoNo => "no-NO",
                Language.PlPl => "pl-PL",
                Language.PtBr => "pt-BR",
                Language.PtPt => "pt-PT",
                Language.RoRo => "ro-RO",
                Language.RuRu => "ru-RU",
                Language.SkSk => "sk-SK",
                Language.SlSi => "sl-SI",
                Language.SrRs => "sr-RS",
                Language.SvSe => "sv-SE",
                Language.SwKe => "sw-KE",
                Language.TaIn => "ta-IN",
                Language.ThTh => "th-TH",
                Language.TrTr => "tr-TR",
                Language.UkUa => "uk-UA",
                Language.UrIn => "ur-IN",
                Language.ViVn => "vi-VN",
                Language.YueCn => "yue-CN",
                Language.ZhCn => "zh-CN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Language? ToEnum(string value)
        {
            return value switch
            {
                "af-ZA" => Language.AfZa,
                "ar-SA" => Language.ArSa,
                "az-AZ" => Language.AzAz,
                "bg-BG" => Language.BgBg,
                "bs-BA" => Language.BsBa,
                "ca-ES" => Language.CaEs,
                "cs-CZ" => Language.CsCz,
                "cy-GB" => Language.CyGb,
                "da-DK" => Language.DaDk,
                "de-DE" => Language.DeDe,
                "el-GR" => Language.ElGr,
                "en-AU" => Language.EnAu,
                "en-GB" => Language.EnGb,
                "en-IN" => Language.EnIn,
                "en-NZ" => Language.EnNz,
                "en-US" => Language.EnUs,
                "es-419" => Language.Es419,
                "es-ES" => Language.EsEs,
                "fa-IR" => Language.FaIr,
                "fi-FI" => Language.FiFi,
                "fil-PH" => Language.FilPh,
                "fr-CA" => Language.FrCa,
                "fr-FR" => Language.FrFr,
                "gl-ES" => Language.GlEs,
                "he-IL" => Language.HeIl,
                "hi-IN" => Language.HiIn,
                "hr-HR" => Language.HrHr,
                "hu-HU" => Language.HuHu,
                "hy-AM" => Language.HyAm,
                "id-ID" => Language.IdId,
                "is-IS" => Language.IsIs,
                "it-IT" => Language.ItIt,
                "ja-JP" => Language.JaJp,
                "kk-KZ" => Language.KkKz,
                "kn-IN" => Language.KnIn,
                "ko-KR" => Language.KoKr,
                "lt-LT" => Language.LtLt,
                "lv-LV" => Language.LvLv,
                "mk-MK" => Language.MkMk,
                "mr-IN" => Language.MrIn,
                "ms-MY" => Language.MsMy,
                "ne-NP" => Language.NeNp,
                "nl-BE" => Language.NlBe,
                "nl-NL" => Language.NlNl,
                "no-NO" => Language.NoNo,
                "pl-PL" => Language.PlPl,
                "pt-BR" => Language.PtBr,
                "pt-PT" => Language.PtPt,
                "ro-RO" => Language.RoRo,
                "ru-RU" => Language.RuRu,
                "sk-SK" => Language.SkSk,
                "sl-SI" => Language.SlSi,
                "sr-RS" => Language.SrRs,
                "sv-SE" => Language.SvSe,
                "sw-KE" => Language.SwKe,
                "ta-IN" => Language.TaIn,
                "th-TH" => Language.ThTh,
                "tr-TR" => Language.TrTr,
                "uk-UA" => Language.UkUa,
                "ur-IN" => Language.UrIn,
                "vi-VN" => Language.ViVn,
                "yue-CN" => Language.YueCn,
                "zh-CN" => Language.ZhCn,
                _ => null,
            };
        }
    }
}