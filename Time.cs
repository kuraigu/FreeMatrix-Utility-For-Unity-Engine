using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FreeMatrix
{
    namespace Utility
    {
        public class Time
        {
            private float _max;
            private float _elapsed;
            private float _scale;
            private float _remaining;

            private List<float> _recorded;

            private bool _isActive;
            private bool _isDone;

            private TYPE _type;

            /// <summary>
            /// Initializes the timer (constructor), then assign necessary values depending on the timer type
            /// </summary>
            /// <param name="type">The type of timer to be run Note: Use TYPE enum to assign a type</param>
            /// <param name="max">The maximum elapsed time to reset the timer, ignored if timer type is STOPWATCH</param>
            /// <param name="scale">Determines how fast the timer is</param>
            public Time(TYPE type = TYPE.STOPWATCH, float max = 60, float scale = 1)
            {
                this._type = type;
                this._max = max;
                this._scale = scale;

                _recorded = new List<float>();

                if (type == TYPE.COUNTUP)
                {
                    _elapsed = 0;
                    _remaining = _max;
                }

                else if (type == TYPE.COUNTDOWN)
                {
                    _elapsed = _max;
                    _remaining = _max;
                }

                else
                {
                    _remaining = 0;
                }

                _isActive = true;
            }

            /// <summary>
            /// Runs the timer
            /// </summary>
            /// <returns>Returns true if timer is done</returns>
            public bool Update()
            {

                if (_isActive)
                {
                    _isDone = false;

                    if (_type == TYPE.COUNTUP && _type == TYPE.STOPWATCH)
                    {
                        _elapsed += _scale * UnityEngine.Time.deltaTime;
                        _remaining -= _elapsed;

                        if (type == TYPE.COUNTUP)
                        {
                            if (_elapsed >= _max)
                            {
                                _isDone = true;
                                Reset();
                                return true;
                            }
                        }
                    }

                    if (_type == TYPE.COUNTDOWN)
                    {
                        _elapsed -= _scale * UnityEngine.Time.deltaTime;
                        _remaining = _elapsed;

                        if (_elapsed <= 0)
                        {
                            _isDone = true;
                            Reset();
                            return true;
                        }
                    }
                }

                return false;
            }

            public void Reset()
            {
                switch (_type)
                {
                    default:
                        break;

                    case TYPE.COUNTUP:
                        _elapsed = 0;
                        break;

                    case TYPE.COUNTDOWN:
                        _elapsed = _max;
                        break;
                }
            }

            /// <summary>
            /// Pauses the timer
            /// </summary>
            public void Pause()
            {
                _isActive = false;
            }

            /// <summary>
            /// Resumes the timer
            /// </summary>
            public void Resume()
            {
                _isActive = true;
            }

            /// <summary>
            /// Records a time
            /// </summary>
            public void Record()
            {
                _recorded.Add(_elapsed);
            }
            public enum TYPE
            {
                COUNTUP,
                COUNTDOWN,
                STOPWATCH
            }

            public float max { get { return _max; } set { _max = value; } }
            public float elapsed { get { return _elapsed; } set { _elapsed = value; } }
            public float scale { get { return _scale; } set { _scale = value; } }
            public float remaining { get { return _remaining; } }

            public List<float> recorded { get { return _recorded; } }

            public bool isActive { get { return _isActive; } }
            public bool isDone { get { return _isDone; } }

            TYPE type { get; set; }
        }
    }
}
