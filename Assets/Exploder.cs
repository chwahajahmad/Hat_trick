using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    public Sprite[] explosionSprites;
    public SpriteRenderer explosionSite;
    public int FramePerSprite;
    public bool startExplosion;
    private int FrameCounter;
    private int spriteCount;
    private int spriteIndex;
    void Start()
    {
        FrameCounter = 0;
        spriteCount = explosionSprites.Length;
        spriteIndex = -1;
        startExplosion = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(!startExplosion)
        {
            return;
        }
        FrameCounter++;
        if(FrameCounter>=FramePerSprite)
        {
            FrameCounter=0;
            spriteIndex++;
            if(spriteIndex>=spriteCount)
            {
                spriteIndex = 0;
            }
            explosionSite.sprite = explosionSprites[spriteIndex];
        }
    }
}
