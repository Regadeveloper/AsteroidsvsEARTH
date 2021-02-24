using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public BoxCollider2D damageBox;
    public SpriteRenderer enemyRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enemy daño" + (Globals.enemyHealth-1));
        enemyRenderer.color = new Color(0, 0, 256);
        Globals.enemyHealth -= 1;
        if (Globals.enemyHealth <= 0)
        {
            killEnemy();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        enemyRenderer.color = new Color(255,2399,0);
    }

    public void EnemyDamage()
    {
        enemyRenderer.color = new Color(256, 0, 0);
        if (Globals.enemyHealth <= 0)
        {
            killEnemy();
        }
    }

    private void killEnemy()
    {
        Destroy(this.GetComponentInParent<SpriteRenderer>());
    }
}
