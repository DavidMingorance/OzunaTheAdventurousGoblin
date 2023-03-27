using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    float xInicial, yInicial;

    public float speed;
    public float jumpForce;

    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer sr;

    public Sprite jumpIMG;
    public Sprite fallIMG;

    bool canIdle = false;
    bool canRun = true;


    bool playerCanJump = true;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        xInicial = transform.position.x;
        yInicial = transform.position.y;
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        rb.AddForce(new Vector2(moveX, 0) * speed * Time.deltaTime);

        if(moveY > 0 && playerCanJump)
        {
            playerCanJump = false;
            rb.AddForce(new Vector2(0, jumpForce));
        }

        if(rb.velocity.y > 0)
        {
            if(moveX > 0)
            {
                sr.flipX = false;
            }
            else if(moveX < 0)
            {
                sr.flipX = true;
            }
<<<<<<< HEAD
=======
            sr.sprite = jumpIMG;
>>>>>>> 1b12b4d73b9afde9776674217f76313a64c55254
            anim.enabled = false;
        }
        else if(rb.velocity.y < 0)
        {
            if (moveX > 0)
            {
                sr.flipX = false;
            }
            else if (moveX < 0)
            {
                sr.flipX = true;
            }
<<<<<<< HEAD

=======
            sr.sprite = fallIMG;
>>>>>>> 1b12b4d73b9afde9776674217f76313a64c55254
        }
        else
        {
            anim.enabled = true;

            if(moveX > 0 && canRun)
            {
                canRun = false;
                canIdle = true;

<<<<<<< HEAD
=======
                anim.SetTrigger("Corriendo");
>>>>>>> 1b12b4d73b9afde9776674217f76313a64c55254
                sr.flipX = false;
            }
            else if(moveX < 0 && canRun)
            {
                canRun = false;
                canIdle = true;

<<<<<<< HEAD
=======
                anim.SetTrigger("Corriendo");
>>>>>>> 1b12b4d73b9afde9776674217f76313a64c55254
                sr.flipX = true;
            }
            else if(moveX == 0 && canIdle)
            {
                canIdle = false;
                canRun = true;

            }
        }
    }

    public void CanJump(bool tof)
    {
        playerCanJump = tof;
    }

    public void Recolocar()
    {
        transform.position = new Vector3(xInicial, yInicial, 0);
    }
}
