#include "StdAfx.h"
#include "GLRenderer.h"
#include "GL\gl.h"
#include "GL\glu.h"
#include "GL\glaux.h"
#include "GL\glut.h"
//#pragma comment(lib, "GL\\glut32.lib")

void CGLRenderer::OnKey(UINT key)
{
	switch (key)
	{
	case 'A': this->camX++; break;
	case 'D': this->camX--; break;
	case 'W': this->camZ++; break;
	case 'S': this->camZ--; break;
	case 'Z': this->camY++; break;
	case 'X': this->camY--; break;

	case VK_UP: this->pitch++; break;
	case VK_DOWN: this->pitch--; break;
	case VK_LEFT: this->yaw++; break;
	case VK_RIGHT: this->yaw--; break;

	case 'U': rotate1++; break;
	case 'I': rotate1--; break;

	case 'J': rotate2++; break;
	case 'K': rotate2--; break;


	case 'N': rotate3++; break;
	case 'M': rotate3--; break;

	default:
		break;
	}
}

void CGLRenderer::PrepareVABox(float a, float b, float c)
{
	int i = 0;
	// front side
	box[i++] = -a / 2; box[i++] = -b / 2; box[i++] = c / 2;
	box[i++] = 0; box[i++] = 0; box[i++] = 1; // norm for front side
	box[i++] = a / 2; box[i++] = -b / 2; box[i++] = c / 2;
	box[i++] = 0; box[i++] = 0; box[i++] = 1; // norm
	box[i++] = a / 2; box[i++] = b / 2; box[i++] = c / 2;
	box[i++] = 0; box[i++] = 0; box[i++] = 1; //norm
	box[i++] = -a / 2; box[i++] = b / 2; box[i++] = c / 2;
	box[i++] = 0; box[i++] = 0; box[i++] = 1; // norm


	// back side
	box[i++] = -a / 2; box[i++] = -b / 2; box[i++] = -c / 2;
	box[i++] = 0; box[i++] = 0; box[i++] = -1; // norm for front side
	box[i++] = a / 2; box[i++] = -b / 2; box[i++] = -c / 2;
	box[i++] = 0; box[i++] = 0; box[i++] = -1; // norm
	box[i++] = a / 2; box[i++] = b / 2; box[i++] = -c / 2;
	box[i++] = 0; box[i++] = 0; box[i++] = -1; //norm
	box[i++] = -a / 2; box[i++] = b / 2; box[i++] = -c / 2;
	box[i++] = 0; box[i++] = 0; box[i++] = -1; // norm

	// down side
	box[i++] = -a / 2; box[i++] = -b / 2; box[i++] = c / 2;
	box[i++] = 0; box[i++] = -1; box[i++] = 0; // norm for front side
	box[i++] = a / 2; box[i++] = -b / 2; box[i++] = c / 2;
	box[i++] = 0; box[i++] = -1; box[i++] = 0; // norm
	box[i++] = a / 2; box[i++] = -b / 2; box[i++] = -c / 2;
	box[i++] = 0; box[i++] = -1; box[i++] = 0; //norm
	box[i++] = -a / 2; box[i++] = -b / 2; box[i++] = -c / 2;
	box[i++] = 0; box[i++] = -1; box[i++] = 0; // norm

	// upper side
	box[i++] = -a / 2; box[i++] = b / 2; box[i++] = c / 2;
	box[i++] = 0; box[i++] = 1; box[i++] = 0; // norm for front side
	box[i++] = a / 2; box[i++] = b / 2; box[i++] = c / 2;
	box[i++] = 0; box[i++] = 1; box[i++] = 0; // norm
	box[i++] = a / 2; box[i++] = b / 2; box[i++] = -c / 2;
	box[i++] = 0; box[i++] = 1; box[i++] = 0; //norm
	box[i++] = -a / 2; box[i++] = b / 2; box[i++] = -c / 2;
	box[i++] = 0; box[i++] = 1; box[i++] = 0; // norm

	// right side
	box[i++] = a / 2; box[i++] = -b / 2; box[i++] = c / 2;
	box[i++] = 1; box[i++] = 0; box[i++] = 0; // norm for front side
	box[i++] = a / 2; box[i++] = -b / 2; box[i++] = -c / 2;
	box[i++] = 1; box[i++] = 0; box[i++] = 0; // norm
	box[i++] = a / 2; box[i++] = b / 2; box[i++] = -c / 2;
	box[i++] = 1; box[i++] = 0; box[i++] = 0; //norm
	box[i++] = a / 2; box[i++] = b / 2; box[i++] = c / 2;
	box[i++] = 1; box[i++] = 0; box[i++] = 0; // norm

	// left side
	box[i++] = -a / 2; box[i++] = -b / 2; box[i++] = c / 2;
	box[i++] = -1; box[i++] = 0; box[i++] = 0; // norm for front side
	box[i++] = -a / 2; box[i++] = -b / 2; box[i++] = -c / 2;
	box[i++] = -1; box[i++] = 0; box[i++] = 0; // norm
	box[i++] = -a / 2; box[i++] = b / 2; box[i++] = -c / 2;
	box[i++] = -1; box[i++] = 0; box[i++] = 0; //norm
	box[i++] = -a / 2; box[i++] = b / 2; box[i++] = c / 2;
	box[i++] = -1; box[i++] = 0; box[i++] = 0; // norm
}

