using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FreeMatrix
{
    namespace Utility
    {
        public class Tween2D
        {
            /// <summary>
            /// Scales up a target value to a specified rate per second
            /// Note: For the target, only use the original scale 
            /// </summary>
            /// <param name="target">The original value</param>
            /// <param name="rate">The rate at which the scale will increase</param>
            /// <returns>Scale in (Vector 2)</returns>
            public static Vector2 ScaleUp(Vector2 target, float rate)
            {
                return new Vector2(target.x - rate, target.y + rate) * UnityEngine.Time.deltaTime;
            }

            /// <summary>
            /// Scales up a target value to a specified rate per second
            /// Note: For the target, only use the original scale 
            /// </summary>
            /// <param name="target">The original value</param>
            /// <param name="rate">The rate at which the scale will increase</param>
            /// <returns>Scale in (float)</returns>
            public static float ScaleUp(float target, float rate)
            {
                return target + rate * UnityEngine.Time.deltaTime;
            }

            /// <summary>
            /// Scales down a target value to a specified rate per second
            /// Note: For the target, only use the original scale 
            /// </summary>
            /// <param name="target">The original value</param>
            /// <param name="rate">The rate at which the scale will increase</param>
            /// <returns>Scale in (Vector 2)</returns>
            public static Vector2 ScaleDown(Vector2 target, float rate)
            {
                return new Vector2(target.x - rate * UnityEngine.Time.deltaTime, target.y - rate * UnityEngine.Time.deltaTime);
            }

            /// <summary>
            /// Scales down a target value to a specified rate per second
            /// Note: For the target, only use the original scale 
            /// </summary>
            /// <param name="target">The original value</param>
            /// <param name="rate">The rate at which the scale will increase</param>
            /// <returns>Scale in (float)</returns>
            public static float ScaleDown(float target, float rate)
            {
                return target - rate * UnityEngine.Time.deltaTime;
            }

            /// <summary>
            /// Points a 2D game object's Vector3.right to a target position
            /// </summary>
            /// <param name="target">The position where the game object is going to point to</param>
            /// <param name="current">The current position of the game object</param>
            /// <param name="currentRotation">The current rotation of the game object</param>
            /// <returns></returns>
            public static Vector3 PointTo(Vector3 target, Vector3 current, Quaternion currentRotation)
            {
                Vector3 dir = target - current;
                Vector3 angle;
                angle.z = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

                angle.x = currentRotation.x;
                angle.y = currentRotation.y;

                return angle;
            }
        }
    }
}