using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    const float VELOCITY = 30.0F;
    const int STATIONARY_COUNT = 5;

    Rigidbody2D rb2d;
    SpriteRenderer sprite;

    LayerMask maskBound;
    ContactFilter2D contactFilterBound;
    LayerMask maskCube;
    ContactFilter2D contactFilterCube;

    GameObject cubeShadow;

    void OnEnable()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();

        maskBound = LayerMask.GetMask("Bound");
        contactFilterBound.useTriggers = false;
        contactFilterBound.SetLayerMask(maskBound);
        contactFilterBound.useLayerMask = true;

        maskCube = LayerMask.GetMask("Cube");
        contactFilterCube.useTriggers = false;
        contactFilterCube.SetLayerMask(maskCube);
        contactFilterCube.useLayerMask = true;

        if (gameObject.name == "CubeRed")
            cubeShadow = GameObject.Find("CubeShadowRed");
        else if (gameObject.name == "CubeGreen")
            cubeShadow = GameObject.Find("CubeShadowGreen");
        else if (gameObject.name == "CubeBlue")
            cubeShadow = GameObject.Find("CubeShadowBlue");
        else if (gameObject.name == "CubeYellow")
            cubeShadow = GameObject.Find("CubeShadowYellow");
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    bool isDirectionUp(Vector2 direction)
    {
        if (direction.y > 0)
            return true;
        return false;
    }

    bool isDirectionDown(Vector2 direction)
    {
        if (direction.y < 0)
            return true;
        return false;
    }

    bool isDirectionLeft(Vector2 direction)
    {
        if (direction.x < 0)
            return true;
        return false;
    }

    bool isDirectionRight(Vector2 direction)
    {
        if (direction.x > 0)
            return true;
        return false;
    }

    int GetDistanceToFirstBound(Vector2 direction)
    {
        RaycastHit2D[] hitResults = new RaycastHit2D[20];
        List<RaycastHit2D> hitResultsUse = new List<RaycastHit2D>(20);

        int hitCount = rb2d.Cast(direction, contactFilterBound, hitResults,
                                 direction.magnitude);
        if (hitCount == 0)
            return -1;

        for (int i = 0; i < hitCount; i++) {
            if (Vector2.Dot(hitResults[i].normal, direction) < 0) {
                // The cube has hit an object whose normal opposes its movement.
                // Add into hitResultsUse list for processing.
                hitResultsUse.Add(hitResults[i]);
            }
        }
        if (hitResultsUse.Count == 0)
            return -1;

        int idx = 0;
        for (int i = 1; i < hitResultsUse.Count; i++) {
            // Find the shortest hit distance.
            if (hitResultsUse[i].distance < hitResultsUse[idx].distance)
                idx = i;
        }
        
        float distance = hitResultsUse[idx].distance;
        if (distance % 1.0F > 0.5)
            return (int)(distance / 1.0F) + 1;
        else
            return (int)(distance / 1.0F);
    }

    int GetNumberOfCubesToBound(Vector2 direction, float distanceToBound)
    {
        RaycastHit2D[] hitResults = new RaycastHit2D[20];
        List<RaycastHit2D> hitResultsUse = new List<RaycastHit2D>(20);

        int hitCount = rb2d.Cast(direction, contactFilterCube, hitResults,
                                 direction.magnitude);

        int count = 0;
        for (int i = 0; i < hitCount; i++) {
            if (Vector2.Dot(hitResults[i].normal, direction) < 0) {
                // The cube has hit an object whose normal opposes its movement.
                if (hitResults[i].distance < distanceToBound)
                    count++;
            }
        }
        return count;
    }

    public Vector2 GetMoveEndPosition(Vector2 direction)
    {
        /* This is to ensure raycasting can extend the entire board */
        direction *= 10.0F;

        int distToFirstBound = GetDistanceToFirstBound(direction);
        int cubesToBound = GetNumberOfCubesToBound(direction, (float)distToFirstBound);
        float dist = (float)(distToFirstBound - cubesToBound);
        
        if (isDirectionUp(direction))
            return new Vector2(rb2d.position.x, rb2d.position.y + dist);
        else if (isDirectionDown(direction))
            return new Vector2(rb2d.position.x, rb2d.position.y - dist);
        else if (isDirectionLeft(direction))
            return new Vector2(rb2d.position.x - dist, rb2d.position.y);
        else if (isDirectionRight(direction))
            return new Vector2(rb2d.position.x + dist, rb2d.position.y);

        return new Vector2(rb2d.position.x, rb2d.position.y);
    }

    public Vector2 GetCurrentPosition()
    {
        return new Vector2(rb2d.position.x, rb2d.position.y);
    }

    public void SetPosition(Vector2 position)
    {
        rb2d.position = new Vector2(position.x, position.y);
        transform.position = new Vector2(position.x, position.y);
        cubeShadow.transform.position = new Vector2(position.x, position.y);
    }

    public void SetDarkColor(float shade)
    {
        sprite.color = new Color(shade, shade, shade, 1.0F);
    }

    public void UnsetDarkColor()
    {
        sprite.color = new Color(1.0F, 1.0F, 1.0F, 1.0F);
    }

    public void PlayCubeEnter()
    {
        if (gameObject.name == "CubeRed") {
            GetComponent<Animator>().Play("CubeRedEnter");
            cubeShadow.GetComponent<Animator>().Play("CubeRedEnter");
        } else if (gameObject.name == "CubeGreen") {
            GetComponent<Animator>().Play("CubeGreenEnter");
            cubeShadow.GetComponent<Animator>().Play("CubeGreenEnter");
        } else if (gameObject.name == "CubeBlue") {
            GetComponent<Animator>().Play("CubeBlueEnter");
            cubeShadow.GetComponent<Animator>().Play("CubeBlueEnter");
        } else if (gameObject.name == "CubeYellow") {
            GetComponent<Animator>().Play("CubeYellowEnter");
            cubeShadow.GetComponent<Animator>().Play("CubeYellowEnter");
        }
    }
}