void CGLRenderer::DrawBox(float a, float b, float c)
{
	PrepareVABox(a, b, c);

	glVertexPointer(3, GL_FLOAT, 6 * sizeof(float), &box[0]);
	glNormalPointer(GL_FLOAT, 6 * sizeof(float), &box[3]);
	glEnableClientState(GL_VERTEX_ARRAY);
	glEnableClientState(GL_NORMAL_ARRAY);

	glDrawArrays(GL_QUADS, 0, 24);

	glDisableClientState(GL_VERTEX_ARRAY);
	glDisableClientState(GL_NORMAL_ARRAY);
}


// OR A.K.A. DRAW SQUERE
void CGLRenderer::PrepareVAWall(float a)
{
	int i = 0;
	//0
	wall[i++] = -a / 2; wall[i++] = - a / 2; wall[i++] = 0.0f;
	wall[i++] = 0.0f; wall[i++] = 0.0f; wall[i++] = 1.0f;

	//1
	wall[i++] = -a / 2; wall[i++] = a / 2; wall[i++] = 0.0f;
	wall[i++] = 0.0f; wall[i++] = 0.0f; wall[i++] = 1.0f;

	//2
	wall[i++] = a / 2; wall[i++] = a / 2; wall[i++] = 0.0f;
	wall[i++] = 0.0f; wall[i++] = 0.0f; wall[i++] = 1.0f;

	//3
	wall[i++] = a / 2; wall[i++] = - a / 2; wall[i++] = 0.0f;
	wall[i++] = 0.0f; wall[i++] = 0.0f; wall[i++] = 1.0f;
}

void CGLRenderer::DrawWall(float a)
{
	PrepareVAWall(a);

	glVertexPointer(3, GL_FLOAT, 6 * sizeof(float), wall);
	glNormalPointer(GL_FLOAT, 6 * sizeof(float), &wall[3]);

	glEnableClientState(GL_VERTEX_ARRAY);
	glEnableClientState(GL_NORMAL_ARRAY);

	glDrawArrays(GL_QUADS, 0, 4);

	glDisableClientState(GL_VERTEX_ARRAY);
	glDisableClientState(GL_NORMAL_ARRAY);
}


#pragma region ne radi
void CGLRenderer::DrawWallsOld(float a)
{
}

void CGLRenderer::WallPolygon(float a, int peaces)
{
	glPushMatrix();
	glTranslatef(-a / 2, -a / 2, 0.0f);
	for (int i = 0; i < peaces; i++)
	{
		glPushMatrix();
		{
			glTranslatef(0.0f, i * a / peaces, 0.0f);
			for (int j = 0; j < peaces; j++)
			{
				glPushMatrix();
				{
					glTranslatef(j*a / peaces, 0.0f, 0.0f);
					DrawWall(a / peaces);
				}
				glPopMatrix();
			}
		}
		glPopMatrix();
	}
}

void CGLRenderer::DrawVABoxNew(float a, int peaces)
{

	// ne radi
	float angle = 90.0f;
	glPushMatrix();
	{
		for (int i = 0; i < 2; i++)
		{
			glRotatef(angle, 0.0f, 1.0f, 0.0f);
			glPushMatrix();
			{
				glTranslatef(0.0f, 0.0f, a / 2);
				WallPolygon(a, peaces);
			}
			glPopMatrix();
		}
	}
	glPopMatrix();

	/*glPushMatrix();
	{
		for (int i = 0; i < 2; i++)
		{
			glRotatef(angle, 0.0f, 1.0f, 0.0f);
			glPushMatrix();
			{
				glTranslatef(0.0f, 0.0f, a / 2);
				WallPolygon(a, peaces);
			}
			glPopMatrix();
		}
	}
	glPopMatrix();*/
}
#pragma endregion





