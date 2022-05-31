using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    [SerializeField] GameObject boom;
    public AudioSource orbDestroySound;
    

    public void ReactToHit()
    {
        WanderingAI behavior = GetComponent<WanderingAI>();
        
        //check if this character has a WanderingAI script, it might not
        if (behavior != null)
        {
            behavior.SetAlive(false);
        }
        StartCoroutine(Die());
    }

    private IEnumerator Die()
    {
        // play orb death sound.
        orbDestroySound.Play();
        boom = Instantiate(boom) as GameObject;
        boom.transform.position = new Vector3(-5.321f, 2.367f, 21.22887f);
        yield return new WaitForSeconds(1.5f);

        // a script can destroy itself (just as it could a separate object)
        Destroy(this.gameObject);        
    }
}
