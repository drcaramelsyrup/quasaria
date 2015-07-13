using UnityEngine;
using System.Collections;

public class Conversation : MonoBehaviour {
	public ConversationNode startNode;

	// Initialization
	void Start()
	{
		startNode = GetComponentInChildren<ConversationNode> ();
	}
}
