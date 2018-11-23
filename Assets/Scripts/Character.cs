using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public MessageBox messageBox;
    public string message;

    public void StartConversation()
    {
        messageBox.Show(message);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       
		
	}

    
}
