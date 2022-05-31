using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] GameObject boom;
    public AudioSource orbDestroySound;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void ReactToHit()
    {
        StartCoroutine(Die());
    }

    private IEnumerator Die()
    {
        // play orb death sound.
        orbDestroySound.Play();
        boom = Instantiate(boom) as GameObject;
        
        yield return new WaitForSeconds(1.0f);
        // after short wait and sound, use the explosion fx.        
        boom.transform.position = transform.position;

        // a script can destroy itself (just as it could a separate object)
        Destroy(this.gameObject);
        gameManager.obj0done = true;
    }
}
