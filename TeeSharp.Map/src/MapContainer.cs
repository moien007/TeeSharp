﻿using System.IO;

namespace TeeSharp.Map
{
    public class MapContainer
    {
        public static MapContainer Load(FileStream stream, out string error)
        {
            var dataFile = DataFileReader.Read(stream, out error);
            if (dataFile == null)
                return null;


            return null;
        }
    }
}
