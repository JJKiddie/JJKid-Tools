namespace JJKid.Math
{
    public class JJMath
    {
        //==========================================================================
        //  Tween
        //==========================================================================
        public static float Linear(float begin, float end, float time, float duration)
        {
            float change = end - begin;

            return change * (time / duration) + begin;
        }

        public static float EaseInQuad(float begin, float end, float time, float duration)
        {
            float change = end - begin;

            time = time / duration;

            return change * time * time + begin;
        }

        public static float EaseOutQuad(float begin, float end, float time, float duration)
        {
            float change = end - begin;

            time = 1 - time / duration;

            return change * (1 - time * time) + begin;
        }

        public static float EaseInCubic(float begin, float end, float time, float duration)
        {
            float change = end - begin;

            time = time / duration;

            return change * time * time * time + begin;
        }

        public static float EaseOutCubic(float begin, float end, float time, float duration)
        {
            float change = end - begin;

            time = 1 - time / duration;

            return change * (1 - time * time * time) + begin;
        }

        public static float EaseInQuart(float begin, float end, float time, float duration)
        {
            float change = end - begin;

            time = time / duration;

            return change * time * time * time * time + begin;
        }

        public static float EaseOutQuart(float begin, float end, float time, float duration)
        {
            float change = end - begin;

            time = 1 - time / duration;

            return change * (1 - time * time * time * time) + begin;
        }


        //==========================================================================
        //  Remap
        //==========================================================================
        public static float Remap(float from, float to, float nowValue, float mapFrom, float mapTo)
        {
            float change = to - from;
            float mapChange = mapTo - mapFrom;
            float percent = (nowValue - from) / change;

            return (mapChange * percent + mapFrom);
        }


        //==========================================================================
        //  Over lerp
        //==========================================================================
        public static float OverLerp(float a, float b, float t)
        {
            float length = b - a;

            return length * t + a;
        }
    }
}
