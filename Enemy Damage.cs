using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private float attack = 3f;
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
}
