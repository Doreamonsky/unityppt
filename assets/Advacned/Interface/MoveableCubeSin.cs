using UnityEngine;

public class MoveableCubeSin : MonoBehaviour,IMoveable {
    float t;

    public void Move() {
        transform.position = new Vector3 {
            y = Mathf.Sin(Mathf.Deg2Rad * t) 
        };
    }

    void Update () {
        t += Time.deltaTime*85;

        Move();
	}
}
