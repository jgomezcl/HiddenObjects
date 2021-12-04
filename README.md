# HiddenObjects
Materials and shaders to make objects invisible behind others or make them only visible behind others using stencils in Unity. The shaders are adapted from [this tutorial](https://www.ronja-tutorials.com/2018/08/18/stencil-buffers.html).

To use them just import the Unity package to your project. After that, drop the *Transparency Manager* prefab on the scene and, on the inspector, add references to the objects you want to hide and to the one that hides them. On startup the *Transparency Manager* will replace the default standard shader by a custom one with stencil operations.

Since all GameObjects are visible on the editor, configuring the scene is easier with the manager but the final result will only be visible in runtime. If you want to see the scene in the editor as it will be seen during execution, instead of using the manager you should manually replace the standard shader of each GameObject by the custom ones that can be found in the Assets/Scripts folder, as it is shown on the example materials on Assets/Materials.
