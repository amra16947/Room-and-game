#pragma strict

function Start () {
	
}

function Update () {

    if(Input.GetKeyDown(KeyCode.C)){
        GetComponent(Renderer).material.color= Color.red;
    }
    if(Input.GetKeyDown(KeyCode.Z)){
        GetComponent(Renderer).material.color= Color.green;
    }
    if(Input.GetKeyDown(KeyCode.P)){
        GetComponent(Renderer).material.color= Color.blue;
    }
	
}
