using UnityEngine;

public class Player : MonoBehaviour
{
    //For editing the movement variables in unity
    public Rigidbody2D RB2D;
    public Animator Animator;
    public float movespeedX = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Establishes the link between player and the Animator/Rigidbody
        RB2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Quick N Dirty movement from Week 1 lesson. 
        float moveX = Input.GetAxis("Horizontal");
        if (Mathf.Abs(moveX) > 0.1f) 
        {
            float force = moveX * movespeedX;
            RB2D.AddForceX(force, ForceMode2D.Force);

        }
        Animator.SetFloat("moveSpeedX", Mathf.Abs(movespeedX));


    }
}
