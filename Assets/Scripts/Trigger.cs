using System.Collections;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Trigger
{

    public Trigger(Action action, Predicate shouldTrigger) {
        this.action = action;
        this.shouldTrigger = shouldTrigger;
        timeTillUpdate = Time.fixedTime;
    }

    private Action action;
    private Predicate shouldTrigger;
    public float cooldown = 0.1f;
    private float timeTillUpdate;

    public void TestTrigger()
    {
        if (shouldTrigger()
            && (cooldown == 0
                || timeTillUpdate <= Time.fixedTime)) {

              action();
              timeTillUpdate = Time.fixedTime + cooldown;
        }
    }

    public delegate void Action();
    public delegate bool Predicate();
}