void CGLRenderer::PrepareSquere(float a, int steps)
{
	//ok, radi
	numOfVert = 0;
	double step = a / steps;
	double y = a / 2;
	int k = 0;
	for (int j = 0; j < steps; j++)
	{
		double x = -a / 2;
		for (int i = 0; i < steps; i++)
		{
			vert[k++] = x; vert[k++] = y; vert[k++] = 0.0f;
			vert[k++] = 0.0f; vert[k++] = 0.0f; vert[k++] = 1.0f;

			vert[k++] = x; vert[k++] = y - step; vert[k++] = 0.0f;
			vert[k++] = 0.0f; vert[k++] = 0.0f; vert[k++] = 1.0f;

			numOfVert += 2;
			x += step;
		}
		y -= step;
	}
}

void CGLRenderer::DrawSquere(float a, int steps)
{
	//ok, radi
	PrepareSquere(a, steps);

	/*bool first = true;
	int row = numOfVert / steps;
	for (int i = 0; i < 2; i++)
	{

		glEnableClientState(GL_VERTEX_ARRAY);
		glEnableClientState(GL_NORMAL_ARRAY);

		glVertexPointer(3, GL_FLOAT, 6 * sizeof(float), &vert[i*row*6 + first == true ? 0: 12]);
		glNormalPointer(GL_FLOAT, 6 * sizeof(float), &vert[i*6* row + 3 + first == true ? 0 : 12]);

		if (first)
			first = false;

		glDrawArrays(GL_TRIANGLE_STRIP, row*i, row);

		glDisableClientState(GL_VERTEX_ARRAY);
		glDisableClientState(GL_NORMAL_ARRAY);
	}*/
	glVertexPointer(3, GL_FLOAT, 6 * sizeof(float), &vert[0]);
	glNormalPointer(GL_FLOAT, 6 * sizeof(float), &vert[3]);

	glEnableClientState(GL_VERTEX_ARRAY);
	glEnableClientState(GL_NORMAL_ARRAY);

	glDrawArrays(GL_TRIANGLE_STRIP, 0, numOfVert);

	glDisableClientState(GL_VERTEX_ARRAY);
	glDisableClientState(GL_NORMAL_ARRAY);

}

void CGLRenderer::DrawCube(double a, int peaces)
{
	// ok, radi
	float angle = 90.0f;
	glPushMatrix();
	{
		for (int i = 0; i < 4; i++)
		{
			glRotatef(angle, 0.0f, 1.0f, 0.0f);
			glPushMatrix();
			{
				glTranslatef(0.0f, 0.0f, a / 2);
				DrawSquere(a, peaces);
			}
			glPopMatrix();
		}
	}
	glPopMatrix();

	glPushMatrix();
	{
		for (int i = 0; i < 2; i++)
		{
			glRotatef(angle, 1.0f, 0.0f, 0.0f);
			glPushMatrix();
			{
				glTranslatef(0.0f, 0.0f, a / 2);
				DrawSquere(a, peaces);
			}
			glPopMatrix();
			angle = 180;
		}
	}
	glPopMatrix();
}

void CGLRenderer::DrawWalls(float a)
{
	glPushMatrix();
	{
		// right wall
		//wallMaterial.Select();
		////glColor3f(0.7, 0.7, 0.7);
		//glTranslatef(0.0f, 0.0f, -a / 2);
		//DrawSquere(a, 10);


		glColor3f(0.65, 0.65, 0.65); 
		glTranslatef(-a / 2,0.0f, a/2);
		glRotatef(90, 0.0f, 1.0f, 0.0f);
		DrawSquere(a, 10);
	}
	glPopMatrix();

	glPushMatrix();
	{
		//floorMaterial.Select();
		//glTranslatef(0.0f, -a/2,0.0f);
		//glRotatef(90, 1.0f, 0.0f, 0.0f);
		////glColor3f(0.5, 0.5, 0.5);
		//DrawSquere(a, 10);
	}
	glPopMatrix();


}

