
#include "CGLMaterial.h"
#pragma once

class CGLRenderer
{
public:

	double camX = 0.0, camY = 0.0, camZ = 0.0;
	double pitch = 0.0, yaw = 0.0;
	float *box;
	
	void OnKey(UINT key);
	void PrepareVABox(float a, float b, float c);
	void DrawBox(float a, float b, float c);

	float *wall;
	void PrepareVAWall(float a);
	void DrawWall(float a);
	void DrawWallsOld(float a);
	void WallPolygon(float a, int peaces);
	void DrawVABoxNew(float a, int peaces);

	float *vert;
	int numOfVert;
	void PrepareSquere(float a, int steps);
	void DrawSquere(float a, int steps);
	void DrawCube(double a, int peaces);
	

	CGLMaterial woodMaterial, lampMaterial, wallMaterial, lightbulbMaterial, floorMaterial;

	void SetWoodMaterial();
	void SetLampMaterial();
	void SetWallMaterial();
	void SetLightBulbMaterial();
	void SetFloorMaterial();
	
	void SetLightModel();
	void SetLightbulbLight();
	void SetAllMaterials();

	float tWidth = 2.5f, tHeight = 0.5, tDepth = 1.5f, tLegHeight = 2.0f, tLegWidth = 0.15f, delta = 0.1f;
	float lampBarW = 0.1f, lampBarH = 1.0f, lampHeadBarW = 0.6f, lampHeadBarH = 0.3f, lampHeadBarD = 0.2f;
	float sizeOfWall = 10.0f;
	float rotate1 = 0.0f, rotate2 = 0.0f, rotate3 = 0.0f;
	void DrawWalls(float a);
	void DrawTable();
	void DrawLamp();
	void DrawHemisphere(float radius);

	CGLRenderer(void);
	virtual ~CGLRenderer(void);
		
	bool CreateGLContext(CDC* pDC);			// kreira OpenGL Rendering Context
	void PrepareScene(CDC* pDC);			// inicijalizuje scenu,
	void Reshape(CDC* pDC, int w, int h);	// kod koji treba da se izvrsi svaki put kada se promeni velicina prozora ili pogleda i
	void DrawScene(CDC* pDC);				// iscrtava scenu
	void DestroyScene(CDC* pDC);			// dealocira resurse alocirane u drugim funkcijama ove klase,

protected:
	HGLRC	 m_hrc; //OpenGL Rendering Context 

};
