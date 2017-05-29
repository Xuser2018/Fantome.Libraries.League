﻿using System;
using System.IO;
using System.Globalization;
using System.Diagnostics;

namespace Fantome.League.Helpers.Structures
{
    [DebuggerDisplay("[ {X}, {Y} ]")]
    public class Vector2 : IEquatable<Vector2>
    {
        public float X;
        public float Y;

        public Vector2(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Vector2(BinaryReader br)
        {
            this.X = br.ReadSingle();
            this.Y = br.ReadSingle();
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(this.X);
            bw.Write(this.Y);
        }

        public bool Equals(Vector2 other)
        {
            return (this.X == other.X) && (this.Y == other.Y);
        }

        public static bool operator <(Vector2 x, Vector2 y)
        {
            return x.X < y.X && x.Y < y.Y;
        }

        public static bool operator >(Vector2 x, Vector2 y)
        {
            return x.X > y.X && x.Y > y.Y;
        }
    }

    [DebuggerDisplay("[ {X}, {Y}, {Z} ]")]
    public class Vector3 : IEquatable<Vector3>
    {
        public float X;
        public float Y;
        public float Z;

        public Vector3(float X, float Y, float Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public Vector3(BinaryReader br)
        {
            this.X = br.ReadSingle();
            this.Y = br.ReadSingle();
            this.Z = br.ReadSingle();
        }

        public Vector3(StreamReader sr)
        {
            string[] input = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            this.X = float.Parse(input[0], CultureInfo.InvariantCulture.NumberFormat);
            this.Y = float.Parse(input[1], CultureInfo.InvariantCulture.NumberFormat);
            this.Z = float.Parse(input[2], CultureInfo.InvariantCulture.NumberFormat);
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(this.X);
            bw.Write(this.Y);
            bw.Write(this.Z);
        }

        public void Write(StreamWriter sw)
        {
            sw.WriteLine(string.Format("{0} {1} {2}", this.X, this.Y, this.Z));
        }

        public bool Equals(Vector3 other)
        {
            return (this.X == other.X) && (this.Y == other.Y) && (this.Z == other.Z);
        }

        public static Vector3 Cross(Vector3 x, Vector3 y)
        {
            return new Vector3(
                (x.Y * y.Z) - (x.Z * y.Y),
                (x.Z * y.X) - (x.X * y.Z),
                (x.X * y.Y) - (x.Y * y.X));
        }

        public static Vector3 operator +(Vector3 x, Vector3 y)
        {
            return new Vector3(x.X + y.X, x.Y + y.Y, x.Z + y.Z);
        }

        public static Vector3 operator -(Vector3 x, Vector3 y)
        {
            return new Vector3(x.X - y.X, x.Y - y.Y, x.Z - y.Z);
        }
    }

    [DebuggerDisplay("[ {X}, {Y}, {Z}, {W} ]")]
    public class Vector4
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        public Vector4(float X, float Y, float Z, float W)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.W = W;
        }

        public Vector4(BinaryReader br)
        {
            this.X = br.ReadSingle();
            this.Y = br.ReadSingle();
            this.Z = br.ReadSingle();
            this.W = br.ReadSingle();
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(this.X);
            bw.Write(this.Y);
            bw.Write(this.Z);
            bw.Write(this.W);
        }
    }

    [DebuggerDisplay("[ {X}, {Y}, {Z} ]")]
    public class Vector3Byte
    {
        public byte X;
        public byte Y;
        public byte Z;

        public Vector3Byte(byte X, byte Y, byte Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public Vector3Byte(BinaryReader br)
        {
            this.X = br.ReadByte();
            this.Y = br.ReadByte();
            this.Z = br.ReadByte();
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(this.X);
            bw.Write(this.Y);
            bw.Write(this.Z);
        }
    }

    [DebuggerDisplay("[ {X}, {Y}, {Z}, {W} ]")]
    public class Vector4Byte
    {
        public byte X;
        public byte Y;
        public byte Z;
        public byte W;

        public Vector4Byte(byte X, byte Y, byte Z, byte W)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.W = W;
        }

        public Vector4Byte(BinaryReader br)
        {
            this.X = br.ReadByte();
            this.Y = br.ReadByte();
            this.Z = br.ReadByte();
            this.W = br.ReadByte();
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(this.X);
            bw.Write(this.Y);
            bw.Write(this.Z);
            bw.Write(this.W);
        }
    }

    [DebuggerDisplay("[ {R}, {G}, {B}, {A} ]")]
    public class ColorRGBAVector4
    {
        public float R;
        public float G;
        public float B;
        public float A;

        public ColorRGBAVector4(float R, float G, float B, float A)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.A = A;
        }

        public ColorRGBAVector4(BinaryReader br)
        {
            this.R = br.ReadSingle();
            this.G = br.ReadSingle();
            this.B = br.ReadSingle();
            this.A = br.ReadSingle();
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(this.R);
            bw.Write(this.G);
            bw.Write(this.B);
            bw.Write(this.A);
        }
    }

    [DebuggerDisplay("[ {B}, {G}, {R}, {A} ]")]
    public class ColorBGRAVector4Byte
    {
        public byte B;
        public byte G;
        public byte R;
        public byte A;

        public ColorBGRAVector4Byte(byte B, byte G, byte R, byte A)
        {
            this.B = B;
            this.G = G;
            this.R = R;
            this.A = A;
        }

        public ColorBGRAVector4Byte(BinaryReader br)
        {
            this.B = br.ReadByte();
            this.G = br.ReadByte();
            this.R = br.ReadByte();
            this.A = br.ReadByte();
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(this.B);
            bw.Write(this.G);
            bw.Write(this.R);
            bw.Write(this.A);
        }
    }

    public class R3DBoundingBox
    {
        public Vector3 Org;
        public Vector3 Size;

        public R3DBoundingBox(Vector3 Org, Vector3 Size)
        {
            this.Org = Org;
            this.Size = Size;
        }

        public R3DBoundingBox(BinaryReader br)
        {
            this.Org = new Vector3(br);
            this.Size = new Vector3(br);
        }

        public void Write(BinaryWriter bw)
        {
            this.Org.Write(bw);
            this.Size.Write(bw);
        }
    }

    public class R3DBox
    {
        public Vector3 Min { get; private set; }
        public Vector3 Max { get; private set; }

        public R3DBox(BinaryReader br)
        {
            this.Min = new Vector3(br);
            this.Max = new Vector3(br);
        }

        public R3DBox(Vector3 min, Vector3 max)
        {
            this.Min = min;
            this.Max = max;
        }

        public void Write(BinaryWriter bw)
        {
            this.Min.Write(bw);
            this.Max.Write(bw);
        }

        public Vector3 GetProportions()
        {
            return this.Max - this.Min;
        }

        public bool ContainsPoint(Vector3 point)
        {
            return ((point.X >= Min.X) && (point.X <= Max.X) && (point.Y >= Min.Y) && (point.Y <= Max.Y) && (point.Z >= Min.Z) && (point.Z <= Max.Z));
        }
    }

    [DebuggerDisplay("[ {Radius} ]")]
    public class R3DSphere
    {
        public Vector3 Position;
        public float Radius;

        public R3DSphere(Vector3 Position, float Radius)
        {
            this.Position = Position;
            this.Radius = Radius;
        }

        public R3DSphere(BinaryReader br)
        {
            this.Position = new Vector3(br);
            this.Radius = br.ReadSingle();
        }

        public void Write(BinaryWriter bw)
        {
            Position.Write(bw);
            bw.Write(Radius);
        }
    }
}