void CGLRenderer::DrawTable()
{
#pragma region Table Legs
	woodMaterial.Select();
	glPushMatrix();
	{
		// legs
		glTranslatef(-tWidth / 2 + tLegWidth/2, -sizeOfWall / 2 + tLegHeight / 2, tDepth / 2 - tLegWidth/2);
		//glColor3f(0.0f, 1.0f, 0.0f);
		glPushMatrix();
		{
			// front left front leg
			glScalef(tLegWidth, tLegHeight, tLegWidth);
			DrawCube(1.0f, 10);
		}
		glPopMatrix();

		glTranslatef(tWidth - tLegWidth, 0.0f, 0.0f);
		glPushMatrix();
		{
			// right front leg
			glScalef(tLegWidth, tLegHeight, tLegWidth);
			DrawCube(1.0f, 10);
		}
		glPopMatrix();

		glTranslatef(0.0f, 0.0f, -tDepth + tLegWidth);
		glPushMatrix();
		{
			// right back leg
			glScalef(tLegWidth, tLegHeight, tLegWidth);
			DrawCube(1.0f, 10);
		}
		glPopMatrix();


		glTranslatef(-tWidth + tLegWidth, 0.0f, 0.0f);
		glPushMatrix();
		{
			// right back leg
			glScalef(tLegWidth, tLegHeight, tLegWidth);
			DrawCube(1.0f, 10);
		}
		glPopMatrix();
	}
	glPopMatrix();
#pragma endregion

#pragma region UpperPart of Table
	glPushMatrix();
	{
		glTranslatef(0.0f, -sizeOfWall / 2 + tLegHeight - tHeight/2, 0.0f);
		//glColor3f(0.5, 0.2, 0.2);
		// fatter part
		glPushMatrix();
		{
			glScalef(tWidth, tHeight, tDepth);
			DrawCube(1.0f, 10);
		}
		glPopMatrix();

		glTranslatef(0.0f, tHeight/2 + delta /2, 0.0f);
		// slimer part
		glPushMatrix();
		{
			//glColor3f(0.5, 0.2, 0.2);
			glScalef(tWidth + delta, delta, tDepth + delta);
			DrawCube(1.0f, 10);
		}
		glPopMatrix();

		glTranslatef(-tWidth/4, delta / 2, 0.0f);
		DrawLamp();
	}
	glPopMatrix();
#pragma endregion
}

void CGLRenderer::DrawLamp()
{
	float Radius = 0.3f;
	// bottom hemisphere
	lampMaterial.Select();
	//glColor3f(1.0f,0.0f, 0.0f);
	DrawHemisphere(Radius);
	glPushMatrix();
	{
		// first bar
		glTranslatef(-Radius /2 , lampBarH / 2,0.0f);
		
		glRotatef(20 + rotate1, 0.0f, 0.0f, 1.0f);
		glPushMatrix();
		{
			glScalef(lampBarW, lampBarH, lampBarW);
			DrawCube(1.0, 10);
		}
		glPopMatrix();

		// middle sphere
		//glColor3f(0.0f, 0.0f, 1.0f);
		float radius = 0.1f;
		glTranslatef(0.0f, lampBarH / 2, 0.0f);
		glutSolidSphere(radius, 40, 40);

		// second bar
		//glColor3f(1.0f, 0.0f, 0.0f);
		glRotatef(-60 + rotate2, 0.0f, 0.0f, 1.0f);
		glTranslatef(0.0f, lampBarH / 2, 0.0f);
		glPushMatrix();
		{
			glScalef(lampBarW, lampBarH, lampBarW);
			DrawCube(1.0, 10);
		}
		glPopMatrix();

		//head
		glTranslatef(0.0f, lampBarH / 2, 0.0f);
		//glColor3f(0.0f, 0.0f, 1.0f);

		glRotatef(90, 0.0f, 1.0f, 0.0f);
		glRotatef(rotate3, 1.0f, 0.0f, 0.0f);
		glPushMatrix();
		{
			glScalef(lampHeadBarD, lampHeadBarH, lampHeadBarW);
			DrawCube(1.0f, 10);
		}
		glPopMatrix();
		// head hemisphere
		//glColor3f(1.0f, 0.0f, 0.0f);
		glTranslatef(0.0f, 0.0f, lampHeadBarW / 2 + Radius*0.9);
		glPushMatrix();
		{
			glRotatef(-90, 1.0f, 0.0f, 0.0f);
			DrawHemisphere(Radius);
		}
		glPopMatrix();
		//lightBalb
		lightbulbMaterial.Select();
		glTranslatef(0.0f, 0.0f, -radius* 0.9);
		//glColor3f(1.0, 1.0, 1.0);
		glutSolidSphere(radius, 40, 40);
		SetLightbulbLight();
	}
	glPopMatrix();
}

