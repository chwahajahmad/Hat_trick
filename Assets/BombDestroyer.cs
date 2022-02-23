using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDestroyer : MonoBehaviour
{
    public bool destructionScheduled = false;
    public int destructionCounter = 0;
    public double destructionLagInFrames = 0;
    void Update()
    {
        if(destructionScheduled)
        {
            destructionCounter++;
            if(destructionCounter>=destructionLagInFrames)
            {
                Destroy(this.gameObject);
                GameObject.Find("Player").GetComponent<PlayerRecord>().Lives--;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.gameObject.name == "Player")
        {
            Debug.Log("Hit Player");
            this.destructionScheduled = true;
            collisionInfo.otherCollider.gameObject.GetComponent<Exploder>().startExplosion = true;   
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
