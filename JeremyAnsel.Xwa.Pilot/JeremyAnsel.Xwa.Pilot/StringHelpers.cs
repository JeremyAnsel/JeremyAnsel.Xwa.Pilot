using System.Text;

namespace JeremyAnsel.Xwa.Pilot
{
    internal static class StringHelpers
    {
        public static string Limit(string value, int count)
        {
            if (value is null)
            {
                return null;
            }

            byte[] bytes = Encoding.ASCII.GetBytes(value);
            return Encoding.ASCII.GetString(bytes, 0, Math.Min(bytes.Length, count));
        }

        public static string Read(BinaryReader file, int limit)
        {
            byte[] bytes = file.ReadBytes(limit);
            string value = Encoding.ASCII.GetString(bytes, 0, limit) + "\0";
            return value.Substring(0, value.IndexOf('\0'));
        }

        public static byte[] GetBytes(string value, int limit)
        {
            byte[] bytes = new byte[limit];

            if (!string.IsNullOrEmpty(value))
            {
                Encoding.ASCII.GetBytes(value).CopyTo(bytes, 0);
            }

            return bytes;
        }
    }
}
