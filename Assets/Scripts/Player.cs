using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float vel;
    
    //isLeft permite conocer si estamos presionando la tecla izquierda
    bool isLeft = false;
    
    //isRight permite conocer si estamos presionando la tecla derecha
    bool isRight = false;
    
    //isUp permite conocer si estamos presionando la tecla de arriba
    bool isUp = false;
    
    //isDown permite conocer si estamos presionando la tecla de abajo
    bool isDown = false;

    private Rigidbody2D rb;
    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent es la principal forma de acceder a otros componentes. 
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float x = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(x*Time.deltaTime*vel, 0));
        */
        
        if (isLeft)
        {
            rb.transform.Translate(new Vector2(-vel, 0) * Time.deltaTime);
        }
        
        if (isRight)
        {
            rb.transform.Translate(new Vector2(vel, 0) * Time.deltaTime);
        }
        
        if (isUp)
        {
            rb.transform.Translate(new Vector2(0, vel) * Time.deltaTime);
        }
        
        if (isDown)
        {
            rb.transform.Translate(new Vector2(0, -vel) * Time.deltaTime);
        }
    }
    
    public void clickLeft()
    {
        isLeft = true;
        anim.SetBool("isLeft", true);
    }
    
    public void releaseLeft()
    {
        isLeft = false;
        anim.SetBool("isLeft", false);
    }
    
    public void clickRight()
    {
        isRight = true;
        anim.SetBool("isRight", true);
    }
    
    public void releaseRight()
    {
        isRight = false;
        anim.SetBool("isRight", false);
    }
    
    public void clickUp()
    {
        isUp = true;
        anim.SetBool("isUp", true);
    }
    
    public void releaseUp()
    {
        isUp = false;
        anim.SetBool("isUp", false);
    }
    
    public void clickDown()
    {
        isDown = true;
        anim.SetBool("isDown", true);
    }
    
    public void releaseDown()
    {
        isDown = false;
        anim.SetBool("isDown", false);
    }
}
