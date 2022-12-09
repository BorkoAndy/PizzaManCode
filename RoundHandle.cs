using UnityEngine;

public class RoundHandle : MonoBehaviour
{
    [SerializeField] Transform handle;
    [SerializeField] private int angleClampingValue;

    public static float Speeder;
    
    public void OnHandleDrag()
    {               
        Vector3 mousePosition = Input.mousePosition;
        Vector2 direction = mousePosition - handle.position;
        float newAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        newAngle = Mathf.Clamp(newAngle, -angleClampingValue, angleClampingValue);
       
        Quaternion r = Quaternion.AngleAxis(-newAngle, Vector3.forward);
        handle.rotation = r;
      
        Speeder =newAngle;             
    }
    public void OnPointerUp()
    {
        handle.rotation = Quaternion.identity;
        Speeder = 0;
    }
}
