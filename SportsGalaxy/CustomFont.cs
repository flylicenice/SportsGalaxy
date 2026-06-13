using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

public static class CustomFonts
{
    private static PrivateFontCollection pfc = new PrivateFontCollection();

    // These static variables will hold your ready-to-use Font objects
    public static Font TitleFont { get; private set; }
    public static Font BodyFont { get; private set; }
    public static Font SmallFont { get; private set; }

    public static void Initialize()
    {
        // 1. Load the font files into the collection once
        string regularPath = Path.Combine(Application.StartupPath, @"Fonts\PixelifySans-Regular.ttf");
        string boldPath = Path.Combine(Application.StartupPath, @"Fonts\PixelifySans-Bold.ttf");

        if (File.Exists(regularPath)) pfc.AddFontFile(regularPath);
        if (File.Exists(boldPath)) pfc.AddFontFile(boldPath);

        if (pfc.Families.Length > 0)
        {
            FontFamily pixelify = pfc.Families[0];

            // 2. Pre-create the font sizes and styles you need
            TitleFont = new Font(pixelify, 24, FontStyle.Bold);
            BodyFont = new Font(pixelify, 12, FontStyle.Regular);
            SmallFont = new Font(pixelify, 8, FontStyle.Regular);
        }
        else
        {
            // Fallback to standard fonts if the files are missing so your app doesn't crash
            TitleFont = new Font("Arial", 24, FontStyle.Bold);
            BodyFont = new Font("Arial", 12, FontStyle.Regular);
            SmallFont = new Font("Arial", 8, FontStyle.Regular);
        }
    }
}