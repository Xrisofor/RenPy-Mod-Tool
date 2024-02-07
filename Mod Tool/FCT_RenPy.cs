using FastColoredTextBoxNS;
using System.Drawing;
using System.Text.RegularExpressions;

namespace ModTool
{
    public class FCT_RenPy
    {
        public static Style Purple = new TextStyle(new SolidBrush( Color.FromArgb(255, 197, 134, 192) ), null, FontStyle.Regular);
        public static Style Blue = new TextStyle(new SolidBrush( Color.FromArgb(255, 86, 156, 214) ), null, FontStyle.Regular);
        public static Style Green = new TextStyle(new SolidBrush( Color.FromArgb(255, 78, 201, 176) ), null, FontStyle.Regular);
        public static Style Orange = new TextStyle(new SolidBrush( Color.FromArgb(255, 206, 145, 112) ), null, FontStyle.Regular);
        public static Style Yellow = new TextStyle(new SolidBrush( Color.FromArgb(255, 220, 220, 159) ), null, FontStyle.Regular);

        public static void ChangedRange(TextChangedEventArgs e)
        {
            // Clear
            e.ChangedRange.ClearStyle(Green);
            e.ChangedRange.ClearStyle(Orange);
            e.ChangedRange.ClearStyle(Purple);
            e.ChangedRange.ClearStyle(Blue);
            e.ChangedRange.ClearStyle(Yellow);

            e.ChangedRange.SetStyle(Green, "#.*$", RegexOptions.Multiline);

            // Purple
            e.ChangedRange.SetStyle(Purple, "return");
            e.ChangedRange.SetStyle(Purple, "pause");
            e.ChangedRange.SetStyle(Purple, "with");
            e.ChangedRange.SetStyle(Purple, "jump");
            e.ChangedRange.SetStyle(Purple, "call");

            // Purple
            e.ChangedRange.SetStyle(Blue, "scene");
            e.ChangedRange.SetStyle(Blue, "hide");
            e.ChangedRange.SetStyle(Blue, "show");
            e.ChangedRange.SetStyle(Blue, "label");
            e.ChangedRange.SetStyle(Blue, "python");
            e.ChangedRange.SetStyle(Blue, "init");
            e.ChangedRange.SetStyle(Blue, "early");
            e.ChangedRange.SetStyle(Blue, "play");
            e.ChangedRange.SetStyle(Blue, "stop");
            e.ChangedRange.SetStyle(Blue, "fadeout");
            e.ChangedRange.SetStyle(Blue, "volume");
            e.ChangedRange.SetStyle(Blue, "loop");
            e.ChangedRange.SetStyle(Blue, "screen");
            e.ChangedRange.SetStyle(Blue, "menu");

            // Green
            e.ChangedRange.SetStyle(Green, "music");
            e.ChangedRange.SetStyle(Green, "ambiences");
            e.ChangedRange.SetStyle(Green, "sound");

            // Other
            e.ChangedRange.SetStyle(Orange, "\".*$", RegexOptions.Multiline);
        }
    }
}
