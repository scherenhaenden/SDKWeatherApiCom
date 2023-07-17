namespace SDKWeatherApiCom.Services.Models.Shared;

public class LanguageCode
{
    private readonly string value;

    private LanguageCode(string value)
    {
        this.value = value;
    }

    public override string ToString()
    {
        return value;
    }

    public static readonly LanguageCode Arabic = new LanguageCode("ar");
    public static readonly LanguageCode Bengali = new LanguageCode("bn");
    public static readonly LanguageCode Bulgarian = new LanguageCode("bg");
    public static readonly LanguageCode ChineseSimplified = new LanguageCode("zh");
    public static readonly LanguageCode ChineseTraditional = new LanguageCode("zh_tw");
    public static readonly LanguageCode Czech = new LanguageCode("cs");
    public static readonly LanguageCode Danish = new LanguageCode("da");
    public static readonly LanguageCode Dutch = new LanguageCode("nl");
    public static readonly LanguageCode Finnish = new LanguageCode("fi");
    public static readonly LanguageCode French = new LanguageCode("fr");
    public static readonly LanguageCode German = new LanguageCode("de");
    public static readonly LanguageCode Greek = new LanguageCode("el");
    public static readonly LanguageCode Hindi = new LanguageCode("hi");
    public static readonly LanguageCode Hungarian = new LanguageCode("hu");
    public static readonly LanguageCode Italian = new LanguageCode("it");
    public static readonly LanguageCode Japanese = new LanguageCode("ja");
    public static readonly LanguageCode Javanese = new LanguageCode("jv");
    public static readonly LanguageCode Korean = new LanguageCode("ko");
    public static readonly LanguageCode Mandarin = new LanguageCode("zh_cmn");
    public static readonly LanguageCode Marathi = new LanguageCode("mr");
    public static readonly LanguageCode Polish = new LanguageCode("pl");
    public static readonly LanguageCode Portuguese = new LanguageCode("pt");
    public static readonly LanguageCode Punjabi = new LanguageCode("pa");
    public static readonly LanguageCode Romanian = new LanguageCode("ro");
    public static readonly LanguageCode Russian = new LanguageCode("ru");
    public static readonly LanguageCode Serbian = new LanguageCode("sr");
    public static readonly LanguageCode Sinhalese = new LanguageCode("si");
    public static readonly LanguageCode Slovak = new LanguageCode("sk");
    public static readonly LanguageCode Spanish = new LanguageCode("es");
    public static readonly LanguageCode Swedish = new LanguageCode("sv");
    public static readonly LanguageCode Tamil = new LanguageCode("ta");
    public static readonly LanguageCode Telugu = new LanguageCode("te");
    public static readonly LanguageCode Turkish = new LanguageCode("tr");
    public static readonly LanguageCode Ukrainian = new LanguageCode("uk");
    public static readonly LanguageCode Urdu = new LanguageCode("ur");
    public static readonly LanguageCode Vietnamese = new LanguageCode("vi");
    public static readonly LanguageCode WuShanghainese = new LanguageCode("zh_wuu");
    public static readonly LanguageCode Xiang = new LanguageCode("zh_hsn");
    public static readonly LanguageCode YueCantonese = new LanguageCode("zh_yue");
    public static readonly LanguageCode Zulu = new LanguageCode("zu");
}