using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public bool istouchtop;
    public bool istouchbottom;
    public bool istouchright;
    public bool istouchleft;
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        if((istouchright&&h==1)||(istouchleft&&h==-1))
            h=0;
        
        float v = Input.GetAxisRaw("Vertical");
        if((istouchtop&&v==1)||(istouchbottom&&v==-1))
            v=0;
        
        Vector3 curPos= transform.position;
        Vector3 nextPos= new Vector3(h,v,0) * speed * Time.deltaTime;
        
        transform.position= curPos + nextPos;
        }
        void OnTriggerEnter2D(Collider2D collision){
            if(collision.gameObject.tag == "border"){
                switch (collision.gameObject.name){
                    case "top":
                        istouchtop= true;
                        break;
                    case "bottom":
                        istouchbottom= true;
                        break;
                    case "right":
                        istouchright= true;
                        break;
                    case "left":
                        istouchleft= true;
                        break;
                }
            }
        }

    void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.tag == "border"){
            switch (collision.gameObject.name){
                case "top":
                    istouchtop= false;
                    break;
                case "bottom":
                    istouchbottom= false;
                    break;
                case "right":
                    istouchright= false;
                    break;
                case "left":
                    istouchleft= false;
                    break;
            }
        }
    }
}
