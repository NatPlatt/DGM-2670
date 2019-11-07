using UnityEngine;

public class PathPoints : MonoBehaviour
{
    public static Transform[] points; //change from static, but can't remember what to use instead

    void Awake()
    {
        points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
}
