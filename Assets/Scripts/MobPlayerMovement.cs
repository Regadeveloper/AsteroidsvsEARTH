using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MobPlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public int vel;
    public float maxHeight;
    public SpriteRenderer playerRenderer;
    public Animator anim;
    public Canvas gameOverCanvas;
    // Start is called before the first frame update
    private void Start()
    {
        Globals.health = 10;
        Globals.enemyHealth = 10;
        gameOverCanvas.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {


        rb.AddForce(new Vector2 (Input.acceleration.x, 0 )* vel);

        if (Input.GetMouseButton(0) && rb.transform.position.y < maxHeight)
        {
            rb.AddForce(transform.up * 2.5f * vel);
            anim.SetBool("Moving", true);
        }

        else if (rb.position.y > -2)
        {
            rb.AddForce(transform.up * -2.5f * vel);
        }
        else
        {
            anim.SetBool("Moving", false);
        }

        if (transform.position.y < -6)
        {
            gameOver();
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "enemySide")
        {
            Debug.Log("Player daño" + (Globals.health-1));
            playerRenderer.color = new Color(0, 100, 256);
            PlayerDamage();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "enemySide")
        {
            playerRenderer.color = new Color(256, 256, 256);
        }
    }

    protected void PlayerDamage()
    {
        Globals.health -= 1;
        if ((Globals.health <= 0))
        {
            gameOver();

        }
    }

    private void gameOver()
    {
        gameOverCanvas.enabled = true;
        Destroy(this.rb);
        Destroy(this.playerRenderer);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene("FirstLevel");
    }


}
