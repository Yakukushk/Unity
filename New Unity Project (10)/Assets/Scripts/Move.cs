using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    //public GameObject Object;
    [SerializeField] private float speed = 0.5f;
    private Rigidbody2D rigidbody;
    [SerializeField] private float JumpForce = 2f;
    public bool onGround;
    public GameObject picker;
    public Animator anim;
    public Transform GetGround;
    public float checkRadius = 0.5f;
    public LayerMask layerMask;
    public Vector2 move;
   [SerializeField] private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        GetGround = GetComponent<Transform>();
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Move_Hero();
        Jump();
        CheckingGround();
    }
     void FixedUpdate()
    {
        //Jump();
    }
    void Move_Hero() {
        try
        {
            anim.SetFloat("moveX", Mathf.Abs(move.x));
          
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
           
            if (Input.GetKey(KeyCode.RightArrow)) {
                this.transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
         
        }
        catch { }
    }
    void Jump() {
        
            if (Input.GetKey(KeyCode.UpArrow) && onGround) {
                source.Play();
                rigidbody.AddForce(Vector2.up * JumpForce);

            }
       
    }
    void CheckingGround() {
        onGround = Physics2D.OverlapCircle(GetGround.position, checkRadius, layerMask);
        anim.SetBool("OnGround", onGround);
        //Debug.Log("Cheaking");
    }
   


}
