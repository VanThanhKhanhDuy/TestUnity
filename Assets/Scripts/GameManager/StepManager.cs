using UnityEngine;

public class StepManager : Singleton<StepManager>
{
    [SerializeField]
    private string objectTag;
    private float moveSpeed = 5f;

    void Start()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(objectTag);
        foreach (GameObject obj in objects)
        {
            obj.AddComponent<Step>();
            Step moveComponent = obj.GetComponent<Step>();
            moveComponent.moveSpeed = moveSpeed;
        }
    }
}