using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    public bool ismoving;
    public LayerMask SolidObjectsLayer;
    private Vector2 input;
    private Animator animator;
    public Rigidbody2D rb;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        
    }
    // Update is called once per frame
    void Update()
    {
        if (!ismoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            if (input.x != 0) input.y = 0; //remove diagonal movements

            if (input != Vector2.zero)
            {
                
                animator.SetFloat("moveX", input.x);
                animator.SetFloat("moveY", input.y);


                var targetPOs = transform.position;
                targetPOs.x += input.x;
                targetPOs.y += input.y;

                if (Walkable(targetPOs))
                    StartCoroutine(Move(targetPOs));
            }
        }
        animator.SetBool("ismoving", ismoving);


    }
    IEnumerator Move(Vector3 targetPOs)
    {
        ismoving = true;
        while ((targetPOs - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPOs, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPOs;

        ismoving = false;
    }

    private bool Walkable(Vector3 targetPOs)
    {
        if (Physics2D.OverlapCircle(targetPOs, 0.2f, SolidObjectsLayer) != null)
        {
            return false;
        }
        return true;
    }

    private void OnTriggerEnter2D(Collider2D collectible)
    {
        if(collectible.CompareTag("Objective"))
        {
            Destroy(collectible.gameObject);
        }
    }

} 
