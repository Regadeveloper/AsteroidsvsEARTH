using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject center;
    public GameObject left;
    public GameObject right;
    public BoxCollider2D damageBox;
    public BoxCollider2D hitBox;
    public BoxCollider2D hitBoxTwo;
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
        Debug.Log("tocando al player");
        enemyRenderer.color = new Color(0, 0, 256);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        enemyRenderer.color = new Color(256, 0, 0);
    }
}
