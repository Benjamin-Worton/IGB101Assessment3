using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardAttackScript : MonoBehaviour
{
    public Animator anim;
    public ParticleSystem FireAttack;
    public ParticleSystem RedPortal1;
    public ParticleSystem RedPortal2;
    public ParticleSystem RedMeteor;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireSpell());
    }


    IEnumerator FireSpell()
    {
        anim.SetBool("Attack1", true);
        yield return new WaitForSeconds(1);
        FireAttack.Play();
        yield return new WaitForSeconds(1);
        anim.SetBool("Attack1", false);
        yield return new WaitForSeconds(1);
        StartCoroutine(RedPortals());
    }
    IEnumerator RedPortals()
    {
        anim.SetBool("Portal", true);
        yield return new WaitForSeconds(1);
        RedPortal1.Play();
        RedPortal2.Play();
        yield return new WaitForSeconds(1);
        anim.SetBool("Portal", false);
        yield return new WaitForSeconds(1);
        StartCoroutine(RedMeteorSpell());
    }

    IEnumerator RedMeteorSpell()
    {
        anim.SetBool("Attack1", true);
        yield return new WaitForSeconds(1);
        RedMeteor.Play();
        yield return new WaitForSeconds(1);
        anim.SetBool("Attack1", false);
        yield return new WaitForSeconds(1);
        StartCoroutine(FireSpell());
    }
}
