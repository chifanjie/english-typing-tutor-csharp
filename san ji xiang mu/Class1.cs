using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace san_ji_xiang_mu
{
    class Class1
    {
        public static string user = "demo";
    }
}


namespace san_ji_xiang_mu
{
    // Optional media is deliberately not bundled without a known redistribution license.
    internal static class DemoResources
    {
        public static string PathFor(string relativePath)
        {
            string root = System.Environment.GetEnvironmentVariable("TYPING_TUTOR_ASSETS");
            if (string.IsNullOrEmpty(root)) root = System.Windows.Forms.Application.StartupPath;
            return System.IO.Path.Combine(root, relativePath);
        }

        public static System.Drawing.Image LoadImage(string path)
        {
            return System.IO.File.Exists(path) ? System.Drawing.Image.FromFile(path) : new System.Drawing.Bitmap(1, 1);
        }

        public static string[] ImageFiles(string directory)
        {
            if (!System.IO.Directory.Exists(directory)) return new string[] { string.Empty };
            string[] files = System.IO.Directory.GetFiles(directory);
            files = System.Array.FindAll(files, delegate(string path)
            {
                string extension = System.IO.Path.GetExtension(path).ToLowerInvariant();
                return extension == ".png" || extension == ".jpg" || extension == ".jpeg" || extension == ".bmp";
            });
            System.Array.Sort(files);
            return files.Length == 0 ? new string[] { string.Empty } : files;
        }
    }
}
