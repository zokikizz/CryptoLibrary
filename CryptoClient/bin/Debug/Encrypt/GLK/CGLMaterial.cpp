#include "stdafx.h"
#include "CGLMaterial.h"


CGLMaterial::CGLMaterial()
{
	ambient[0] = 0.2; ambient[1] = 0.2;
	ambient[2] = 0.2; ambient[3] = 1.0;

	diffuse[0] = 0.8; diffuse[1] = 0.8;
	diffuse[2] = 0.8; diffuse[3] = 1.0;

	specular[0] = 0.0; specular[1] = 0.0;
	specular[2] = 0.0; specular[3] = 0.0;

	emission[0] = 0.0; emission[1] = 0.0;
	emission[2] = 0.0; emission[3] = 1.0;

	shininess = 0.0;
}


CGLMaterial::~CGLMaterial()
{
}

void CGLMaterial::Select()
{
	glMaterialfv(GL_FRONT, GL_AMBIENT, ambient);
	glMaterialfv(GL_FRONT, GL_DIFFUSE, diffuse);
	glMaterialfv(GL_FRONT, GL_SPECULAR, specular);
	glMaterialfv(GL_FRONT, GL_EMISSION, emission);
	glMaterialf(GL_FRONT, GL_SHININESS, shininess);
}

void CGLMaterial::SetAmbient(float r, float g, float b, float a)
{
	int i = 0;
	ambient[i++] = r; ambient[i++] = g;
	ambient[i++] = b; ambient[i++] = a;
}

void CGLMaterial::SetDiffuse(float r, float g, float b, float a)
{
	int i = 0;
	diffuse[i++] = r; diffuse[i++] = g;
	diffuse[i++] = b; diffuse[i++] = a;
}

void CGLMaterial::SetSpecular(float r, float g, float b, float a)
{
	int i = 0;
	specular[i++] = r; specular[i++] = g;
	specular[i++] = b; specular[i++] = a;
}

void CGLMaterial::SetEmission(float r, float g, float b, float a)
{
	int i = 0;
	emission[i++] = r; emission[i++] = g;
	emission[i++] = b; emission[i++] = a;
}

void CGLMaterial::SetShininess(float s)
{
	if (s < 0)
		shininess = 0;
	else if (s > 128)
		shininess = 128;
	else
		shininess = s;
}	
