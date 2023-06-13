# undefined-work-game
A video game you can play at work

The Game:
A simple platformer game that will make you look like you work but you are playing.

Story line:
To be decided...

Tasks (POC):
1.	Platforms - the platforms of this game will be lines of code.
Create platforms that are lines of code.
The code will be taken from a file (example.js or something similar).
The platforms and their line of code will be visible in the editor.
The basic Idea:
Rectangle sprite that has text (text mesh pro) as it`s child.
The sprite will be invisible (besides the text) and will have a collider.
For example:   will be the text in the platform, and you can stand on this line of code.
The changes will be visible throw a costume editor - when the scale (size) of the platform is changed, the code inside the platform will change.
For the code to be continues, a static variable will be saved to indicate the last index of text read inside the code. (ex, if the first platform is able to hold 10 characters, the second one will start from the 11th character).
Another idea (Amit), use fit font (wrap) and check where the max font is. When the font changes (becomes smaller), that means that the text is wrapped and we got overflow.

2.	Player movement - for the start, we need a basic player movement.
The player movement includes walking (horizontal) and jumping (only when grounded).

3.	Camera movement - The camera follows the player only on the vertical axis (up and down).
Try to look at Brackys` tutorials to find some ideas for that.

4.	Enemies - simple bugs. The enemies walk right and left and changes direction when encounter an edge. The enemies` speed is slower than the player`s.


For later:
*	Enable costume levels (levels editor).
*	Change the code (costume file).
*	Special levels in the hierarchy and terminal.
*	Special movements with C, V, X, and more…

