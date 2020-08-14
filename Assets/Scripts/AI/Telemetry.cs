using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Telemetry : MonoBehaviour
{
    // Start is called before the first frame update
    public string urlstring = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSfC6kpltl-Cdk_9U_uxSIPVk9tW3qG70NUJPH40VdfIRi30fQ/formResponse";
    void Start()
    {
        StartCoroutine(Post());
    }
    IEnumerator Post()
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1982025961", "1.1");
        form.AddField("entry.1079424068", "Production");
        form.AddField("entry.416404671", "Food");
        form.AddField("entry.1069903528", "Industrial");
        form.AddField("entry.1432877640", "3");
        form.AddField("entry.1997210124", "312");
        form.AddField("entry.1193337966", "22");
        form.AddField("entry.258792244", "222");
        form.AddField("entry.1553467135", "312");
        form.AddField("entry.1410261082", "mon");
        form.AddField("entry.1876660428", "22");
        form.AddField("entry.549131437", "222");
        byte[] data = form.data;
        UnityWebRequest www = UnityWebRequest.Post(urlstring, form);
        yield return www.SendWebRequest();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
