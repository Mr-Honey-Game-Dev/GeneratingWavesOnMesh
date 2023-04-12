# Generating Waves On Mesh

This Unity project implements a wave generator that creates realistic waves on a mesh. The wave generator changes positoin of mesh verticies in response to a sine/cos/tan wave. The mesh can be any shape or size, and the wave amplitude and frequency can be adjusted to create a variety of wave patterns.

# Getting Started
To use this project, simply clone the repository or download the source code as a ZIP file. Open the project in Unity and navigate to the "Demo" scene to see the wave generator in action.

The "GeneratorWaveOnMesh" script is responsible for animating the mesh with waves. It can be attached to any mesh object in the scene, and provides customizable properties for wave amplitude, frequency, and speed.

The "MeshHelper" class can be used to subdivide meshes, resulting in smoother and more detailed surfaces for the wave generator to operate on. To use this class, simply add the "MeshHelper" script to a game object and call its "Subdivide" function with a mesh as the argument.

![image](https://user-images.githubusercontent.com/61724400/231471269-2b63bf85-ad0c-47e8-b89f-787b912bb3d3.png)
![image](https://user-images.githubusercontent.com/61724400/231472000-9154fa61-2231-425d-a98e-f8347124d55b.png)

# Acknowledgments
This project was supported by the work of Ragueel, who provided the Mesh Helper class used in this project.
https://gist.github.com/Ragueel/f6a07d1a46f0fe66137dd947950b2a99


