using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemyController : MonoBehaviour
{

    private Animator anim;

    public float speed;

    public LayerMask isGround;
    public LayerMask isPlayer;

    public Transform wallHitBox;
    public Transform playerHitBox;

    private bool wallHit;
    
    

    public float wallHitHeight;
    public float wallHitWidth;

    private bool playerHit;
    

    public float playerHitHeight;
    public float playerHitWidth;




    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {

        transform.Translate(speed * Time.deltaTime, 0, 0);

        wallHit = Physics2D.OverlapBox(wallHitBox.position, new Vector2(wallHitWidth, wallHitHeight), 0, isGround);
        playerHit = Physics2D.OverlapBox(playerHitBox.position, new Vector2(playerHitWidth, playerHitHeight), 0, isPlayer);
        if (wallHit == true)
        {
            speed = speed * -1;
        }
        
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player"&& playerHit==true)
        {

            Debug.Log(playerHit);
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(wallHitBox.position, new Vector3(wallHitWidth, wallHitHeight, 1));
        Gizmos.color = Color.blue;
        Gizmos.DrawCube(playerHitBox.position, new Vector3(playerHitWidth, playerHitHeight, 1));
    }
}