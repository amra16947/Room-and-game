#pragma strict

private var myLight : Light;

function Start ()
{
    myLight = GetComponent(Light);
}
function Update ()
{
    if(Input.GetKeyUp(KeyCode.Space))
    {
        myLight.enabled = !myLight.enabled;
    }
}