# City Drive Audio Visualizer

Kyle Heffernan

C17444434

DT211C/4

# Project Description
This project simulates driving through a city at night. The buildings are audio reactive, as well as the ring around the sun in the distance.
The city itself is procedurally generated using prefabs. There is also some PostProcessing for nice visuals.

# Instructions for use
Run the exe file.

# How it works
First, the audio analyzer script takes in the selected audio file. It isolates the sample rate and the binWidth from the audio. It then
seperates the audio spectrum into 9 bands using averages and an exponential formula. The bands represent these ranges:
- 20-60 - Subbase
- 60-250 - Bass
- 250-500 - Low midrange
- 500 - 2Khz - Midrange
- 2Khz - 4Khz - Upper midrange
- 4Khz - 6Khz - Presence
- 6Khz - 20Khz - Brilliance

It also gets the smoothed ampitude of the audio. Every frame, these values are updated.
I have a building prefab which uses a parent object as a pivot point so the y only scales upwards.
I have a terrain prefab, which has 9 buildings on each side. These 9 buildings are all set to unique audio bands.
Each frame, the scale of these buildings is lerped to the size of the audio band they represent.
The terrain spawner takes in this prefab, and spawns prefabs up to a set distance. Each prefab spawned is set to
move towards the camera at a set speed. The spawner will always spawn up to the set distance so once the prefab moves 
far enough, another one will spawn. Every 5th prefab spawns using an altered version containing a streetlamp on each side.
When the prefabs are spawned, they are set to be destroyed after 30 seconds as once they move behind the camera there is no need
for them. The car has a simple driving script which makes it sway side to side to make it look more realistic. The body of the
car also has a suspension script to make it bounce up and down on the wheels. The wheels have a rotating script to make it look
like the car is actually driving.
Further out in the scene, a sun object has a second audio visualizer attached to it. This audio visualizer makes a circle around
the sun using a set radius and spawns 512 cubes along this circle, each cube representing an element in the audio analyzer framesize.
Each frame, the scale of these cubes is lerped to the wave that they represent. The visualizer object itself is also being 
rotated and is multiplied by amplitude, so the higher the amplitude, the faster it spins. There are also some smaller stars 
attached to this analyzer that spin around the sun, making it look like their are shooting stars.
Many materials in the scene have an emission on them, making them look brighter. The sun and stars have this, as well as the streetlights
and building windows.
Post Processing was added to the main camera, and various effects were added to the scene:
- Bloom - Makes the bright objects appear as if they're glowing
- Ambient Occlusion - Makes the lighting look a bit more realistic as it shines on other objects
- Chromatic aberration - Gives a kind of lens distortion look which I think adds to the scene
- Color Grading - Some general color adjustments. Also allows access to Hue which is used in a script
- Vignette - A black effect around the corners of the camera, I think it makes the scene look more cinematic
The hue is accessed with a script and is slowly increased as the project runs. Once it reaches the max, it is set back to the
minimum and continues to be increased. When the audio amptitude is above a threshold of .3, the hue changes much faster.




# References
- Unity Documentation
- Game Engines Examples 2020 Github
- [Car](https://assetstore.unity.com/packages/3d/vehicles/land/shaded-free-retro-car-179873)
- [SkyBox](https://assetstore.unity.com/packages/2d/textures-materials/sky/urban-night-sky-134468)
- [PostProcessing](https://www.youtube.com/watch?v=jg2I2odw51M&ab_channel=ExpressedUnity)

# What I am most proud of in the assignment
I'm really proud of the general aesthetic of the project, I think it looks really cool.

# Proposal submitted earlier can go here:
I initially planned to have the assignment focus on Unity's particle system. I still made use of some particle systems,
but shifted the focus.
"For my assignment, I plan to make an audio visualiser which makes use of Unity's particle system. 
The visualiser will have geysers of liquid reactive to sound."



[This is my youtube demo](https://youtu.be/y7GNvbx5ke8)

