using PdfSharp.Fonts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace MELTADO_CAFE.AdminAccess
{
    public class FontResolver : IFontResolver
    {
        private readonly Dictionary<string, string> fontFiles = new Dictionary<string, string>()
        {
            { "segoeui-regular", "MELTADO_CAFE.AdminAccess.Fonts.segoeui_regular.ttf" },
            { "segoeui-bold", "MELTADO_CAFE.AdminAccess.Fonts.segoeui_bold.ttf" }
        };



        // ✅ This loads the actual font data from embedded resources
        public byte[] GetFont(string faceName)
        {
            if (!fontFiles.TryGetValue(faceName.ToLowerInvariant(), out string resourceName))
                throw new ArgumentException($"Font '{faceName}' not found.");

            var assembly = Assembly.GetExecutingAssembly();
            using Stream stream = assembly.GetManifestResourceStream(resourceName);
            if (stream == null)
                throw new FileNotFoundException($"Embedded resource '{resourceName}' not found.");

            byte[] fontData = new byte[stream.Length];
            stream.Read(fontData, 0, fontData.Length);
            return fontData;
        }

        // ✅ This maps the font usage request to your embedded resource
        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            if (familyName.Equals("Segoe UI", StringComparison.InvariantCultureIgnoreCase))
            {
                if (isBold)
                    return new FontResolverInfo("segoeui-bold");
                else
                    return new FontResolverInfo("segoeui-regular");
            }

            return PlatformFontResolver.ResolveTypeface(familyName, isBold, isItalic);
        }
    }
}
