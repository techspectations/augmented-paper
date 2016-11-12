using UnityEngine;
using System.Collections;
using Vuforia;

public class PlayMovie : MonoBehaviour,
ITrackableEventHandler {
	
	private TrackableBehaviour mTrackableBehaviour;
	MovieTexture movTexture;
	public AudioClip ac;
	public AudioSource ae;
	// Use this for initialization
	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}
	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			// Play audio when target is found
			GetComponent<AudioSource> ().Play ();


		}
		else
		{
			// Stop audio when target is lost
			GetComponent<AudioSource> ().Pause ();


		}
	}   
	

}
