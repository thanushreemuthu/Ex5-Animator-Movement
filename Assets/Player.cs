using UnityEngine;

public class player : MonoBehaviour
{
    public Animator animator;
    public float InputX;
    public float InputY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        InputX = Input.GetAxis("Horizontal");
        InputY = Input.GetAxis("Vertical");

        animator.SetFloat("InputX", InputX);
        animator.SetFloat("InputY", InputY);
        
    }
}