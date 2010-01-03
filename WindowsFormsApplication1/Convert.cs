﻿using System;
namespace NFSU2CH
{
    internal class Converter
    {
        static int[] _a = new int[256] { 144, 39, 78, 119, 5, 171, 202, 98, 200, 178, 50, 140, 214, 72, 196, 49, 100, 25, 53, 225, 107, 138, 65, 71, 73, 89, 175, 170, 116, 114, 165, 13, 239, 117, 75, 54, 106, 161, 131, 233, 21, 182, 155, 23, 2, 87, 70, 137, 90, 241, 95, 41, 1, 128, 230, 7, 197, 55, 46, 36, 52, 0, 167, 42, 198, 59, 69, 12, 215, 20, 124, 205, 166, 173, 238, 60, 134, 152, 102, 250, 218, 37, 22, 216, 91, 31, 99, 162, 179, 169, 129, 206, 156, 151, 32, 188, 183, 82, 220, 194, 180, 177, 85, 228, 33, 201, 26, 195, 9, 184, 110, 123, 14, 157, 193, 189, 199, 121, 149, 68, 125, 122, 164, 111, 94, 191, 47, 38, 249, 19, 213, 88, 86, 84, 207, 242, 3, 204, 186, 210, 203, 244, 66, 27, 227, 10, 158, 163, 115, 190, 253, 153, 51, 187, 221, 255, 81, 237, 44, 108, 57, 135, 58, 77, 208, 217, 34, 243, 172, 231, 101, 147, 229, 132, 141, 251, 64, 79, 113, 92, 80, 245, 254, 232, 159, 105, 136, 130, 28, 154, 252, 83, 67, 226, 247, 223, 192, 93, 212, 148, 15, 139, 16, 127, 35, 43, 6, 145, 62, 40, 176, 185, 209, 61, 168, 120, 56, 219, 142, 143, 236, 211, 160, 126, 48, 74, 174, 45, 104, 234, 18, 224, 96, 109, 103, 181, 146, 8, 29, 4, 246, 76, 222, 150, 97, 235, 24, 240, 133, 30, 112, 248, 11, 118, 63, 17 };
        static int[] _b = new int[256] { 61, 52, 44, 136, 239, 4, 206, 55, 237, 108, 145, 252, 67, 31, 112, 200, 202, 255, 230, 129, 69, 40, 82, 43, 246, 17, 106, 143, 188, 238, 249, 85, 94, 104, 166, 204, 59, 81, 127, 1, 209, 51, 63, 205, 158, 227, 58, 126, 224, 15, 10, 152, 60, 18, 35, 57, 216, 160, 162, 65, 75, 213, 208, 254, 176, 22, 142, 192, 119, 66, 46, 23, 13, 24, 225, 34, 241, 163, 2, 177, 180, 156, 97, 191, 133, 102, 132, 45, 131, 25, 48, 84, 179, 197, 124, 50, 232, 244, 7, 86, 16, 170, 78, 234, 228, 185, 36, 20, 159, 233, 110, 123, 250, 178, 29, 148, 28, 33, 253, 3, 215, 117, 121, 111, 70, 120, 223, 203, 53, 90, 187, 38, 173, 248, 76, 161, 186, 47, 21, 201, 11, 174, 218, 219, 0, 207, 236, 171, 199, 118, 243, 93, 77, 151, 189, 42, 92, 113, 146, 184, 222, 37, 87, 147, 122, 30, 72, 62, 214, 89, 27, 5, 168, 73, 226, 26, 210, 101, 9, 88, 100, 235, 41, 96, 109, 211, 138, 153, 95, 115, 149, 125, 196, 114, 99, 107, 14, 56, 64, 116, 8, 105, 6, 140, 137, 71, 91, 134, 164, 212, 139, 221, 198, 130, 12, 68, 83, 165, 80, 217, 98, 154, 242, 195, 231, 19, 193, 144, 103, 172, 54, 169, 183, 39, 229, 245, 220, 157, 74, 32, 247, 49, 135, 167, 141, 181, 240, 194, 251, 128, 79, 175, 190, 150, 182, 155 };
        static int _enc(int b)
        {
            return _a[b];
        }
        static int _dec(int b)
        {
            return _b[b];
        }
/* *
        public static int Encode(int b)
        {
            return _enc(b);
        }
 * */
        public static byte Encode(int b)
        {
            return (byte)_enc(b);
        }
/* 
        public static int Encode(byte b)
        {
            return _enc((int)b);
        }
* */
        public static byte Encode(byte b)
        {
            return (byte)_enc((int)b);
        }
/* *
        public static int Decode(int b)
        {
            return _dec(b);
        }
 * */
        public static byte Decode(int b)
        {
            return (byte)_dec(b);
        }
/* *
        public static int Decode(byte b)
        {
            return _dec((int)b);
        }
 * */
        public static byte Decode(byte b)
        {
            return (byte)_dec((int)b);
        }
    }
}