void CGLRenderer::DrawHemisphere(float radius)
{
	double eq[4] = { 0.0f, 1.0f, 0.0f, 0.0f };

	glClipPlane(GL_CLIP_PLANE0, eq);
	glEnable(GL_CLIP_PLANE0);
	glutSolidSphere(radius, 50, 30);
	glDisable(GL_CLIP_PLANE0);
}

#pragma region Materials

void CGLRenderer::SetWoodMaterial()
{
	woodMaterial.SetAmbient(0.5, 0.3, 0, 1);
	woodMaterial.SetDiffuse(0.3, 0.1, 0, 1);
	woodMaterial.SetSpecular(1, 1, 1, 1);
	woodMaterial.SetEmission(0, 0, 0, 1);
	woodMaterial.SetShininess(16);
}

void CGLRenderer::SetLampMaterial()
{
	lampMaterial.SetAmbient(1.0, 0, 0, 1);
	lampMaterial.SetDiffuse(1, 0, 0, 1);
	lampMaterial.SetSpecular(1, 1, 1, 1);
	lampMaterial.SetEmission(0, 0, 0, 1);
	lampMaterial.SetShininess(16);
}

void CGLRenderer::SetWallMaterial()
{
	wallMaterial.SetAmbient(0.6, 0.5, 0.4, 1);
	wallMaterial.SetDiffuse(0.9, 0.8, 0.7, 1);
	wallMaterial.SetSpecular(1, 1, 1, 1);
	wallMaterial.SetEmission(0, 0, 0, 1);
	wallMaterial.SetShininess(128);
}

void CGLRenderer::SetLightBulbMaterial()
{
	lightbulbMaterial.SetAmbient(1, 1, 0, 1);
	lightbulbMaterial.SetDiffuse(1, 1, 0, 1);
	lightbulbMaterial.SetSpecular(1, 1, 0, 1);
	lightbulbMaterial.SetEmission(1, 1, 0.7, 1);
}

void CGLRenderer::SetFloorMaterial()
{
	floorMaterial.SetAmbient(0.4, 0.3, 0.2, 1.0);
	floorMaterial.SetDiffuse(0.5, 0.4, 0.3, 1.0);
	floorMaterial.SetSpecular(1, 1, 1, 1.0);
	floorMaterial.SetEmission(0, 0, 0, 1);
	floorMaterial.SetShininess(128);
}

void CGLRenderer::SetLightModel()
{
	float light_ambient0[] = { 0.2,0.2,0.2,1.0 };
	//glLightModelfv(GL_LIGHT_MODEL_AMBIENT, light_ambient0);
	glLightfv(GL_LIGHT0, GL_AMBIENT, light_ambient0);
	glLightModeli(GL_LIGHT_MODEL_TWO_SIDE, GL_TRUE);
	glLightModeli(GL_LIGHT_MODEL_LOCAL_VIEWER, GL_FALSE);

	float light_diffuse[] = { 1.0,1.0,1.0 };
	float light_specular[] = { 1.0,1.0,1.0 };
	float light_ambient[] = { 0.2,0.2,0.2 };

	float light_position[] = { 25.0,10.0,10.0,1.0 };

	glLightfv(GL_LIGHT1, GL_AMBIENT, light_ambient);
	glLightfv(GL_LIGHT1, GL_DIFFUSE, light_diffuse);
	glLightfv(GL_LIGHT1, GL_SPECULAR, light_specular);
	glLightfv(GL_LIGHT1, GL_POSITION, light_position);


	glEnable(GL_LIGHTING);
	glEnable(GL_LIGHT1);
	glEnable(GL_LIGHT0);
}

void CGLRenderer::SetLightbulbLight()
{
	GLfloat position[] = { 0,0,0,1 };
	const GLfloat ambient[4] = { 1,1,0.2,1.0 };
	const GLfloat diffuse[4] = { 1.0,1.0,0.2,1.0 };
	const GLfloat specular[4] = { 1.0,1.0,1.0,1.0 };
	GLfloat direction[] = { 0,-1,0 };

	glLightfv(GL_LIGHT2, GL_AMBIENT, ambient);
	glLightfv(GL_LIGHT2, GL_DIFFUSE, diffuse);
	glLightfv(GL_LIGHT2, GL_SPECULAR, specular);

	glLightfv(GL_LIGHT2, GL_POSITION, position);

	glLightf(GL_LIGHT2, GL_CONSTANT_ATTENUATION, 1);
	glLightf(GL_LIGHT2, GL_LINEAR_ATTENUATION, 0.5);
	glLightf(GL_LIGHT2, GL_QUADRATIC_ATTENUATION, 0.002);

	glLightf(GL_LIGHT2, GL_SPOT_CUTOFF, 45.0);
	glLightfv(GL_LIGHT2, GL_SPOT_DIRECTION, direction);
	glLightf(GL_LIGHT2, GL_SPOT_EXPONENT, 2.0);

	glEnable(GL_LIGHT2);
}

