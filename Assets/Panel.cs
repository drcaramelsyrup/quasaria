using UnityEngine;
using System.Collections;

public class Panel : MonoBehaviour {
	
	public Conversation currentConvo; 
	UnityEngine.UI.Text panelText;
	
	// Use this for initialization
	void Start () {
		panelText = GetComponentInChildren<UnityEngine.UI.Text>();
	}
	
	// Update is called once per frame
	void Update () {
		panelText.text = currentConvo.startNode.dialogueText;
	}
}

