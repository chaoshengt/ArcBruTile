﻿using BruTile;

namespace BrutileArcGIS.lib
{
    public class Tile<T>
    {
        public TileInfo Info { get; set; }
        public T Image { get; set; }
        public long StartAnimation { get; set; }
        public byte[] Data { get; set; }
    }
}
