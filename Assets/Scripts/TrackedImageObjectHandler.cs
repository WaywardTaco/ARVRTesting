using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class TrackedImageObjectHandler : MonoBehaviour
{
    public void OnTrackedImageChanged(ARTrackablesChangedEventArgs<ARTrackedImage> eventArgs){
        foreach(var image in eventArgs.added){
            Debug.Log("Tracked New Image: " + image.referenceImage.name);
        }

        foreach(var image in eventArgs.updated){
            Debug.Log("Updated Image: " + image.referenceImage.name);
        }

        foreach(var image in eventArgs.removed){
            Debug.Log("Removed Image: " + image.referenceImage.name);
        }
    }
}
