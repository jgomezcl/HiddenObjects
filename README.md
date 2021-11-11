# HiddenObjects
Materials and shaders to make objects invisible behind others or make them only visible behind others using stencils in Unity. The shaders are adapted from [this tutorial](https://www.ronja-tutorials.com/2018/08/18/stencil-buffers.html).

To use them just import the Unity package on your project. After that, drop the *Transparency Manager* prefab at the scene and add references to the objects you want to hide and to the one that hides them on the inspector. On startup the manager replaces the default standard shader by a custom one with stencil operations.

Since all GameObjects are visible on the editor, configuring the scene is easier with the manager but the final result will only be visible during execution. If you want to see the scene in the editor as it will be seen during execution you should avoid using the manager and replace the standard shader of each GameObject by the custom ones, as it is shown on the example materials.
