using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGate : MonoBehaviour
{
    [SerializeField] private Animator gate = null;
    [SerializeField] private Animator gate2 = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                gate.Play("Gate 1 open", 0, 0.0f);
                gameObject.SetActive(false);

                gate2.Play("Gate 2 open", 0, 0.0f);
                gameObject.SetActive(false);
            }

            else if (closeTrigger)
            {
                gate.Play("Gate 1 close", 0, 0.0f);
                gameObject.SetActive(false);

                gate2.Play("Gate 2 close", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
