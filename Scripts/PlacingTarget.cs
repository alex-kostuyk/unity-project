
using UnityEngine;

public class PlacingTarget : MonoBehaviour
{
  
    [SerializeField]
    private Transform target;


    void OnMouseDrag()

    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            target.position = new Vector3(hit.point.x,0,hit.point.z);
        }
        

    } 
     
}
