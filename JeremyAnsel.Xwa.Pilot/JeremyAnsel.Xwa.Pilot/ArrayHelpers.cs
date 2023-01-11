namespace JeremyAnsel.Xwa.Pilot
{
    internal static class ArrayHelpers
    {
        public static void ReadInt(BinaryReader file, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = file.ReadInt32();
            }
        }

        public static void ReadInt2(BinaryReader file, int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = file.ReadInt32();
                }
            }
        }

        public static void ReadByte(BinaryReader file, byte[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = file.ReadByte();
            }
        }

        public static void ReadByte2(BinaryReader file, byte[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = file.ReadByte();
                }
            }
        }

        public static void ReadEnum<T>(BinaryReader file, T[] array) where T : Enum
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (T)(object)file.ReadInt32();
            }
        }

        public static void ReadEnum2<T>(BinaryReader file, T[,] array) where T : Enum
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = (T)(object)file.ReadInt32();
                }
            }
        }
        public static void WriteInt(BinaryWriter file, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                file.Write(array[i]);
            }
        }

        public static void WriteInt2(BinaryWriter file, int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    file.Write(array[i, j]);
                }
            }
        }

        public static void WriteByte(BinaryWriter file, byte[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                file.Write(array[i]);
            }
        }

        public static void WriteByte2(BinaryWriter file, byte[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    file.Write(array[i, j]);
                }
            }
        }

        public static void WriteEnum<T>(BinaryWriter file, T[] array) where T : Enum
        {
            for (int i = 0; i < array.Length; i++)
            {
                file.Write((int)(object)array[i]);
            }
        }

        public static void WriteEnum2<T>(BinaryWriter file, T[,] array) where T : Enum
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    file.Write((int)(object)array[i, j]);
                }
            }
        }
    }
}
