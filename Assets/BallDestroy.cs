using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{

    public GameObject Ball;
    public Collider2D BallCol;
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        ContactPoint2D[] contactsAt = new ContactPoint2D[collisionInfo.contactCount];
        collisionInfo.GetContacts(contactsAt);

        foreach (ContactPoint2D cont in contactsAt)
        {
            if(cont.collider.GetType() == typeof(UnityEngine.EdgeCollider2D))
            {
                Destroy(this.Ball);
                GameObject.Find("Player").GetComponent<PlayerRecord>().Score++;
            }
            else if(cont.collider.GetType() != typeof(UnityEngine.CapsuleCollider2D))
            {
                Destroy(this.Ball);
                GameObject.Find("Player").GetComponent<PlayerRecord>().Lives--;
            
            }
        }
        
            
    }
}
       