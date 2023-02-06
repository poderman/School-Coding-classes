using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemySprite : MonoBehaviour
{
    public AIPath aiPath;

    public Animator GobAnim;

    // Update is called once per frame
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f)
        {
            GobAnim.Play("GobRight");
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            GobAnim.Play("GobLeft");
        }
        else if (aiPath.desiredVelocity.y >= 0.01f && aiPath.desiredVelocity.x == 0)
        {
            GobAnim.Play("GobUp");
        }
        else if (aiPath.desiredVelocity.y >= -0.01f && aiPath.desiredVelocity.x == 0)
        {
            GobAnim.Play("GobDown");
        }
    }
}
