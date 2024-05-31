using DigitalRuby.LightningBolt;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardShieldScript : MonoBehaviour
{
    public Animator anim;
    public ParticleSystem ShieldSpell1;
    public GameObject LightningBolt1;
    public GameObject LightningBolt2;
    public ParticleSystem ShieldSpell2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shield1());
    }


    IEnumerator Shield1()
    {
        anim.SetBool("Shield", true);
        yield return new WaitForSeconds(0.5f);
        ShieldSpell1.Play();
        yield return new WaitForSeconds(1.5f);
        anim.SetBool("Shield", false);
        yield return new WaitForSeconds(1);
        StartCoroutine(LightningSpell());
    }

    IEnumerator LightningSpell()
    {
        anim.SetBool("Attack1", true);
        yield return new WaitForSeconds(1);
        for(int frames=0; frames<30;  frames++)
        {
            LightningBolt1.GetComponent<LightningBoltScript>().Trigger();
            LightningBolt2.GetComponent<LightningBoltScript>().Trigger();
            yield return new WaitForSeconds(0.033f);
        }
        anim.SetBool("Attack1", false);
        yield return new WaitForSeconds(1);
        StartCoroutine(Shield2());
    }
    IEnumerator Shield2()
    {
        anim.SetBool("Shield", true);
        yield return new WaitForSeconds(1f);
        ShieldSpell2.Play();
        yield return new WaitForSeconds(1f);
        anim.SetBool("Shield", false);
        yield return new WaitForSeconds(1);
        StartCoroutine(Shield1());
    }
}
