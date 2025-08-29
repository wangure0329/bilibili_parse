using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class bilibili_parse : UdonSharpBehaviour {
    public InputField Input;
    public InputField Output;

    public void ConvertUrl() {
        if (Input.text != string.Empty) Output.text = "https://jx.91vrchat.com/bl/?url=" + Input.text;
        Debug.Log(Input.text);
    }
    
    public void ClearUrls() {
        Input.text = string.Empty;
        Output.text = string.Empty;
    }
}
