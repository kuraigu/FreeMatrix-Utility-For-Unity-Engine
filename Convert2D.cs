using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FreeMatrix
{
    namespace Utility
    {
        public class Convert2D
        {
            /// <summary>
            /// Scales a pixel to a target reference (parent) scale 
            /// Note: Parent's scale is used as a reference
            /// </summary>
            /// <param name="reference">The scale of the reference</param>
            /// <param name="target">The target pixel</param>
            /// <returns>Converted local units in (Vector2)</returns>
            public static Vector2 PixelToLocal(Vector2 reference, Vector2 target)
            {
                return (target / reference) / 100;
            }

            /// <summary>
            /// Scales a pixel to a target reference (parent) scale  
            /// Note: Parent's scale is used as a reference
            /// </summary>
            /// <param name="reference">The scale of the reference</param>
            /// <param name="target">The pixel value that is going to be converted</param>
            /// <returns>Converted local units in (float)</returns>
            public static float PixelToLocal(float reference, float target)
            {
                return (target / reference) / 100;
            }

            /// <summary>
            /// Convert pixels to unity's world unit
            /// </summary>
            /// <param name="target">The pixel value that is going to be converted</param>
            /// <returns>Converted world units in (vector2)</returns>
            public static Vector2 PixelToWorld(Vector2 target)
            {
                return target / 100;
            }


            /// <summary>
            /// Convert pixels to unity's world unit
            /// </summary>
            /// <param name="target">The pixel value that is going to be converted</param>
            /// <returns>Converted world units in (float)</returns>
            public static float PixelToWorld(float target)
            {
                return target / 100;
            }

            /// <summary>
            /// Converts a local unit to pixels using the parent's scale
            /// Note: Parent's scale is used as a reference
            /// </summary>
            /// <param name="reference">The scale of the reference (parent)</param>
            /// <param name="target">The local value going to be converted to pixels</param>
            /// <returns>Converted pixels in (Vector2)</returns>
            public static Vector2 LocalToPixel(Vector2 reference, Vector2 target)
            {
                return (target * reference) * 100;
            }

            /// <summary>
            /// Converts a local unit to pixels using the parent's scale
            /// Note: Parent's scale is used as a reference
            /// </summary>
            /// <param name="reference">The scale of the reference (parent)</param>
            /// <param name="target">The local value to be converted to pixels</param>
            /// <returns>Converted pixels in (float)</returns>
            public static float LocalToPixel(float reference, float target)
            {
                return (target * reference) * 100;
            }


            /// <summary>
            /// Converts local value to unity's world unit
            /// Note: Parent's scale is used as a reference
            /// </summary>
            /// <param name="reference">The scale of the reference parent</param>
            /// <param name="target"></param>
            /// <returns>Converted world units in (Vector2)</returns>
            public static Vector2 LocalToWorld(Vector2 reference, Vector2 target)
            {
                Vector2 _return = LocalToPixel(reference, target);
                return PixelToWorld(_return);
            }

            /// <summary>
            /// Converts local value to unity's world unit
            /// Note: Parent's scale is used as a reference
            /// </summary>
            /// <param name="reference">The scale of the reference parent</param>
            /// <param name="target"></param>
            /// <returns>Converted world units in (float)</returns>
            public static float LocalToWorld(float reference, float target)
            {
                float _return = LocalToPixel(reference, target);
                return PixelToWorld(_return);
            }

            /// <summary>
            /// Converts Unity's world units to pixels
            /// </summary>
            /// <param name="target">Value of world units going to be converted to pixels</param>
            /// <returns>Converted pixels in (Vector2)</returns>
            public static Vector2 WorldToPixel(Vector2 target)
            {
                return target * 100;
            }

            /// <summary>
            /// Converts Unity's world units to pixels
            /// </summary>
            /// <param name="target">Value of world units going to be converted to pixels</param>
            /// <returns>Converted pixels in (float)</returns>
            public static float WorldToPixel(float target)
            {
                return target * 100;
            }

            /// <summary>
            /// Converts world units to a local unit
            /// Note: Parent's scale is used as a reference
            /// </summary>
            /// <param name="reference"></param>
            /// <param name="target"></param>
            /// <returns>Converted local units in (Vector2)</returns>
            public static Vector2 WorldToLocal(Vector2 reference, Vector2 target)
            {
                Vector2 _return = WorldToPixel(target);
                return PixelToLocal(reference, _return);
            }

            /// <summary>
            /// Converts world units to a local unit
            /// Note: Parent's scale is used as a reference
            /// </summary>
            /// <param name="reference"></param>
            /// <param name="target"></param>
            /// <returns>Converted local units in (float)</returns>
            public static float WorldToLocal(float reference, float target)
            {
                float _return = WorldToPixel(target);
                return PixelToLocal(reference, _return);
            }
        }
    }
}