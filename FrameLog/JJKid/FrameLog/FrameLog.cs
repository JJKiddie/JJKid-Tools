using System.Diagnostics;
using System.Runtime.CompilerServices;


namespace JJKid.Log
{
    public class FrameLog
    {
        public static void Log(string msg, int showCallerLevel = 0, [CallerFilePath] string callerFilePath = "", 
                [CallerMemberName] string callerMemberName = "", [CallerLineNumber] int callerLineNum = 0)
        {
#if UNITY_EDITOR
            FrameLog.ShowCaller(showCallerLevel);

            string fileName = callerFilePath;

            fileName = fileName.Substring(fileName.LastIndexOf('\\') + 1);
            fileName = fileName.Replace(".cs", "");

            UnityEngine.Debug.Log("F " + UnityEngine.Time.frameCount.ToString()
                                  + " [" + fileName + "# " + callerMemberName
                                  + ": " + callerLineNum.ToString() + "] " + msg);
#else
            UnityEngine.Debug.Log("F " + FrameInfo.FrameNo.ToString()
                                  + "[#] " + msg);
#endif
        }

        public static void LogOrgVer(string msg, int showCallerLevel = 0)
        {
#if UNITY_EDITOR
            FrameLog.ShowCaller(showCallerLevel);

            StackFrame frame = new StackFrame(1, true);
            string fileName = frame.GetFileName();

            fileName = fileName.Substring(fileName.LastIndexOf('\\') + 1);
            fileName = fileName.Replace(".cs", "");
            UnityEngine.Debug.Log("F " + UnityEngine.Time.frameCount.ToString()
                                  + " [" + fileName + "# " + frame.GetMethod().Name
                                  + ": " + frame.GetFileLineNumber() + "] " + msg);
#else
            UnityEngine.Debug.Log("F " + FrameInfo.FrameNo.ToString()
                                  + "[#] " + msg);
#endif
        }

        private static void ShowCaller(int trackLevel)
        {
            if(trackLevel <= 0)
                return;

            string output = "";
            StackFrame[] frames = new StackFrame[trackLevel];

            for(int i = 0; i < trackLevel; i++)
            {
                frames[i] = new StackFrame(2 + i, false);

                if(i > 0)
                    output = frames[i].GetMethod().Name + " > " + output;
                else
                    output = frames[i].GetMethod().Name;
            }

            UnityEngine.Debug.Log("[CALLER] " + output);
        }
    }
}
