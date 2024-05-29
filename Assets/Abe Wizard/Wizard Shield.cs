using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardShieldScript : MonoBehaviour
{
    public Animator anim;
    public ParticleSystem particles;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shield());
    }


    IEnumerator Shield()
    {
        anim.SetBool("Shield", true);
        yield return new WaitForSeconds(1);
        particles.Play();
        yield return new WaitForSeconds(1);
        anim.SetBool("Shield", false);
        yield return new WaitForSeconds(5);
        StartCoroutine(Shield());
    }
}
