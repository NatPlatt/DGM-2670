

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

public interface IMove
{
    void Move(CharacterController controller); 
    //requires any character in the scene to have a character controller
}