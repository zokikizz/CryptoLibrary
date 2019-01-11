
#include "GL\GL.H"
#pragma once
class CGLMaterial
{
protected:
	float ambient[4], diffuse[4], specular[4], emission[4], shininess;
public:
	CGLMaterial();
	~CGLMaterial();

	void Select();
	void SetAmbient(float r, float g, float b, float a);
	void SetDiffuse(float r, float g, float b, float a);
	void SetSpecular(float r, float g, float b, float a);
	void SetEmission(float r, float g, float b, float a);
	void SetShininess(float s);
};

