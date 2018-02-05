using UnityEngine;
using System.Collections;

public class ColorManager : MonoBehaviour {

    public Color color = Color.blue;
	
	void OnColorChange(HSBColor color)
    {
        this.color = color.ToColor();	
	}
}
