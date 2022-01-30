
using UnityEngine;

public class menu : MonoBehaviour
{
    public float speed ;
    private Transform m_transform;
    private float pose;
    
    private float size;
    // Start is called before the first frame update
    void Start()
    {
        m_transform = GetComponent<Transform>();
        size = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
         Move();
        
    }
   
    private void Move() {
        m_transform.Translate(Vector3.right * speed * Time.deltaTime);
        //Vector2 offset = new Vector2(speed, 0);
       Vector3 offset = Vector3.zero;
        if (m_transform.position.x <= -size) {
            offset = new Vector3(size* 2, 0, 0);
        }if (m_transform.position.x >= size) {
            offset = new Vector3(-size* 2, 0, 0);
        }
        m_transform.position += offset;
       
    
    }
}
