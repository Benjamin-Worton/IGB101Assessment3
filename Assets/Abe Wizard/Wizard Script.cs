using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardScript : MonoBehaviour
{
    public Animator anim;
    public ParticleSystem particles;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Attack1());
    }


    IEnumerator Attack1()
    {
        anim.SetBool("Attack1", true);
        yield return new WaitForSeconds(1);
        particles.Play();
        yield return new WaitForSeconds(1);
        anim.SetBool("Attack1", false);
        yield return new WaitForSeconds(5);
        StartCoroutine(Attack1());
    }
}
