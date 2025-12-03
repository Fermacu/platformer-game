using UnityEngine;

public class Enemy_Mushroom : Enemy
{
    protected override void Update()
    {

        base.Update();
        anim.SetFloat("xVelocity", rb.linearVelocity.x);

        if(isDead)
            return;

        HandleCollision();
        HandleMovement();

        if (isGrounded)
            HandleTurnAround();
    }

    private void HandleTurnAround()
    {
        if (!isGroundInfrontDetected || isWallDetected)
        {
            Flip();
            idleTimer = idleDuration;
            rb.linearVelocity = Vector2.zero;
        }
    }

    private void HandleMovement()
    {
        if (idleTimer > 0)
            return;
        
        rb.linearVelocity = new Vector2(moveSpeed * facingDir, rb.linearVelocity.y);
    }
}
