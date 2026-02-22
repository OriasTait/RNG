using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Attach this script to any gameObject for which you want to put a note.
/// </summary>

namespace UI_Notes
{
    public class Comments : MonoBehaviour
    {
        /*
        ===============================================================================================
        PURPOSE:
        Provide the ability to add comments to Unity Game Objects.
        -----------------------------------------------------------------------------------------------
        NOTES:
        - The name of the string cannot be the same as the class.
        - The area for the comments is set to have
          - Start with 5 lines
          - Expand to 20 lines before the scroll bar appears
        ===============================================================================================
        */
        [TextArea(5,20)]
        public string Notes = "Comment Here.";  // Do not place your note/comment here. Enter your note in the Unity Editor.
    } // public class Comments : MonoBehaviour
} // namespace UI_Notes
