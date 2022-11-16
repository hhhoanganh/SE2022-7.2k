using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets.Scripts.Generals
{
    public static class Utils
    {
        public static IEnumerator LoadImage(string url)
        {
            using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(url))
            {
                yield return uwr.SendWebRequest();

                if (uwr.result != UnityWebRequest.Result.Success)
                {
                    Debug.Log(uwr.error);
                }
                else
                {
                    // Get downloaded asset bundle
                    var texture = DownloadHandlerTexture.GetContent(uwr);
                }
            }
        }
    }
}
