#pragma strict
var trig = false;
var played = false;
var scareSound: AudioClip;
function Start () {
trig = false;
	//scare.GetComponent.<Renderer>().enabled = false;
	
}
function OnTriggerEnter (other : Collider) {
	trig = true;
}
function Update () {
	if (trig == true) {
		//scare.GetComponent.<Renderer>().enabled = true;
		
		makehimscream ();
	}
}
function makehimscream () {
	if (!played) {
		played = true;
		GetComponent.<AudioSource>().PlayOneShot(scareSound);
	}
}