void CGLRenderer::SetAllMaterials()
{
	SetWoodMaterial();
	SetWallMaterial();
	SetLampMaterial();
	SetFloorMaterial();
	SetLightBulbMaterial();
}

#pragma endregion



CGLRenderer::CGLRenderer(void)
{
	this->box = new float[144];
	this->wall = new float[24];
	vert = new float[10000]; // kada hoces da ga podelis sa 10 poligona i po visini i duzini moras ovako oko 10000 elemenata za vertex
}

CGLRenderer::~CGLRenderer(void)
{
	delete[] wall;
	delete [] box;
	delete[] vert;
}

bool CGLRenderer::CreateGLContext(CDC* pDC)
{
	PIXELFORMATDESCRIPTOR pfd ;
   	memset(&pfd, 0, sizeof(PIXELFORMATDESCRIPTOR));
   	pfd.nSize  = sizeof(PIXELFORMATDESCRIPTOR);
   	pfd.nVersion   = 1; 
   	pfd.dwFlags    = PFD_DOUBLEBUFFER | PFD_SUPPORT_OPENGL | PFD_DRAW_TO_WINDOW;   
   	pfd.iPixelType = PFD_TYPE_RGBA; 
   	pfd.cColorBits = 32;
   	pfd.cDepthBits = 24; 
   	pfd.iLayerType = PFD_MAIN_PLANE;
	
	int nPixelFormat = ChoosePixelFormat(pDC->m_hDC, &pfd);
	
	if (nPixelFormat == 0) return false; 

	BOOL bResult = SetPixelFormat (pDC->m_hDC, nPixelFormat, &pfd);
  	
	if (!bResult) return false; 

   	m_hrc = wglCreateContext(pDC->m_hDC); 

	if (!m_hrc) return false; 

	return true;	
}

void CGLRenderer::PrepareScene(CDC *pDC)
{
	wglMakeCurrent(pDC->m_hDC, m_hrc);
	//---------------------------------
	glClearColor(1.0f, 1.0f, 1.0f, 0.0f);
	glEnable(GL_DEPTH_TEST);

	glLineWidth(2.0f);

	SetAllMaterials();
	SetLightModel();
	//---------------------------------
	wglMakeCurrent(NULL, NULL);
}

void CGLRenderer::DrawScene(CDC *pDC)
{
	wglMakeCurrent(pDC->m_hDC, m_hrc);
	//---------------------------------

	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);
	glLoadIdentity();
	glPushMatrix();

	glTranslatef(this->camX, this->camY, this->camZ);

	glRotatef(this->pitch, 1.0f, 0.0f, 0.0f);
	glRotatef(this->yaw, 0.0f, 1.0f, 0.0f);
	
	glPushMatrix();
	{
		glTranslatef(0.0f, 0.0f, -15.0f);

		DrawWalls(sizeOfWall);
		//DrawTable();
	}
	glPopMatrix();


	glPopMatrix();

	glFlush();
	SwapBuffers(pDC->m_hDC);
	//---------------------------------
	wglMakeCurrent(NULL, NULL);
}

void CGLRenderer::Reshape(CDC *pDC, int w, int h)
{
	wglMakeCurrent(pDC->m_hDC, m_hrc);
	//---------------------------------
	glViewport(0, 0, (GLsizei)w, (GLsizei)h);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluPerspective(40, (double)w / (double)h, 1, 100);
	glMatrixMode(GL_MODELVIEW);
	//---------------------------------
	wglMakeCurrent(NULL, NULL);
}

void CGLRenderer::DestroyScene(CDC *pDC)
{
	wglMakeCurrent(pDC->m_hDC, m_hrc);
	// ... 
	wglMakeCurrent(NULL,NULL); 
	if(m_hrc) 
	{
		wglDeleteContext(m_hrc);
		m_hrc = NULL;
	}
}
