# GFX-FinalPractical
 Final Exam Practical Component
( I made a mistake and misread which section to complete, So i've done the 'even' shaders. I also did the scantron as 'even') 
 
## Scene Creation:
 - Scene contains Floor, walls, moving player, moving light ( attached to player)
 
 ![sceneGeom-GFX-final](https://user-images.githubusercontent.com/64446905/233706794-37fb0f65-6ebb-42bb-b218-bb0a0a96b634.png)

## Bump Mapping
 - I created an albedo and bump texture and used these to achieve an look similar to the wallpaper in the game
![wallBump](https://user-images.githubusercontent.com/64446905/233706952-df037aaa-461c-4b2a-a854-b74f6682ba75.png)
![wallAlbedo](https://user-images.githubusercontent.com/64446905/233706990-4b1ff5bb-b51c-4a4f-8792-418d3f2e173d.png)


## Flowing Lava
 - This is a modified version of the wave shader from class. The effect can now be toggled to simulate a binary state of either moving slowly or quickly (with more turbulence). The effect is achieved using vertex displacement and is applied to a rotated prism ( a plane didn't look quite right ) 
![Screenshot 2023-04-21 141742](https://user-images.githubusercontent.com/64446905/233707306-86683892-e4a6-4401-b051-20568c85c600.png)


## Bloom
 - This is a modified version of the bloom effect from class. The effect can now be toggled on and off. When the effect is turned off, it will set the 'threshold' value much higher so that nothing will trigger the effect. In the future, this value could be interpolated so the effect could be toggled more smoothly. The effect is noticable on the lava and on the moving light attached to the player.
![Screenshot 2023-04-21 141828](https://user-images.githubusercontent.com/64446905/233707408-a4444bc2-8f2b-411e-a297-c82cbdb48ce9.png)

## Bonus: Pixelation
- This is a similar effect to the downsample blur that was taught in class. like that effect, it downsamples the output of the camera and then upsamples it back to the desired output resolution, thus reducing image quality. This effect uses point / Nearest Neighbor filtering (ie: no filter), and so as opposed to a blur effect it 'pixelates' the image. I thought this effect would fit this retro game scene. 
![Screenshot 2023-04-21 141914](https://user-images.githubusercontent.com/64446905/233707560-a21fadde-6a78-4c50-b616-0589c54ac8b6.png)

