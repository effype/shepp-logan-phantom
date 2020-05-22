# Shepp-Logan Phantom

I know how difficult it is to implement this model, which is why I present the simplest solution. Enjoy!
I do some kind of filtration of real model, so this model doesn't count anything. Just filtrate. 
You can create your own model based on the table:

|Ellipse  | Center         |  Major Axis  | Minor Axis  | Theta | Gray level  |
| --------| ---------------|--------------|-------------|-------|-------------|
| I       | (0,0)          |  0.69        | 0.92        | 0     | 2           |
| II      | (0,−0.0184)    |  0.6624      | 0.874       | 0     | −0.98       |
| III     |  	(0.22,0)     |  0.11        | 0.31        | −18°  | −0.02       |
| IV      | (−0.22,0)      |  0.16        | 0.41        | 18°   | −0.02       |
| V       | (0,0.35)       |  0.21        | 0.25        | 0     | 0.01        |
| VI      | (0,0.1)        |  0.046       | 0.046       | 0     | 0.01        |
| VII     | (0,−0.1)       |  0.046       | 0.046       | 0     | 0.01        |
| VIII    | (−0.08,−0.605) |  0.046       | 0.023       | 0     | 0.01        |
| IX      | (0,−0.605)     |  0.023       | 0.023       | 0     | 0.01        |
| X       | (0.06,−0.605)  |  0.023       | 0.046       | 0     | 0.01        |

Result of running application

<img src="https://raw.githubusercontent.com/effype/shepp-logan-phantom/master/img/Screenshot_11.png" />

So in this case this is just one ellipse. Implement rest of 9 ellipses.
