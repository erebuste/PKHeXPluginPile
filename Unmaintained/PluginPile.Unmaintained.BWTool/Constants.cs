namespace PluginPile.Unmaintained.BWTool;
internal static class Constants {

  public const int TrainerData = 27;
  public const int TrainerCard = 33;
  public const int TrainerRecords = 38;
  public const int Musical = 42;
  public const int Badges = 52;

  internal static class BW {

    public static int[] BlockTable = {
      0x00000, 0x00400, 0x01400, 0x02400, 0x03400, 0x04400, 0x05400, //6
      0x06400, 0x07400, 0x08400, 0x09400, 0x0A400, 0x0B400, 0x0C400, //13
      0x0D400, 0x0E400, 0x0F400, 0x10400, 0x11400, 0x12400, 0x13400, //20
      0x14400, 0x15400, 0x16400, 0x17400, 0x18400, 0x18E00, 0x19400, //27
      0x19500, 0x19600, 0x1AA00, 0x1B200, 0x1C000, 0x1C100, 0x1C800, //34
      0x1D300, 0x1D500, 0x1D900, 0x1DA00, 0x1DC00, 0x1DD00, 0x1E200, //41
      0x1F700, 0x1FA00, 0x1FD00, 0x20100, 0x20500, 0x20600, 0x20900, //48
      0x20A00, 0x20E00, 0x21000, 0x21200, 0x21300, 0x21500, 0x21600, //55
      0x21B00, 0x21C00, 0x21D00, 0x21F00, 0x22B00, 0x22C00, 0x23500, //62
      0x23600, 0x23900, 0x23A00, 0x23B00, 0x23D00, 0x23E00, 0x23F00  //69
    };

    public static int[] BlockTableLength = {
      0x3E0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, //6
      0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, //13
      0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, //20
      0xFF0, 0xFF0, 0xFF0, 0xFF0, 0x9C0, 0X534, 0x68,  //27
      0x9C, 0x1338, 0x7C4, 0xD54, 0X2C, 0x658, 0xA94,  //34
      0x1AC, 0x3EC, 0x5C, 0x1E0, 0xA8, 0x460, 0x1400,  //41
      0x2A4, 0x2DC, 0x34C, 0x3EC, 0xF8, 0x2FC, 0x94,   //48
      0x35C, 0x1CC, 0x168, 0xEC, 0x1B0, 0x1C, 0x4D4,   //55
      0X34, 0x3C, 0x1AC, 0xB90, 0x9C, 0x850, 0x28,     //62
      0x284, 0x10, 0x5C, 0x16C, 0x40, 0xFC, 0x8C       //69
    };

    public const int CrcIndex = 69;
    public const int BackupOffset = 0x24000; // B/W

    public const int Battle = 58;
    public const int Forest = 61;
  }

  internal static class B2W2 {
    public static int[] BlockTable = {
      0x00000, 0x00400, 0x01400, 0x02400, 0x03400, 0x04400, 0x05400, //6
      0x06400, 0x07400, 0x08400, 0x09400, 0x0A400, 0x0B400, 0x0C400, //13
      0x0D400, 0x0E400, 0x0F400, 0x10400, 0x11400, 0x12400, 0x13400, //20
      0x14400, 0x15400, 0x16400, 0x17400, 0x18400, 0x18E00, 0x19400, //27
      0x19500, 0x19600, 0x1AA00, 0x1B200, 0x1C000, 0x1C100, 0x1C800, //34
      0x1D300, 0x1D500, 0x1D900, 0x1DA00, 0x1DC00, 0x1DD00, 0x1E200, //41
      0x1F700, 0x1FA00, 0x1FB00, 0x1FF00, 0x20400, 0x20500, 0x20800, //48
      0x20900, 0x20D00, 0x20F00, 0x21100, 0x21200, 0x21400, 0x21900, //55
      0x21A00, 0x21B00, 0x21D00, 0x22900, 0x22A00, 0x23300, 0x23600, //62
      0x23700, 0x23800, 0x23A00, 0x23B00, 0x23C00, 0x25300, 0x25800, //69
      0x25900, 0x25A00, 0x25E00, 0x25F00                             //73
    };

    public static int[] BlockTableLength = {
      0x3E0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, //6
      0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, //13
      0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, //20
      0xFF0, 0xFF0, 0xFF0, 0xFF0, 0x9EC, 0X534, 0xB0,  //27
      0xA8, 0x1338, 0x7C4, 0xD54, 0X94, 0x658, 0xA94,  //34
      0x1AC, 0x3EC, 0x5C, 0x1E0, 0xA8, 0x460, 0x1400,  //41
      0x2A4, 0xE0, 0x34C, 0x4E0, 0xF8, 0x2FC, 0x94,    //48
      0x35C, 0x1D4, 0x1E0, 0xF0, 0x1B4, 0x4DC, 0x34,   //55
      0X3C, 0x1AC, 0xB90, 0xAC, 0x850, 0x284, 0x10,    //62
      0xA8, 0x16C, 0x80, 0xFC, 0x16A8, 0x498, 0x60,    //69
      0xFC, 0x3E4, 0xF0, 0x94                          //73
    };

    public const int CrcIndex = 73;
    public const int BackupOffset = 0x26000; // B2/W2

    public const int Overworld = 55;
    public const int Battle = 57;
    public const int Forest = 60;
    public const int Grotto = 66;
    public const int Rival = 66;
    public const int JoinAvenue = 67;
    public const int Medals = 68;
    public const int Keys = 69;
    public const int DreamRadarKey = 72;
  }

}
