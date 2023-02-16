using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLinks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenGithubUser() {
        Application.OpenURL("https://github.com/poderman");
    }
    public void OpenYoutubeChannel() {
        Application.OpenURL("https://www.youtube.com/channel/UCNnmsqM9y-uihyfz3vp57SQ");
    }
}
