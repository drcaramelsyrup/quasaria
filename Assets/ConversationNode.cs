using UnityEngine;
using System.Collections;

public class ConversationNode : MonoBehaviour {

	public string dialogueText;
	public ConversationNode[] responses;
	bool emotion = false;

	// TODO: change to ToggleEmotion and set to enum argument for all emotions
	public void SetSarcasm(bool isSarcasm)
	{
		emotion = isSarcasm;
	}

	// Use this for initialization
	void Start () {
		dialogueText = "This is dialogue";
	}

	// Update is called once per frame
	void Update () {
		if (!emotion)
			dialogueText = "This is dialogue";
		else
			dialogueText = "Your vast intellect must surely comprehend the concept that this is dialogue.";
	}
}
