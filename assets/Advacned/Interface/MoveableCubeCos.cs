using UnityEngine;

public class MoveableCubeCos : MonoBehaviour,IMoveable {
    float t;

    public void Move() {
        transform.position = new Vector3 {
            z = Mathf.Cos(Mathf.Deg2Rad * t),
            y = Mathf.Cos(Mathf.Deg2Rad * t)
        };
    }

    void Update () {
        t += Time.deltaTime * 85;

        Move();
    }
}
