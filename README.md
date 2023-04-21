# GFX-FinalPractical
 Final Exam Practical Component


## Scene Creation:
 - Scene contains Floor, walls, moving player, moving light ( attached to player)

## Bump Mapping
 - I created an albedo and bump texture and used these to achieve an look similar to the wallpaper in the game

## Flowing Lava
 - This is a modified version of the wave shader from class. The effect can now be toggled to simulate a binary state of either moving slowly or quickly (with more turbulence). The effect is achieved using vertex displacement and is applied to a rotated prism ( a plane didn't look quite right ) 

## Bloom
 - This is a modified version of the bloom effect from class. The effect can now be toggled on and off. When the effect is turned off, it will set the 'threshold' value much higher so that nothing will trigger the effect. In the future, this value could be interpolated so the effect could be toggled more smoothly. The effect is noticable on the lava and on the moving light attached to the player.

## Bonus: Pixelation
- This is a similar effect to the downsample blur that was taught in class. like that effect, it downsamples the output of the camera and then upsamples it back to the desired output resolution, thus reducing image quality. This effect uses point / Nearest Neighbor filtering (ie: no filter), and so as opposed to a blur effect it 'pixelates' the image. I thought this effect would fit this retro game scene. 
