using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageBox : MonoBehaviour {

    public Canvas canvas;
    public Text text;

    public void Show(string message)
    {
        canvas.enabled = true;
        StartCoroutine(Flow(message));
    }

    IEnumerator Flow(string message)
    {
        for (var i = 0; i < message.Length; i++)
        {
            text.text = message.Substring(0, i + 1);
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(1f);
        canvas.enabled = false;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
