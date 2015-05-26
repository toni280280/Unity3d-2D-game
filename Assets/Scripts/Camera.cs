using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{

    private float offsetX;

    public GameObject obj;
    

    public void Start() 
    {
        this.offsetX = this.transform.position.x - this.obj.transform.position.x;
        
    }
    public void Update()
    {
        
          
        var a = this.transform.position;
        a.x = this.obj.transform.position.x + offsetX;
        this.transform.position = a;
        
    }
}
