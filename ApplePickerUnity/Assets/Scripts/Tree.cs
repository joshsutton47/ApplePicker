/*** 
 *  Created by: Josh Sutton
 *  Date Created: 31 Jan 2022
 *  
 *  Last Edited By: Josh Sutton
 *  Last Edited: 31 Jan 2022
 * 
 *  Description: controls the tree behavior
 * 
 ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    #region Variables
    public GameObject applePrefab;
    public float speed = 1f;
    public float sideEdge = 10f;
    public float changeDirectionChance = 0.1f;
    public float dropTime = 1f;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", dropTime);
    }

    // Update is called once per frame
    void Update()
    {
        #region Move Tree
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        #endregion

        #region Edge Return
        if(pos.x < -sideEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if(pos.x > sideEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        #endregion

    }//end Update

    private void FixedUpdate()
    {
        #region Tree Change Direction
        if (Random.value < changeDirectionChance)
        {
            speed *= -1;
        }
        #endregion
    }
}
