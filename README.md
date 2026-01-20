[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
On top of my original planned objects (player, camera, ground, coin *prefab, coin spawner, UI), I also added a coin destroyer object to despawn the coins once the leave the screen without being collected by the player. I used old knowledge learned from MG1 (access public method to update UI with the current number of coins) in public void UpdatePointText(int _point), where the function is called in Player.cs every time it collides with a coin, and uses the stored coin number for _point parameter. 

[itch.io web build link](https://hayaya22333.itch.io/mg2)

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
