using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace EliteJournalReader
{
    internal class JournalPath
    {

        private static string _journalPath = null;

        public static string GetJournalPath()
        {
            if (_journalPath == null)
            {

                int result = UnsafeNativeMethods.SHGetKnownFolderPath(new Guid("4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4"), 0, new IntPtr(0), out IntPtr pathPtr);
                if (result != 0)
                {
                    throw new InvalidOperationException("Elite Dangerous Journal Path Not Found");
                }

                var path = Marshal.PtrToStringUni(pathPtr) + @"\Frontier Developments\Elite Dangerous";
                if (!Directory.Exists(path))
                {
                    throw new InvalidOperationException("Elite Dangerous Journal Path Does Not Exist: " + path);
                }

                _journalPath = path;

            }
            return _journalPath;
        }

        private class UnsafeNativeMethods
        {
            [DllImport("Shell32.dll")]
            public static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, out IntPtr ppszPath);
        }

    }
}
