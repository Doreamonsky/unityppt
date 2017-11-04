/*
    通过查询Transform API 文档了解更多API 使用方法 
*/

using UnityEngine;

public enum TransformAPI{
    move,
    rotate,
    orbit
}

public class TransformAPIs : MonoBehaviour {
    [Header("执行不同API")]
    public TransformAPI apis;
    [Header("控制的对象")]
    public Transform Target;

    private Quaternion rotationWhenOrbit;
    private Vector3 initalLocationWhenOrbit;

    private float t;

    private void Start()
    {
        rotationWhenOrbit = Quaternion.identity;
        initalLocationWhenOrbit = Target.position;
    }

    private void Update()
    {
        t += Time.deltaTime;

        switch(apis){
            case TransformAPI.move:
                Target.Translate(0, 0, Time.deltaTime*2);
                break;
            case TransformAPI.rotate:
                Target.Rotate(Time.deltaTime*50, 0, 0);
                break;
            case TransformAPI.orbit:
                Vector3 distanceToOribit = new Vector3(0, 0, 1);

                rotationWhenOrbit = Quaternion.Euler(new Vector3(t*50 , 0, 0));

                Target.position = rotationWhenOrbit * distanceToOribit + initalLocationWhenOrbit;
                break;
        }
    }

}
