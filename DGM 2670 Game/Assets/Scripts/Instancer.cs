
using UnityEngine;
[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public Vector3 instanceAtLocation;
    public GameAction gameActionObj;
    
    public void InstanceObject(GameObject obj)
    {
        var newObj = Instantiate(obj, instanceAtLocation, Quaternion.identity);
        gameActionObj.transformAction(newObj.transform);
    }
}
