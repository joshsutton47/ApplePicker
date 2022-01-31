/*** 
 *  Created by: Josh Sutton
 *  Date Created: 31 Jan 2022
 *  
 *  Last Edited By: Josh Sutton
 *  Last Edited: 31 Jan 2022
 * 
 *  Description: controls apple behaviors in the game
 * 
 ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;


    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
        }
    }
}
