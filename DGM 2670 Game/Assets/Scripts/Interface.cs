

using UnityEngine;
using UnityEngine.Events;

public interface IRun
{
    float Speed { get; set; }

    void Run();
    void Run(float f);
}

public interface ITest
{
    void Test();
}

public interface IListen
{ 
    IRun NewIRunObj { get; set; }
    void Start();
    UnityEvent Event { get; set; }
}

public interface ITrigger
{
    void OnTriggerEnter(Collider obj);
}