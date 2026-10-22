using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentPerception : MonoBehaviour
{
    private AgentScript agentScript;

    private void Start() {
        agentScript = FindObjectOfType<AgentScript>();
    }

    private void Update() { 
        
    }

    private void OnTriggerEnter(Collider col) {
        if (col.CompareTag("Player")) {
            agentScript.chaseMode = true;
            Debug.Log("El estado de ChaseMode es: " + agentScript.chaseMode);
        }
    }
}
