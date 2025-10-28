# in-class-activities
## Devlogs
### W5
1.) Write down a question you have about vectors, the Transform Component, gameObject, or GetComponent().

I didn't have any questions about those, but instead I just wanted to know... where do you find the Vector3 static properties page that was shown in class? And also, does Vector3 always need to have the 3 at the end of Vector?

Answers: You can find the link to the Vector3 static properties page in this week's class slides. Yes Vector3 always is written with the 3 at the end, but only for 3D games. Cause you have transformation vectors, x, y, and z. In a 2D game you'd only have x and y.
### W4
In class assignment part 2:
Table #10
1.) What solution did you come up with for the collider activity, and why? Specifically- which objects did you add Rigidbodies to, and which object(s) did you check Is Trigger on?
- We added rigidbodies to the cat and the soccer ball. We checked Is Trigger On for the goal because we didn't want the goal to move, or go flying when the ball or the cat collided with it.

2.) IF your game did not work perfectly the first time you tested it, talk about what you had to fix.
- It was mainly an issue with the sphere collider shape attached to the cat object body. We just didn't shape it correctly around the cat; half of it was clipping through the grown which caused the cat to float in the air. The second problem concerned the cat falling over. We fixed this by checking x, y, z on the cat's Freeze Rotation under Constraints.

In class assignment part 1:
1.) Let’s break down line 5. [SerializedField] basically allows us to keep the float private while also letting us appear in the inspector. Adding private just makes sure that this line of code cannot be edited outside. Declaring a float lets us know that the value of _movespeed we will be using will be a decimal. This whole line overall declares that the value of _movespeed is 1.

2.) I think overall line 22 is saying we’re changing the speed and rotation of the ball. “Float Translation” could probably be saying that the variables that we’ll be working with in this line of code, the decimals, will be changing. Adding Input.GetAxis (“Vertical”) could be calling the ball’s vertical axis rotation; this is the variable that we’ll be changing. By changing the variable, we need to multiply the ball’s speed by the rotation per second, which is shown as _movespeed * Time.deltaTime;.

3.) Line 25 the Translate method is being called on. Writing the transform.Translate and then (0, 0, translation); might be telling us the start translation of the ball.

### W3
Part 2:
2.) We think the balls get extremely bright if they bounce too much becasue each time they bounce the ball color multiplier is applied making the values higher and in turning making the color brighter.

1.) With your table mates, come up with a metaphor to explain the relationship between classes and Components with a metaphor. Also describe how methods and member variables factor into that metaphor.  Remember that classes are templates that can become Components; member variables are traits of each class; and methods are things the class can do.

Classes are like the ingredients to create a plate/dish. Metaphor: Classes are like the egg, or butter. The Component is like a cake.


Part 1: What would you make the parameters (input) and return type (output) of this method?

You’re building a visual novel, and you’re writing a method named GetResponse that gives you a character’s text response to a player’s dialogue choice based on the player’s current friendship level with the character and a flag that tells you whether or not the player knows the character’s secret.

We would make the paramters the "friendship level" and return type a boolean (true/false) because the friend either knows the secret, or they do not.
### W2
Why are the r, g, and b variables floats instead of ints, bools, or strings?
r, g, and b variable are floats because floats represent fractional numbers. r, g, and b can be represented using fractional numbers instead of whole integers.

Why is the _bounce variable an int instead of a float, bool, or string?
The bounce variable is an integer because an integer represents a whole number. Bounce variables are represented using whole numbers. 

The error you got after Step X of Part 2 told you something useful about why that line of code was broken- what was it?
The error that I got after Step X of Part was due to lack of a semicolon. We simply added a semicolon after 0.0f.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
