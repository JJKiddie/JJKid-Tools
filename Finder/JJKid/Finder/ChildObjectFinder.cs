using UnityEngine;


namespace JJKid.Finder
{
    public class ChildObjectFinder
    {
        public static Transform FindChildByName(GameObject rootGO, string targetName)
        {
            Transform[] trans = rootGO.GetComponentsInChildren<Transform>();

            for(int i = 0; i < trans.Length; i++)
            {
                if(trans[i].name == targetName)
                    return trans[i];
            }

            return null;
        }
    }
}
