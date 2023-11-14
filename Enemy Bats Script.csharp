using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTargetbats : MonoBehaviour
{
    public float speed = 5;
    private Transform target;

    private float attack = 2;
    private float attackspeed = 0.5f;
    private float canAttack;

    void OnCollisionStay2D(Collision2D enemy)
    {
        if (enemy.gameObject.tag == "Player")
        {
            if (attackspeed <= canAttack)
            {
                SoundManagerScript.PlaySound("damage");
                enemy.gameObject.GetComponent<Playerhealth>().UpdateHP(-attack);
                canAttack = 0f;
            }
            else
            {
                canAttack += Time.deltaTime;
            }
        }
    }
    private void Update()
    {
        if (target != null)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" )
        {
            target = collision.transform;
            Debug.Log(target);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            target = null;
        }
    }
}
