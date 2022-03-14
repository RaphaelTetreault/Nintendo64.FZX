using System;
using System.IO;
using System.Text.RegularExpressions;
using Manifold.IO;
using Unity.Mathematics;

namespace Nintendo64.FZX
{
    [Serializable]
    public class ControlPoint
    {
        public float x;
        public float y;
        public float z;
        public float widthL;
        public float widthR;
        public ushort banking; // fixedpoint?
        public TrackType trackType;
       
        public float3 Position => new float3(x, y, z);
        public float FullWidth => widthL + widthR;

    }

}
